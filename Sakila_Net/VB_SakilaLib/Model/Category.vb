Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClCategory

   private categoryId as Integer
   private name as String
   private lastUpdate as Date


   public Property DataCategoryId() as Integer
        Get
            Return categoryId
        End Get
        Set(ByVal Value as Integer)
            categoryId = Value
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

   Public Sub New (categoryId    as Integer,name    as String,lastUpdate    as Date)
		   dataCategoryId = categoryId
		   dataName = name
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (categoryId    as Integer)
    dataCategoryId = categoryId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "categoryId" & chr(34) & ":" & chr(34) & dataCategoryId & chr(34) _
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
