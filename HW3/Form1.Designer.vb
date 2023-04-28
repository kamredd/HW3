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
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.rbtnCheese = New System.Windows.Forms.RadioButton()
        Me.rbtnWheel = New System.Windows.Forms.RadioButton()
        Me.rbtnVeg = New System.Windows.Forms.RadioButton()
        Me.rbtnSausage = New System.Windows.Forms.RadioButton()
        Me.rbtnFruit = New System.Windows.Forms.RadioButton()
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.lblCatering = New System.Windows.Forms.Label()
        Me.lblMarket = New System.Windows.Forms.Label()
        Me.lblLoyalty = New System.Windows.Forms.Label()
        Me.txtLoyalty = New System.Windows.Forms.TextBox()
        Me.grpPay = New System.Windows.Forms.GroupBox()
        Me.rbtnPrePay = New System.Windows.Forms.RadioButton()
        Me.rbtnPickupPay = New System.Windows.Forms.RadioButton()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpOrder.SuspendLayout()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOrder
        '
        Me.grpOrder.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpOrder.Controls.Add(Me.rbtnFruit)
        Me.grpOrder.Controls.Add(Me.rbtnSausage)
        Me.grpOrder.Controls.Add(Me.rbtnVeg)
        Me.grpOrder.Controls.Add(Me.rbtnWheel)
        Me.grpOrder.Controls.Add(Me.rbtnCheese)
        Me.grpOrder.Location = New System.Drawing.Point(25, 105)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(295, 167)
        Me.grpOrder.TabIndex = 0
        Me.grpOrder.TabStop = False
        '
        'rbtnCheese
        '
        Me.rbtnCheese.AutoSize = True
        Me.rbtnCheese.Location = New System.Drawing.Point(6, 19)
        Me.rbtnCheese.Name = "rbtnCheese"
        Me.rbtnCheese.Size = New System.Drawing.Size(140, 17)
        Me.rbtnCheese.TabIndex = 0
        Me.rbtnCheese.TabStop = True
        Me.rbtnCheese.Text = "Gourmet Cheese $49.99"
        Me.rbtnCheese.UseVisualStyleBackColor = True
        '
        'rbtnWheel
        '
        Me.rbtnWheel.AutoSize = True
        Me.rbtnWheel.Location = New System.Drawing.Point(6, 49)
        Me.rbtnWheel.Name = "rbtnWheel"
        Me.rbtnWheel.Size = New System.Drawing.Size(138, 17)
        Me.rbtnWheel.TabIndex = 1
        Me.rbtnWheel.TabStop = True
        Me.rbtnWheel.Text = "Pinwheel Wraps $59.99"
        Me.rbtnWheel.UseVisualStyleBackColor = True
        '
        'rbtnVeg
        '
        Me.rbtnVeg.AutoSize = True
        Me.rbtnVeg.Location = New System.Drawing.Point(6, 78)
        Me.rbtnVeg.Name = "rbtnVeg"
        Me.rbtnVeg.Size = New System.Drawing.Size(94, 17)
        Me.rbtnVeg.TabIndex = 2
        Me.rbtnVeg.TabStop = True
        Me.rbtnVeg.Text = "Veggie $29.99"
        Me.rbtnVeg.UseVisualStyleBackColor = True
        '
        'rbtnSausage
        '
        Me.rbtnSausage.AutoSize = True
        Me.rbtnSausage.Location = New System.Drawing.Point(6, 107)
        Me.rbtnSausage.Name = "rbtnSausage"
        Me.rbtnSausage.Size = New System.Drawing.Size(163, 17)
        Me.rbtnSausage.TabIndex = 3
        Me.rbtnSausage.TabStop = True
        Me.rbtnSausage.Text = "Sausage and Cheese $49.99"
        Me.rbtnSausage.UseVisualStyleBackColor = True
        '
        'rbtnFruit
        '
        Me.rbtnFruit.AutoSize = True
        Me.rbtnFruit.Location = New System.Drawing.Point(6, 136)
        Me.rbtnFruit.Name = "rbtnFruit"
        Me.rbtnFruit.Size = New System.Drawing.Size(81, 17)
        Me.rbtnFruit.TabIndex = 4
        Me.rbtnFruit.TabStop = True
        Me.rbtnFruit.Text = "Fruit $29.99"
        Me.rbtnFruit.UseVisualStyleBackColor = True
        '
        'picPlatter
        '
        Me.picPlatter.Image = Global.HW3.My.Resources.Resources.platter
        Me.picPlatter.Location = New System.Drawing.Point(349, 12)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(353, 201)
        Me.picPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlatter.TabIndex = 1
        Me.picPlatter.TabStop = False
        '
        'lblCatering
        '
        Me.lblCatering.AutoSize = True
        Me.lblCatering.Font = New System.Drawing.Font("Microsoft Uighur", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatering.Location = New System.Drawing.Point(80, 9)
        Me.lblCatering.Name = "lblCatering"
        Me.lblCatering.Size = New System.Drawing.Size(136, 51)
        Me.lblCatering.TabIndex = 2
        Me.lblCatering.Text = "Catering"
        '
        'lblMarket
        '
        Me.lblMarket.AutoSize = True
        Me.lblMarket.Font = New System.Drawing.Font("Microsoft Uighur", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarket.Location = New System.Drawing.Point(66, 50)
        Me.lblMarket.Name = "lblMarket"
        Me.lblMarket.Size = New System.Drawing.Size(116, 35)
        Me.lblMarket.TabIndex = 3
        Me.lblMarket.Text = "Star Market"
        '
        'lblLoyalty
        '
        Me.lblLoyalty.AutoSize = True
        Me.lblLoyalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyalty.Location = New System.Drawing.Point(431, 240)
        Me.lblLoyalty.Name = "lblLoyalty"
        Me.lblLoyalty.Size = New System.Drawing.Size(105, 16)
        Me.lblLoyalty.TabIndex = 4
        Me.lblLoyalty.Text = "Loyalty Points"
        '
        'txtLoyalty
        '
        Me.txtLoyalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyalty.Location = New System.Drawing.Point(567, 236)
        Me.txtLoyalty.Name = "txtLoyalty"
        Me.txtLoyalty.Size = New System.Drawing.Size(46, 22)
        Me.txtLoyalty.TabIndex = 5
        '
        'grpPay
        '
        Me.grpPay.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpPay.Controls.Add(Me.rbtnPickupPay)
        Me.grpPay.Controls.Add(Me.rbtnPrePay)
        Me.grpPay.Location = New System.Drawing.Point(112, 286)
        Me.grpPay.Name = "grpPay"
        Me.grpPay.Size = New System.Drawing.Size(200, 100)
        Me.grpPay.TabIndex = 6
        Me.grpPay.TabStop = False
        '
        'rbtnPrePay
        '
        Me.rbtnPrePay.AutoSize = True
        Me.rbtnPrePay.Location = New System.Drawing.Point(7, 20)
        Me.rbtnPrePay.Name = "rbtnPrePay"
        Me.rbtnPrePay.Size = New System.Drawing.Size(62, 17)
        Me.rbtnPrePay.TabIndex = 0
        Me.rbtnPrePay.TabStop = True
        Me.rbtnPrePay.Text = "Pre-Pay"
        Me.rbtnPrePay.UseVisualStyleBackColor = True
        '
        'rbtnPickupPay
        '
        Me.rbtnPickupPay.AutoSize = True
        Me.rbtnPickupPay.Location = New System.Drawing.Point(7, 56)
        Me.rbtnPickupPay.Name = "rbtnPickupPay"
        Me.rbtnPickupPay.Size = New System.Drawing.Size(106, 17)
        Me.rbtnPickupPay.TabIndex = 1
        Me.rbtnPickupPay.TabStop = True
        Me.rbtnPickupPay.Text = "Pay upon Pickup"
        Me.rbtnPickupPay.UseVisualStyleBackColor = True
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.Location = New System.Drawing.Point(119, 415)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(92, 16)
        Me.lblPay.TabIndex = 7
        Me.lblPay.Text = "Please Pay:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(279, 412)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(55, 16)
        Me.lblPayment.TabIndex = 8
        Me.lblPayment.Text = "Label5"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Moccasin
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(409, 333)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 31)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Moccasin
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(557, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 31)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(751, 459)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.grpPay)
        Me.Controls.Add(Me.txtLoyalty)
        Me.Controls.Add(Me.lblLoyalty)
        Me.Controls.Add(Me.lblMarket)
        Me.Controls.Add(Me.lblCatering)
        Me.Controls.Add(Me.picPlatter)
        Me.Controls.Add(Me.grpOrder)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPay.ResumeLayout(False)
        Me.grpPay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents rbtnFruit As RadioButton
    Friend WithEvents rbtnSausage As RadioButton
    Friend WithEvents rbtnVeg As RadioButton
    Friend WithEvents rbtnWheel As RadioButton
    Friend WithEvents rbtnCheese As RadioButton
    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents lblCatering As Label
    Friend WithEvents lblMarket As Label
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents txtLoyalty As TextBox
    Friend WithEvents grpPay As GroupBox
    Friend WithEvents rbtnPickupPay As RadioButton
    Friend WithEvents rbtnPrePay As RadioButton
    Friend WithEvents lblPay As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
