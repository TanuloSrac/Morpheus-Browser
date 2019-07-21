Imports CefSharp.WinForms
Imports CefSharp
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Sub checkAdress() Handles WebBrowser1.DocumentCompleted
        txbAdress.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub TmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        Label2.Text = WebBrowser1.StatusText.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Navigate(txbAdress.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Settings.SE = "Google" Then
            WebBrowser1.Navigate(My.Settings.Google + txbSearch.Text)
        ElseIf My.Settings.SE = "DuckDuckGo" Then
            WebBrowser1.Navigate(My.Settings.DuckDuckGo + txbSearch.Text)
        End If
    End Sub

    Private Sub txbSearch_TextChanged(sender As Object, e As EventArgs) Handles txbSearch.Click
        If txbSearch.Text = "Kereső mező" Then
            txbSearch.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


    End Sub
End Class
