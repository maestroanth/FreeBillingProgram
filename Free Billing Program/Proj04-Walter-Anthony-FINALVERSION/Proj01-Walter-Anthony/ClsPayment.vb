'Copyright (c) 2009-2014 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Utility System
'File:               ClsPayment.vb
'Author:             Anthony Walter
'Description:        This class describes a general Utility Payment
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

Public Class Payment

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants

    '********** Module-level variables
    Private mID As String
    Private mPaymentDate As Date
    Private mAmountPaid As Decimal

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

    Public Sub New(ByVal pID As String, ByVal pDate As Date, _
            ByVal pAmountPaid As Decimal)

        'Special constructor

        'This constructor creates the ID, Name, Type, And Units As Strings

        MyBase.New()

        _ID = pID
        _Date = pDate
        _AmountPaid = pAmountPaid

    End Sub 'New(pUtility)


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

    Public ReadOnly Property PaymentDate As Date
        Get
            Return _Date
        End Get
    End Property

    Public ReadOnly Property AmountPaid As Decimal
        Get
            Return _AmountPaid
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

    Private Property _Date As Date
        Get
            Return mPaymentDate
        End Get
        Set(pValue As Date)
            mPaymentDate = pValue
        End Set
    End Property

    Private Property _AmountPaid As Decimal
        Get
            Return mAmountPaid
        End Get
        Set(pValue As Decimal)
            mAmountPaid = pValue
        End Set
    End Property

#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods


    'Public Function value() As Decimal

    '    'value() calculates and returns the actual value of this
    '    'PortfolioItem: the current market price times the number of
    '    'shares owned.

    '    'We could have used this public function for this purpose, but
    '    'instead we designed an equivalent private/public pair of property
    '    'procedures (above) and use them instead.

    '    'This is the public method; 
    '    'it depends on the private method to actually do the work.

    '    Return _value()

    'End Function 'value()

    Public Overrides Function ToString() As String

        'ToString() returns a string version of the object.
        'It is a standard method that should be provided for *all* classes.

        'This is the public method; 
        'it depends on the private method to actually do the work.

        Return _toString()

    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods


    Private Function _getBillID() As String
        Dim theReceivedBillID As String
        For i As Integer = 0 To FrmMain.TheUtilitySystem.NumOfBills - 1

            'bill being searched
            For j As Integer = 0 To FrmMain.TheUtilitySystem.Bill(i).NumberOfPayments - 1
                If (FrmMain.TheUtilitySystem.Bill(i).Payment(j).ID = Me.mID) Then
                    theReceivedBillID = FrmMain.TheUtilitySystem.Bill(i).ID
                End If

            Next j
        Next i
        'If Not (theReceivedBillID = "") Then
        '    MessageBox.Show(theReceivedBillID.ToString)
        'End If

        Return theReceivedBillID
    End Function

    Private Function _toString() As String

        '_toString() returns a string version of the object.

        'This is the private method, that actually does the work.

        'need to search for BillID this payment is linked to



        Dim tmpStr As String
        Dim theReceivedBillID As String
        theReceivedBillID = _getBillID() 'has to add me or it'd think it's a "general" billID I'm trying to get

        tmpStr = _
            Date.Now.ToString("yyyyMMdd") + "; " _
            & DateTime.Now.ToString("HHmm") + "; " _
            & "BILL; " _
            & "PAY; " _
            & Me.ID + "; " _
            & theReceivedBillID + "; " _
            & Me.PaymentDate.ToString("MM/dd/yyyy") + "; " _
            & Me.AmountPaid.ToString + "; "
        Return tmpStr

    End Function '_toString()

#End Region 'Behavioral Methods

#Region "Event Procedures"
    '******************************************************************
    'Event Procedures
    '******************************************************************

    'No Event Procedures are currently defined.
    'These are all private.

    '********** User-Interface Event Procedures
    '             - Initiated explicitly by user

    '********** User-Interface Event Procedures
    '             - Initiated automatically by system

    '********** Business Logic Event Procedures


#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events

End Class 'Payment