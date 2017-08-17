<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenuForm
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
        Me.btnQuiz = New System.Windows.Forms.Button()
        Me.btnEuh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnQuiz
        '
        Me.btnQuiz.Location = New System.Drawing.Point(279, 252)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(244, 47)
        Me.btnQuiz.TabIndex = 0
        Me.btnQuiz.Text = "Quiz mode"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'btnEuh
        '
        Me.btnEuh.Location = New System.Drawing.Point(279, 308)
        Me.btnEuh.Name = "btnEuh"
        Me.btnEuh.Size = New System.Drawing.Size(244, 47)
        Me.btnEuh.TabIndex = 1
        Me.btnEuh.Text = "'Zeg eens euh' mode"
        Me.btnEuh.UseVisualStyleBackColor = True
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 557)
        Me.Controls.Add(Me.btnEuh)
        Me.Controls.Add(Me.btnQuiz)
        Me.Name = "MainMenuForm"
        Me.Text = "Quiz app"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnQuiz As Button
    Friend WithEvents btnEuh As Button
End Class
