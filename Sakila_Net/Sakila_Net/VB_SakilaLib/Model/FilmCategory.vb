Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClFilmCategory

   private  filmId  as ClFilm
   private  categoryId  as ClCategory
   private lastUpdate as Date


   public Property DataFilmId()  as ClFilm
        Get
            Return filmId
        End Get
        Set(ByVal Value  as ClFilm)
            filmId = Value
        End Set        
   End Property   
   public Property DataCategoryId()  as ClCategory
        Get
            Return categoryId
        End Get
        Set(ByVal Value  as ClCategory)
            categoryId = Value
        End Set        
   End Property   
   public Property DataLastUpdate() as Date
        Get
            Return lastUpdate
        End Get
        Set(ByVal Value as Date)
            lastUpdate = Value
        End Set        
   End Property   

   Public Sub New (filmId  as ClFilm,categoryId  as ClCategory,lastUpdate    as Date)
		   dataFilmId = filmId
		   dataCategoryId = categoryId
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (filmId  as ClFilm,categoryId  as ClCategory)
    dataFilmId = filmId
    dataCategoryId = categoryId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "filmId" & chr(34) & ":" & chr(34) & dataFilmId.ToString() & chr(34) _
		    & "," & chr(34) & "categoryId" & chr(34) & ":" & chr(34) & dataCategoryId.ToString() & chr(34) _
		    & "," & chr(34) & "lastUpdate" & chr(34) & ":" & chr(34) & dataLastUpdate & chr(34) _
		 & "}"
   End Function   
   public Sub imprimir()
        Console.WriteLine(ToString())
   End Sub
   public Function jsonSerialize()
           return "get_object_vars($this);"
   End Function   
End Class
         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
