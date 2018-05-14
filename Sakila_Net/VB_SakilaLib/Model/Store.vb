Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClStore

   private storeId as Integer
   private managerStaffId as Integer
   private  addressId  as ClAddress
   private lastUpdate as Date


   public Property DataStoreId() as Integer
        Get
            Return storeId
        End Get
        Set(ByVal Value as Integer)
            storeId = Value
        End Set        
   End Property   
   public Property DataManagerStaffId() as Integer
        Get
            Return managerStaffId
        End Get
        Set(ByVal Value as Integer)
            managerStaffId = Value
        End Set        
   End Property   
   public Property DataAddressId()  as ClAddress
        Get
            Return addressId
        End Get
        Set(ByVal Value  as ClAddress)
            addressId = Value
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

   Public Sub New (storeId    as Integer,managerStaffId    as Integer,addressId  as ClAddress,lastUpdate    as Date)
		   dataStoreId = storeId
		   dataManagerStaffId = managerStaffId
		   dataAddressId = addressId
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (storeId    as Integer)
    dataStoreId = storeId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "storeId" & chr(34) & ":" & chr(34) & dataStoreId & chr(34) _
		    & "," & chr(34) & "managerStaffId" & chr(34) & ":" & chr(34) & dataManagerStaffId & chr(34) _
		    & "," & chr(34) & "addressId" & chr(34) & ":" & chr(34) & dataAddressId.ToString() & chr(34) _
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
