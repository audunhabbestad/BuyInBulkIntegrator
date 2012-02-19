Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Net.Mail


' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service1
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod()> _
    Public Function Add(name As String, email As String) As String
        SendEmail(name & " - " & email + " Recived")

        Return name & " - " & email + " Recived"
    End Function

    Public Shared Sub SendEmail(MyString As String)
        'Start by creating a mail message object
        Dim MyMailMessage As New MailMessage("audunhabbestad@gmail.com", "audunhabbestad@gmail.com ", "Message Subject", "Test: " & MyString)




        'Create the SMTPClient object and specify the SMTP server name
        Dim SMTPServer As New SmtpClient("smtp.gmail.com", 587)
        SMTPServer.Credentials = New Net.NetworkCredential("audunhabbestad@gmail.com", "TA230101")
        SMTPServer.EnableSsl = True

        SMTPServer.Send(MyMailMessage)
    End Sub


End Class