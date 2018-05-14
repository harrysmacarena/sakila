Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegStore
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOStore.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( store as ClStore) as Boolean
                        Return DAO.DAOStore.SelectOne(store)     
                    End Function
                    Public  Shared Function crear( store as ClStore) as Integer
                        Return DAO.DAOStore.SqlInsert(store)     
                    End Function
                    Public  Shared Function eliminar( store as ClStore) as Integer
                        Return DAO.DAOStore.SqlDelete(store)     
                    End Function
                    Public  Shared Function actualizar( store as ClStore) as Integer
                        Return DAO.DAOStore.SqlUpdate(store)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
