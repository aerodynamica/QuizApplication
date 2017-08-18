<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEuhForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtVerboden = New System.Windows.Forms.TextBox()
        Me.txtOnderwerp = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.cmbPlayer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welke speler is aan de beurt?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Wat is het onderwerp?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Wat is het verboden woord?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Hoeveel seconden?"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(72, 227)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(43, 20)
        Me.txtTime.TabIndex = 2
        '
        'txtVerboden
        '
        Me.txtVerboden.Location = New System.Drawing.Point(72, 163)
        Me.txtVerboden.Name = "txtVerboden"
        Me.txtVerboden.Size = New System.Drawing.Size(100, 20)
        Me.txtVerboden.TabIndex = 2
        '
        'txtOnderwerp
        '
        Me.txtOnderwerp.Location = New System.Drawing.Point(72, 111)
        Me.txtOnderwerp.Name = "txtOnderwerp"
        Me.txtOnderwerp.Size = New System.Drawing.Size(138, 20)
        Me.txtOnderwerp.TabIndex = 2
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(309, 260)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "Nieuw spel"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'cmbPlayer
        '
        Me.cmbPlayer.FormattingEnabled = True
        Me.cmbPlayer.Location = New System.Drawing.Point(72, 59)
        Me.cmbPlayer.Name = "cmbPlayer"
        Me.cmbPlayer.Size = New System.Drawing.Size(121, 21)
        Me.cmbPlayer.TabIndex = 4
        '
        'NewEuhForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 291)
        Me.Controls.Add(Me.cmbPlayer)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtOnderwerp)
        Me.Controls.Add(Me.txtVerboden)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewEuhForm"
        Me.Text = "NewEuhForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtVerboden As TextBox
    Friend WithEvents txtOnderwerp As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents cmbPlayer As ComboBox
End Class
