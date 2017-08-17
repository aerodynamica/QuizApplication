Imports System.Xml.Serialization

Public Class NamesForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim players(3) As String

        players(0) = txtNamePlayer1.Text
        players(1) = txtNamePlayer2.Text
        players(2) = txtNamePlayer3.Text
        players(3) = txtNamePlayer4.Text


        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(String()))
        Dim file As New System.IO.StreamWriter("players.xml")
        writer.Serialize(file, players)
        file.Close()


        Me.Close()

    End Sub

    Private Sub NamesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(String()))
        Dim file As New System.IO.StreamReader("players.xml")
        Dim players(3) As String
        players = CType(reader.Deserialize(file), String())
        file.Close()


        txtNamePlayer1.Text = players(0)
        txtNamePlayer2.Text = players(1)
        txtNamePlayer3.Text = players(2)
        txtNamePlayer4.Text = players(3)

    End Sub
End Class