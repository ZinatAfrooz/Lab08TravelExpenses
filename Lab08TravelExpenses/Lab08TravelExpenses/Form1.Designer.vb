<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblDaysOnTrip = New System.Windows.Forms.Label()
        Me.lblAirfareAmount = New System.Windows.Forms.Label()
        Me.lblMealExpenses = New System.Windows.Forms.Label()
        Me.lblCarRental = New System.Windows.Forms.Label()
        Me.lblMilesDriven = New System.Windows.Forms.Label()
        Me.txtDaysOnTrip = New System.Windows.Forms.TextBox()
        Me.txtAmountAirfare = New System.Windows.Forms.TextBox()
        Me.txtMealExpenses = New System.Windows.Forms.TextBox()
        Me.txtCarRental = New System.Windows.Forms.TextBox()
        Me.txtMilesDriven = New System.Windows.Forms.TextBox()
        Me.lblParkingFee = New System.Windows.Forms.Label()
        Me.lblTaxiFee = New System.Windows.Forms.Label()
        Me.lblRegisFee = New System.Windows.Forms.Label()
        Me.lblLodgingCharge = New System.Windows.Forms.Label()
        Me.txtParkingFees = New System.Windows.Forms.TextBox()
        Me.txtTaxiFees = New System.Windows.Forms.TextBox()
        Me.txtRegisFees = New System.Windows.Forms.TextBox()
        Me.txtLodgingCharge = New System.Windows.Forms.TextBox()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.lblAllowExpenses = New System.Windows.Forms.Label()
        Me.lblAmountResponsible = New System.Windows.Forms.Label()
        Me.lblAmountSaved = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotExpenseValue = New System.Windows.Forms.Label()
        Me.lblTotalAllowExpenValue = New System.Windows.Forms.Label()
        Me.lblAmtResponsibleValue = New System.Windows.Forms.Label()
        Me.lblAmuntSavedValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(199, 33)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(226, 20)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Travel Expenses Calculator"
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(4, 81)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(178, 13)
        Me.lblInformation.TabIndex = 1
        Me.lblInformation.Text = "Enter Information (if available)"
        '
        'lblDaysOnTrip
        '
        Me.lblDaysOnTrip.AutoSize = True
        Me.lblDaysOnTrip.Location = New System.Drawing.Point(7, 116)
        Me.lblDaysOnTrip.Name = "lblDaysOnTrip"
        Me.lblDaysOnTrip.Size = New System.Drawing.Size(99, 13)
        Me.lblDaysOnTrip.TabIndex = 2
        Me.lblDaysOnTrip.Text = "No. of Days on Trip"
        '
        'lblAirfareAmount
        '
        Me.lblAirfareAmount.AutoSize = True
        Me.lblAirfareAmount.Location = New System.Drawing.Point(7, 146)
        Me.lblAirfareAmount.Name = "lblAirfareAmount"
        Me.lblAirfareAmount.Size = New System.Drawing.Size(88, 13)
        Me.lblAirfareAmount.TabIndex = 3
        Me.lblAirfareAmount.Text = "Amount of Airfare"
        '
        'lblMealExpenses
        '
        Me.lblMealExpenses.AutoSize = True
        Me.lblMealExpenses.Location = New System.Drawing.Point(7, 173)
        Me.lblMealExpenses.Name = "lblMealExpenses"
        Me.lblMealExpenses.Size = New System.Drawing.Size(79, 13)
        Me.lblMealExpenses.TabIndex = 4
        Me.lblMealExpenses.Text = "Meal Expenses"
        '
        'lblCarRental
        '
        Me.lblCarRental.AutoSize = True
        Me.lblCarRental.Location = New System.Drawing.Point(7, 204)
        Me.lblCarRental.Name = "lblCarRental"
        Me.lblCarRental.Size = New System.Drawing.Size(83, 13)
        Me.lblCarRental.TabIndex = 5
        Me.lblCarRental.Text = "Car Rental Fees"
        '
        'lblMilesDriven
        '
        Me.lblMilesDriven.AutoSize = True
        Me.lblMilesDriven.Location = New System.Drawing.Point(4, 235)
        Me.lblMilesDriven.Name = "lblMilesDriven"
        Me.lblMilesDriven.Size = New System.Drawing.Size(117, 13)
        Me.lblMilesDriven.TabIndex = 6
        Me.lblMilesDriven.Text = "Number of Miles Driven"
        '
        'txtDaysOnTrip
        '
        Me.txtDaysOnTrip.Location = New System.Drawing.Point(156, 116)
        Me.txtDaysOnTrip.Name = "txtDaysOnTrip"
        Me.txtDaysOnTrip.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysOnTrip.TabIndex = 7
        '
        'txtAmountAirfare
        '
        Me.txtAmountAirfare.Location = New System.Drawing.Point(156, 146)
        Me.txtAmountAirfare.Name = "txtAmountAirfare"
        Me.txtAmountAirfare.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountAirfare.TabIndex = 8
        '
        'txtMealExpenses
        '
        Me.txtMealExpenses.Location = New System.Drawing.Point(156, 173)
        Me.txtMealExpenses.Name = "txtMealExpenses"
        Me.txtMealExpenses.Size = New System.Drawing.Size(100, 20)
        Me.txtMealExpenses.TabIndex = 9
        '
        'txtCarRental
        '
        Me.txtCarRental.Location = New System.Drawing.Point(156, 204)
        Me.txtCarRental.Name = "txtCarRental"
        Me.txtCarRental.Size = New System.Drawing.Size(100, 20)
        Me.txtCarRental.TabIndex = 10
        '
        'txtMilesDriven
        '
        Me.txtMilesDriven.Location = New System.Drawing.Point(156, 235)
        Me.txtMilesDriven.Name = "txtMilesDriven"
        Me.txtMilesDriven.Size = New System.Drawing.Size(100, 20)
        Me.txtMilesDriven.TabIndex = 11
        '
        'lblParkingFee
        '
        Me.lblParkingFee.AutoSize = True
        Me.lblParkingFee.Location = New System.Drawing.Point(302, 116)
        Me.lblParkingFee.Name = "lblParkingFee"
        Me.lblParkingFee.Size = New System.Drawing.Size(69, 13)
        Me.lblParkingFee.TabIndex = 12
        Me.lblParkingFee.Text = "Parking Fees"
        '
        'lblTaxiFee
        '
        Me.lblTaxiFee.AutoSize = True
        Me.lblTaxiFee.Location = New System.Drawing.Point(302, 146)
        Me.lblTaxiFee.Name = "lblTaxiFee"
        Me.lblTaxiFee.Size = New System.Drawing.Size(53, 13)
        Me.lblTaxiFee.TabIndex = 13
        Me.lblTaxiFee.Text = "Taxi Fees"
        '
        'lblRegisFee
        '
        Me.lblRegisFee.AutoSize = True
        Me.lblRegisFee.Location = New System.Drawing.Point(302, 173)
        Me.lblRegisFee.Name = "lblRegisFee"
        Me.lblRegisFee.Size = New System.Drawing.Size(89, 13)
        Me.lblRegisFee.TabIndex = 14
        Me.lblRegisFee.Text = "Registration Fees"
        '
        'lblLodgingCharge
        '
        Me.lblLodgingCharge.AutoSize = True
        Me.lblLodgingCharge.Location = New System.Drawing.Point(302, 204)
        Me.lblLodgingCharge.Name = "lblLodgingCharge"
        Me.lblLodgingCharge.Size = New System.Drawing.Size(82, 13)
        Me.lblLodgingCharge.TabIndex = 15
        Me.lblLodgingCharge.Text = "Lodging Charge"
        '
        'txtParkingFees
        '
        Me.txtParkingFees.Location = New System.Drawing.Point(410, 116)
        Me.txtParkingFees.Name = "txtParkingFees"
        Me.txtParkingFees.Size = New System.Drawing.Size(100, 20)
        Me.txtParkingFees.TabIndex = 16
        '
        'txtTaxiFees
        '
        Me.txtTaxiFees.Location = New System.Drawing.Point(410, 146)
        Me.txtTaxiFees.Name = "txtTaxiFees"
        Me.txtTaxiFees.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxiFees.TabIndex = 17
        '
        'txtRegisFees
        '
        Me.txtRegisFees.Location = New System.Drawing.Point(410, 173)
        Me.txtRegisFees.Name = "txtRegisFees"
        Me.txtRegisFees.Size = New System.Drawing.Size(100, 20)
        Me.txtRegisFees.TabIndex = 18
        '
        'txtLodgingCharge
        '
        Me.txtLodgingCharge.Location = New System.Drawing.Point(410, 204)
        Me.txtLodgingCharge.Name = "txtLodgingCharge"
        Me.txtLodgingCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtLodgingCharge.TabIndex = 19
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(13, 284)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(57, 13)
        Me.lblSummary.TabIndex = 20
        Me.lblSummary.Text = "Summary"
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.Location = New System.Drawing.Point(16, 318)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(80, 13)
        Me.lblTotalExpenses.TabIndex = 21
        Me.lblTotalExpenses.Text = "Total Expenses"
        '
        'lblAllowExpenses
        '
        Me.lblAllowExpenses.AutoSize = True
        Me.lblAllowExpenses.Location = New System.Drawing.Point(16, 347)
        Me.lblAllowExpenses.Name = "lblAllowExpenses"
        Me.lblAllowExpenses.Size = New System.Drawing.Size(128, 13)
        Me.lblAllowExpenses.TabIndex = 22
        Me.lblAllowExpenses.Text = "Total Allowable Expenses"
        '
        'lblAmountResponsible
        '
        Me.lblAmountResponsible.AutoSize = True
        Me.lblAmountResponsible.Location = New System.Drawing.Point(16, 375)
        Me.lblAmountResponsible.Name = "lblAmountResponsible"
        Me.lblAmountResponsible.Size = New System.Drawing.Size(199, 13)
        Me.lblAmountResponsible.TabIndex = 23
        Me.lblAmountResponsible.Text = "Amount Responsible by Business Person"
        '
        'lblAmountSaved
        '
        Me.lblAmountSaved.AutoSize = True
        Me.lblAmountSaved.Location = New System.Drawing.Point(16, 397)
        Me.lblAmountSaved.Name = "lblAmountSaved"
        Me.lblAmountSaved.Size = New System.Drawing.Size(172, 13)
        Me.lblAmountSaved.TabIndex = 24
        Me.lblAmountSaved.Text = "Amount Saved by Business Person"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(112, 430)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(235, 430)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 26
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(370, 430)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotExpenseValue
        '
        Me.lblTotExpenseValue.AutoSize = True
        Me.lblTotExpenseValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotExpenseValue.Location = New System.Drawing.Point(250, 317)
        Me.lblTotExpenseValue.Name = "lblTotExpenseValue"
        Me.lblTotExpenseValue.Padding = New System.Windows.Forms.Padding(0, 0, 75, 0)
        Me.lblTotExpenseValue.Size = New System.Drawing.Size(77, 15)
        Me.lblTotExpenseValue.TabIndex = 28
        '
        'lblTotalAllowExpenValue
        '
        Me.lblTotalAllowExpenValue.AutoSize = True
        Me.lblTotalAllowExpenValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAllowExpenValue.Location = New System.Drawing.Point(250, 345)
        Me.lblTotalAllowExpenValue.Name = "lblTotalAllowExpenValue"
        Me.lblTotalAllowExpenValue.Padding = New System.Windows.Forms.Padding(0, 0, 75, 0)
        Me.lblTotalAllowExpenValue.Size = New System.Drawing.Size(77, 15)
        Me.lblTotalAllowExpenValue.TabIndex = 29
        '
        'lblAmtResponsibleValue
        '
        Me.lblAmtResponsibleValue.AutoSize = True
        Me.lblAmtResponsibleValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmtResponsibleValue.Location = New System.Drawing.Point(250, 373)
        Me.lblAmtResponsibleValue.Name = "lblAmtResponsibleValue"
        Me.lblAmtResponsibleValue.Padding = New System.Windows.Forms.Padding(0, 0, 75, 0)
        Me.lblAmtResponsibleValue.Size = New System.Drawing.Size(77, 15)
        Me.lblAmtResponsibleValue.TabIndex = 30
        '
        'lblAmuntSavedValue
        '
        Me.lblAmuntSavedValue.AutoSize = True
        Me.lblAmuntSavedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmuntSavedValue.Location = New System.Drawing.Point(250, 395)
        Me.lblAmuntSavedValue.Name = "lblAmuntSavedValue"
        Me.lblAmuntSavedValue.Padding = New System.Windows.Forms.Padding(0, 0, 75, 0)
        Me.lblAmuntSavedValue.Size = New System.Drawing.Size(77, 15)
        Me.lblAmuntSavedValue.TabIndex = 31
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 474)
        Me.Controls.Add(Me.lblAmuntSavedValue)
        Me.Controls.Add(Me.lblAmtResponsibleValue)
        Me.Controls.Add(Me.lblTotalAllowExpenValue)
        Me.Controls.Add(Me.lblTotExpenseValue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblAmountSaved)
        Me.Controls.Add(Me.lblAmountResponsible)
        Me.Controls.Add(Me.lblAllowExpenses)
        Me.Controls.Add(Me.lblTotalExpenses)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.txtLodgingCharge)
        Me.Controls.Add(Me.txtRegisFees)
        Me.Controls.Add(Me.txtTaxiFees)
        Me.Controls.Add(Me.txtParkingFees)
        Me.Controls.Add(Me.lblLodgingCharge)
        Me.Controls.Add(Me.lblRegisFee)
        Me.Controls.Add(Me.lblTaxiFee)
        Me.Controls.Add(Me.lblParkingFee)
        Me.Controls.Add(Me.txtMilesDriven)
        Me.Controls.Add(Me.txtCarRental)
        Me.Controls.Add(Me.txtMealExpenses)
        Me.Controls.Add(Me.txtAmountAirfare)
        Me.Controls.Add(Me.txtDaysOnTrip)
        Me.Controls.Add(Me.lblMilesDriven)
        Me.Controls.Add(Me.lblCarRental)
        Me.Controls.Add(Me.lblMealExpenses)
        Me.Controls.Add(Me.lblAirfareAmount)
        Me.Controls.Add(Me.lblDaysOnTrip)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Travel Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblInformation As Label
    Friend WithEvents lblDaysOnTrip As Label
    Friend WithEvents lblAirfareAmount As Label
    Friend WithEvents lblMealExpenses As Label
    Friend WithEvents lblCarRental As Label
    Friend WithEvents lblMilesDriven As Label
    Friend WithEvents txtDaysOnTrip As TextBox
    Friend WithEvents txtAmountAirfare As TextBox
    Friend WithEvents txtMealExpenses As TextBox
    Friend WithEvents txtCarRental As TextBox
    Friend WithEvents txtMilesDriven As TextBox
    Friend WithEvents lblParkingFee As Label
    Friend WithEvents lblTaxiFee As Label
    Friend WithEvents lblRegisFee As Label
    Friend WithEvents lblLodgingCharge As Label
    Friend WithEvents txtParkingFees As TextBox
    Friend WithEvents txtTaxiFees As TextBox
    Friend WithEvents txtRegisFees As TextBox
    Friend WithEvents txtLodgingCharge As TextBox
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents lblAllowExpenses As Label
    Friend WithEvents lblAmountResponsible As Label
    Friend WithEvents lblAmountSaved As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotExpenseValue As Label
    Friend WithEvents lblTotalAllowExpenValue As Label
    Friend WithEvents lblAmtResponsibleValue As Label
    Friend WithEvents lblAmuntSavedValue As Label
End Class
