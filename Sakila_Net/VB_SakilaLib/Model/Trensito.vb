Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClTrensito

   private id as Integer
   private nombre as String
   private largo as Integer
   private idMarca as Integer


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
   public Property DataLargo() as Integer
        Get
            Return largo
        End Get
        Set(ByVal Value as Integer)
            largo = Value
        End Set        
   End Property   
   public Property DataIdMarca() as Integer
        Get
            Return idMarca
        End Get
        Set(ByVal Value as Integer)
            idMarca = Value
        End Set        
   End Property   

   Public Sub New (id    as Integer,nombre    as String,largo    as Integer,idMarca    as Integer)
		   dataId = id
		   dataNombre = nombre
		   dataLargo = largo
		   dataIdMarca = idMarca
   End Sub
   Public Sub New (id    as Integer)
    dataId = id
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "id" & chr(34) & ":" & chr(34) & dataId & chr(34) _
		    & "," & chr(34) & "nombre" & chr(34) & ":" & chr(34) & dataNombre & chr(34) _
		    & "," & chr(34) & "largo" & chr(34) & ":" & chr(34) & dataLargo & chr(34) _
		    & "," & chr(34) & "idMarca" & chr(34) & ":" & chr(34) & dataIdMarca & chr(34) _
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
