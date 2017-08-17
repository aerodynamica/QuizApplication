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
        Me.btnNames = New System.Windows.Forms.Button()
        Me.PicBox_Euh = New System.Windows.Forms.PictureBox()
        Me.PicBox_Quiz = New System.Windows.Forms.PictureBox()
        CType(Me.PicBox_Euh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_Quiz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuiz
        '
        Me.btnQuiz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQuiz.Location = New System.Drawing.Point(79, 447)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(244, 47)
        Me.btnQuiz.TabIndex = 0
        Me.btnQuiz.Text = "Quiz"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'btnEuh
        '
        Me.btnEuh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEuh.Location = New System.Drawing.Point(499, 447)
        Me.btnEuh.Name = "btnEuh"
        Me.btnEuh.Size = New System.Drawing.Size(244, 47)
        Me.btnEuh.TabIndex = 1
        Me.btnEuh.Text = "Zeg-Eens-Euh"
        Me.btnEuh.UseVisualStyleBackColor = True
        '
        'btnNames
        '
        Me.btnNames.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNames.Location = New System.Drawing.Point(288, 500)
        Me.btnNames.Name = "btnNames"
        Me.btnNames.Size = New System.Drawing.Size(244, 47)
        Me.btnNames.TabIndex = 0
        Me.btnNames.Text = "Namen aanpassen"
        Me.btnNames.UseVisualStyleBackColor = True
        '
        'PicBox_Euh
        '
        Me.PicBox_Euh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBox_Euh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicBox_Euh.Image = Global.QuizApp.My.Resources.Resources.ZegEensEuh
        Me.PicBox_Euh.Location = New System.Drawing.Point(426, 12)
        Me.PicBox_Euh.Name = "PicBox_Euh"
        Me.PicBox_Euh.Size = New System.Drawing.Size(382, 429)
        Me.PicBox_Euh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox_Euh.TabIndex = 2
        Me.PicBox_Euh.TabStop = False
        '
        'PicBox_Quiz
        '
        Me.PicBox_Quiz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicBox_Quiz.Image = Global.QuizApp.My.Resources.Resources.Quiz_Image
        Me.PicBox_Quiz.Location = New System.Drawing.Point(12, 12)
        Me.PicBox_Quiz.Name = "PicBox_Quiz"
        Me.PicBox_Quiz.Size = New System.Drawing.Size(389, 429)
        Me.PicBox_Quiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox_Quiz.TabIndex = 3
        Me.PicBox_Quiz.TabStop = False
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 557)
        Me.Controls.Add(Me.PicBox_Quiz)
        Me.Controls.Add(Me.PicBox_Euh)
        Me.Controls.Add(Me.btnEuh)
        Me.Controls.Add(Me.btnNames)
        Me.Controls.Add(Me.btnQuiz)
        Me.Name = "MainMenuForm"
        Me.Text = "Quiz app"
        CType(Me.PicBox_Euh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_Quiz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnQuiz As Button
    Friend WithEvents btnEuh As Button
    Friend WithEvents btnNames As Button
    Friend WithEvents PicBox_Euh As PictureBox
    Friend WithEvents PicBox_Quiz As PictureBox
End Class
