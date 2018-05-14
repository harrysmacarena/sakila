Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegStaff
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOStaff.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( staff as ClStaff) as Boolean
                        Return DAO.DAOStaff.SelectOne(staff)     
                    End Function
                    Public  Shared Function crear( staff as ClStaff) as Integer
                        Return DAO.DAOStaff.SqlInsert(staff)     
                    End Function
                    Public  Shared Function eliminar( staff as ClStaff) as Integer
                        Return DAO.DAOStaff.SqlDelete(staff)     
                    End Function
                    Public  Shared Function actualizar( staff as ClStaff) as Integer
                        Return DAO.DAOStaff.SqlUpdate(staff)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
