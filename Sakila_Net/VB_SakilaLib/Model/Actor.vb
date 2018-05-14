Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClActor

   private actorId as Integer
   private firstName as String
   private lastName as String
   private lastUpdate as Date


   public Property DataActorId() as Integer
        Get
            Return actorId
        End Get
        Set(ByVal Value as Integer)
            actorId = Value
        End Set        
   End Property   
   public Property DataFirstName() as String
        Get
            Return firstName
        End Get
        Set(ByVal Value as String)
            firstName = Value
        End Set        
   End Property   
   public Property DataLastName() as String
        Get
            Return lastName
        End Get
        Set(ByVal Value as String)
            lastName = Value
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

   Public Sub New (actorId    as Integer,firstName    as String,lastName    as String,lastUpdate    as Date)
		   dataActorId = actorId
		   dataFirstName = firstName
		   dataLastName = lastName
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (actorId    as Integer)
    dataActorId = actorId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "actorId" & chr(34) & ":" & chr(34) & dataActorId & chr(34) _
		    & "," & chr(34) & "firstName" & chr(34) & ":" & chr(34) & dataFirstName & chr(34) _
		    & "," & chr(34) & "lastName" & chr(34) & ":" & chr(34) & dataLastName & chr(34) _
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
