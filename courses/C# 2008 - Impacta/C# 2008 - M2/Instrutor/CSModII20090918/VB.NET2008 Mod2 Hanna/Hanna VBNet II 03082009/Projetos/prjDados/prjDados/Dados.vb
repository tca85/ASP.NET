﻿Public Class Dados
    Public Shared Function StringDeConexao() As String
        Return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\SQLExpress"
    End Function
End Class
