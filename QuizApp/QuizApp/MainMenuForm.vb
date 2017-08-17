Imports System.IO

Public Class MainMenuForm

    Public Shared data As QuizData

    Private Sub BtnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Dim form As New QuizForm()
        form.Show()
        Me.Close()
    End Sub

    Private Sub BtnNames_Click(sender As Object, e As EventArgs) Handles btnNames.Click
        Dim form As New NamesForm()
        form.Show()
    End Sub

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("players.xml") Then
            Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(QuizData))
            Dim file As New System.IO.StreamReader("players.xml")
            data = CType(reader.Deserialize(file), QuizData)
            file.Close()
        Else
            'create default quiz data
            data = New QuizData With {
                .Player1 = New Player("speler1"),
                .Player2 = New Player("speler2"),
                .Player3 = New Player("speler3"),
                .Player4 = New Player("speler4")
            }

            Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(QuizData))
            Dim file As New System.IO.StreamWriter("players.xml")
            writer.Serialize(file, data)
            file.Close()
        End If


    End Sub

    Private Sub BtnEuh_Click(sender As Object, e As EventArgs) Handles btnEuh.Click
        Dim form As New EuhForm()
        form.Show()
        Me.Close()
    End Sub
End Class
