Public Class Banira
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Banira_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Sub checkAddress() Handles WebBrowser1.DocumentCompleted
        txbaddress.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub Tmrstatus_Tick(sender As Object, e As EventArgs) Handles Tmrstatus.Tick
        Label1.Text = WebBrowser1.StatusText.ToString
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

        WebBrowser1.Navigate(txbaddress.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Settings.SE = "Google" Then
            WebBrowser1.Navigate(My.Settings.Google + txbsearch.Text)
        ElseIf My.Settings.SE = "Bing" Then
            WebBrowser1.Navigate(My.Settings.Bing + txbsearch.Text)
        ElseIf My.Settings.SE = "Youtube" Then
            WebBrowser1.Navigate(My.Settings.Youtube + txbsearch.Text)
        End If
    End Sub

    Private Sub txbsearch_TextChanged(sender As Object, e As EventArgs) Handles txbsearch.Click
        If txbsearch.Text = "Search" Then
            txbsearch.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
    End Sub

    Private Sub txbaddress_TextChanged(sender As Object, e As EventArgs) Handles txbaddress.TextChanged
        If txbaddress.Text = "1" Then
            txbaddress.Text = "www.google.com"
        End If
    End Sub
End Class
