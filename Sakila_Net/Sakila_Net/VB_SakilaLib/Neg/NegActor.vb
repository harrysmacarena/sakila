Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegActor
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOActor.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( actor as ClActor) as Boolean
                        Return DAO.DAOActor.SelectOne(actor)     
                    End Function
                    Public  Shared Function crear( actor as ClActor) as Integer
                        Return DAO.DAOActor.SqlInsert(actor)     
                    End Function
                    Public  Shared Function eliminar( actor as ClActor) as Integer
                        Return DAO.DAOActor.SqlDelete(actor)     
                    End Function
                    Public  Shared Function actualizar( actor as ClActor) as Integer
                        Return DAO.DAOActor.SqlUpdate(actor)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
