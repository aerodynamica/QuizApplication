<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NamesForm
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblNaamSpeler1 = New System.Windows.Forms.Label()
        Me.txtNamePlayer1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamePlayer2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamePlayer3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamePlayer4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(95, 127)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 31)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Opslaan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblNaamSpeler1
        '
        Me.lblNaamSpeler1.AutoSize = True
        Me.lblNaamSpeler1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaamSpeler1.Location = New System.Drawing.Point(44, 12)
        Me.lblNaamSpeler1.Name = "lblNaamSpeler1"
        Me.lblNaamSpeler1.Size = New System.Drawing.Size(64, 16)
        Me.lblNaamSpeler1.TabIndex = 1
        Me.lblNaamSpeler1.Text = "Speler 1 :"
        '
        'txtNamePlayer1
        '
        Me.txtNamePlayer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamePlayer1.Location = New System.Drawing.Point(114, 11)
        Me.txtNamePlayer1.Name = "txtNamePlayer1"
        Me.txtNamePlayer1.Size = New System.Drawing.Size(150, 20)
        Me.txtNamePlayer1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Speler 2 :"
        '
        'txtNamePlayer2
        '
        Me.txtNamePlayer2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamePlayer2.Location = New System.Drawing.Point(114, 37)
        Me.txtNamePlayer2.Name = "txtNamePlayer2"
        Me.txtNamePlayer2.Size = New System.Drawing.Size(150, 20)
        Me.txtNamePlayer2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Speler 3 :"
        '
        'txtNamePlayer3
        '
        Me.txtNamePlayer3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamePlayer3.Location = New System.Drawing.Point(114, 63)
        Me.txtNamePlayer3.Name = "txtNamePlayer3"
        Me.txtNamePlayer3.Size = New System.Drawing.Size(150, 20)
        Me.txtNamePlayer3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Speler 4 :"
        '
        'txtNamePlayer4
        '
        Me.txtNamePlayer4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamePlayer4.Location = New System.Drawing.Point(114, 89)
        Me.txtNamePlayer4.Name = "txtNamePlayer4"
        Me.txtNamePlayer4.Size = New System.Drawing.Size(150, 20)
        Me.txtNamePlayer4.TabIndex = 2
        '
        'NamesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 170)
        Me.Controls.Add(Me.txtNamePlayer4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamePlayer3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamePlayer2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNamePlayer1)
        Me.Controls.Add(Me.lblNaamSpeler1)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "NamesForm"
        Me.Text = "Input namen van spelers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblNaamSpeler1 As Label
    Friend WithEvents txtNamePlayer1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamePlayer2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamePlayer3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamePlayer4 As TextBox
End Class
