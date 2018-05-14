Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegInventory
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOInventory.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( inventory as ClInventory) as Boolean
                        Return DAO.DAOInventory.SelectOne(inventory)     
                    End Function
                    Public  Shared Function crear( inventory as ClInventory) as Integer
                        Return DAO.DAOInventory.SqlInsert(inventory)     
                    End Function
                    Public  Shared Function eliminar( inventory as ClInventory) as Integer
                        Return DAO.DAOInventory.SqlDelete(inventory)     
                    End Function
                    Public  Shared Function actualizar( inventory as ClInventory) as Integer
                        Return DAO.DAOInventory.SqlUpdate(inventory)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
