Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClMarca

   private id as Integer
   private nombre as String


   public Property DataId() as Integer
        Get
            Return id
        End Get
        Set(ByVal Value as Integer)
            id = Value
        End Set        
   End Property   
   public Property DataNombre() as String
        Get
            Return nombre
        End Get
        Set(ByVal Value as String)
            nombre = Value
        End Set        
   End Property   

   Public Sub New (id    as Integer,nombre    as String)
		   dataId = id
		   dataNombre = nombre
   End Sub
   Public Sub New (id    as Integer)
    dataId = id
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "id" & chr(34) & ":" & chr(34) & dataId & chr(34) _
		    & "," & chr(34) & "nombre" & chr(34) & ":" & chr(34) & dataNombre & chr(34) _
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
