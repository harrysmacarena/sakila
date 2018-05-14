Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegCountry
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOCountry.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( country as ClCountry) as Boolean
                        Return DAO.DAOCountry.SelectOne(country)     
                    End Function
                    Public  Shared Function crear( country as ClCountry) as Integer
                        Return DAO.DAOCountry.SqlInsert(country)     
                    End Function
                    Public  Shared Function eliminar( country as ClCountry) as Integer
                        Return DAO.DAOCountry.SqlDelete(country)     
                    End Function
                    Public  Shared Function actualizar( country as ClCountry) as Integer
                        Return DAO.DAOCountry.SqlUpdate(country)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
