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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_phy = New System.Windows.Forms.Label()
        Me.lbl_lab = New System.Windows.Forms.Label()
        Me.lbl_sur = New System.Windows.Forms.Label()
        Me.lbl_meds = New System.Windows.Forms.Label()
        Me.lbl_days = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_phy = New System.Windows.Forms.TextBox()
        Me.txt_lab = New System.Windows.Forms.TextBox()
        Me.txt_surg = New System.Windows.Forms.TextBox()
        Me.txt_meds = New System.Windows.Forms.TextBox()
        Me.txt_days = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_cost = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_phy)
        Me.Panel1.Controls.Add(Me.lbl_lab)
        Me.Panel1.Controls.Add(Me.lbl_sur)
        Me.Panel1.Controls.Add(Me.lbl_meds)
        Me.Panel1.Controls.Add(Me.lbl_days)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_phy)
        Me.Panel1.Controls.Add(Me.txt_lab)
        Me.Panel1.Controls.Add(Me.txt_surg)
        Me.Panel1.Controls.Add(Me.txt_meds)
        Me.Panel1.Controls.Add(Me.txt_days)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 270)
        Me.Panel1.TabIndex = 0
        '
        'lbl_phy
        '
        Me.lbl_phy.AutoSize = True
        Me.lbl_phy.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_phy.ForeColor = System.Drawing.Color.Red
        Me.lbl_phy.Location = New System.Drawing.Point(346, 218)
        Me.lbl_phy.Name = "lbl_phy"
        Me.lbl_phy.Size = New System.Drawing.Size(0, 13)
        Me.lbl_phy.TabIndex = 14
        '
        'lbl_lab
        '
        Me.lbl_lab.AutoSize = True
        Me.lbl_lab.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_lab.ForeColor = System.Drawing.Color.Red
        Me.lbl_lab.Location = New System.Drawing.Point(346, 169)
        Me.lbl_lab.Name = "lbl_lab"
        Me.lbl_lab.Size = New System.Drawing.Size(0, 13)
        Me.lbl_lab.TabIndex = 13
        '
        'lbl_sur
        '
        Me.lbl_sur.AutoSize = True
        Me.lbl_sur.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_sur.ForeColor = System.Drawing.Color.Red
        Me.lbl_sur.Location = New System.Drawing.Point(346, 120)
        Me.lbl_sur.Name = "lbl_sur"
        Me.lbl_sur.Size = New System.Drawing.Size(0, 13)
        Me.lbl_sur.TabIndex = 12
        '
        'lbl_meds
        '
        Me.lbl_meds.AutoSize = True
        Me.lbl_meds.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_meds.ForeColor = System.Drawing.Color.Red
        Me.lbl_meds.Location = New System.Drawing.Point(346, 76)
        Me.lbl_meds.Name = "lbl_meds"
        Me.lbl_meds.Size = New System.Drawing.Size(0, 13)
        Me.lbl_meds.TabIndex = 11
        '
        'lbl_days
        '
        Me.lbl_days.AutoSize = True
        Me.lbl_days.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_days.ForeColor = System.Drawing.Color.Red
        Me.lbl_days.Location = New System.Drawing.Point(346, 32)
        Me.lbl_days.Name = "lbl_days"
        Me.lbl_days.Size = New System.Drawing.Size(0, 13)
        Me.lbl_days.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Physical Charges"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lab Fees"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Surgical Charges"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Medication"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Length Of Stay (Days)"
        '
        'txt_phy
        '
        Me.txt_phy.Location = New System.Drawing.Point(191, 211)
        Me.txt_phy.Name = "txt_phy"
        Me.txt_phy.Size = New System.Drawing.Size(130, 20)
        Me.txt_phy.TabIndex = 4
        Me.txt_phy.Text = "0"
        '
        'txt_lab
        '
        Me.txt_lab.Location = New System.Drawing.Point(191, 162)
        Me.txt_lab.Name = "txt_lab"
        Me.txt_lab.Size = New System.Drawing.Size(130, 20)
        Me.txt_lab.TabIndex = 3
        Me.txt_lab.Text = "0"
        '
        'txt_surg
        '
        Me.txt_surg.Location = New System.Drawing.Point(191, 113)
        Me.txt_surg.Name = "txt_surg"
        Me.txt_surg.Size = New System.Drawing.Size(130, 20)
        Me.txt_surg.TabIndex = 2
        Me.txt_surg.Text = "0"
        '
        'txt_meds
        '
        Me.txt_meds.Location = New System.Drawing.Point(191, 69)
        Me.txt_meds.Name = "txt_meds"
        Me.txt_meds.Size = New System.Drawing.Size(130, 20)
        Me.txt_meds.TabIndex = 1
        Me.txt_meds.Text = "0"
        '
        'txt_days
        '
        Me.txt_days.Location = New System.Drawing.Point(191, 25)
        Me.txt_days.Name = "txt_days"
        Me.txt_days.Size = New System.Drawing.Size(130, 20)
        Me.txt_days.TabIndex = 0
        Me.txt_days.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbl_cost)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(12, 299)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 37)
        Me.Panel2.TabIndex = 1
        '
        'lbl_cost
        '
        Me.lbl_cost.AutoSize = True
        Me.lbl_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_cost.Location = New System.Drawing.Point(212, 12)
        Me.lbl_cost.Name = "lbl_cost"
        Me.lbl_cost.Size = New System.Drawing.Size(0, 13)
        Me.lbl_cost.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(148, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Total Cost:"
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(67, 361)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(108, 44)
        Me.btn_calc.TabIndex = 2
        Me.btn_calc.Text = "Calculate Charges"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(214, 361)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(108, 44)
        Me.btn_clear.TabIndex = 3
        Me.btn_clear.Text = "Clear Form"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(362, 361)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 44)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 420)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Hospital Charges"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_phy As Label
    Friend WithEvents lbl_lab As Label
    Friend WithEvents lbl_sur As Label
    Friend WithEvents lbl_meds As Label
    Friend WithEvents lbl_days As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_phy As TextBox
    Friend WithEvents txt_lab As TextBox
    Friend WithEvents txt_surg As TextBox
    Friend WithEvents txt_meds As TextBox
    Friend WithEvents txt_days As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_cost As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents Button3 As Button
End Class
