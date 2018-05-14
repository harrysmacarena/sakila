Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegTrensito
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOTrensito.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( trensito as ClTrensito) as Boolean
                        Return DAO.DAOTrensito.SelectOne(trensito)     
                    End Function
                    Public  Shared Function crear( trensito as ClTrensito) as Integer
                        Return DAO.DAOTrensito.SqlInsert(trensito)     
                    End Function
                    Public  Shared Function eliminar( trensito as ClTrensito) as Integer
                        Return DAO.DAOTrensito.SqlDelete(trensito)     
                    End Function
                    Public  Shared Function actualizar( trensito as ClTrensito) as Integer
                        Return DAO.DAOTrensito.SqlUpdate(trensito)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
