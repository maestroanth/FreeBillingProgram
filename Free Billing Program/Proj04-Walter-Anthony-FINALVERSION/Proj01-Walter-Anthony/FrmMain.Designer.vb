<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtPaymentCount = New System.Windows.Forms.TextBox()
        Me.txtBillCount = New System.Windows.Forms.TextBox()
        Me.lstBills = New System.Windows.Forms.ListBox()
        Me.lstPayments = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerCount = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lstUtility = New System.Windows.Forms.ListBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lstCustomer = New System.Windows.Forms.ListBox()
        Me.txtUtilityCount = New System.Windows.Forms.TextBox()
        Me.lstMisc = New System.Windows.Forms.ListBox()
        Me.tabCustomer = New System.Windows.Forms.TabPage()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtNewCustomerID = New System.Windows.Forms.TextBox()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.tabUtility = New System.Windows.Forms.TabPage()
        Me.grpUtility = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtUnitOfMeasure = New System.Windows.Forms.TextBox()
        Me.txtUtilityType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUtilityName = New System.Windows.Forms.TextBox()
        Me.txtNewUtilityID = New System.Windows.Forms.TextBox()
        Me.btnAddUtility = New System.Windows.Forms.Button()
        Me.tabBills = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenerateBill = New System.Windows.Forms.Button()
        Me.grpBill = New System.Windows.Forms.GroupBox()
        Me.txtBillsTabCustomerName = New System.Windows.Forms.TextBox()
        Me.txtBillsTabUtilityName = New System.Windows.Forms.TextBox()
        Me.cboBillsTabCustomerID = New System.Windows.Forms.ComboBox()
        Me.cboBillsTabUtilityID = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBillID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBillsAmountOwed = New System.Windows.Forms.TextBox()
        Me.txtUsage = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpBillDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabPayments = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstPaymentsTabPaymentAmount = New System.Windows.Forms.ListBox()
        Me.txtPaymentsTabTotalPayments = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lstBillsTabPaymentID = New System.Windows.Forms.ListBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtPaymentsTabAmountOwed = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboPaymentsTabBillID = New System.Windows.Forms.ComboBox()
        Me.txtPaymentsTabUtilityName = New System.Windows.Forms.TextBox()
        Me.txtPaymentsTabCustomerName = New System.Windows.Forms.TextBox()
        Me.txtPaymentsTabBillDate = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.grpPayments = New System.Windows.Forms.GroupBox()
        Me.txtCustomerPayment = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpReceipts = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtReceiptID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabTransactions = New System.Windows.Forms.TabPage()
        Me.grpFiles = New System.Windows.Forms.GroupBox()
        Me.chkAppendFileToggle = New System.Windows.Forms.CheckBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.grpTransactions = New System.Windows.Forms.GroupBox()
        Me.txtNumTransactions = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstTransactions = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tipForFrmMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTestData = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.tbcMain.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        Me.grpCustomer.SuspendLayout()
        Me.tabUtility.SuspendLayout()
        Me.grpUtility.SuspendLayout()
        Me.tabBills.SuspendLayout()
        Me.grpBill.SuspendLayout()
        Me.tabPayments.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpPayments.SuspendLayout()
        Me.tabTransactions.SuspendLayout()
        Me.grpFiles.SuspendLayout()
        Me.grpTransactions.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabSummary)
        Me.tbcMain.Controls.Add(Me.tabCustomer)
        Me.tbcMain.Controls.Add(Me.tabUtility)
        Me.tbcMain.Controls.Add(Me.tabBills)
        Me.tbcMain.Controls.Add(Me.tabPayments)
        Me.tbcMain.Controls.Add(Me.tabTransactions)
        Me.tbcMain.HotTrack = True
        Me.tbcMain.Location = New System.Drawing.Point(41, 25)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(578, 420)
        Me.tbcMain.TabIndex = 1
        Me.tbcMain.TabStop = False
        '
        'tabSummary
        '
        Me.tabSummary.Controls.Add(Me.Label24)
        Me.tabSummary.Controls.Add(Me.GroupBox2)
        Me.tabSummary.Controls.Add(Me.GroupBox1)
        Me.tabSummary.Controls.Add(Me.lstMisc)
        Me.tabSummary.Location = New System.Drawing.Point(4, 22)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(570, 394)
        Me.tabSummary.TabIndex = 0
        Me.tabSummary.Text = "Summary"
        Me.tipForFrmMain.SetToolTip(Me.tabSummary, "Overall Summary of Utility")
        Me.tabSummary.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(19, 335)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 13)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Details/Misc. List:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.txtPaymentCount)
        Me.GroupBox2.Controls.Add(Me.txtBillCount)
        Me.GroupBox2.Controls.Add(Me.lstBills)
        Me.GroupBox2.Controls.Add(Me.lstPayments)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bill and Payment Lists"
        Me.tipForFrmMain.SetToolTip(Me.GroupBox2, "Summary of Bill and Payment Lists")
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(312, 127)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(82, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Payment Count:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(122, 127)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(54, 13)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "Bill Count:"
        '
        'txtPaymentCount
        '
        Me.txtPaymentCount.Location = New System.Drawing.Point(403, 124)
        Me.txtPaymentCount.Name = "txtPaymentCount"
        Me.txtPaymentCount.ReadOnly = True
        Me.txtPaymentCount.Size = New System.Drawing.Size(31, 20)
        Me.txtPaymentCount.TabIndex = 4
        Me.txtPaymentCount.TabStop = False
        '
        'txtBillCount
        '
        Me.txtBillCount.Location = New System.Drawing.Point(185, 124)
        Me.txtBillCount.Name = "txtBillCount"
        Me.txtBillCount.ReadOnly = True
        Me.txtBillCount.Size = New System.Drawing.Size(31, 20)
        Me.txtBillCount.TabIndex = 6
        Me.txtBillCount.TabStop = False
        '
        'lstBills
        '
        Me.lstBills.FormattingEnabled = True
        Me.lstBills.HorizontalScrollbar = True
        Me.lstBills.Location = New System.Drawing.Point(16, 19)
        Me.lstBills.Name = "lstBills"
        Me.lstBills.Size = New System.Drawing.Size(200, 95)
        Me.lstBills.TabIndex = 1
        Me.lstBills.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.lstBills, "Bill List")
        '
        'lstPayments
        '
        Me.lstPayments.FormattingEnabled = True
        Me.lstPayments.HorizontalScrollbar = True
        Me.lstPayments.Location = New System.Drawing.Point(228, 19)
        Me.lstPayments.Name = "lstPayments"
        Me.lstPayments.Size = New System.Drawing.Size(215, 95)
        Me.lstPayments.TabIndex = 1
        Me.lstPayments.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.lstPayments, "Payments Received")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCustomerCount)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.lstUtility)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.lstCustomer)
        Me.GroupBox1.Controls.Add(Me.txtUtilityCount)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer and Utility Lists"
        Me.tipForFrmMain.SetToolTip(Me.GroupBox1, "Summary of Customer and Utility Lists")
        '
        'txtCustomerCount
        '
        Me.txtCustomerCount.Location = New System.Drawing.Point(185, 116)
        Me.txtCustomerCount.Name = "txtCustomerCount"
        Me.txtCustomerCount.ReadOnly = True
        Me.txtCustomerCount.Size = New System.Drawing.Size(31, 20)
        Me.txtCustomerCount.TabIndex = 3
        Me.txtCustomerCount.TabStop = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(91, 119)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(85, 13)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "Customer Count:"
        '
        'lstUtility
        '
        Me.lstUtility.FormattingEnabled = True
        Me.lstUtility.HorizontalScrollbar = True
        Me.lstUtility.Location = New System.Drawing.Point(234, 21)
        Me.lstUtility.Name = "lstUtility"
        Me.lstUtility.Size = New System.Drawing.Size(209, 95)
        Me.lstUtility.TabIndex = 0
        Me.lstUtility.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.lstUtility, "Utility List")
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(340, 119)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 13)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Utility Count:"
        '
        'lstCustomer
        '
        Me.lstCustomer.FormattingEnabled = True
        Me.lstCustomer.HorizontalScrollbar = True
        Me.lstCustomer.Location = New System.Drawing.Point(16, 19)
        Me.lstCustomer.Name = "lstCustomer"
        Me.lstCustomer.Size = New System.Drawing.Size(200, 95)
        Me.lstCustomer.TabIndex = 0
        Me.lstCustomer.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.lstCustomer, "Customer List")
        '
        'txtUtilityCount
        '
        Me.txtUtilityCount.Location = New System.Drawing.Point(412, 116)
        Me.txtUtilityCount.Name = "txtUtilityCount"
        Me.txtUtilityCount.ReadOnly = True
        Me.txtUtilityCount.Size = New System.Drawing.Size(31, 20)
        Me.txtUtilityCount.TabIndex = 5
        Me.txtUtilityCount.TabStop = False
        '
        'lstMisc
        '
        Me.lstMisc.FormattingEnabled = True
        Me.lstMisc.HorizontalScrollbar = True
        Me.lstMisc.Location = New System.Drawing.Point(116, 306)
        Me.lstMisc.Name = "lstMisc"
        Me.lstMisc.Size = New System.Drawing.Size(370, 82)
        Me.lstMisc.TabIndex = 2
        Me.lstMisc.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.lstMisc, "Misc. List of selected objects.")
        '
        'tabCustomer
        '
        Me.tabCustomer.Controls.Add(Me.grpCustomer)
        Me.tabCustomer.Controls.Add(Me.btnAddCustomer)
        Me.tabCustomer.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomer.Name = "tabCustomer"
        Me.tabCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomer.Size = New System.Drawing.Size(570, 394)
        Me.tabCustomer.TabIndex = 1
        Me.tabCustomer.Text = "Customer"
        Me.tabCustomer.UseVisualStyleBackColor = True
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.Label2)
        Me.grpCustomer.Controls.Add(Me.Label3)
        Me.grpCustomer.Controls.Add(Me.txtCustomerName)
        Me.grpCustomer.Controls.Add(Me.txtNewCustomerID)
        Me.grpCustomer.Location = New System.Drawing.Point(111, 97)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(280, 140)
        Me.grpCustomer.TabIndex = 0
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Add New Customer"
        Me.tipForFrmMain.SetToolTip(Me.grpCustomer, "Use to Add Customer Info")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Customer ID#:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Name:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(101, 85)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(155, 20)
        Me.txtCustomerName.TabIndex = 1
        Me.tipForFrmMain.SetToolTip(Me.txtCustomerName, "Enter Customer Name (First and Last)")
        '
        'txtNewCustomerID
        '
        Me.txtNewCustomerID.Location = New System.Drawing.Point(101, 43)
        Me.txtNewCustomerID.Name = "txtNewCustomerID"
        Me.txtNewCustomerID.Size = New System.Drawing.Size(45, 20)
        Me.txtNewCustomerID.TabIndex = 0
        Me.tipForFrmMain.SetToolTip(Me.txtNewCustomerID, "Enter Customer ID")
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(220, 272)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCustomer.TabIndex = 1
        Me.btnAddCustomer.Text = "&Add"
        Me.tipForFrmMain.SetToolTip(Me.btnAddCustomer, "Add New Customer")
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'tabUtility
        '
        Me.tabUtility.Controls.Add(Me.grpUtility)
        Me.tabUtility.Controls.Add(Me.btnAddUtility)
        Me.tabUtility.Location = New System.Drawing.Point(4, 22)
        Me.tabUtility.Name = "tabUtility"
        Me.tabUtility.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUtility.Size = New System.Drawing.Size(570, 394)
        Me.tabUtility.TabIndex = 2
        Me.tabUtility.Text = "Utility"
        Me.tabUtility.UseVisualStyleBackColor = True
        '
        'grpUtility
        '
        Me.grpUtility.Controls.Add(Me.Label25)
        Me.grpUtility.Controls.Add(Me.txtUnitOfMeasure)
        Me.grpUtility.Controls.Add(Me.txtUtilityType)
        Me.grpUtility.Controls.Add(Me.Label11)
        Me.grpUtility.Controls.Add(Me.Label1)
        Me.grpUtility.Controls.Add(Me.Label7)
        Me.grpUtility.Controls.Add(Me.txtUtilityName)
        Me.grpUtility.Controls.Add(Me.txtNewUtilityID)
        Me.grpUtility.Location = New System.Drawing.Point(108, 89)
        Me.grpUtility.Name = "grpUtility"
        Me.grpUtility.Size = New System.Drawing.Size(280, 173)
        Me.grpUtility.TabIndex = 0
        Me.grpUtility.TabStop = False
        Me.grpUtility.Text = "Add New Utility Company"
        Me.tipForFrmMain.SetToolTip(Me.grpUtility, "Add Utility Company Info")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 124)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Unit of Measure: "
        '
        'txtUnitOfMeasure
        '
        Me.txtUnitOfMeasure.Location = New System.Drawing.Point(120, 121)
        Me.txtUnitOfMeasure.Name = "txtUnitOfMeasure"
        Me.txtUnitOfMeasure.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitOfMeasure.TabIndex = 3
        '
        'txtUtilityType
        '
        Me.txtUtilityType.Location = New System.Drawing.Point(174, 46)
        Me.txtUtilityType.Name = "txtUtilityType"
        Me.txtUtilityType.Size = New System.Drawing.Size(100, 20)
        Me.txtUtilityType.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(138, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "&Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Utility ID#:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "&Name:"
        '
        'txtUtilityName
        '
        Me.txtUtilityName.Location = New System.Drawing.Point(97, 82)
        Me.txtUtilityName.Name = "txtUtilityName"
        Me.txtUtilityName.Size = New System.Drawing.Size(155, 20)
        Me.txtUtilityName.TabIndex = 2
        Me.tipForFrmMain.SetToolTip(Me.txtUtilityName, "Enter Utility Company's Name")
        '
        'txtNewUtilityID
        '
        Me.txtNewUtilityID.Location = New System.Drawing.Point(68, 46)
        Me.txtNewUtilityID.Name = "txtNewUtilityID"
        Me.txtNewUtilityID.Size = New System.Drawing.Size(64, 20)
        Me.txtNewUtilityID.TabIndex = 0
        Me.tipForFrmMain.SetToolTip(Me.txtNewUtilityID, "Enter Utility ID")
        '
        'btnAddUtility
        '
        Me.btnAddUtility.Location = New System.Drawing.Point(202, 350)
        Me.btnAddUtility.Name = "btnAddUtility"
        Me.btnAddUtility.Size = New System.Drawing.Size(75, 23)
        Me.btnAddUtility.TabIndex = 1
        Me.btnAddUtility.Text = "&Add"
        Me.tipForFrmMain.SetToolTip(Me.btnAddUtility, "Add New Utility")
        Me.btnAddUtility.UseVisualStyleBackColor = True
        '
        'tabBills
        '
        Me.tabBills.Controls.Add(Me.Label4)
        Me.tabBills.Controls.Add(Me.btnGenerateBill)
        Me.tabBills.Controls.Add(Me.grpBill)
        Me.tabBills.Location = New System.Drawing.Point(4, 22)
        Me.tabBills.Name = "tabBills"
        Me.tabBills.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBills.Size = New System.Drawing.Size(570, 394)
        Me.tabBills.TabIndex = 3
        Me.tabBills.Text = "Bills"
        Me.tabBills.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Note: Need To Make Customers And Utilities First Before Bills Can Be Created"
        '
        'btnGenerateBill
        '
        Me.btnGenerateBill.Location = New System.Drawing.Point(207, 357)
        Me.btnGenerateBill.Name = "btnGenerateBill"
        Me.btnGenerateBill.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerateBill.TabIndex = 1
        Me.btnGenerateBill.Text = "&Generate"
        Me.tipForFrmMain.SetToolTip(Me.btnGenerateBill, "Generate Bill")
        Me.btnGenerateBill.UseVisualStyleBackColor = True
        '
        'grpBill
        '
        Me.grpBill.Controls.Add(Me.txtBillsTabCustomerName)
        Me.grpBill.Controls.Add(Me.txtBillsTabUtilityName)
        Me.grpBill.Controls.Add(Me.cboBillsTabCustomerID)
        Me.grpBill.Controls.Add(Me.cboBillsTabUtilityID)
        Me.grpBill.Controls.Add(Me.Label20)
        Me.grpBill.Controls.Add(Me.Label19)
        Me.grpBill.Controls.Add(Me.Label13)
        Me.grpBill.Controls.Add(Me.Label12)
        Me.grpBill.Controls.Add(Me.txtBillID)
        Me.grpBill.Controls.Add(Me.Label17)
        Me.grpBill.Controls.Add(Me.txtBillsAmountOwed)
        Me.grpBill.Controls.Add(Me.txtUsage)
        Me.grpBill.Controls.Add(Me.Label16)
        Me.grpBill.Controls.Add(Me.dtpBillDate)
        Me.grpBill.Controls.Add(Me.Label15)
        Me.grpBill.Controls.Add(Me.Label14)
        Me.grpBill.Location = New System.Drawing.Point(40, 35)
        Me.grpBill.Name = "grpBill"
        Me.grpBill.Size = New System.Drawing.Size(432, 316)
        Me.grpBill.TabIndex = 0
        Me.grpBill.TabStop = False
        Me.grpBill.Text = "Generate Bill"
        Me.tipForFrmMain.SetToolTip(Me.grpBill, "Use to Enter Billing Info ")
        '
        'txtBillsTabCustomerName
        '
        Me.txtBillsTabCustomerName.Location = New System.Drawing.Point(298, 76)
        Me.txtBillsTabCustomerName.Name = "txtBillsTabCustomerName"
        Me.txtBillsTabCustomerName.ReadOnly = True
        Me.txtBillsTabCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtBillsTabCustomerName.TabIndex = 17
        Me.txtBillsTabCustomerName.TabStop = False
        '
        'txtBillsTabUtilityName
        '
        Me.txtBillsTabUtilityName.Location = New System.Drawing.Point(298, 122)
        Me.txtBillsTabUtilityName.Name = "txtBillsTabUtilityName"
        Me.txtBillsTabUtilityName.ReadOnly = True
        Me.txtBillsTabUtilityName.Size = New System.Drawing.Size(100, 20)
        Me.txtBillsTabUtilityName.TabIndex = 16
        Me.txtBillsTabUtilityName.TabStop = False
        '
        'cboBillsTabCustomerID
        '
        Me.cboBillsTabCustomerID.AllowDrop = True
        Me.cboBillsTabCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBillsTabCustomerID.FormattingEnabled = True
        Me.cboBillsTabCustomerID.Location = New System.Drawing.Point(99, 76)
        Me.cboBillsTabCustomerID.MaxDropDownItems = 99
        Me.cboBillsTabCustomerID.Name = "cboBillsTabCustomerID"
        Me.cboBillsTabCustomerID.Size = New System.Drawing.Size(100, 21)
        Me.cboBillsTabCustomerID.TabIndex = 3
        Me.cboBillsTabCustomerID.TabStop = False
        '
        'cboBillsTabUtilityID
        '
        Me.cboBillsTabUtilityID.AllowDrop = True
        Me.cboBillsTabUtilityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBillsTabUtilityID.FormattingEnabled = True
        Me.cboBillsTabUtilityID.Location = New System.Drawing.Point(100, 122)
        Me.cboBillsTabUtilityID.MaxDropDownItems = 99
        Me.cboBillsTabUtilityID.Name = "cboBillsTabUtilityID"
        Me.cboBillsTabUtilityID.Size = New System.Drawing.Size(101, 21)
        Me.cboBillsTabUtilityID.TabIndex = 5
        Me.cboBillsTabUtilityID.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(206, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Customer Name:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(207, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Utility Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Customer ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Utility ID:"
        '
        'txtBillID
        '
        Me.txtBillID.Location = New System.Drawing.Point(100, 35)
        Me.txtBillID.Name = "txtBillID"
        Me.txtBillID.Size = New System.Drawing.Size(100, 20)
        Me.txtBillID.TabIndex = 0
        Me.tipForFrmMain.SetToolTip(Me.txtBillID, "Enter Billing ID")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "&Bill ID:"
        '
        'txtBillsAmountOwed
        '
        Me.txtBillsAmountOwed.Location = New System.Drawing.Point(100, 257)
        Me.txtBillsAmountOwed.Name = "txtBillsAmountOwed"
        Me.txtBillsAmountOwed.Size = New System.Drawing.Size(100, 20)
        Me.txtBillsAmountOwed.TabIndex = 2
        Me.tipForFrmMain.SetToolTip(Me.txtBillsAmountOwed, "Enter Amount Owed")
        '
        'txtUsage
        '
        Me.txtUsage.Location = New System.Drawing.Point(100, 214)
        Me.txtUsage.Name = "txtUsage"
        Me.txtUsage.Size = New System.Drawing.Size(100, 20)
        Me.txtUsage.TabIndex = 1
        Me.tipForFrmMain.SetToolTip(Me.txtUsage, "Enter Usage Amount")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 260)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "&Amount Owed:"
        '
        'dtpBillDate
        '
        Me.dtpBillDate.Location = New System.Drawing.Point(100, 172)
        Me.dtpBillDate.Name = "dtpBillDate"
        Me.dtpBillDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBillDate.TabIndex = 7
        Me.dtpBillDate.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.dtpBillDate, "Pick Date")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 217)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "U&sage:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "&Date:"
        '
        'tabPayments
        '
        Me.tabPayments.Controls.Add(Me.Label5)
        Me.tabPayments.Controls.Add(Me.GroupBox4)
        Me.tabPayments.Controls.Add(Me.GroupBox3)
        Me.tabPayments.Controls.Add(Me.btnPay)
        Me.tabPayments.Controls.Add(Me.grpPayments)
        Me.tabPayments.Location = New System.Drawing.Point(4, 22)
        Me.tabPayments.Name = "tabPayments"
        Me.tabPayments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPayments.Size = New System.Drawing.Size(570, 394)
        Me.tabPayments.TabIndex = 4
        Me.tabPayments.Text = "Payments"
        Me.tabPayments.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(406, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Note: Need To Make Customers, Utilities, And Bills Before Payments Can Be Created" & _
    ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstPaymentsTabPaymentAmount)
        Me.GroupBox4.Controls.Add(Me.txtPaymentsTabTotalPayments)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.lstBillsTabPaymentID)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtPaymentsTabAmountOwed)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Location = New System.Drawing.Point(218, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 200)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payment Details"
        Me.tipForFrmMain.SetToolTip(Me.GroupBox4, "The Bill's Payment Details")
        '
        'lstPaymentsTabPaymentAmount
        '
        Me.lstPaymentsTabPaymentAmount.FormattingEnabled = True
        Me.lstPaymentsTabPaymentAmount.Location = New System.Drawing.Point(186, 41)
        Me.lstPaymentsTabPaymentAmount.Name = "lstPaymentsTabPaymentAmount"
        Me.lstPaymentsTabPaymentAmount.ScrollAlwaysVisible = True
        Me.lstPaymentsTabPaymentAmount.Size = New System.Drawing.Size(100, 95)
        Me.lstPaymentsTabPaymentAmount.TabIndex = 3
        Me.lstPaymentsTabPaymentAmount.TabStop = False
        '
        'txtPaymentsTabTotalPayments
        '
        Me.txtPaymentsTabTotalPayments.Location = New System.Drawing.Point(131, 142)
        Me.txtPaymentsTabTotalPayments.Name = "txtPaymentsTabTotalPayments"
        Me.txtPaymentsTabTotalPayments.ReadOnly = True
        Me.txtPaymentsTabTotalPayments.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsTabTotalPayments.TabIndex = 12
        Me.txtPaymentsTabTotalPayments.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(44, 181)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(0, 13)
        Me.Label33.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(41, 150)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(83, 13)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "Total Payments:"
        '
        'lstBillsTabPaymentID
        '
        Me.lstBillsTabPaymentID.FormattingEnabled = True
        Me.lstBillsTabPaymentID.Location = New System.Drawing.Point(44, 41)
        Me.lstBillsTabPaymentID.Name = "lstBillsTabPaymentID"
        Me.lstBillsTabPaymentID.ScrollAlwaysVisible = True
        Me.lstBillsTabPaymentID.Size = New System.Drawing.Size(120, 95)
        Me.lstBillsTabPaymentID.TabIndex = 1
        Me.lstBillsTabPaymentID.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(169, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(90, 13)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Payment Amount:"
        '
        'txtPaymentsTabAmountOwed
        '
        Me.txtPaymentsTabAmountOwed.Location = New System.Drawing.Point(131, 172)
        Me.txtPaymentsTabAmountOwed.Name = "txtPaymentsTabAmountOwed"
        Me.txtPaymentsTabAmountOwed.ReadOnly = True
        Me.txtPaymentsTabAmountOwed.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsTabAmountOwed.TabIndex = 11
        Me.txtPaymentsTabAmountOwed.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.txtPaymentsTabAmountOwed, "Here's what you still owe.")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(48, 175)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Amount Owed:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(25, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(65, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Payment ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboPaymentsTabBillID)
        Me.GroupBox3.Controls.Add(Me.txtPaymentsTabUtilityName)
        Me.GroupBox3.Controls.Add(Me.txtPaymentsTabCustomerName)
        Me.GroupBox3.Controls.Add(Me.txtPaymentsTabBillDate)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(195, 206)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bill Details"
        Me.tipForFrmMain.SetToolTip(Me.GroupBox3, "Select A Bill")
        '
        'cboPaymentsTabBillID
        '
        Me.cboPaymentsTabBillID.AllowDrop = True
        Me.cboPaymentsTabBillID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentsTabBillID.FormattingEnabled = True
        Me.cboPaymentsTabBillID.Location = New System.Drawing.Point(66, 41)
        Me.cboPaymentsTabBillID.Name = "cboPaymentsTabBillID"
        Me.cboPaymentsTabBillID.Size = New System.Drawing.Size(121, 21)
        Me.cboPaymentsTabBillID.TabIndex = 1
        Me.cboPaymentsTabBillID.TabStop = False
        '
        'txtPaymentsTabUtilityName
        '
        Me.txtPaymentsTabUtilityName.Location = New System.Drawing.Point(87, 156)
        Me.txtPaymentsTabUtilityName.Name = "txtPaymentsTabUtilityName"
        Me.txtPaymentsTabUtilityName.ReadOnly = True
        Me.txtPaymentsTabUtilityName.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsTabUtilityName.TabIndex = 6
        Me.txtPaymentsTabUtilityName.TabStop = False
        '
        'txtPaymentsTabCustomerName
        '
        Me.txtPaymentsTabCustomerName.Location = New System.Drawing.Point(87, 122)
        Me.txtPaymentsTabCustomerName.Name = "txtPaymentsTabCustomerName"
        Me.txtPaymentsTabCustomerName.ReadOnly = True
        Me.txtPaymentsTabCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsTabCustomerName.TabIndex = 5
        Me.txtPaymentsTabCustomerName.TabStop = False
        '
        'txtPaymentsTabBillDate
        '
        Me.txtPaymentsTabBillDate.Location = New System.Drawing.Point(87, 86)
        Me.txtPaymentsTabBillDate.Name = "txtPaymentsTabBillDate"
        Me.txtPaymentsTabBillDate.ReadOnly = True
        Me.txtPaymentsTabBillDate.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsTabBillDate.TabIndex = 4
        Me.txtPaymentsTabBillDate.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(21, 156)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 13)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Utility Name:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(2, 122)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Customer Name:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(38, 89)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Bill Date:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(23, 44)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Bill ID:"
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(207, 355)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 1
        Me.btnPay.Text = "&Pay"
        Me.tipForFrmMain.SetToolTip(Me.btnPay, "Send Payment")
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'grpPayments
        '
        Me.grpPayments.Controls.Add(Me.txtCustomerPayment)
        Me.grpPayments.Controls.Add(Me.Label23)
        Me.grpPayments.Controls.Add(Me.dtpReceipts)
        Me.grpPayments.Controls.Add(Me.Label22)
        Me.grpPayments.Controls.Add(Me.txtReceiptID)
        Me.grpPayments.Controls.Add(Me.Label18)
        Me.grpPayments.Location = New System.Drawing.Point(76, 243)
        Me.grpPayments.Name = "grpPayments"
        Me.grpPayments.Size = New System.Drawing.Size(401, 103)
        Me.grpPayments.TabIndex = 0
        Me.grpPayments.TabStop = False
        Me.grpPayments.Text = "Make Payment"
        Me.tipForFrmMain.SetToolTip(Me.grpPayments, "Enter Payment Info")
        '
        'txtCustomerPayment
        '
        Me.txtCustomerPayment.Location = New System.Drawing.Point(102, 74)
        Me.txtCustomerPayment.Name = "txtCustomerPayment"
        Me.txtCustomerPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerPayment.TabIndex = 1
        Me.tipForFrmMain.SetToolTip(Me.txtCustomerPayment, "Enter Amound You Like To Pay")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "&Payment Amount:"
        '
        'dtpReceipts
        '
        Me.dtpReceipts.Location = New System.Drawing.Point(106, 45)
        Me.dtpReceipts.Name = "dtpReceipts"
        Me.dtpReceipts.Size = New System.Drawing.Size(200, 20)
        Me.dtpReceipts.TabIndex = 3
        Me.dtpReceipts.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.dtpReceipts, "Pick Date")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(60, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "&Date:"
        '
        'txtReceiptID
        '
        Me.txtReceiptID.Location = New System.Drawing.Point(106, 14)
        Me.txtReceiptID.Name = "txtReceiptID"
        Me.txtReceiptID.Size = New System.Drawing.Size(100, 20)
        Me.txtReceiptID.TabIndex = 0
        Me.tipForFrmMain.SetToolTip(Me.txtReceiptID, "Enter Receipt ID")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(32, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "&Receipt ID:"
        '
        'tabTransactions
        '
        Me.tabTransactions.Controls.Add(Me.grpFiles)
        Me.tabTransactions.Controls.Add(Me.grpTransactions)
        Me.tabTransactions.Location = New System.Drawing.Point(4, 22)
        Me.tabTransactions.Name = "tabTransactions"
        Me.tabTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransactions.Size = New System.Drawing.Size(570, 394)
        Me.tabTransactions.TabIndex = 5
        Me.tabTransactions.Text = "Transactions"
        Me.tabTransactions.UseVisualStyleBackColor = True
        '
        'grpFiles
        '
        Me.grpFiles.Controls.Add(Me.chkAppendFileToggle)
        Me.grpFiles.Controls.Add(Me.btnExport)
        Me.grpFiles.Controls.Add(Me.btnImport)
        Me.grpFiles.Location = New System.Drawing.Point(49, 275)
        Me.grpFiles.Name = "grpFiles"
        Me.grpFiles.Size = New System.Drawing.Size(382, 113)
        Me.grpFiles.TabIndex = 1
        Me.grpFiles.TabStop = False
        Me.grpFiles.Text = "File Handling"
        Me.tipForFrmMain.SetToolTip(Me.grpFiles, "File Importer and Exporter")
        '
        'chkAppendFileToggle
        '
        Me.chkAppendFileToggle.AutoSize = True
        Me.chkAppendFileToggle.Location = New System.Drawing.Point(126, 78)
        Me.chkAppendFileToggle.Name = "chkAppendFileToggle"
        Me.chkAppendFileToggle.Size = New System.Drawing.Size(166, 17)
        Me.chkAppendFileToggle.TabIndex = 2
        Me.chkAppendFileToggle.TabStop = False
        Me.chkAppendFileToggle.Text = "Append To File When Writing"
        Me.tipForFrmMain.SetToolTip(Me.chkAppendFileToggle, "Check if you want to not delete, but add to end of file.")
        Me.chkAppendFileToggle.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(218, 38)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "&Export"
        Me.tipForFrmMain.SetToolTip(Me.btnExport, "Export File")
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(71, 38)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "&Import"
        Me.tipForFrmMain.SetToolTip(Me.btnImport, "Import File")
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'grpTransactions
        '
        Me.grpTransactions.Controls.Add(Me.txtNumTransactions)
        Me.grpTransactions.Controls.Add(Me.Label6)
        Me.grpTransactions.Controls.Add(Me.lstTransactions)
        Me.grpTransactions.Location = New System.Drawing.Point(49, 21)
        Me.grpTransactions.Name = "grpTransactions"
        Me.grpTransactions.Size = New System.Drawing.Size(382, 236)
        Me.grpTransactions.TabIndex = 0
        Me.grpTransactions.TabStop = False
        Me.grpTransactions.Text = "Transactions"
        Me.tipForFrmMain.SetToolTip(Me.grpTransactions, "Transaction List")
        '
        'txtNumTransactions
        '
        Me.txtNumTransactions.Location = New System.Drawing.Point(328, 209)
        Me.txtNumTransactions.Name = "txtNumTransactions"
        Me.txtNumTransactions.ReadOnly = True
        Me.txtNumTransactions.Size = New System.Drawing.Size(29, 20)
        Me.txtNumTransactions.TabIndex = 2
        Me.txtNumTransactions.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "No. Of Transactions:"
        '
        'lstTransactions
        '
        Me.lstTransactions.FormattingEnabled = True
        Me.lstTransactions.HorizontalScrollbar = True
        Me.lstTransactions.Location = New System.Drawing.Point(24, 32)
        Me.lstTransactions.Name = "lstTransactions"
        Me.lstTransactions.Size = New System.Drawing.Size(333, 173)
        Me.lstTransactions.TabIndex = 0
        Me.lstTransactions.TabStop = False
        Me.tipForFrmMain.SetToolTip(Me.lstTransactions, "List of All Transactions")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(252, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.tipForFrmMain.SetToolTip(Me.btnExit, "Close Form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTestData
        '
        Me.btnTestData.Location = New System.Drawing.Point(41, 451)
        Me.btnTestData.Name = "btnTestData"
        Me.btnTestData.Size = New System.Drawing.Size(75, 23)
        Me.btnTestData.TabIndex = 3
        Me.btnTestData.Text = "Test Data"
        Me.btnTestData.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(689, 484)
        Me.Controls.Add(Me.btnTestData)
        Me.Controls.Add(Me.tbcMain)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "FrmMain"
        Me.Text = "Gimmie My Money Utilities"
        Me.tbcMain.ResumeLayout(False)
        Me.tabSummary.ResumeLayout(False)
        Me.tabSummary.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabCustomer.ResumeLayout(False)
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.tabUtility.ResumeLayout(False)
        Me.grpUtility.ResumeLayout(False)
        Me.grpUtility.PerformLayout()
        Me.tabBills.ResumeLayout(False)
        Me.tabBills.PerformLayout()
        Me.grpBill.ResumeLayout(False)
        Me.grpBill.PerformLayout()
        Me.tabPayments.ResumeLayout(False)
        Me.tabPayments.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpPayments.ResumeLayout(False)
        Me.grpPayments.PerformLayout()
        Me.tabTransactions.ResumeLayout(False)
        Me.grpFiles.ResumeLayout(False)
        Me.grpFiles.PerformLayout()
        Me.grpTransactions.ResumeLayout(False)
        Me.grpTransactions.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcMain As System.Windows.Forms.TabControl
    Friend WithEvents tabSummary As System.Windows.Forms.TabPage
    Friend WithEvents tabCustomer As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tabUtility As System.Windows.Forms.TabPage
    Friend WithEvents tabBills As System.Windows.Forms.TabPage
    Friend WithEvents tabPayments As System.Windows.Forms.TabPage
    Friend WithEvents tabTransactions As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtNewCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents grpCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents grpUtility As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUtilityName As System.Windows.Forms.TextBox
    Friend WithEvents txtNewUtilityID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAddUtility As System.Windows.Forms.Button
    Friend WithEvents btnGenerateBill As System.Windows.Forms.Button
    Friend WithEvents grpBill As System.Windows.Forms.GroupBox
    Friend WithEvents txtBillsAmountOwed As System.Windows.Forms.TextBox
    Friend WithEvents txtUsage As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpBillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtBillID As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents grpPayments As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentsTabAmountOwed As System.Windows.Forms.TextBox
    Friend WithEvents dtpReceipts As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptID As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents grpFiles As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents grpTransactions As System.Windows.Forms.GroupBox
    Friend WithEvents lstTransactions As System.Windows.Forms.ListBox
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstUtility As System.Windows.Forms.ListBox
    Friend WithEvents lstBills As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstCustomer As System.Windows.Forms.ListBox
    Friend WithEvents lstPayments As System.Windows.Forms.ListBox
    Friend WithEvents lstMisc As System.Windows.Forms.ListBox
    Friend WithEvents tipForFrmMain As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtUnitOfMeasure As System.Windows.Forms.TextBox
    Friend WithEvents txtUtilityType As System.Windows.Forms.TextBox
    Friend WithEvents btnTestData As System.Windows.Forms.Button
    Friend WithEvents txtBillsTabCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtBillsTabUtilityName As System.Windows.Forms.TextBox
    Friend WithEvents cboBillsTabCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents cboBillsTabUtilityID As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lstBillsTabPaymentID As System.Windows.Forms.ListBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboPaymentsTabBillID As System.Windows.Forms.ComboBox
    Friend WithEvents txtPaymentsTabUtilityName As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentsTabCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentsTabBillDate As System.Windows.Forms.TextBox
    Friend WithEvents lstPaymentsTabPaymentAmount As System.Windows.Forms.ListBox
    Friend WithEvents txtPaymentsTabTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents chkAppendFileToggle As System.Windows.Forms.CheckBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtBillCount As System.Windows.Forms.TextBox
    Friend WithEvents txtUtilityCount As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentCount As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerCount As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumTransactions As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
