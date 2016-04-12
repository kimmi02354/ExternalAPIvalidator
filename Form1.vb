Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Xml.Schema


Public Class Form1

    Public dc As New XmlDocument

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        'check AG data against schemas
        ' Dim dc As New XmlDocument

        'dc.Load(Me.AGXml.Text)

        Try

            Me.ConsTxt.Text = ""
            Me.ConsTxt.BackColor = Color.White

            dc.InnerXml = Me.AGXml.Text

            checkAGSchema(Me.lstFunctions.SelectedItem.ToString(), dc)

            PostDataToOperator(dc.InnerXml.ToString())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function checkAGSchema(ByVal xmlType As String, ByVal xmldoc As XmlDocument) As Boolean

        Try

            Dim schema As New XmlSchema()

            schema.SourceUri = Application.StartupPath.ToString() & "/schemas/" & xmlType & ".xsd"

            xmldoc.Schemas.Add("data", schema.SourceUri)
            xmldoc.Validate(AddressOf ValidationEventHandler)

            Me.ConsTxt.Text = "request message valid"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function

    Protected Sub ValidationEventHandler(ByVal sender As Object, ByVal e As ValidationEventArgs)

        Dim test As String = ""

        Select Case e.Severity
            Case XmlSeverityType.Error
                MsgBox(e.Message)
            Case XmlSeverityType.Warning
                MsgBox(e.Message)
        End Select

    End Sub

    Public Function PostDataToOperator(ByVal data As String) As String

        Try

            Me.ConsTxt.Text = "Posting data to server..."

            Dim postBuffer As Byte() = System.Text.Encoding.ASCII.GetBytes(data)

            Dim req As HttpWebRequest = DirectCast(WebRequest.Create(My.Settings.ServerLink), HttpWebRequest)
            req.Method = "POST"

            'write data to request
            req.ContentType = "application/x-www-form-urlencoded"
            req.ContentLength = postBuffer.Length
            req.Timeout = CInt(My.Settings.timeOutValue) 'to be configurable
            Dim requestStream As Stream = req.GetRequestStream()
            requestStream.Write(postBuffer, 0, postBuffer.Length)
            requestStream.Close()

            Dim Content As String = New StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd

            postBuffer = Nothing


            Me.ExtXML.Text = Content

            Me.ConsTxt.Text = "Data received..."
            Me.ConsTxt.BackColor = Color.Green

        Catch ex As Exception

            Me.ConsTxt.Text = ex.Message
            Me.ConsTxt.BackColor = Color.Red
            Return Nothing
        End Try

    End Function
    Private Sub lstFunctions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFunctions.SelectedIndexChanged

        ' Dim dc As New XmlDocument
        Try

            dc = New XmlDocument

            dc.Load(Application.StartupPath.ToString() & "/examples/" & LCase(lstFunctions.SelectedItem.ToString()) & ".xml")

            Me.AGXml.Text = dc.InnerXml.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
