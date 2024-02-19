Imports System.IO
Imports System.Reflection

Public Class FormControlsPresetSystem2

    Public Shared Sub SaveControlValues(form As Form, filePath As String)
        Using sw As New StreamWriter(filePath)
            For Each ctrl In form.Controls
                SaveControlValue(ctrl, sw)
            Next
        End Using
    End Sub

    Public Shared Sub LoadControlValues(form As Form, filePath As String)
        If Not File.Exists(filePath) Then Return
        Dim controlValues As New Dictionary(Of String, String)
        Using sr As New StreamReader(filePath)
            While Not sr.EndOfStream
                Dim line = sr.ReadLine()
                Dim parts = line.Split(New Char() {"="c}, 2)
                If parts.Length = 2 Then
                    controlValues(parts(0)) = parts(1)
                End If
            End While
        End Using
        For Each ctrl In form.Controls
            LoadControlValue(ctrl, controlValues)
        Next
    End Sub

    Private Shared Sub SaveControlValue(ctrl As Control, sw As StreamWriter)
        Dim controlType As Type = ctrl.GetType()
        Select Case True
            Case TypeOf ctrl Is TextBox
                sw.WriteLine($"{ctrl.Name}={ctrl.Text}")
            Case TypeOf ctrl Is CheckBox
                sw.WriteLine($"{ctrl.Name}={DirectCast(ctrl, CheckBox).Checked}")
            Case TypeOf ctrl Is ComboBox
                sw.WriteLine($"{ctrl.Name}={DirectCast(ctrl, ComboBox).SelectedIndex}")
            Case TypeOf ctrl Is RadioButton
                sw.WriteLine($"{ctrl.Name}={DirectCast(ctrl, RadioButton).Checked}")
        End Select
    End Sub

    Private Shared Sub LoadControlValue(ctrl As Control, controlValues As Dictionary(Of String, String))
        Dim value As String = String.Empty

        Select Case True
            Case TypeOf ctrl Is TextBox
                If controlValues.TryGetValue(ctrl.Name, value) Then ctrl.Text = value
            Case TypeOf ctrl Is CheckBox
                If controlValues.TryGetValue(ctrl.Name, value) Then DirectCast(ctrl, CheckBox).Checked = Boolean.Parse(value)
            Case TypeOf ctrl Is ComboBox
                If controlValues.TryGetValue(ctrl.Name, value) Then DirectCast(ctrl, ComboBox).SelectedIndex = Integer.Parse(value)
            Case TypeOf ctrl Is RadioButton
                If controlValues.TryGetValue(ctrl.Name, value) Then DirectCast(ctrl, RadioButton).Checked = Boolean.Parse(value)
        End Select
    End Sub
End Class
