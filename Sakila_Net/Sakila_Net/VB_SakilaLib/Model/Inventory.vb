Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClInventory

   private inventoryId as Integer
   private  filmId  as ClFilm
   private  storeId  as ClStore
   private lastUpdate as Date


   public Property DataInventoryId() as Integer
        Get
            Return inventoryId
        End Get
        Set(ByVal Value as Integer)
            inventoryId = Value
        End Set        
   End Property   
   public Property DataFilmId()  as ClFilm
        Get
            Return filmId
        End Get
        Set(ByVal Value  as ClFilm)
            filmId = Value
        End Set        
   End Property   
   public Property DataStoreId()  as ClStore
        Get
            Return storeId
        End Get
        Set(ByVal Value  as ClStore)
            storeId = Value
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

   Public Sub New (inventoryId    as Integer,filmId  as ClFilm,storeId  as ClStore,lastUpdate    as Date)
		   dataInventoryId = inventoryId
		   dataFilmId = filmId
		   dataStoreId = storeId
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (inventoryId    as Integer)
    dataInventoryId = inventoryId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "inventoryId" & chr(34) & ":" & chr(34) & dataInventoryId & chr(34) _
		    & "," & chr(34) & "filmId" & chr(34) & ":" & chr(34) & dataFilmId.ToString() & chr(34) _
		    & "," & chr(34) & "storeId" & chr(34) & ":" & chr(34) & dataStoreId.ToString() & chr(34) _
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
