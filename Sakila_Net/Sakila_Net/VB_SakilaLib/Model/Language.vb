Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClLanguage

   private languageId as Integer
   private name as String
   private lastUpdate as Date


   public Property DataLanguageId() as Integer
        Get
            Return languageId
        End Get
        Set(ByVal Value as Integer)
            languageId = Value
        End Set        
   End Property   
   public Property DataName() as String
        Get
            Return name
        End Get
        Set(ByVal Value as String)
            name = Value
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

   Public Sub New (languageId    as Integer,name    as String,lastUpdate    as Date)
		   dataLanguageId = languageId
		   dataName = name
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (languageId    as Integer)
    dataLanguageId = languageId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "languageId" & chr(34) & ":" & chr(34) & dataLanguageId & chr(34) _
		    & "," & chr(34) & "name" & chr(34) & ":" & chr(34) & dataName & chr(34) _
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
