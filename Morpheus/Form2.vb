Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.SettingsKey = "Google" Then
            RadioButton1.Checked = True
        ElseIf My.Settings.SettingsKey = "DuckDuckGo" Then
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.SE = "Google"
        ElseIf RadioButton2.Checked = True Then
            My.Settings.SE = "DuckDuckGo"

            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub
End Class