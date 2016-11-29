'Copyright (c) 2009-2014 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Utility System
'File:               ClsBill.vb
'Author:             Anthony Walter
'Description:        This class describes a general Utility Bill
'Date:               3/5/2015
'Tier:               Business Logic
'Exceptions:         None generated
'Exception-Handling: None
'Events:             None generated
'Event-Handling:     None
#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
#End Region 'Option / Imports

Public Class Bill

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mID As String
    Private mBillDate As Date
    Private mUnitsUsed As Decimal
    Private mCurrentBillAmountDue As Decimal
    Private mNumberOfPayments As Integer

    'Reference variables
    Private mCustomer As Customer
    Private mUtility As Utility

    'Array of Payments
    Private mPayment() As Payment

    Private mMaxPayments As Integer

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    Public Sub New(ByVal pID As String, ByVal pBillDate As Date, _
            ByVal pUnitsUsed As Decimal, ByVal pCurrentBillAmountDue As Decimal, _
            ByRef pCustomer As Customer, ByRef pUtility As Utility)

        'Special constructor

        'This constructor creates the ID, Name, Type, And Units As Strings

        MyBase.New()

        _ID = pID
        _BillDate = pBillDate
        _UnitsUsed = pUnitsUsed
        _CurrentBillAmountDue = pCurrentBillAmountDue
        _Customer = pCustomer
        _Utility = pUtility

        _maxPayments = UtilitySystem.mARRAY_SIZE_DEFAULT
        ReDim mPayment(_maxPayments - 1)
    End Sub 'New(pBill)


    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement

    Public ReadOnly Property ID As String
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property BillDate As Date
        Get
            Return _BillDate
        End Get
    End Property

    Public ReadOnly Property UnitsUsed As Decimal
        Get
            Return _UnitsUsed
        End Get
    End Property

    Public ReadOnly Property CurrentBillAmountDue As Decimal
        Get
            Return _CurrentBillAmountDue
        End Get
    End Property

    Public ReadOnly Property NumberOfPayments As Integer
        Get
            Return _NumberOfPayments
        End Get
    End Property

    Public ReadOnly Property Customer As Customer
        Get
            Return _Customer
        End Get
    End Property

    Public ReadOnly Property Utility As Utility
        Get
            Return _Utility
        End Get
    End Property

    Public ReadOnly Property MaxPayment As Integer
        Get
            Return _maxPayments
        End Get
    End Property

    Public ReadOnly Property Payment(ByVal pI As Integer) As Payment
        Get
            Return _ithPayment(pI)
        End Get
    End Property




    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _ID As String
        Get
            Return mID
        End Get
        Set(pValue As String)
            mID = pValue
        End Set
    End Property

    Private Property _BillDate As Date
        Get
            Return mBillDate
        End Get
        Set(pValue As Date)
            mBillDate = pValue
        End Set
    End Property

    Private Property _UnitsUsed As Decimal
        Get
            Return mUnitsUsed
        End Get
        Set(pValue As Decimal)
            mUnitsUsed = pValue
        End Set
    End Property

    Private Property _CurrentBillAmountDue As Decimal
        Get
            Return mCurrentBillAmountDue
        End Get
        Set(pValue As Decimal)
            mCurrentBillAmountDue = pValue
        End Set
    End Property

    Private Property _NumberOfPayments As Integer
        Get
            Return mNumberOfPayments
        End Get
        Set(pValue As Integer)
            mNumberOfPayments = pValue
        End Set
    End Property

    Private Property _Customer As Customer
        Get
            Return mCustomer
        End Get
        Set(pValue As Customer)
            mCustomer = pValue
        End Set
    End Property

    Private Property _Utility As Utility
        Get
            Return mUtility
        End Get
        Set(pValue As Utility)
            mUtility = pValue
        End Set
    End Property

    Private Property _maxPayments As Integer
        Get
            Return mMaxPayments
        End Get
        Set(pValue As Integer)
            mMaxPayments = pValue
        End Set
    End Property

    Private Property _ithPayment(ByVal pI As Integer) As Payment
        'Assumes: 0 <= pN < _numCustomer.
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pI >= 0 And pI < _maxPayments Then
                Return mPayment(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Payment)
            If pI >= 0 And pI < _maxPayments Then
                mPayment(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property
#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods
    Public Function TotalPayments() As Decimal

        Dim totalPayment As Decimal

        totalPayment = _totalPayments()

        Return totalPayment
    End Function
    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods
    Public Sub ApplyPayment(ByVal pID As String, ByVal pPaymentDate As Date, ByVal pAmountPaid As Decimal)

        _applyPayment(pID, pPaymentDate, pAmountPaid)


    End Sub 'ApplyPayment(ByVal pID As String, ByVal pPaymentDate As Date, ByVal pAmountPaid As Decimal)

    Public Overrides Function ToString() As String

        'ToString() returns a string version of the object.
        'It is a standard method that should be provided for *all* classes.

        'This is the public method; 
        'it depends on the private method to actually do the work.

        Return _toString()

    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods
    '
    'Apply Payment
    Private Sub _applyPayment(ByVal pID As String, ByVal pPaymentDate As Date, ByVal pAmountPaid As Decimal)

        Dim totalPayments As Decimal
        Dim thePayment As New Payment(pID, pPaymentDate, pAmountPaid)
        If _NumberOfPayments >= _maxPayments Then
            _maxPayments += UtilitySystem.mARRAY_INCREMENT_DEFAULT
            ReDim Preserve mPayment(_maxPayments - 1)
        End If

        Try
            _ithPayment(_NumberOfPayments) = thePayment
        Catch ex As IndexOutOfRangeException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        'call Private Sub Balance Due Here
        Me.mCurrentBillAmountDue = _BalanceDue(thePayment)
        'call Private Sub Paid To Date Here
        totalPayments = _totalPayments()




        _NumberOfPayments += 1

        'Right now all Apply Payment does is increment the Number of Payments and Creates Payment Object

    End Sub

    Private Function _totalPayments() As Decimal

        Dim totalPayments As Decimal

        For i As Integer = 0 To mNumberOfPayments - 1
            totalPayments = totalPayments + Payment(i).AmountPaid
        Next


        Return totalPayments
    End Function

    Private Function _BalanceDue(ByRef pPayment As Payment) As Decimal

        Dim BalanceDue As Decimal = mCurrentBillAmountDue
        BalanceDue = Me.mCurrentBillAmountDue - pPayment.AmountPaid

        Return BalanceDue

    End Function
    'Balance Due (calculation)
    '
    '
    '

    Private Function _toString() As String

        '_toString() returns a string version of the object.

        'This is the private method, that actually does the work.

        Dim tmpStr As String
        tmpStr = _
            Date.Now.ToString("yyyyMMdd") + "; " _
            & DateTime.Now.ToString("HHmm") + "; " _
            & "CUSTOMER; " _
            & "BILL; " _
            & Me.ID + "; " _
            & Customer.ID + "; " _
            & Utility.ID + "; " _
            & Me.BillDate.ToString("MM/dd/yyyy") + "; " _
            & Me.UnitsUsed.ToString + "; " _
            & Me.CurrentBillAmountDue.ToString + "; "
        Return tmpStr

    End Function '_toString()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************


    'These are all public.

#End Region 'Events

End Class 'Bill