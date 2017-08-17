<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EuhForm
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
        Me.lblCurrentPlayerName = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCurrentPlayerName
        '
        Me.lblCurrentPlayerName.AutoSize = True
        Me.lblCurrentPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPlayerName.Location = New System.Drawing.Point(28, 28)
        Me.lblCurrentPlayerName.Name = "lblCurrentPlayerName"
        Me.lblCurrentPlayerName.Size = New System.Drawing.Size(232, 39)
        Me.lblCurrentPlayerName.TabIndex = 0
        Me.lblCurrentPlayerName.Text = "huidige speler"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(262, 166)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(156, 135)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "..."
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(549, 405)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'EuhForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 490)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblCurrentPlayerName)
        Me.Name = "EuhForm"
        Me.Text = "EuhForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentPlayerName As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnStart As Button
End Class
