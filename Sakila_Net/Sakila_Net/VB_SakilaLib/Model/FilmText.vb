Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClFilmText

   private filmId as Integer
   private title as String
   private description as String


   public Property DataFilmId() as Integer
        Get
            Return filmId
        End Get
        Set(ByVal Value as Integer)
            filmId = Value
        End Set        
   End Property   
   public Property DataTitle() as String
        Get
            Return title
        End Get
        Set(ByVal Value as String)
            title = Value
        End Set        
   End Property   
   public Property DataDescription() as String
        Get
            Return description
        End Get
        Set(ByVal Value as String)
            description = Value
        End Set        
   End Property   

   Public Sub New (filmId    as Integer,title    as String,description    as String)
		   dataFilmId = filmId
		   dataTitle = title
		   dataDescription = description
   End Sub
   Public Sub New (filmId    as Integer)
    dataFilmId = filmId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "filmId" & chr(34) & ":" & chr(34) & dataFilmId & chr(34) _
		    & "," & chr(34) & "title" & chr(34) & ":" & chr(34) & dataTitle & chr(34) _
		    & "," & chr(34) & "description" & chr(34) & ":" & chr(34) & dataDescription & chr(34) _
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
