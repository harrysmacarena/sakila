﻿Imports System.Data.SqlClient
Namespace Cl
    Namespace Harrys
        Namespace BD
            Public Class MyBD
                Dim Cmd As SqlCommand
                Dim Cnn As SqlConnection
                Private Shared ReadOnly _instance As New Lazy(Of MyBD)(Function() New MyBD(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)
                Private Sub New()
                    Cnn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Trabajo_Plantillas\BaseSqlServer\Sakila.mdf;Integrated Security=True;Connect Timeout=30")
                    Cnn.Open()
                End Sub
                Public Shared ReadOnly Property getInstance() As MyBD
                    Get
                        Return _instance.Value
                    End Get
                End Property
                Public Function SqlSelect(StSql As String, nPagina As Integer, cantidad As Integer) As DataTable
                    Cmd = New SqlClient.SqlCommand(StSql, Cnn)
                    Dim dt As DataTable = New DataTable()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(Cmd)
                    da.Fill(dt)
                    Return dt
                End Function
                Public Function SqlSelect(StSql As String) As DataTable
                    Return SqlSelect(StSql, 1, 1)
                End Function
                Public Function SqlEjecutar(StSql As String) As Integer
                    Cmd = New SqlClient.SqlCommand(StSql, Cnn)
                    Return Cmd.ExecuteNonQuery()
                End Function
            End Class
        End Namespace
    End Namespace
End Namespace
