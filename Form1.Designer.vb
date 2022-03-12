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
        Me.main_TB = New System.Windows.Forms.TextBox()
        Me.percentage_BTN = New System.Windows.Forms.Button()
        Me.ce_BTN = New System.Windows.Forms.Button()
        Me.c_BTN = New System.Windows.Forms.Button()
        Me.back_BTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'main_TB
        '
        Me.main_TB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.main_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.main_TB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.main_TB.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.main_TB.ForeColor = System.Drawing.Color.White
        Me.main_TB.Location = New System.Drawing.Point(16, 80)
        Me.main_TB.Name = "main_TB"
        Me.main_TB.ReadOnly = True
        Me.main_TB.Size = New System.Drawing.Size(354, 54)
        Me.main_TB.TabIndex = 0
        Me.main_TB.Text = "0"
        Me.main_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'percentage_BTN
        '
        Me.percentage_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.percentage_BTN.FlatAppearance.BorderSize = 0
        Me.percentage_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.percentage_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.percentage_BTN.ForeColor = System.Drawing.Color.White
        Me.percentage_BTN.Location = New System.Drawing.Point(5, 159)
        Me.percentage_BTN.Name = "percentage_BTN"
        Me.percentage_BTN.Size = New System.Drawing.Size(90, 45)
        Me.percentage_BTN.TabIndex = 1
        Me.percentage_BTN.Text = "%"
        Me.percentage_BTN.UseVisualStyleBackColor = False
        '
        'ce_BTN
        '
        Me.ce_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ce_BTN.FlatAppearance.BorderSize = 0
        Me.ce_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ce_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ce_BTN.ForeColor = System.Drawing.Color.White
        Me.ce_BTN.Location = New System.Drawing.Point(100, 159)
        Me.ce_BTN.Name = "ce_BTN"
        Me.ce_BTN.Size = New System.Drawing.Size(90, 45)
        Me.ce_BTN.TabIndex = 2
        Me.ce_BTN.Text = "CE"
        Me.ce_BTN.UseVisualStyleBackColor = False
        '
        'c_BTN
        '
        Me.c_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.c_BTN.FlatAppearance.BorderSize = 0
        Me.c_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.c_BTN.ForeColor = System.Drawing.Color.White
        Me.c_BTN.Location = New System.Drawing.Point(195, 159)
        Me.c_BTN.Name = "c_BTN"
        Me.c_BTN.Size = New System.Drawing.Size(90, 45)
        Me.c_BTN.TabIndex = 3
        Me.c_BTN.Text = "C"
        Me.c_BTN.UseVisualStyleBackColor = False
        '
        'back_BTN
        '
        Me.back_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.back_BTN.FlatAppearance.BorderSize = 0
        Me.back_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_BTN.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.back_BTN.ForeColor = System.Drawing.Color.White
        Me.back_BTN.Location = New System.Drawing.Point(290, 159)
        Me.back_BTN.Name = "back_BTN"
        Me.back_BTN.Size = New System.Drawing.Size(90, 45)
        Me.back_BTN.TabIndex = 4
        Me.back_BTN.Text = "<-"
        Me.back_BTN.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(386, 555)
        Me.Controls.Add(Me.back_BTN)
        Me.Controls.Add(Me.c_BTN)
        Me.Controls.Add(Me.ce_BTN)
        Me.Controls.Add(Me.percentage_BTN)
        Me.Controls.Add(Me.main_TB)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents main_TB As TextBox
    Friend WithEvents percentage_BTN As Button
    Friend WithEvents ce_BTN As Button
    Friend WithEvents c_BTN As Button
    Friend WithEvents back_BTN As Button
End Class
