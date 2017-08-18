Public Class NewEuhForm

    Private _parent As EuhForm

    Public Sub New(ByRef parent As EuhForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _parent = parent

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If cmbPlayer.SelectedItem IsNot Nothing Then

            _parent.UpdateCurrentPlayer(cmbPlayer.SelectedItem)
        Else
            MessageBox.Show("Kies een speler")
            Return
        End If

        If txtOnderwerp.Text IsNot "" Then
            _parent.lblOnderwerp.Text = txtOnderwerp.Text
        Else
            MessageBox.Show("Geef een onderwerp in")
            Return
        End If

        If txtVerboden.Text IsNot "" Then
            _parent.lblVerboden.Text = txtVerboden.Text
        Else
            MessageBox.Show("Geef een verboden woord in")
            Return
        End If

        If txtTime.Text IsNot "" Then
            _parent.TimeLeft = txtTime.Text
            _parent.lblTimer.Text = txtTime.Text
        Else
            MessageBox.Show("Geef een tijd in in")
            Return
        End If

        Close()

    End Sub

    Private Sub NewEuhForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 3
            cmbPlayer.Items.Add(MainMenuForm.data.GetPlayer(i))
        Next
        cmbPlayer.SelectedItem = _parent.CurrentPlayer

        txtTime.Text = 60

    End Sub


End Class