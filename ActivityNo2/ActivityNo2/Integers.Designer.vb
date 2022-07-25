<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInt
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
        Me.lblIntegerTitle = New System.Windows.Forms.Label()
        Me.txbInteger = New System.Windows.Forms.TextBox()
        Me.lblInteger = New System.Windows.Forms.Label()
        Me.lblScreening = New System.Windows.Forms.Label()
        Me.lblCenter = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIntegerTitle
        '
        Me.lblIntegerTitle.AutoSize = True
        Me.lblIntegerTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblIntegerTitle.Font = New System.Drawing.Font("Bebas Neue", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntegerTitle.ForeColor = System.Drawing.Color.Snow
        Me.lblIntegerTitle.Location = New System.Drawing.Point(52, 29)
        Me.lblIntegerTitle.Name = "lblIntegerTitle"
        Me.lblIntegerTitle.Size = New System.Drawing.Size(145, 58)
        Me.lblIntegerTitle.TabIndex = 0
        Me.lblIntegerTitle.Text = "Integer"
        Me.lblIntegerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbInteger
        '
        Me.txbInteger.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbInteger.Font = New System.Drawing.Font("Bebas Neue", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbInteger.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.txbInteger.Location = New System.Drawing.Point(214, 58)
        Me.txbInteger.Name = "txbInteger"
        Me.txbInteger.Size = New System.Drawing.Size(234, 35)
        Me.txbInteger.TabIndex = 1
        Me.txbInteger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInteger
        '
        Me.lblInteger.AutoSize = True
        Me.lblInteger.BackColor = System.Drawing.Color.Transparent
        Me.lblInteger.Font = New System.Drawing.Font("Bebas Neue", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInteger.Location = New System.Drawing.Point(212, 22)
        Me.lblInteger.Name = "lblInteger"
        Me.lblInteger.Size = New System.Drawing.Size(240, 35)
        Me.lblInteger.TabIndex = 0
        Me.lblInteger.Text = "Enter a worthy integer"
        '
        'lblScreening
        '
        Me.lblScreening.AutoSize = True
        Me.lblScreening.BackColor = System.Drawing.Color.Transparent
        Me.lblScreening.Font = New System.Drawing.Font("Bebas Neue", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreening.Location = New System.Drawing.Point(12, 73)
        Me.lblScreening.Name = "lblScreening"
        Me.lblScreening.Size = New System.Drawing.Size(185, 58)
        Me.lblScreening.TabIndex = 0
        Me.lblScreening.Text = "Screening"
        Me.lblScreening.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCenter
        '
        Me.lblCenter.AutoSize = True
        Me.lblCenter.BackColor = System.Drawing.Color.Transparent
        Me.lblCenter.Font = New System.Drawing.Font("Bebas Neue", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCenter.Location = New System.Drawing.Point(61, 117)
        Me.lblCenter.Name = "lblCenter"
        Me.lblCenter.Size = New System.Drawing.Size(136, 58)
        Me.lblCenter.TabIndex = 0
        Me.lblCenter.Text = "Center"
        Me.lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Snow
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Bebas Neue", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnCheck.Location = New System.Drawing.Point(214, 99)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 75)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Snow
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Bebas Neue", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnClear.Location = New System.Drawing.Point(294, 99)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 75)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Snow
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Bebas Neue", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnCancel.Location = New System.Drawing.Point(373, 99)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 75)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(482, 200)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblCenter)
        Me.Controls.Add(Me.lblScreening)
        Me.Controls.Add(Me.lblInteger)
        Me.Controls.Add(Me.txbInteger)
        Me.Controls.Add(Me.lblIntegerTitle)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rubinos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntegerTitle As System.Windows.Forms.Label
    Friend WithEvents txbInteger As System.Windows.Forms.TextBox
    Friend WithEvents lblInteger As System.Windows.Forms.Label
    Friend WithEvents lblScreening As System.Windows.Forms.Label
    Friend WithEvents lblCenter As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
