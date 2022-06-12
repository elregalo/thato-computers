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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rtxtbReceipt = New System.Windows.Forms.RichTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.bntCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbRam = New System.Windows.Forms.ComboBox()
        Me.cmbHdd = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbComputerType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkGraphicCard = New System.Windows.Forms.CheckBox()
        Me.chkSpeaker = New System.Windows.Forms.CheckBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.chkMonitor = New System.Windows.Forms.CheckBox()
        Me.chkMouse = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.SplitContainer1.Panel1.Controls.Add(Me.rtxtbReceipt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bntCalculate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblHeading)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 490)
        Me.SplitContainer1.SplitterDistance = 287
        Me.SplitContainer1.TabIndex = 0
        '
        'rtxtbReceipt
        '
        Me.rtxtbReceipt.Location = New System.Drawing.Point(3, 117)
        Me.rtxtbReceipt.Name = "rtxtbReceipt"
        Me.rtxtbReceipt.ReadOnly = True
        Me.rtxtbReceipt.Size = New System.Drawing.Size(281, 321)
        Me.rtxtbReceipt.TabIndex = 0
        Me.rtxtbReceipt.Text = "Computer Quotation" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Fullnames: " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Computer Type:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "RAM: " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "HDD: " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Mouse: " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Monitor: " & _
    "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Keyboard: " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Speaker:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Graphic Card:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "VAT:" & Global.Microsoft.VisualBasic.ChrW(10) & "PPRICE: "
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 455)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'bntCalculate
        '
        Me.bntCalculate.Location = New System.Drawing.Point(112, 455)
        Me.bntCalculate.Name = "bntCalculate"
        Me.bntCalculate.Size = New System.Drawing.Size(75, 23)
        Me.bntCalculate.TabIndex = 1
        Me.bntCalculate.Text = "Calculate"
        Me.bntCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 455)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.Thato_Computers.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(25, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 102)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbRam)
        Me.GroupBox2.Controls.Add(Me.cmbHdd)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Location = New System.Drawing.Point(3, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 151)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Specifications"
        '
        'cmbRam
        '
        Me.cmbRam.FormattingEnabled = True
        Me.cmbRam.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbRam.Location = New System.Drawing.Point(126, 90)
        Me.cmbRam.Name = "cmbRam"
        Me.cmbRam.Size = New System.Drawing.Size(189, 35)
        Me.cmbRam.TabIndex = 7
        '
        'cmbHdd
        '
        Me.cmbHdd.FormattingEnabled = True
        Me.cmbHdd.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbHdd.Location = New System.Drawing.Point(126, 41)
        Me.cmbHdd.Name = "cmbHdd"
        Me.cmbHdd.Size = New System.Drawing.Size(189, 35)
        Me.cmbHdd.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ram:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hard Drive:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbComputerType)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox3.Location = New System.Drawing.Point(429, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Computer Type"
        '
        'cmbComputerType
        '
        Me.cmbComputerType.FormattingEnabled = True
        Me.cmbComputerType.Items.AddRange(New Object() {"Standard", "Upgradeable", "Peripherals"})
        Me.cmbComputerType.Location = New System.Drawing.Point(107, 42)
        Me.cmbComputerType.Name = "cmbComputerType"
        Me.cmbComputerType.Size = New System.Drawing.Size(183, 35)
        Me.cmbComputerType.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Computer"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkGraphicCard)
        Me.GroupBox4.Controls.Add(Me.chkSpeaker)
        Me.GroupBox4.Controls.Add(Me.chkKeyboard)
        Me.GroupBox4.Controls.Add(Me.chkMonitor)
        Me.GroupBox4.Controls.Add(Me.chkMouse)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox4.Location = New System.Drawing.Point(429, 287)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 151)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Peripherals"
        '
        'chkGraphicCard
        '
        Me.chkGraphicCard.AutoSize = True
        Me.chkGraphicCard.Location = New System.Drawing.Point(90, 113)
        Me.chkGraphicCard.Name = "chkGraphicCard"
        Me.chkGraphicCard.Size = New System.Drawing.Size(116, 31)
        Me.chkGraphicCard.TabIndex = 4
        Me.chkGraphicCard.Text = "Graphic Card"
        Me.chkGraphicCard.UseVisualStyleBackColor = True
        '
        'chkSpeaker
        '
        Me.chkSpeaker.AutoSize = True
        Me.chkSpeaker.Location = New System.Drawing.Point(186, 76)
        Me.chkSpeaker.Name = "chkSpeaker"
        Me.chkSpeaker.Size = New System.Drawing.Size(82, 31)
        Me.chkSpeaker.TabIndex = 3
        Me.chkSpeaker.Text = "Speaker"
        Me.chkSpeaker.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Location = New System.Drawing.Point(6, 76)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(94, 31)
        Me.chkKeyboard.TabIndex = 2
        Me.chkKeyboard.Text = "Keyboard"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'chkMonitor
        '
        Me.chkMonitor.AutoSize = True
        Me.chkMonitor.Location = New System.Drawing.Point(186, 37)
        Me.chkMonitor.Name = "chkMonitor"
        Me.chkMonitor.Size = New System.Drawing.Size(85, 31)
        Me.chkMonitor.TabIndex = 1
        Me.chkMonitor.Text = "Monitor"
        Me.chkMonitor.UseVisualStyleBackColor = True
        '
        'chkMouse
        '
        Me.chkMouse.AutoSize = True
        Me.chkMouse.Location = New System.Drawing.Point(6, 43)
        Me.chkMouse.Name = "chkMouse"
        Me.chkMouse.Size = New System.Drawing.Size(74, 31)
        Me.chkMouse.TabIndex = 0
        Me.chkMouse.Text = "Mouse"
        Me.chkMouse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Location = New System.Drawing.Point(3, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 121)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(126, 85)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(189, 30)
        Me.txtSurname.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(126, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 30)
        Me.txtName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Surname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Uighur", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblHeading.Location = New System.Drawing.Point(303, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(158, 34)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Thato Computers"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(737, 490)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.DarkCyan
        Me.LineShape5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape5.BorderWidth = 2
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 0
        Me.LineShape5.X2 = 741
        Me.LineShape5.Y1 = 457
        Me.LineShape5.Y2 = 460
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.DarkCyan
        Me.LineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.LineShape4.BorderWidth = 30
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = -1
        Me.LineShape4.X2 = 741
        Me.LineShape4.Y1 = 474
        Me.LineShape4.Y2 = 474
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.DarkCyan
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 742
        Me.LineShape3.Y1 = 71
        Me.LineShape3.Y2 = 71
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkCyan
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 1
        Me.LineShape2.X2 = 743
        Me.LineShape2.Y1 = 51
        Me.LineShape2.Y2 = 49
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DarkCyan
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 739
        Me.LineShape1.Y1 = 29
        Me.LineShape1.Y2 = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 490)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Thato Computers"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents rtxtbReceipt As System.Windows.Forms.RichTextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents bntCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbRam As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHdd As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbComputerType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGraphicCard As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpeaker As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeyboard As System.Windows.Forms.CheckBox
    Friend WithEvents chkMonitor As System.Windows.Forms.CheckBox
    Friend WithEvents chkMouse As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape

    REM: method to calculate price after markup added
    Function CalculateMarkUp(ByVal decCostPrice As Decimal) As Decimal

        Return decCostPrice * (40 / 100) + decCostPrice
    End Function

    REM: method to calculate VAT
    Function CalculateVat(ByVal decConstPrice As Decimal) As Decimal
        Return decConstPrice * (15 / 100)
    End Function

    REM: method calculate product price
    Function CalculateRetailPrice(ByVal decCostPrice As Decimal, ByVal intProductQuality As Integer) As Decimal
        REM: 
        Return decCostPrice * intProductQuality
    End Function

    REM: method make all calculations for quaoting
    Private Sub bntCalculate_Click(sender As Object, e As EventArgs) Handles bntCalculate.Click
        REM: product prices
        Dim decHddPrice As Decimal = CalculateMarkUp(900)
        Dim decRamPrice As Decimal = CalculateMarkUp(800)
        Dim decKeyboardPrice As Decimal = CalculateMarkUp(450)
        Dim decGraphicCardPrice As Decimal = CalculateMarkUp(1200)
        Dim decMonitorPrice As Decimal = CalculateMarkUp(1500)
        Dim decMousePrice As Decimal = CalculateMarkUp(350)
        Dim decSpeakerPrice As Decimal = CalculateMarkUp(230)

        REM: product quantity
        Dim intHddQuantity, intRamQuantity, intGraphicCardQuantity, intKeyboardQuantity, intMouseQuantity, intMonitorQuantity, intSpeakerQuantity As Integer
        REM: 
        Dim decHddCost, decRamCost, decKeyboardCost, decGraphicCardCost, decMonitorCost, decMouseCost, decSpeakerCost, decTotalCost As Decimal

        REM: get customer details
        Dim strFullnames As String = txtName.Text + " " + txtSurname.Text

        REM :check computer type
        If cmbComputerType.Text = "Standard" Then
            REM :
            intHddQuantity = 1
            intRamQuantity = 1
            REM calc computer costs 1hdd 1 ram
            decHddCost = CalculateRetailPrice(decHddPrice, intHddQuantity)
            decRamCost = CalculateRetailPrice(decRamPrice, intRamQuantity)
            decTotalCost = decHddCost + decRamCost
            rtxtbReceipt.Text = String.Format(
                           "Computer Quotation" & vbNewLine & vbNewLine &
                           "Fullnames: {0}" & vbNewLine & vbNewLine &
                           "Computer Type : {1}" & vbNewLine & vbNewLine &
                           "RAM: R{2} x{3}" & vbNewLine & vbNewLine &
                           "HDD: R{4} x{5}" & vbNewLine & vbNewLine &
                           "Mouse: R{6} x{7}" & vbNewLine & vbNewLine &
                           "Monitor: R{8} x{9}" & vbNewLine & vbNewLine &
                           "Keyboard: R{10} x{11}" & vbNewLine & vbNewLine &
                           "Speaker: R{12} x{13}" & vbNewLine & vbNewLine &
                           "Graphic Card: R{14} x{15}" & vbNewLine & vbNewLine &
                           "VAT: R{16}" & vbNewLine & "PRICE: R{17}",
                           strFullnames, cmbComputerType.Text,
                           decRamCost, intRamQuantity, decHddCost, intHddQuantity,
                           0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, decTotalCost)

        ElseIf cmbComputerType.Text = "Upgradeable" Then
            REM :
            intHddQuantity = CInt(cmbHdd.Text)
            intRamQuantity = CInt(cmbRam.Text)
            If chkGraphicCard.Checked = True Then
                intGraphicCardQuantity = 1
            End If
            If chkKeyboard.Checked = True Then
                intKeyboardQuantity = 1
            End If
            If chkMonitor.Checked = True Then
                intMonitorQuantity = 1
            End If
            If chkMouse.Checked = True Then
                intMouseQuantity = 1
            End If
            If chkSpeaker.Checked = True Then
                intSpeakerQuantity = 1
            End If

            REM: calc items cost after adding quantity
            decHddCost = CalculateRetailPrice(decHddPrice, intHddQuantity)
            decRamCost = CalculateRetailPrice(decRamPrice, intRamQuantity)
            decGraphicCardCost = CalculateRetailPrice(decGraphicCardPrice, intGraphicCardQuantity)
            decKeyboardCost = CalculateRetailPrice(decKeyboardPrice, intKeyboardQuantity)
            decMonitorCost = CalculateRetailPrice(decMonitorPrice, intMonitorQuantity)
            decSpeakerCost = CalculateRetailPrice(decSpeakerPrice, intSpeakerQuantity)
            decMouseCost = CalculateRetailPrice(decMousePrice, intMouseQuantity)

            rtxtbReceipt.Text = String.Format(
               "Computer Quotation" & vbNewLine & vbNewLine &
               "Fullnames: {0}" & vbNewLine & vbNewLine &
               "Computer Type : {1}" & vbNewLine & vbNewLine &
               "RAM: R{2} x{3}" & vbNewLine & vbNewLine &
               "HDD: R{4} x{5}" & vbNewLine & vbNewLine &
               "Mouse: R{6} x{7}" & vbNewLine & vbNewLine &
               "Monitor: R{8} x{9}" & vbNewLine & vbNewLine &
               "Keyboard: R{10} x{11}" & vbNewLine & vbNewLine &
               "Speaker: R{12} x{13}" & vbNewLine & vbNewLine &
               "Graphic Card: R{14} x{15}" & vbNewLine & vbNewLine &
               "VAT: R{16}" & vbNewLine & "PRICE: R{17}",
               strFullnames, cmbComputerType.Text,
               decRamCost, intRamQuantity, decHddCost, intHddQuantity,
               decMouseCost, intMouseQuantity, decMonitorCost, intMonitorQuantity,
               decKeyboardCost, intKeyboardQuantity,
               decSpeakerCost, intSpeakerQuantity,
               decGraphicCardCost, intGraphicCardQuantity,
               0, decHddCost + decRamCost)
        ElseIf cmbComputerType.Text = "Peripherals" Then
            REM : check if check boxes are clicked
            If chkGraphicCard.Checked = True Then
                intGraphicCardQuantity = 1
            End If
            If chkKeyboard.Checked = True Then
                intKeyboardQuantity = 1
            End If
            If chkMonitor.Checked = True Then
                intMonitorQuantity = 1
            End If
            If chkMouse.Checked = True Then
                intMouseQuantity = 1
            End If
            If chkSpeaker.Checked = True Then
                intSpeakerQuantity = 1
            End If
            REM: calc items cost after adding quantity
            decGraphicCardCost = CalculateRetailPrice(decGraphicCardPrice, intGraphicCardQuantity)
            decKeyboardCost = CalculateRetailPrice(decKeyboardPrice, intKeyboardQuantity)
            decMonitorCost = CalculateRetailPrice(decMonitorPrice, intMonitorQuantity)
            decSpeakerCost = CalculateRetailPrice(decSpeakerPrice, intSpeakerQuantity)
            decMouseCost = CalculateRetailPrice(decMousePrice, intMouseQuantity)

            decTotalCost = decGraphicCardCost + decKeyboardCost + decMonitorCost + decSpeakerCost + decMouseCost

            rtxtbReceipt.Text = String.Format(
               "Computer Quotation" & vbNewLine & vbNewLine &
               "Fullnames: {0}" & vbNewLine & vbNewLine &
               "Computer Type : {1}" & vbNewLine & vbNewLine &
               "RAM: R{2} x{3}" & vbNewLine & vbNewLine &
               "HDD: R{4} x{5}" & vbNewLine & vbNewLine &
               "Mouse: R{6} x{7}" & vbNewLine & vbNewLine &
               "Monitor: R{8} x{9}" & vbNewLine & vbNewLine &
               "Keyboard: R{10} x{11}" & vbNewLine & vbNewLine &
               "Speaker: R{12} x{13}" & vbNewLine & vbNewLine &
               "Graphic Card: R{14} x{15}" & vbNewLine & vbNewLine &
               "VAT: R{16}" & vbNewLine & "PRICE: R{17}",
               strFullnames, cmbComputerType.Text,
               0, 0, 0, 0,
               decMouseCost, intMouseQuantity, decMonitorCost, intMonitorQuantity,
               decKeyboardCost, intKeyboardQuantity,
               decSpeakerCost, intSpeakerQuantity,
               decGraphicCardCost, intGraphicCardQuantity,
               0, decTotalCost)
        End If
    End Sub

    REM: method to exit program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            Dim existStatus As DialogResult = MessageBox.Show("Are you sure you want to Quit ? ", "WARNING!", MessageBoxButtons.YesNo)

            If existStatus = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occured while exiting!!", "WARNING!")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rtxtbReceipt.Text = String.Empty
        chkGraphicCard.CheckState = CheckState.Unchecked
        chkKeyboard.CheckState = CheckState.Unchecked
        chkMonitor.CheckState = CheckState.Unchecked
        chkMouse.CheckState = CheckState.Unchecked
        chkSpeaker.CheckState = CheckState.Unchecked
        txtName.Text = String.Empty
        txtSurname.Text = String.Empty
        cmbComputerType.Text = ""
        cmbHdd.Text = ""
        cmbRam.Text = ""
    End Sub
End Class
