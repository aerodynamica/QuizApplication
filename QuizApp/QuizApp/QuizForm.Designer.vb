<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizForm
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
        Me.lblCandidate1 = New System.Windows.Forms.Label()
        Me.lblCandidate2 = New System.Windows.Forms.Label()
        Me.lblCandidate3 = New System.Windows.Forms.Label()
        Me.lblCandidate4 = New System.Windows.Forms.Label()
        Me.lblBig = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCandidate1
        '
        Me.lblCandidate1.AutoSize = True
        Me.lblCandidate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandidate1.Location = New System.Drawing.Point(65, 84)
        Me.lblCandidate1.Name = "lblCandidate1"
        Me.lblCandidate1.Size = New System.Drawing.Size(121, 25)
        Me.lblCandidate1.TabIndex = 0
        Me.lblCandidate1.Text = "Kandidaat1"
        '
        'lblCandidate2
        '
        Me.lblCandidate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCandidate2.AutoSize = True
        Me.lblCandidate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandidate2.Location = New System.Drawing.Point(768, 84)
        Me.lblCandidate2.Name = "lblCandidate2"
        Me.lblCandidate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCandidate2.Size = New System.Drawing.Size(121, 25)
        Me.lblCandidate2.TabIndex = 0
        Me.lblCandidate2.Text = "Kandidaat2"
        '
        'lblCandidate3
        '
        Me.lblCandidate3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCandidate3.AutoSize = True
        Me.lblCandidate3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandidate3.Location = New System.Drawing.Point(65, 490)
        Me.lblCandidate3.Name = "lblCandidate3"
        Me.lblCandidate3.Size = New System.Drawing.Size(121, 25)
        Me.lblCandidate3.TabIndex = 0
        Me.lblCandidate3.Text = "Kandidaat3"
        '
        'lblCandidate4
        '
        Me.lblCandidate4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCandidate4.AutoSize = True
        Me.lblCandidate4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandidate4.Location = New System.Drawing.Point(768, 490)
        Me.lblCandidate4.Name = "lblCandidate4"
        Me.lblCandidate4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCandidate4.Size = New System.Drawing.Size(121, 25)
        Me.lblCandidate4.TabIndex = 0
        Me.lblCandidate4.Text = "Kandidaat4"
        '
        'lblBig
        '
        Me.lblBig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBig.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBig.Location = New System.Drawing.Point(0, 0)
        Me.lblBig.Name = "lblBig"
        Me.lblBig.Size = New System.Drawing.Size(947, 577)
        Me.lblBig.TabIndex = 1
        Me.lblBig.Text = "QUIZ"
        Me.lblBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuizForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 577)
        Me.Controls.Add(Me.lblCandidate4)
        Me.Controls.Add(Me.lblCandidate3)
        Me.Controls.Add(Me.lblCandidate2)
        Me.Controls.Add(Me.lblCandidate1)
        Me.Controls.Add(Me.lblBig)
        Me.Name = "QuizForm"
        Me.Text = "Quiz-Time!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCandidate1 As Label
    Friend WithEvents lblCandidate2 As Label
    Friend WithEvents lblCandidate3 As Label
    Friend WithEvents lblCandidate4 As Label
    Friend WithEvents lblBig As Label
End Class
