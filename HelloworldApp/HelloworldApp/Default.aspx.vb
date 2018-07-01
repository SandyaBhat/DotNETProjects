Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        spnWelcome.InnerText = "Welcome Guest"
    End Sub
End Class