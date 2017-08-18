<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EuhForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblCurrentPlayerName = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.CountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblOnderwerp = New System.Windows.Forms.Label()
        Me.lblVerboden = New System.Windows.Forms.Label()
        Me.btnStartNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCurrentPlayerName
        '
        Me.lblCurrentPlayerName.AutoSize = True
        Me.lblCurrentPlayerName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCurrentPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPlayerName.Location = New System.Drawing.Point(0, 0)
        Me.lblCurrentPlayerName.Name = "lblCurrentPlayerName"
        Me.lblCurrentPlayerName.Size = New System.Drawing.Size(47, 39)
        Me.lblCurrentPlayerName.TabIndex = 0
        Me.lblCurrentPlayerName.Text = "..."
        '
        'lblTimer
        '
        Me.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(0, 39)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(724, 469)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "..."
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnStart.Location = New System.Drawing.Point(616, 226)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Timer"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'CountdownTimer
        '
        Me.CountdownTimer.Interval = 1000
        '
        'lblOnderwerp
        '
        Me.lblOnderwerp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOnderwerp.AutoSize = True
        Me.lblOnderwerp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnderwerp.Location = New System.Drawing.Point(78, 294)
        Me.lblOnderwerp.Name = "lblOnderwerp"
        Me.lblOnderwerp.Size = New System.Drawing.Size(48, 42)
        Me.lblOnderwerp.TabIndex = 3
        Me.lblOnderwerp.Text = "..."
        '
        'lblVerboden
        '
        Me.lblVerboden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVerboden.AutoSize = True
        Me.lblVerboden.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerboden.ForeColor = System.Drawing.Color.Red
        Me.lblVerboden.Location = New System.Drawing.Point(78, 353)
        Me.lblVerboden.Name = "lblVerboden"
        Me.lblVerboden.Size = New System.Drawing.Size(48, 42)
        Me.lblVerboden.TabIndex = 3
        Me.lblVerboden.Text = "..."
        '
        'btnStartNew
        '
        Me.btnStartNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStartNew.Location = New System.Drawing.Point(310, 459)
        Me.btnStartNew.Name = "btnStartNew"
        Me.btnStartNew.Size = New System.Drawing.Size(134, 23)
        Me.btnStartNew.TabIndex = 4
        Me.btnStartNew.Text = "Start Nieuwe Ronde"
        Me.btnStartNew.UseVisualStyleBackColor = True
        '
        'EuhForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 508)
        Me.Controls.Add(Me.btnStartNew)
        Me.Controls.Add(Me.lblVerboden)
        Me.Controls.Add(Me.lblOnderwerp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblCurrentPlayerName)
        Me.Name = "EuhForm"
        Me.Text = "Zeg eens euh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentPlayerName As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents CountdownTimer As Timer
    Friend WithEvents lblOnderwerp As Label
    Friend WithEvents lblVerboden As Label
    Friend WithEvents btnStartNew As Button
End Class
