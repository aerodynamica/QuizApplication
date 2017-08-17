Imports System.Xml.Serialization

Public Class NamesForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim quizData As New QuizData()

        quizData.Player1 = New Player(txtNamePlayer1.Text)
        quizData.Player2 = New Player(txtNamePlayer2.Text)
        quizData.Player3 = New Player(txtNamePlayer3.Text)
        quizData.Player4 = New Player(txtNamePlayer4.Text)


        MainMenuForm.data = quizData


        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(QuizData))
        Dim file As New System.IO.StreamWriter("players.xml")
        writer.Serialize(file, quizData)
        file.Close()


        Me.Close()

    End Sub

    Private Sub NamesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNamePlayer1.Text = MainMenuForm.data.Player1.FirstName
        txtNamePlayer2.Text = MainMenuForm.data.Player2.FirstName
        txtNamePlayer3.Text = MainMenuForm.data.Player3.FirstName
        txtNamePlayer4.Text = MainMenuForm.data.Player4.FirstName

    End Sub
End Class