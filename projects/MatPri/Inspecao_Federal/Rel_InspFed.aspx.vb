Imports System.Web
Imports System.Data

Partial Class Inspecao_Federal_Rel_InspFed
    Inherits System.Web.UI.Page
    Private TipDoc(9) As String

    Protected Sub imb_Imprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_Imprimir.Click
        If Me.Page.IsValid = True Then
            If txt_DataRecI.Text = "" Or _
               txt_DataRecF.Text = "" Then
                Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Faltam dados a serem preenchidos');</script>")
            Else
                Dim jscript As String = ""
                TipDoc = Session("arrTipoDocumento")
                Session("ddlLocalizacao") = ddl_Localizacao.SelectedValue
                Session("ddlRemetente") = ddl_Remetente.SelectedValue
                Session("txtDataRecI") = txt_DataRecI.Text
                Session("txtDataRecF") = txt_DataRecF.Text
                If Request.Browser.Browser = "IE" Then
                    If Session("Resolucao") = "768x1024" Then
                        jscript += "<script language='JavaScript'>"
                        jscript += "window.open('Rep_InspFed.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1005, height=695, left= 5, top=5')"
                        jscript += "</script>"
                        ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
                    ElseIf Session("Resolucao") = "600x800" Then
                        jscript += "<script language='JavaScript'>"
                        jscript += "window.open('Rep_InspFed.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=780, height=530, left= 5, top=5')"
                        jscript += "</script>"
                        ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
                    Else
                        jscript += "<script language='JavaScript'>"
                        jscript += "window.open('Rep_InspFed.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1005, height=695, left= 5, top=5')"
                        jscript += "</script>"
                        ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
                    End If
                Else
                    jscript += "<script language='JavaScript'>"
                    jscript += "window.open('Rep_InspFed.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1005, height=695, left= 5, top=5')"
                    jscript += "</script>"
                    ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
                End If
            End If
        End If
    End Sub

    Protected Sub rdlSelecione_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdlSelecione.CheckedChanged
        Dim jscript As String = ""
        jscript += "<script language='JavaScript'>"
        jscript += "window.open('../TipoDocumento.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=200, height=325, left=350, top=250')"
        jscript += "</script>"
        ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
    End Sub

    Protected Sub rdlTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdlTodos.CheckedChanged
        Dim i As Integer
        For i = 0 To 9
            Select Case i
                Case 0
                    TipDoc(0) = "01"
                Case 1
                    TipDoc(1) = "02"
                Case 2
                    TipDoc(2) = "03"
                Case 3
                    TipDoc(3) = "04"
                Case 4
                    TipDoc(4) = "92"
                Case 5
                    TipDoc(5) = "94"
                Case 6
                    TipDoc(6) = "96"
                Case 7
                    TipDoc(7) = "97"
                Case 8
                    TipDoc(8) = "98"
                Case 9
                    TipDoc(9) = "99"
            End Select
        Next
        Session("arrTipoDocumento") = TipDoc
    End Sub
End Class