Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClFilmActor

   private  actorId  as ClActor
   private  filmId  as ClFilm
   private lastUpdate as Date


   public Property DataActorId()  as ClActor
        Get
            Return actorId
        End Get
        Set(ByVal Value  as ClActor)
            actorId = Value
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
   public Property DataLastUpdate() as Date
        Get
            Return lastUpdate
        End Get
        Set(ByVal Value as Date)
            lastUpdate = Value
        End Set        
   End Property   

   Public Sub New (actorId  as ClActor,filmId  as ClFilm,lastUpdate    as Date)
		   dataActorId = actorId
		   dataFilmId = filmId
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (actorId  as ClActor,filmId  as ClFilm)
    dataActorId = actorId
    dataFilmId = filmId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "actorId" & chr(34) & ":" & chr(34) & dataActorId.ToString() & chr(34) _
		    & "," & chr(34) & "filmId" & chr(34) & ":" & chr(34) & dataFilmId.ToString() & chr(34) _
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
