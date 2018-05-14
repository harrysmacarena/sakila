Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegMarca
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOMarca.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( marca as ClMarca) as Boolean
                        Return DAO.DAOMarca.SelectOne(marca)     
                    End Function
                    Public  Shared Function crear( marca as ClMarca) as Integer
                        Return DAO.DAOMarca.SqlInsert(marca)     
                    End Function
                    Public  Shared Function eliminar( marca as ClMarca) as Integer
                        Return DAO.DAOMarca.SqlDelete(marca)     
                    End Function
                    Public  Shared Function actualizar( marca as ClMarca) as Integer
                        Return DAO.DAOMarca.SqlUpdate(marca)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
