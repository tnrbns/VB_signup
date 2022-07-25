<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculater
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
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.txbX = New System.Windows.Forms.TextBox()
        Me.txbY = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.lblSubheader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.BackColor = System.Drawing.Color.Transparent
        Me.lblX.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblX.Location = New System.Drawing.Point(100, 95)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(83, 23)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "First value"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.BackColor = System.Drawing.Color.Transparent
        Me.lblY.Font = New System.Drawing.Font("Bebas Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblY.Location = New System.Drawing.Point(290, 95)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(95, 23)
        Me.lblY.TabIndex = 1
        Me.lblY.Text = "Second Value"
        '
        'txbX
        '
        Me.txbX.BackColor = System.Drawing.Color.White
        Me.txbX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbX.Font = New System.Drawing.Font("Bebas Neue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbX.Location = New System.Drawing.Point(33, 121)
        Me.txbX.Name = "txbX"
        Me.txbX.Size = New System.Drawing.Size(150, 33)
        Me.txbX.TabIndex = 1
        Me.txbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbY
        '
        Me.txbY.BackColor = System.Drawing.Color.White
        Me.txbY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbY.Font = New System.Drawing.Font("Bebas Neue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbY.Location = New System.Drawing.Point(237, 121)
        Me.txbY.Name = "txbY"
        Me.txbY.Size = New System.Drawing.Size(150, 33)
        Me.txbY.TabIndex = 2
        Me.txbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.BurlyWood
        Me.btnPlus.FlatAppearance.BorderSize = 0
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnPlus.Location = New System.Drawing.Point(21, 254)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(90, 80)
        Me.btnPlus.TabIndex = 3
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnSubtract
        '
        Me.btnSubtract.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSubtract.FlatAppearance.BorderSize = 0
        Me.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubtract.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnSubtract.Location = New System.Drawing.Point(117, 254)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(90, 80)
        Me.btnSubtract.TabIndex = 4
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.BurlyWood
        Me.btnMultiply.FlatAppearance.BorderSize = 0
        Me.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultiply.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnMultiply.Location = New System.Drawing.Point(213, 254)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(90, 80)
        Me.btnMultiply.TabIndex = 5
        Me.btnMultiply.Text = "×"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.BurlyWood
        Me.btnDivide.FlatAppearance.BorderSize = 0
        Me.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDivide.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnDivide.Location = New System.Drawing.Point(309, 254)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(90, 80)
        Me.btnDivide.TabIndex = 6
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Bebas Neue", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHeader.Location = New System.Drawing.Point(107, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(219, 58)
        Me.lblHeader.TabIndex = 9
        Me.lblHeader.Text = "Calcu-later"
        '
        'lblAns
        '
        Me.lblAns.BackColor = System.Drawing.Color.Transparent
        Me.lblAns.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblAns.Location = New System.Drawing.Point(33, 164)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(354, 77)
        Me.lblAns.TabIndex = 0
        Me.lblAns.Text = "Answer"
        Me.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubheader
        '
        Me.lblSubheader.AutoSize = True
        Me.lblSubheader.BackColor = System.Drawing.Color.Transparent
        Me.lblSubheader.Font = New System.Drawing.Font("BigNoodleTitling", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheader.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblSubheader.Location = New System.Drawing.Point(148, 53)
        Me.lblSubheader.Name = "lblSubheader"
        Me.lblSubheader.Size = New System.Drawing.Size(128, 27)
        Me.lblSubheader.TabIndex = 10
        Me.lblSubheader.Text = "sa mga tapulan"
        '
        'frmCalculater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(415, 362)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.lblSubheader)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txbY)
        Me.Controls.Add(Me.txbX)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmCalculater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rubinos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents txbX As System.Windows.Forms.TextBox
    Friend WithEvents txbY As System.Windows.Forms.TextBox
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents lblSubheader As System.Windows.Forms.Label

End Class
