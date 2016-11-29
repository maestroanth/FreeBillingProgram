'Copyright (c) 2009-2014 Dan Turk

#Region "Class / File Comment Header block"
'Program:            Utility System
'File:               ClsUtilitySystem.vb
'Author:             Anthony Walter
'Description:        This class Creates the Utility system
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

Imports System.IO
Imports System.Reflection
Imports System.Globalization

#End Region 'Option / Imports

Public Class UtilitySystem

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    '********** Module-level constants
    'Note: These are global so the Bill class can access these so I wouldn't have to change array size in more than one spot if so desired.
    Public Const mARRAY_SIZE_DEFAULT As Integer = 10
    Public Const mARRAY_INCREMENT_DEFAULT As Integer = 5
    Public Const mMAX_ERRORLOG_SIZE As Integer = 1000
    Public Const mMAX_OUTPUT_FILE_SIZE As Integer = 9000

    '********** Module-level variables
    Private mSystemName As String
    Private mNumOfUtilitySystems As Integer
    Private mNumOfBills As Integer
    Private mNumOfUtilities As Integer
    Private mNumOfCustomers As Integer
    Private mNumOfALLPayments As Integer
    Private mNumOfTransactions As Integer
    Private mNumOfErrors As Integer
    Private mOverAllInputLineCounter As Integer
    Private mOverAllOutputLineCounter As Integer

    'Arrays
    Private mCustomer() As Customer
    Private mUtility() As Utility
    Private mBill() As Bill
    Private mTransaction() As String
    Private mErrorLog(mMAX_ERRORLOG_SIZE) As String

    'variable sizes
    Private mMaxCustomers As Integer
    Private mMaxUtilities As Integer
    Private mMaxBills As Integer
    Private mMaxTransactions As Integer

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************
    'These are all public.

    '********** Default constructor
    '             - no parameters
    Public Sub New()

        'Default constructor.
        'Initializes attributes with default values.

        _maxCustomers = ARRAY_SIZE_DEFAULT
        ReDim mCustomer(_maxCustomers - 1)
        _maxUtilities = ARRAY_SIZE_DEFAULT
        ReDim mUtility(_maxUtilities - 1)
        _maxBills = ARRAY_SIZE_DEFAULT
        ReDim mBill(_maxBills - 1)
        _maxTransactions = ARRAY_SIZE_DEFAULT
        ReDim mTransaction(_maxTransactions - 1)

    End Sub 'New()


    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    Public Sub New(ByVal pSystemName As String)

        'Special constructor

        'This constructor creates a new Utility System

        MyBase.New()

        _SystemName = pSystemName
    End Sub 'New(pStock)


    '********** Copy constructor(s)
    '             - one parameter, an object of the same class

#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement


    Public ReadOnly Property SystemName As String
        Get
            Return _SystemName
        End Get
    End Property

    Public ReadOnly Property NumOfUtilitySystems As Integer
        Get
            Return _NumOfUtilitySystems
        End Get
    End Property

    Public ReadOnly Property NumOfUtilities As Integer
        Get
            Return _NumOfUtilities
        End Get
    End Property

    Public ReadOnly Property NumOfCustomers As Integer
        Get
            Return _NumOfCustomers
        End Get
    End Property

    Public ReadOnly Property NumOfBills As Integer
        Get
            Return _NumOfBills
        End Get
    End Property

    Public ReadOnly Property NumOfALLPayments As Integer
        Get
            Return _NumOfALLPayments
        End Get
    End Property

    Public ReadOnly Property NumOfTransactions As Integer
        Get
            Return _NumOfTransactions
        End Get
    End Property

    Public ReadOnly Property ARRAY_SIZE_DEFAULT As Integer
        Get
            Return mARRAY_SIZE_DEFAULT
        End Get
    End Property

    Public ReadOnly Property ARRAY_INCREMENT_DEFAULT As Integer
        Get
            Return mARRAY_INCREMENT_DEFAULT
        End Get
    End Property

    ''These properties are to get specific elements from an array

    Public ReadOnly Property Customer(ByVal pI As Integer) As Customer
        Get
            Return _ithCustomer(pI)
        End Get
    End Property

    Public ReadOnly Property Utility(ByVal pI As Integer) As Utility
        Get
            Return _ithUtility(pI)
        End Get
    End Property

    Public ReadOnly Property Bill(ByVal pI As Integer) As Bill
        Get
            Return _ithBill(pI)
        End Get
    End Property

    Public ReadOnly Property Transaction(ByVal pI As Integer) As String
        Get
            Return _ithTransaction(pI)
        End Get
    End Property

    Public ReadOnly Property NumOfErrors() As Integer
        Get
            Return _numOfErrors()
        End Get
    End Property

    Public ReadOnly Property OverAllInputLineCounter() As Integer
        Get
            Return _OverAllInputLineCounter()
        End Get
    End Property

    Public ReadOnly Property ErrorLog(ByVal pI As Integer) As String
        Get
            Return _ithErrorLog(pI)
        End Get
    End Property

    Public ReadOnly Property OverAllOutputLineCounter() As Integer
        Get
            Return _overAllOutputLineCounter
        End Get
    End Property

    Private Property _overAllOutputLineCounter() As Integer
        Get
            Return mOverAllOutputLineCounter
        End Get
        Set(pValue As Integer)
            mOverAllOutputLineCounter = pValue
        End Set
    End Property

    Private Property _ithErrorLog(ByVal pI As Integer) As String
        'Assumes: 0 <= pN < _numCustomer.
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pI >= 0 And pI < mMAX_ERRORLOG_SIZE Then
                Return mErrorLog(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(pvalue As String)
            If pI >= 0 And pI < mMAX_ERRORLOG_SIZE Then
                mErrorLog(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property




    Private Property _OverAllInputLineCounter() As Integer
        Get
            Return mOverAllInputLineCounter
        End Get
        Set(pValue As Integer)
            mOverAllInputLineCounter = pValue
        End Set
    End Property

    Private Property _numOfErrors() As Integer
        Get
            Return mNumOfErrors
        End Get
        Set(pValue As Integer)
            mNumOfErrors = pValue
        End Set
    End Property


    Private Property _ithCustomer(ByVal pI As Integer) As Customer
        'Assumes: 0 <= pN < _numCustomer.
        'Throws an IndexOutOfRangeException if this is not the case.
        Get
            If pI >= 0 And pI < _maxCustomers Then
                Return mCustomer(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Customer)
            If pI >= 0 And pI < _maxCustomers Then
                mCustomer(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property


    Private Property _ithUtility(ByVal pI As Integer) As Utility
        Get
            If pI >= 0 And pI < _maxUtilities Then
                Return mUtility(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Utility)
            If pI >= 0 And pI < _maxUtilities Then
                mUtility(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property



    Private Property _ithBill(ByVal pI As Integer) As Bill
        Get
            If pI >= 0 And pI < _maxBills Then
                Return mBill(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As Bill)
            If pI >= 0 And pI < _maxBills Then
                mBill(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    Private Property _ithTransaction(ByVal pI As Integer) As String
        Get
            If pI >= 0 And pI < _maxTransactions Then
                Return mTransaction(pI)
            Else
                Throw New IndexOutOfRangeException
            End If
        End Get
        Set(ByVal pvalue As String)
            If pI >= 0 And pI < _maxTransactions Then
                mTransaction(pI) = pvalue
            Else
                Throw New IndexOutOfRangeException
            End If
        End Set
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)

    Private Property _SystemName As String
        Get
            Return mSystemName
        End Get
        Set(pValue As String)
            mSystemName = pValue
        End Set
    End Property

    Private Property _NumOfUtilitySystems As Integer
        Get
            Return mNumOfUtilitySystems
        End Get
        Set(pValue As Integer)
            mNumOfUtilitySystems = pValue
        End Set
    End Property

    Private Property _NumOfBills As Integer
        Get
            Return mNumOfBills
        End Get
        Set(pValue As Integer)
            mNumOfBills = pValue
        End Set
    End Property

    Private Property _NumOfUtilities As Integer
        Get
            Return mNumOfUtilities
        End Get
        Set(pValue As Integer)
            mNumOfUtilities = pValue
        End Set
    End Property

    Private Property _NumOfCustomers As Integer
        Get
            Return mNumOfCustomers
        End Get
        Set(pValue As Integer)
            mNumOfCustomers = pValue
        End Set
    End Property

    Private Property _NumOfALLPayments As Integer
        Get
            Return mNumOfALLPayments
        End Get
        Set(pValue As Integer)
            mNumOfALLPayments = pValue
        End Set
    End Property

    Private Property _NumOfTransactions As Integer
        Get
            Return mNumOfTransactions
        End Get
        Set(pValue As Integer)
            mNumOfTransactions = pValue
        End Set
    End Property

    Private Property _maxCustomers As Integer
        Get
            Return mMaxCustomers
        End Get
        Set(ByVal pValue As Integer)
            mMaxCustomers = pValue
        End Set
    End Property

    Private Property _maxUtilities As Integer
        Get
            Return mMaxUtilities
        End Get
        Set(ByVal pValue As Integer)
            mMaxUtilities = pValue
        End Set
    End Property

    Private Property _maxBills As Integer
        Get
            Return mMaxBills
        End Get
        Set(ByVal pValue As Integer)
            mMaxBills = pValue
        End Set
    End Property

    Private Property _maxTransactions As Integer
        Get
            Return mMaxTransactions
        End Get
        Set(ByVal pValue As Integer)
            mMaxTransactions = pValue
        End Set
    End Property
#End Region

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    '********** Public Shared Behavioral Methods\
    'this will be an overloaded method
    Public Sub WriteFile(ByVal appendToggle As Boolean)

        Dim dialog As New FolderBrowserDialog()
        Dim file As System.IO.StreamWriter
        Dim thePath As String
        Dim fileHeader As String
        '1. retrieve fields from the lst box
        '2. format fields in same style as input
        '3. sort fields 
        '4. test making sure it can import the same files it exports then it's a perfect program with long term data capabilities!

        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Output Destination"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            thePath = dialog.SelectedPath
            Exit Sub
        Else
            thePath = dialog.SelectedPath
            MessageBox.Show("Writing Output File: " + thePath + "\GimmieMyMoneyUtilities-Output.txt")
        End If

        
        'My.Computer.FileSystem.WriteAllText(thePath & "Proj04-Output.txt", thePath, False)

        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(thePath + "\GimmieMyMoneyUtilities-Output.txt", appendToggle)
        Catch
            MessageBox.Show("Export file not written due to cancellation or not clicking on a folder!")
            Exit Sub
        End Try
        For Each o As Object In FrmMain.lstTransactions.Items
            file.WriteLine(o.ToString())
        Next

        file.Flush()
        file.Close()
    End Sub

    Public Sub WriteErrorFile()
        Dim dialog As New FolderBrowserDialog()
        Dim file As System.IO.StreamWriter
        Dim thePath As String

        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Output Destination"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            thePath = dialog.SelectedPath
            Exit Sub
        Else
            thePath = dialog.SelectedPath
            MessageBox.Show("Writing Errorlog File to: " + thePath + "\GimmieMyMoneyUtilities-ErrorLog.txt")
        End If

        'My.Computer.FileSystem.WriteAllText(thePath & "Proj04-Output.txt", thePath, False)
        ' MessageBox.Show(mErrorLog.Length.ToString())
        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(thePath + "\GimmieMyMoneyUtilities.txt", FrmMain.chkAppendFileToggle.Checked)
        Catch
            MessageBox.Show("Errorlog not written due to cancellation or not clicking on a folder!")
            Exit Sub
        End Try
        For i As Integer = 0 To mNumOfErrors - 1

            file.WriteLine(mErrorLog(i).ToString())
        Next
        file.Flush()
        file.Close()

    End Sub 'WriteFile(ByVal errorLog() As String)

    Public Sub ReadFile(ByVal inputFile As System.IO.Stream)
        Dim reader As StreamReader
        reader = New StreamReader(inputFile)

        Dim line As String
        Dim field() As String

        _numOfErrors = 0
        _OverAllInputLineCounter = 0
        mErrorLog(0) = "t"

        'These are declared in same order that the .txt format is in
        Dim theTransactionType As Integer = 0

        'field(2) and field(3) I'll leave undeclared because they'll be in an if statement which will then cause appropiate add function


        Dim approxFilePath As String = "~\Proj04-Walter-Anthony\Proj01-Walter-Anthony\bin\Debug" 'this is just for reference, doesn't do anything


        Dim Comments(99) As String 'Saves comments in an array of strings
        Dim CommentCounter As Integer = 0

        'I need to learn more about this path stuff if time allows
        'Dim exedir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
        'approxFilePath = Path.Combine(exedir, "InputOutputFiles\Transactions-in-SAMPLE.txt")
        'inputFile = New StreamReader(approxFilePath) 'this is in some debug folder
        'Try
        Do While Not reader.EndOfStream
            theTransactionType = 0 'resets transaction type
            _OverAllInputLineCounter += 1
            line = reader.ReadLine
            If Not line = vbNullString Then 'if line is not empty
                If Not line.Chars(0) = "#" Then 'only continues processing if the first char is NOT "#"(a commented line)
                    'MessageBox.Show(line.ToString)
                    field = Split(line, ";")
                    For i As Integer = 0 To field.Length - 1 'get upperbound parameter 0 for one dimension 1 for two dimensions, etc.
                        field(i) = Trim(field(i)) 'Trim(field(i)) ALONE doesn't trim the string, it needs to resave the trim into the array
                        'field(i) = field(i).Trim(CChar(";"), CChar(",")) 'trim whatever other chars
                        'MessageBox.Show(field(i)) 'for debugging don't delete comment out when done
                    Next i

                    'If statements to determine which of the 4 possible categories the line is 1. UTILITY/CREATE 2. CUSTOMER/CREATE 3. CUSTOMER/BILL 4.BILL/PAY
                    ' MessageBox.Show(field(2).ToString)
                    'MessageBox.Show("Compare result: " + StrComp(field(2).ToUpper, "UTILITY", CompareMethod.Text).ToString)
                    Try
                        If StrComp(field(2).ToString.ToUpper, "UTILITY", CompareMethod.Text) = 0 Then '-1 sorts behind, 0 is equal, 1 sorts ahead
                            theTransactionType = 1
                        End If
                    Catch
                        MessageBox.Show("Please only pick a file outputted by this program.")
                        Exit Sub
                    End Try
                    If field(2).ToUpper = ("CUSTOMER") Then
                        If field(3).ToUpper = ("CREATE") Then
                            theTransactionType = 2
                        Else
                            theTransactionType = 3
                        End If
                    End If

                    If field(2).ToUpper = ("BILL") Then
                        theTransactionType = 4
                    End If
                    'MessageBox.Show("Transaction Type: " + theTransactionType.ToString) 'for debugging comment out when done
                    If theTransactionType < 1 Then
                        mErrorLog(NumOfErrors) = "Unable to Determine Transaction Type At Line: #" + OverAllInputLineCounter.ToString
                        _numOfErrors += 1
                    End If
                    _FinishLineProcessing(theTransactionType, field) 'passing it into another function to finish line processing
                    'MessageBox.Show(mErrorLog(mNumOfErrors).ToString())

                Else
                    Comments(CommentCounter) = line.ToString
                    'MessageBox.Show(Comments(CommentCounter)) 'for debugging comment out when done
                    CommentCounter = CommentCounter + 1

                End If
            Else
                Comments(CommentCounter) = vbNullString 'sets a NULL string for this index, maybe useful for consistent formatting
                'MessageBox.Show("Blank Line") 'for debugging comment out when done
                CommentCounter = CommentCounter + 1
            End If
        Loop
        MessageBox.Show("Finished Reading File")
        Dim response = MsgBox("Do you wish to export the Error Log?", MsgBoxStyle.YesNo, "Finished Reading File")

        If response = MsgBoxResult.Yes Then
            WriteErrorFile()
        End If
        'Catch
        '    MessageBox.Show("file import still under development")
        '    inputFile.Close()
        'Finally
        '    MessageBox.Show("file import still under development")
        '    inputFile.Close()
        'End Try
    End Sub 'ReadFile(ByVal inputFile As System.IO.Stream)


    '********** Private Shared Behavioral Methods
   Private Sub _FinishLineProcessing(ByVal pTransactionType As Integer, ByVal pField() As String) 'The Public Method Calls the Private Method For some reason, why not just make the private method public then??

        'NOTE: The variables declared will be based on the transaction type later
        Dim theDate As String
        Dim actualDate As Date
        Dim dateParamaterString As String
        Dim theTime As String


        theDate = pField(0)
        theTime = pField(1).ToString() 'can figure out how to format time later

        'date crap
        Dim year As String = Strings.Left(theDate, 4)
        Dim month As String = Strings.Mid(theDate, 5, 2)
        Dim day As String = Strings.Right(theDate, 2)
        dateParamaterString = month + "/" + day + "/" + year
        'MessageBox.Show(dateParamaterString) 'save this for debugging, format needs to match EXACTLY to below

        actualDate = DateTime.ParseExact(dateParamaterString, "MM/dd/yyyy", CultureInfo.InvariantCulture)

        'MessageBox.Show(actualDate.ToString("MM/dd/yyyy"))
        '1. UTILITY/CREATE 2. CUSTOMER/CREATE 3. CUSTOMER/BILL 4.BILL/PAY

        If pTransactionType = 1 Then 'the line is a utility to import

            Dim theUtilityID As String = pField(4)
            Dim theUtilityName As String = pField(5)
            Dim theUtilityType As String = pField(6)
            Dim theUtilityUnits As String = pField(7)
            For i As Integer = 0 To NumOfUtilities - 1
                'error check for duplicate id
                If (mUtility(i).ID = theUtilityID) Then
                    mErrorLog(NumOfErrors) = "Duplicate Utility Read Error At Line: #" + OverAllInputLineCounter.ToString
                    _numOfErrors += 1
                    Exit Sub
                End If
            Next i
            AddUtility(theUtilityID, theUtilityName, theUtilityType, theUtilityUnits)
        End If

        If pTransactionType = 2 Then 'the line is a customer to import

            Dim theCustomerID As String = pField(4)
            Dim theCustomerName As String = pField(5)
            For i As Integer = 0 To NumOfCustomers - 1
                ' Error check for duplicate customer
                If (mCustomer(i).ID = theCustomerID) Then
                    mErrorLog(NumOfErrors) = "Duplicate Customer Read Error At Line: #" + OverAllInputLineCounter.ToString
                    _numOfErrors += 1
                    Exit Sub
                End If

            Next i
            AddCustomer(theCustomerID, theCustomerName)
        End If

        If pTransactionType = 3 Then 'the line is a bill to import
            Dim theBillID As String = pField(4)
            Dim theBillCustomerID As String = pField(5)
            Dim theBillUtilityID As String = pField(6)
            Dim theBillDate As String = pField(7)
            Dim theActualBillDate As Date
            'For i As Integer = 0 To pField.Length - 1
            '    MessageBox.Show(pField(i).ToString)
            'Next

            'date crap again
            Dim yearBill As String = Strings.Left(theDate, 4)
            Dim monthBill As String = Strings.Mid(theDate, 5, 2)
            Dim dayBill As String = Strings.Right(theDate, 2)
            dateParamaterString = monthBill + "/" + dayBill + "/" + yearBill
            theActualBillDate = DateTime.ParseExact(dateParamaterString, "MM/dd/yyyy", CultureInfo.InvariantCulture)
            'Try
            Dim theUnitsUsed As Decimal = CDec(pField(8))
            Dim theCurrentBillAmountDue As Decimal = CDec(pField(9))

            'Catch ex As Exception
            '    MessageBox.Show("An error with bill parsing.")
            '    Exit Sub
            'End Try
            'error check for duplicate Bill
            For i As Integer = 0 To NumOfBills - 1
                If (mBill(i).ID = theBillID) Then
                    mErrorLog(NumOfErrors) = "Bill Already Exists At Line: #" + OverAllInputLineCounter.ToString
                    _numOfErrors += 1
                    Exit Sub
                End If
            Next i
            'retrieve Customer and Utility
            Dim theCustomer As Customer
            Dim theUtility As Utility

            'search arrays for matching ids, if found sets reference
            For i As Integer = 0 To NumOfCustomers - 1
                If (mCustomer(i).ID = theBillCustomerID) Then

                    theCustomer = mCustomer(i)

                End If
            Next i
            For i As Integer = 0 To NumOfUtilities - 1
                If (mUtility(i).ID = theBillUtilityID) Then
                    theUtility = mUtility(i)
                End If
            Next i

            If IsNothing(theCustomer) Then
                mErrorLog(mNumOfErrors) = "Customer Doesn't Exist At Line: #" + OverAllInputLineCounter.ToString
                _numOfErrors += 1
                Exit Sub
            End If

            If IsNothing(theUtility) Then
                mErrorLog(mNumOfErrors) = "An error with utility reference for bill At Line: #" + OverAllInputLineCounter.ToString
                _numOfErrors += 1
                Exit Sub
            End If

            AddBill(theBillID, theActualBillDate, theUnitsUsed, theCurrentBillAmountDue, theCustomer, theUtility)
        End If

        If pTransactionType = 4 Then 'the line is a payment to import
            '20150420; 0900; BILL; PAY; P 001(f); B 001(f); 20150419; 50.75
            Dim thePaymentID As String = pField(4)
            Dim theBillPaymentID As String = pField(5)
            Dim thePaymentDate As String = pField(6)
            Dim theActualPaymentDate As Date
            Dim theBillInPayment As Bill

            'date crap again
            Dim yearPayment As String = Strings.Left(theDate, 4)
            Dim monthPayment As String = Strings.Mid(theDate, 5, 2)
            Dim dayPayment As String = Strings.Right(theDate, 2)
            dateParamaterString = monthPayment + "/" + dayPayment + "/" + yearPayment
            theActualPaymentDate = DateTime.ParseExact(dateParamaterString, "MM/dd/yyyy", CultureInfo.InvariantCulture)
            'Try
            Dim thePayAmount As Decimal = CDec(pField(7))
            'get bill
            For i As Integer = 0 To NumOfBills - 1
                If (mBill(i).ID = theBillPaymentID) Then
                    theBillInPayment = mBill(i)
                End If
            Next i
            If IsNothing(theBillInPayment) Then
                mErrorLog(mNumOfErrors) = "An error with bill reference At Line: #" + OverAllInputLineCounter.ToString
                _numOfErrors += 1

                Exit Sub
            End If
            'error check for duplicate payment
            Dim NumOfPayments As Integer = theBillInPayment.NumberOfPayments

            'search through all bills and all payments in each bill to catch last error
            For i As Integer = 0 To NumOfBills - 1
                'bill being searched
                For j As Integer = 0 To Me.Bill(i).NumberOfPayments - 1
                    If (Me.Bill(i).Payment(j).ID = thePaymentID) Then
                        mErrorLog(mNumOfErrors) = "Payment Already Exists At Line: #" + OverAllInputLineCounter.ToString
                        _numOfErrors += 1
                        Exit Sub
                    End If
                Next j
            Next i


            ApplyPayment(thePaymentID, theActualPaymentDate, thePayAmount, theBillInPayment)
        End If

    End Sub 'FinishLineProcessing(ByVal pTransactionType)
    '********** Public Non-Shared Behavioral Methods

    Public Sub AddUtilitySystem(ByVal pSystemName As String) 'The Public Method Calls the Private Method For some reason, why not just make the private method public then??

        _addUtilitySystem(pSystemName)

    End Sub '_AddUtilitySystem(ByVal pSystemName As String)

    Public Sub AddBill(ByVal pID As String, ByVal pBillDate As Date, ByVal pUnitsUsed As Decimal, ByVal pCurrentBillAmountDue As Decimal, _
                       ByRef pCustomer As Customer, ByRef pUtility As Utility)

        _addBill(pID, pBillDate, pUnitsUsed, pCurrentBillAmountDue, pCustomer, pUtility)

    End Sub '_AddBill(ByVal pID As String, ByVal pBillDate As Date, ByVal pUnitsUsed As Decimal, ByVal pCurrentBillAmountDue As Decimal)

    Public Sub AddCustomer(ByVal pID As String, ByVal pName As String)

        _addCustomer(pID, pName)

    End Sub '_AddBill(ByVal pID As String, ByVal pBillDate As Date, ByVal pUnitsUsed As Decimal, ByVal pCurrentBillAmountDue As Decimal)

    Public Sub AddUtility(ByVal pID As String, ByVal pName As String, ByVal pType As String, ByVal pUnits As String)

        _addUtility(pID, pName, pType, pUnits)

    End Sub 'AddUtility(ByVal pID As String, ByVal pName As String, ByVal pType As String, ByVal pUnits As String)

    Public Sub ApplyPayment(ByVal pID As String, ByVal pPaymentDate As Date, ByVal pAmountPaid As Decimal, ByRef pBill As Bill)

        _applyPayment(pID, pPaymentDate, pAmountPaid, pBill)

    End Sub 'AddUtility(ByVal pID As String, ByVal pName As String, ByVal pType As String, ByVal pUnits As String)

    Public Sub AddTransaction(ByVal pTransaction As String)

        _addTransaction(pTransaction)

    End Sub 'AddUtility(ByVal pID As String, ByVal pName As String, ByVal pType As String, ByVal pUnits As String)


    Public Overrides Function ToString() As String

        'ToString() returns a string version of the object.
        'It is a standard method that should be provided for *all* classes.

        'This is the public method; 
        'it depends on the private method to actually do the work.

        Return _toString()

    End Function 'ToString()

    '********** Private Non-Shared Behavioral Methods
    Private Sub _addUtilitySystem(ByVal pSystemName As String)
        Dim theUtilitySystem As UtilitySystem
        theUtilitySystem = New UtilitySystem(pSystemName)

        _NumOfUtilitySystems += 1


        RaiseEvent UtilitySystem_UtilitySystemAdded(Me, New UtilitySystem_EventArgs_UtilitySystemAdded(theUtilitySystem))
        _addTransaction(theUtilitySystem.ToString)
    End Sub '_addUtilitySystem(ByVal pSystemName As String)

    Private Sub _addBill(ByVal pID As String, ByVal pBillDate As Date, ByVal pUnitsUsed As Decimal, ByVal pCurrentBillAmountDue As Decimal, _
                         ByRef pCustomer As Customer, ByRef pUtility As Utility)
        Dim theBill As New Bill(pID, pBillDate, pUnitsUsed, pCurrentBillAmountDue, pCustomer, pUtility)

        If _NumOfBills >= _maxBills Then
            _maxBills += ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mBill(_maxBills - 1)
        End If

        Try
            _ithBill(_NumOfBills) = theBill
        Catch ex As IndexOutOfRangeException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        _NumOfBills += 1


        RaiseEvent Bill_BillAdded(Me, New Bill_EventArgs_BillAdded(theBill))
        _addTransaction(theBill.ToString)
    End Sub '_addBill(ByVal pID As String, ByVal pBillDate As Date, ByVal pUnitsUsed As Decimal, ByVal pCurrentBillAmountDue As Decimal, _etc)

    Private Sub _addCustomer(ByVal pID As String, ByVal pName As String)
        Dim theCustomer As New Customer(pID, pName)

        If _NumOfCustomers >= _maxCustomers Then
            _maxCustomers += ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mCustomer(_maxCustomers - 1)
        End If

        Try
            _ithCustomer(_NumOfCustomers) = theCustomer
        Catch ex As IndexOutOfRangeException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        _NumOfCustomers += 1


        RaiseEvent Customer_CustomerAdded(Me, New Customer_EventArgs_CustomerAdded(theCustomer))
        _addTransaction(theCustomer.ToString)
    End Sub '_addCustomer(ByVal pID As String, ByVal pName As String)

    Private Sub _addUtility(ByVal pID As String, ByVal pName As String, ByVal pType As String, ByVal pUnits As String)

        Dim theUtility As New Utility(pID, pName, pType, pUnits)

        If _NumOfUtilities >= _maxUtilities Then
            _maxUtilities += ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mUtility(_maxUtilities - 1)
        End If

        Try
            _ithUtility(_NumOfUtilities) = theUtility
        Catch ex As IndexOutOfRangeException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try

        _NumOfUtilities += 1


        RaiseEvent Utility_UtilityAdded(Me, New Utility_EventArgs_UtilityAdded(theUtility))
        _addTransaction(theUtility.ToString)
    End Sub

    Private Sub _applyPayment(ByVal pID As String, ByVal pPaymentDate As Date, ByVal pAmountPaid As Decimal, ByRef pBill As Bill)

        Dim theBill As Bill = pBill
        'Make sure the correct bill is searched from the array before next line of code
        'A bunch of error checking can be done here whether if the payment is too much, or whatever, process only if valid or allow negative numbers?
        'Only raise Event After Payment has been applied, maybe add a bool?
        theBill.ApplyPayment(pID, pPaymentDate, pAmountPaid) 'This is the line where the payment is applied to the specified bill, so bill parameter isn't needed now
        _NumOfALLPayments += 1

        RaiseEvent Payment_PaymentAdded(Me, New Payment_EventArgs_PaymentAdded(theBill.Payment(theBill.NumberOfPayments - 1))) 'it'll always be the last index of the array being raised
    End Sub '_applyPayment(ByVal pID As String, ByVal pPaymentDate As Date, ByVal pAmountPaid As Decimal, ByRef pBill As Bill)

    Private Sub _addTransaction(ByVal pTransaction As String)

        Dim theTransaction As String = pTransaction

        If _NumOfTransactions >= _maxTransactions Then
            _maxTransactions += ARRAY_INCREMENT_DEFAULT
            ReDim Preserve mTransaction(_maxTransactions - 1)
        End If

        Try
            _ithTransaction(_NumOfTransactions) = theTransaction
        Catch ex As IndexOutOfRangeException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try

        _NumOfTransactions += 1

        RaiseEvent Transaction_TransactionAdded(Me, New EventArgs_TransactionAdded(theTransaction))
    End Sub
    'Private Function _value() As Decimal

    '    '_value() calculates and returns the actual value of this
    '    'PortfolioItem: the current market price times the number of
    '    'shares owned.

    '    'We could have used this private function for this purpose, but
    '    'instead we designed an equivalent private/public pair of property
    '    'procedures (above) and use them instead.

    '    Return _stock.price * _numShares

    'End Function '_value()

    Private Function _toString() As String

        '_toString() returns a string version of the object.

        'This is the private method, that actually does the work.

        Dim tmpStr As String

        tmpStr = _
            "# Utility System CREATED: " _
            & "System Name =" & _SystemName.ToString _
            & "No. Of Utility Systems =" & _NumOfUtilitySystems.ToString _
            & "No. Of Bills =" & _NumOfBills.ToString _
            & ")" + Environment.NewLine

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
    '             - Initiated as a result of business logic
    '               method(s) running

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'These are all public.
    Public Event UtilitySystem_UtilitySystemAdded(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Bill_BillAdded(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Customer_CustomerAdded(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Utility_UtilityAdded(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Transaction_TransactionAdded(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event Payment_PaymentAdded(ByVal sender As Object, ByVal e As System.EventArgs)

#End Region 'Events


End Class 'UtilitySystem