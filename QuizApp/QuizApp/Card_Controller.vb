
Public Class Card_Controller


    Private Declare Function OpenDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Private Declare Sub CloseDevice Lib "k8055d.dll" ()
    Private Declare Function Version Lib "k8055d.dll" () As Integer
    Private Declare Function SearchDevices Lib "k8055d.dll" () As Integer
    Private Declare Function SetCurrentDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Private Declare Function ReadAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Integer
    Private Declare Sub ReadAllAnalog Lib "k8055d.dll" (ByRef Data1 As Integer, ByRef Data2 As Integer)
    Private Declare Sub OutputAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer, ByVal Data As Integer)
    Private Declare Sub OutputAllAnalog Lib "k8055d.dll" (ByVal Data1 As Integer, ByVal Data2 As Integer)
    Private Declare Sub ClearAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub SetAllAnalog Lib "k8055d.dll" ()
    Private Declare Sub ClearAllAnalog Lib "k8055d.dll" ()
    Private Declare Sub SetAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub WriteAllDigital Lib "k8055d.dll" (ByVal Data As Integer)
    Private Declare Sub ClearDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub ClearAllDigital Lib "k8055d.dll" ()
    Private Declare Sub SetDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub SetAllDigital Lib "k8055d.dll" ()
    Private Declare Function ReadDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Boolean
    Private Declare Function ReadAllDigital Lib "k8055d.dll" () As Integer
    Private Declare Function ReadCounter Lib "k8055d.dll" (ByVal CounterNr As Integer) As Integer
    Private Declare Sub ResetCounter Lib "k8055d.dll" (ByVal CounterNr As Integer)
    Private Declare Sub SetCounterDebounceTime Lib "k8055d.dll" (ByVal CounterNr As Integer, ByVal DebounceTime As Integer)


    Dim _CardAddress As Integer
    Dim _Handle As Integer


    Dim _IsConnected As Boolean = False

    Public Function Connect() As Boolean

        _CardAddress = 0 'both pins still present

        _Handle = OpenDevice(_CardAddress)

        Select Case _Handle
            Case 0
                _IsConnected = True
                Return True
            Case -1
                Return False
        End Select

        Return False

    End Function


    Public Sub Disconnect()
        _IsConnected = False

        For i = 1 To 9
            ClearDigitalChannel(i)
        Next





        CloseDevice
    End Sub


    Public Function ActivateLed(ByVal _position As Integer, ByVal _status As Boolean) As Boolean

        If _IsConnected Then
            If _status Then
                SetDigitalChannel(_position)
                Return True
            ElseIf Not _status Then
                ClearDigitalChannel(_position)
                Return True
            End If

            Return False

        End If
        MessageBox.Show("Card is not active")
        Return False
    End Function


    Public Function IsButtonPressed(ByVal location As Integer) As Boolean
        'requires some error handling for positions still


        Return ReadDigitalChannel(location)

    End Function


    'Public Function CheckAllButtons() As List(Of Boolean)

    '    Dim _ButtonList As List(Of Boolean) = New List(Of Boolean)


    '    For i = 1 To 6
    '        Try
    '            _ButtonList.Add(ReadDigitalChannel(i))

    '        Catch
    '            MessageBox.Show("Something went wrong during the check")
    '            Return Nothing

    '        End Try



    '    Next

    '    Return _ButtonList

    '    MessageBox.Show("Something went wrong during the check")
    '    Return Nothing

    'End Function


    Public Function CheckAllButtons() As Boolean()

        Dim ButtonStatus As Long
        Dim Bool_array() As Boolean = New Boolean(4) {False, False, False, False, False}

        Try
            ButtonStatus = ReadAllDigital
        Catch ex As Exception
            MessageBox.Show("Something went wrong during the check")
            Return Nothing
        End Try


        Dim Button_Binary As String = Convert.ToString(ButtonStatus, 2)

        Dim looper = Button_Binary.Length

        While Not looper = 5
            Button_Binary = "0" + Button_Binary

            looper = Button_Binary.Length
        End While



        For loc As Integer = 0 To Button_Binary.Length - 1
            Dim tempconversion As Integer
            Integer.TryParse(Button_Binary(loc), tempconversion)


            Bool_array(loc) = CBool(tempconversion)

        Next

        If (Bool_array.Length = 5) Then
            Return Bool_array
        End If

        MessageBox.Show("Something went wrong during the Boolean creation")
        Return Nothing

    End Function


End Class
