Imports Microsoft.VisualBasic
Imports OrcaleServer20.ConexaoSQL20
Imports System.Data.OracleClient
Imports System.Data

Public Class clRecLeiteDes
    Public MsgErro As String
    Public CODLOC As String
    Public TIPREM As String
    Public TIPOMP As String
    Public TIPDOC As String
    Public CODREM As String
    Public TEORMGI As String
    Public TEORMGF As String
    Public DATRECI As String
    Public DATRECF As String

    Public Property PCodLoc() As String
        Get
            Return CODLOC
        End Get
        Set(ByVal value As String)
            CODLOC = value
        End Set
    End Property
    Public Property PTipRem() As String
        Get
            Return TIPREM
        End Get
        Set(ByVal value As String)
            TIPREM = value
        End Set
    End Property
    Public Property PTipoMp() As String
        Get
            Return TIPOMP
        End Get
        Set(ByVal value As String)
            TIPOMP = value
        End Set
    End Property
    Public Property PTipDoc() As String
        Get
            Return TIPDOC
        End Get
        Set(ByVal value As String)
            TIPDOC = value
        End Set
    End Property

    Public Property PCodRem() As String
        Get
            Return CODREM
        End Get
        Set(ByVal value As String)
            CODREM = value
        End Set
    End Property
    Public Property PTeorMgI() As String
        Get
            Return TEORMGI
        End Get
        Set(ByVal value As String)
            TEORMGI = value
        End Set
    End Property
    Public Property PTeorMgF() As String
        Get
            Return TEORMGF
        End Get
        Set(ByVal value As String)
            TEORMGF = value
        End Set
    End Property
    Public Property PDatRecI() As String
        Get
            Return DATRECI
        End Get
        Set(ByVal value As String)
            DATRECI = value
        End Set
    End Property
    Public Property PDatRecF() As String
        Get
            Return DATRECF
        End Get
        Set(ByVal value As String)
            DATRECF = value
        End Set
    End Property
    Public Function Imprimir(ByVal Conn As String) As DataTable
        Dim Fields() As String = {"P_CODLOC", "P_TIPREM", "P_TIPOMP", "P_TIPDOC", "P_CODREM", "P_TEORMGI", "P_TEORMGF", "P_DATRECI", "P_DATRECF"}
        Dim Param() As String = {CODLOC.ToString(), TIPREM.ToString(), TIPOMP.ToString(), TIPDOC.ToString(), CODREM.ToString(), TEORMGI.ToString(), TEORMGF.ToString(), DATRECI.ToString(), DATRECF.ToString()}
        Dim OConexao As clsOracleServer20 = New clsOracleServer20
        Return OConexao.AbrirDataTable(Conn, "PR_ADI_SEL_LEIDES", Fields, Param)
    End Function
End Class
