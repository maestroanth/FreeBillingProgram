'Copyright (c) 2009-2014 Dan Turk

#Region "Class / File Comment Header block"
'Program:   Proj04-Walter-Anthony    
'File:      Proj04-Walter-Anthony            
'Author:    Anthony Walter         
'Description:   4rd iteration main form of mock utility billing company project  
'Date:         5/4/2015      
'Tier:          User-Interface    
'Exceptions:    Checks for errors in parsing data unselected comboboxes
'Exception-Handling: Uses Try/Catches for catching parsing errors and if statements for blank textboxes or cboboxes
'Events:         Responds to Event Args being added
'Event-Handling: Responds to Added Events at the end  

'note to myself: if I ever wanna change file format, adjust the WriteFile(), _finishWriteFile() functions and adjust 
'the export .ToStrings methodsappropiately in each object class

#End Region 'Class / File Comment Header block

#Region "Option / Imports"
Option Explicit On      'Must declare variables before using them
Option Strict On        'Must perform explicit data type conversions
Imports System.IO
Imports System.Reflection
#End Region 'Option / Imports

Public Class FrmMain

#Region "Attributes"
    '******************************************************************
    'Attributes + Module-level Constants+Variables
    '******************************************************************

    Private WithEvents mTheUtilitySystem As UtilitySystem
    Private WithEvents theOpenFileDialog As New OpenFileDialog
    '********** Module-level constants

    '********** Module-level variables

#End Region 'Attributes

#Region "Constructors"
    '******************************************************************
    'Constructors
    '******************************************************************

    'No Constructors are currently defined.
    'These are all public.

    '********** Default constructor
    '             - no parameters

    '********** Special constructor(s)
    '             - typically constructors have parameters 
    '               that are used to initialize attributes

    '********** Copy constructor(s)
    '             - one parameter, an object of the same class
    'blah
#End Region 'Constructors

#Region "Get/Set Methods"
    '******************************************************************
    'Get/Set Methods
    '******************************************************************

    'No Get/Set Methods are currently defined.

    '********** Public Get/Set Methods
    '             - call private get/set methods to implement
    Public ReadOnly Property TheUtilitySystem As UtilitySystem
        Get
            Return mTheUtilitySystem
        End Get
    End Property

    '********** Private Get/Set Methods
    '             - access attributes, begin name with underscore (_)
    Private Property _theUtilitySystem As UtilitySystem
        Get
            Return mTheUtilitySystem
        End Get
        Set(pValue As UtilitySystem)
            mTheUtilitySystem = pValue
        End Set
    End Property


#End Region 'Get/Set Methods

#Region "Behavioral Methods"
    '******************************************************************
    'Behavioral Methods
    '******************************************************************

    'No Behavioral Methods are currently defined.

    '********** Public Shared Behavioral Methods

    '********** Private Shared Behavioral Methods

    '********** Public Non-Shared Behavioral Methods

    Private Sub _initializeBusinessLogic()
        'creates the whole system Utility class where all the other classes and creation methods come from
        _theUtilitySystem = New UtilitySystem("Gimmie My Money Utilities!!!!!")
        mTheUtilitySystem.AddUtilitySystem("Gimmie My Money Utilities!!!!!")
    End Sub '_initializeBusinessLogic()

    Private Sub _initializeUserInterface()
        Me.AcceptButton = btnTestData
        Me.CancelButton = btnExit
        'Me.btnTestData.Hide() 'BOOL THIS OFF IN RELEASE VERIONS!!!
        'btnConfirm.enabled = False
    End Sub '_initializeUserInterface()

    Private Sub _processTestData()
        'calling events with hardcode this is the only part that allows duplication

        mTheUtilitySystem.AddCustomer("CUS001", "Joe Ker")
        mTheUtilitySystem.AddCustomer("CUS002", "Bat Man")
        mTheUtilitySystem.AddCustomer("CUS003", "Super Man")

        mTheUtilitySystem.AddUtility("UTI001", "Smelley Plumbing", "Sewer", "Gallons")
        mTheUtilitySystem.AddUtility("UTI002", "Zap's Electricity", "Electricity", "Watts")
        mTheUtilitySystem.AddUtility("UTI003", "Pyro Heating", "Gas/Heating", "Liters")

        mTheUtilitySystem.AddBill("BIL001", New Date(2016, 2, 26), CDec(43.23), CDec(454.44), mTheUtilitySystem.Customer(0), _
                                  mTheUtilitySystem.Utility(0))
        mTheUtilitySystem.AddBill("BIL002", New Date(2016, 2, 25), CDec(23.23), CDec(111.34), mTheUtilitySystem.Customer(1), _
                                  mTheUtilitySystem.Utility(1))

        mTheUtilitySystem.ApplyPayment("PAY001", New Date(9999, 12, 31), CDec(224.13), mTheUtilitySystem.Bill(0))
        mTheUtilitySystem.ApplyPayment("PAY002", New Date(1442, 5, 10), CDec(114.43), mTheUtilitySystem.Bill(1))
        mTheUtilitySystem.ApplyPayment("PAY003", New Date(2021, 11, 15), CDec(24.73), mTheUtilitySystem.Bill(0))
        mTheUtilitySystem.ApplyPayment("PAY004", New Date(1044, 2, 1), CDec(1.13), mTheUtilitySystem.Bill(1))

    End Sub '_processTestData()


    '********** Private Non-Shared Behavioral Methods

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
    Private Sub _FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _initializeBusinessLogic()
        _initializeUserInterface()
    End Sub ' _FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    '********** Business Logic Event Procedures
    '             - Initiated as a result of business logic
    '               method(s) running
    Private Sub _UtilitySystemAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.UtilitySystem_UtilitySystemAdded
        'declare variables
        Dim theUtilitySystemAdded_EventArgs_UtilitySystemAdded As UtilitySystem_EventArgs_UtilitySystemAdded


        Dim theUtilitySystem As UtilitySystem

        'get/validate input
        theUtilitySystemAdded_EventArgs_UtilitySystemAdded = CType(e, UtilitySystem_EventArgs_UtilitySystemAdded)

        theUtilitySystem = theUtilitySystemAdded_EventArgs_UtilitySystemAdded.UtilitySystem
        'do processing

        'display output


        lstTransactions.Items.Add(theUtilitySystem.ToString())
        lstMisc.Items.Add(theUtilitySystem.ToString())
        txtNumTransactions.Text = mTheUtilitySystem.NumOfTransactions.ToString
    End Sub '_UtilitySystemAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.UtilitySystem_UtilitySystemAdded

    Private Sub _BillAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Bill_BillAdded
        'declare variables
        Dim theBillAdded_EventArgs_BillAdded As Bill_EventArgs_BillAdded


        Dim theBill As Bill

        'get/validate input
        theBillAdded_EventArgs_BillAdded = CType(e, Bill_EventArgs_BillAdded) ' retrieving the data from class

        theBill = theBillAdded_EventArgs_BillAdded.Bill 'setting the data to variable
        'do processing

        'display output
        lstTransactions.Items.Add(theBill.ToString)
        lstBills.Items.Add(theBill.ID.ToString)
        'lstMisc.Items.Add(theBill.ToString)
        cboPaymentsTabBillID.Items.Add(theBill.ID)
        txtBillCount.Text = mTheUtilitySystem.NumOfBills.ToString
        txtNumTransactions.Text = mTheUtilitySystem.NumOfTransactions.ToString

        'get ready for next input
        txtBillID.Clear()
        txtUsage.Clear()
        dtpBillDate.Value = Today
        txtBillsAmountOwed.Clear()
        txtBillID.Focus()
        mTheUtilitySystem.AddTransaction(theBill.ToString)
    End Sub '_BillAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Bill_BillAdded

    Private Sub _UtilityAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Utility_UtilityAdded
        'declare variables
        Dim theUtilityAdded_EventArgs_UtilityAdded As Utility_EventArgs_UtilityAdded


        Dim theUtility As Utility

        'get/validate input
        theUtilityAdded_EventArgs_UtilityAdded = CType(e, Utility_EventArgs_UtilityAdded) ' retrieving the data from class

        theUtility = theUtilityAdded_EventArgs_UtilityAdded.Utility 'setting the data to variable
        'do processing

        'display output
        lstTransactions.Items.Add(theUtility.ToString)
        lstUtility.Items.Add(theUtility.ID.ToString)
        'lstMisc.Items.Add(theUtility.ToString)
        cboBillsTabUtilityID.Items.Add(theUtility.ID)
        txtUtilityCount.Text = mTheUtilitySystem.NumOfUtilities.ToString
        txtNumTransactions.Text = mTheUtilitySystem.NumOfTransactions.ToString

        'get ready for next input
        txtNewUtilityID.Clear()
        txtUtilityName.Clear()
        txtUtilityType.Clear()
        txtUnitOfMeasure.Clear()
        txtNewUtilityID.Focus()
        mTheUtilitySystem.AddTransaction(theUtility.ToString)

    End Sub '_UtilityAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Utility_UtilityAdded

    Private Sub _CustomerAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Customer_CustomerAdded
        'declare variables
        Dim theCustomerAdded_EventArgs_CustomerAdded As Customer_EventArgs_CustomerAdded


        Dim theCustomer As Customer

        'get/validate input
        theCustomerAdded_EventArgs_CustomerAdded = CType(e, Customer_EventArgs_CustomerAdded) ' retrieving the data from class

        theCustomer = theCustomerAdded_EventArgs_CustomerAdded.Customer 'setting the data to variable
        'do processing

        'display output
        lstTransactions.Items.Add(theCustomer.ToString)
        lstCustomer.Items.Add(theCustomer.ID.ToString)
        'lstMisc.Items.Add(theCustomer.ToString)
        cboBillsTabCustomerID.Items.Add(theCustomer.ID)
        txtCustomerCount.Text = mTheUtilitySystem.NumOfCustomers.ToString
        txtNumTransactions.Text = mTheUtilitySystem.NumOfTransactions.ToString

        'get ready for next input
        txtNewCustomerID.Clear()
        txtCustomerName.Clear()
        txtNewCustomerID.Focus()
        mTheUtilitySystem.AddTransaction(theCustomer.ToString)
    End Sub '_CustomerAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Customer_CustomerAdded

    Private Sub _PaymentAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Payment_PaymentAdded
        'declare variables
        Dim thePaymentAdded_EventArgs_PaymentAdded As Payment_EventArgs_PaymentAdded


        Dim thePayment As Payment

        'get/validate input
        thePaymentAdded_EventArgs_PaymentAdded = CType(e, Payment_EventArgs_PaymentAdded) ' retrieving the data from class

        thePayment = thePaymentAdded_EventArgs_PaymentAdded.Payment 'setting the data to variable
        'do processing

        'display output
        lstTransactions.Items.Add(thePayment.ToString)
        txtNumTransactions.Text = mTheUtilitySystem.NumOfTransactions.ToString

        'get ready for next input
        txtReceiptID.Clear()
        txtCustomerPayment.Clear()
        txtReceiptID.Focus()
        mTheUtilitySystem.AddTransaction(thePayment.ToString)
    End Sub '_PaymentAdded(ByVal sender As Object, ByVal e As EventArgs) Handles mTheUtilitySystem.Payment_PaymentAdded

#End Region 'Event Procedures

#Region "Events"
    '******************************************************************
    'Events
    '******************************************************************

    'No Events are currently defined.
    'These are all public.

#End Region 'Events



    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click

        'declare variables
        Dim theID As String
        Dim theName As String

        'get & parse input ADD ERROR CHECKING FOR BLANKS AND CORRECT VALUES VERY LAST
        If txtNewCustomerID.Text = "" Then
            MessageBox.Show("Please enter a CustomerID")
            txtNewCustomerID.Focus()
            Exit Sub
        Else
            theID = Trim(txtNewCustomerID.Text)
        End If

        If txtCustomerName.Text = "" Then
            MessageBox.Show("Please enter a Customer Name")
            txtCustomerName.Focus()

            Exit Sub
        Else
            theName = Trim(txtCustomerName.Text)
        End If

        'check for duplicate entries

        For i As Integer = 0 To mTheUtilitySystem.NumOfCustomers - 1
            If Trim(Me.txtNewCustomerID.Text) = mTheUtilitySystem.Customer(i).ID Then
                MessageBox.Show("This is a duplicate ID. Enter a new ID.")
                txtNewCustomerID.Focus()
                Exit Sub
            End If

        Next

        'add the customer
        mTheUtilitySystem.AddCustomer(theID, theName)

    End Sub 'btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click

    Private Sub btnAddUtility_Click(sender As Object, e As EventArgs) Handles btnAddUtility.Click

        'declare variables
        Dim theID As String
        Dim theName As String
        Dim theType As String
        Dim theUnits As String


        'get & parse input ADD ERROR CHECKING FOR BLANKS AND CORRECT VALUES VERY LAST
        If txtNewUtilityID.Text = "" Then
            MessageBox.Show("Please enter a Utility ID")
            txtNewUtilityID.Focus()
            Exit Sub
        Else
            theID = Trim(txtNewUtilityID.Text)
        End If

        If txtUtilityType.Text = "" Then
            MessageBox.Show("Please enter a Utility Type")
            txtUtilityType.Focus()
            Exit Sub
        Else
            theType = Trim(txtUtilityType.Text)
        End If
        If txtUtilityName.Text = "" Then
            MessageBox.Show("Please enter a Utility Name")
            txtUtilityName.Focus()
            Exit Sub
        Else
            theName = Trim(txtUtilityName.Text)
        End If

        

        If txtUnitOfMeasure.Text = "" Then
            MessageBox.Show("Please enter a Unit of Measure")
            txtUnitOfMeasure.Focus()
            Exit Sub
        Else
            theUnits = Trim(txtUnitOfMeasure.Text)
        End If

        'check for duplicate entries

        For i As Integer = 0 To mTheUtilitySystem.NumOfUtilities - 1
            If Trim(Me.txtNewUtilityID.Text) = mTheUtilitySystem.Utility(i).ID Then
                MessageBox.Show("This is a duplicate ID. Enter a new ID.")
                txtNewUtilityID.Focus()
                Exit Sub
            End If
        Next


        'add the utility
        mTheUtilitySystem.AddUtility(theID, theName, theType, theUnits)
    End Sub 'btnAddUtility_Click(sender As Object, e As EventArgs) Handles btnAddUtility.Click

    Private Sub btnGenerateBill_Click(sender As Object, e As EventArgs) Handles btnGenerateBill.Click
        'declare variables
        Dim theID As String
        Dim theBillDate As Date
        Dim theUnitsUsed As Decimal
        Dim theCurrentBillAmountDue As Decimal
        Dim theCustomerID As String
        Dim theUtilityID As String
        Dim theCustomer As Customer
        Dim theUtility As Utility
        Dim customerIndex As Integer 'this is used to help populate textbox and grab correct class[index]
        Dim utilityIndex As Integer 'this is used to help populate textbox and grab correct class[index]

        'get & parse input ADD ERROR CHECKING FOR BLANKS AND COMBOBOX CHOICES VERY LAST
        If txtBillID.Text = "" Then
            MessageBox.Show("Please enter a Bill ID")
            txtBillID.Focus()
            Exit Sub
        Else
            theID = Trim(txtBillID.Text)
        End If


        If cboBillsTabCustomerID.Text = String.Empty Then
            MessageBox.Show("Please Select A Customer ID")
            cboBillsTabCustomerID.Focus()
            Exit Sub
        Else
            theCustomerID = cboBillsTabCustomerID.Text
            customerIndex = cboBillsTabCustomerID.SelectedIndex

        End If

        'check for duplicate entries

        For i As Integer = 0 To mTheUtilitySystem.NumOfBills - 1
            If Trim(Me.txtBillID.Text) = mTheUtilitySystem.Bill(i).ID Then
                MessageBox.Show("This is a duplicate ID. Enter a new ID.")
                txtBillID.Focus()
                Exit Sub
            End If
        Next


        If cboBillsTabUtilityID.Text = String.Empty = True Then
            MessageBox.Show("Please Select A Utility ID")
            cboBillsTabUtilityID.Focus()
            Exit Sub
        Else
            theUtilityID = cboBillsTabUtilityID.Text
            utilityIndex = cboBillsTabUtilityID.SelectedIndex
        End If

        Try 'Do if statement later to make sure date isn't earlier than today
            theBillDate = dtpBillDate.Value
        Catch ex As Exception
            MessageBox.Show("Please choose a valid date from the date picker.")
            dtpBillDate.Focus()
            Exit Sub
        End Try

        Try
            Trim(txtUsage.Text)
            theUnitsUsed = Decimal.Parse(txtUsage.Text)

        Catch ex As Exception
            MessageBox.Show("Please enter a decimal value for the Units Used." _
                & "For example: 25.75")
            txtUsage.Focus()
            Exit Sub
        End Try



        Try
            Trim(txtBillsAmountOwed.Text)
            theCurrentBillAmountDue = Decimal.Parse(txtBillsAmountOwed.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a decimal value for the Amount Due." _
                & "For example: 25.75")
            txtBillsAmountOwed.Focus()
            Exit Sub
        End Try






        'Make Do Processing

        'The logic to grab class from cbo box is passing the index selected to index of array, it should be the same if numOfCustomers are updated accurately
        theCustomer = mTheUtilitySystem.Customer(customerIndex)


        'Need to find a way to bring up the Utility Class from ID
        theUtility = mTheUtilitySystem.Utility(utilityIndex)

        mTheUtilitySystem.AddBill(theID, theBillDate, theUnitsUsed, theCurrentBillAmountDue, theCustomer, theUtility)

    End Sub 'btnGenerateBill_Click(sender As Object, e As EventArgs) Handles btnGenerateBill.Click

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        'declare variables
        Dim theReceiptID As String
        Dim thePaymentDate As Date
        Dim theAmountPaid As Decimal
        Dim theBillID As String
        Dim theBill As Bill
        Dim billIndex As Integer
        Dim trimmedString As String
        'get & parse input ADD ERROR CHECKING FOR BLANKS AND COMBOBOX CHOICES VERY LAST

        If cboPaymentsTabBillID.Text = String.Empty = True Then
            MessageBox.Show("Please Select A Bill ID")
            cboBillsTabUtilityID.Focus()
            Exit Sub
        Else
            theBillID = cboBillsTabUtilityID.Text
            billIndex = cboPaymentsTabBillID.SelectedIndex
        End If

        If txtReceiptID.Text = "" Then
            MessageBox.Show("Please enter a Receipt ID")
            txtReceiptID.Focus()
            Exit Sub
        Else
            theReceiptID = Trim(txtReceiptID.Text)
        End If
        trimmedString = Trim(txtReceiptID.Text)
        'check for duplicate payment ID's
        For i As Integer = 0 To mTheUtilitySystem.NumOfBills - 1

            'bill being searched
            For j As Integer = 0 To mTheUtilitySystem.Bill(i).NumberOfPayments - 1

                If (mTheUtilitySystem.Bill(i).Payment(j).ID = trimmedString) Then
                    MessageBox.Show("This is a duplicate ID. Enter a new ID.")
                    txtReceiptID.Focus()
                    Exit Sub
                End If

            Next j
        Next i

        Try 'Do if statement later to make sure date isn't earlier than today
            thePaymentDate = dtpReceipts.Value
        Catch ex As Exception
            MessageBox.Show("Please choose a valid date from the date picker.")
            dtpReceipts.Focus()
            Exit Sub
        End Try


        Try
            Trim(txtCustomerPayment.Text)
            theAmountPaid = Decimal.Parse(txtCustomerPayment.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a decimal value for the Amount Due." _
                & "For example: 25.75")
            txtCustomerPayment.Focus()
            txtCustomerPayment.SelectAll()
            Exit Sub
        End Try

        'Make Do Processing
        theBill = mTheUtilitySystem.Bill(billIndex)


        'Make Payment object
        mTheUtilitySystem.ApplyPayment(theReceiptID, thePaymentDate, theAmountPaid, theBill)

        'Reset Form(Same function as cbo dropdown event)
        cboPaymentsTabBillIDBoxChanged()
        txtReceiptID.Text = ""
        txtCustomerPayment.Text = ""
        dtpReceipts.Value = Today

    End Sub 'btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

    'BottomeButtons
    Private Sub btnTestData_Click(sender As Object, e As EventArgs) Handles btnTestData.Click
        _processTestData()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub 'BottomeButtons

    Private Sub grpCustomer_Enter(sender As Object, e As EventArgs) Handles grpCustomer.Enter

    End Sub

    'Pairing Up the list boxes in Payments Tab if selection changes
    Private Sub lstBillsTabPaymentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBillsTabPaymentID.SelectedIndexChanged
        lstPaymentsTabPaymentAmount.SelectedIndex = lstBillsTabPaymentID.SelectedIndex
        Dim billIndex As Integer = cboPaymentsTabBillID.SelectedIndex
        Dim paymentIndex As Integer = lstBillsTabPaymentID.SelectedIndex
        ' Dim thePayment As Payment

        'Ugh, didn't need this data afterall, but it's commented out just in case I want to access a payment from the form
        'thePayment = mTheUtilitySystem.Bill(billIndex).Payment(paymentIndex) 'should be array index of selected combobox for bill and selected lstbox for payment

    End Sub

    Private Sub lstPaymentsTabPaymentAmount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPaymentsTabPaymentAmount.SelectedIndexChanged
        lstBillsTabPaymentID.SelectedIndex = lstPaymentsTabPaymentAmount.SelectedIndex
    End Sub




    Private Sub cboBillsTabCustomerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBillsTabCustomerID.SelectedIndexChanged
        Dim customerIndex As Integer = cboBillsTabCustomerID.SelectedIndex
        Dim theCustomer As Customer

        theCustomer = mTheUtilitySystem.Customer(customerIndex)

        txtBillsTabCustomerName.Text = theCustomer.Name

    End Sub

    Private Sub cboBillsTabUtilityID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBillsTabUtilityID.SelectedIndexChanged
        Dim utilityIndex As Integer = cboBillsTabUtilityID.SelectedIndex
        Dim theUtility As Utility

        theUtility = mTheUtilitySystem.Utility(utilityIndex)

        txtBillsTabUtilityName.Text = theUtility.Name

    End Sub

    Private Sub cboPaymentsTabBillID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentsTabBillID.SelectedIndexChanged
        cboPaymentsTabBillIDBoxChanged() 'moved this to separate function so it can be used with pay button too to reset the form.
    End Sub

    Private Sub cboPaymentsTabBillIDBoxChanged()
        Dim billIndex As Integer = cboPaymentsTabBillID.SelectedIndex
        Dim theBill As Bill
        Dim theCustomer As Customer
        Dim theUtility As Utility

        theBill = mTheUtilitySystem.Bill(billIndex)
        theUtility = theBill.Utility
        theCustomer = theBill.Customer

        lstBillsTabPaymentID.Items.Clear()
        lstPaymentsTabPaymentAmount.Items.Clear()
        'populating listboxes
        For i As Integer = 0 To theBill.NumberOfPayments - 1
            lstBillsTabPaymentID.Items.Add(theBill.Payment(i).ID)
            lstPaymentsTabPaymentAmount.Items.Add(theBill.Payment(i).AmountPaid)
        Next i

        'populating textboxes
        txtPaymentsTabBillDate.Text = theBill.BillDate.ToString("yyyy-MM-dd")
        txtPaymentsTabCustomerName.Text = theCustomer.Name
        txtPaymentsTabUtilityName.Text = theUtility.Name
        txtPaymentsTabTotalPayments.Text = CStr(theBill.TotalPayments())
        txtPaymentsTabAmountOwed.Text = CStr(theBill.CurrentBillAmountDue)

    End Sub




    Private Sub lstPayments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPayments.SelectedIndexChanged


        Dim paymentBillIndex As Integer = lstPayments.SelectedIndex
        Dim thePayment As Payment

        'setting and clearing if lst is too full
        If lstMisc.Items.Count > 3 Then
            lstMisc.Items.Clear()
        End If

        Try
            thePayment = mTheUtilitySystem.Bill(lstBills.SelectedIndex).Payment(paymentBillIndex)
        Catch
            Exit Sub
        End Try


        lstMisc.Items.Add(thePayment.ToString)

        'clear/deselect other boxes

        'Clearing Selections is causing this to crash for some reason
        'lstBills.ClearSelected()
        ' lstUtility.ClearSelected()
        'lstCustomer.ClearSelected()

    End Sub

    Private Sub lstBills_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBills.SelectedIndexChanged
        Dim billIndex As Integer = lstBills.SelectedIndex
        Dim theBill As Bill
        lstPayments.Items.Clear()

        Try
            theBill = mTheUtilitySystem.Bill(billIndex)
        Catch
            Exit Sub
        End Try

        'setting and clearing if lst is too full
        If lstMisc.Items.Count > 3 Then
            lstMisc.Items.Clear()
        End If

        For i As Integer = 0 To theBill.NumberOfPayments - 1
            lstPayments.Items.Add(theBill.Payment(i).ID.ToString)
        Next
        lstMisc.Items.Add(theBill.ToString)
        txtPaymentCount.Text = lstPayments.Items.Count.ToString
        'clear/deselect other boxes

        'lstPayments.ClearSelected()
        'lstUtility.ClearSelected()
        'lstCustomer.ClearSelected()
    End Sub


    Private Sub lstCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomer.SelectedIndexChanged

        Dim customerIndex As Integer = lstCustomer.SelectedIndex
        Dim theCustomer As Customer

        'setting and clearing if lst is too full
        If lstMisc.Items.Count > 3 Then
            lstMisc.Items.Clear()
        End If
        Try
            theCustomer = mTheUtilitySystem.Customer(customerIndex)
        Catch
            Exit Sub
        End Try

        lstMisc.Items.Add(theCustomer.ToString)

        'clear/deselect other boxes

        'lstPayments.ClearSelected()
        'lstUtility.ClearSelected()
        'lstBills.ClearSelected()

    End Sub

    Private Sub lstUtility_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUtility.SelectedIndexChanged
        Dim utilityIndex As Integer = lstUtility.SelectedIndex
        Dim theUtility As Utility



        'setting and clearing if lst is too full
        If lstMisc.Items.Count > 3 Then
            lstMisc.Items.Clear()
        End If

        Try
            theUtility = mTheUtilitySystem.Utility(utilityIndex)
        Catch
            Exit Sub
        End Try


        lstMisc.Items.Add(theUtility.ToString)
        'clear/deselect other boxes

        ' lstPayments.ClearSelected()
        'lstBills.ClearSelected()
        'lstCustomer.ClearSelected()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        mTheUtilitySystem.WriteFile(chkAppendFileToggle.Checked)

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        theOpenFileDialog.Title = "Please Select a File"

        theOpenFileDialog.InitialDirectory = "C:\Desktop"
        theOpenFileDialog.ShowDialog()


    End Sub
    Private Sub OpenFileDialog1_FifjleOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles theOpenFileDialog.FileOk


        Dim theFile As System.IO.Stream


        theFile = theOpenFileDialog.OpenFile()


        'TextBox1.Text = theOpenFileDialog.FileName.ToString()

        If Not (theFile Is Nothing) Then
            'insert code to read the file data
            mTheUtilitySystem.ReadFile(theFile)
            theFile.Close()
        Else
            MessageBox.Show("problem opening file.")
        End If


    End Sub

End Class 'FrmMain