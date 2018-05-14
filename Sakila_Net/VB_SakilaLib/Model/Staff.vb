Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClStaff

   private staffId as Integer
   private firstName as String
   private lastName as String
   private  addressId  as ClAddress
   private picture as String
   private email as String
   private  storeId  as ClStore
   private active as Integer
   private username as String
   private password as String
   private lastUpdate as Date


   public Property DataStaffId() as Integer
        Get
            Return staffId
        End Get
        Set(ByVal Value as Integer)
            staffId = Value
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
   public Property DataAddressId()  as ClAddress
        Get
            Return addressId
        End Get
        Set(ByVal Value  as ClAddress)
            addressId = Value
        End Set        
   End Property   
   public Property DataPicture() as String
        Get
            Return picture
        End Get
        Set(ByVal Value as String)
            picture = Value
        End Set        
   End Property   
   public Property DataEmail() as String
        Get
            Return email
        End Get
        Set(ByVal Value as String)
            email = Value
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
   public Property DataActive() as Integer
        Get
            Return active
        End Get
        Set(ByVal Value as Integer)
            active = Value
        End Set        
   End Property   
   public Property DataUsername() as String
        Get
            Return username
        End Get
        Set(ByVal Value as String)
            username = Value
        End Set        
   End Property   
   public Property DataPassword() as String
        Get
            Return password
        End Get
        Set(ByVal Value as String)
            password = Value
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

   Public Sub New (staffId    as Integer,firstName    as String,lastName    as String,addressId  as ClAddress,picture    as String,email    as String,storeId  as ClStore,active    as Integer,username    as String,password    as String,lastUpdate    as Date)
		   dataStaffId = staffId
		   dataFirstName = firstName
		   dataLastName = lastName
		   dataAddressId = addressId
		   dataPicture = picture
		   dataEmail = email
		   dataStoreId = storeId
		   dataActive = active
		   dataUsername = username
		   dataPassword = password
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (staffId    as Integer)
    dataStaffId = staffId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "staffId" & chr(34) & ":" & chr(34) & dataStaffId & chr(34) _
		    & "," & chr(34) & "firstName" & chr(34) & ":" & chr(34) & dataFirstName & chr(34) _
		    & "," & chr(34) & "lastName" & chr(34) & ":" & chr(34) & dataLastName & chr(34) _
		    & "," & chr(34) & "addressId" & chr(34) & ":" & chr(34) & dataAddressId.ToString() & chr(34) _
		    & "," & chr(34) & "picture" & chr(34) & ":" & chr(34) & dataPicture & chr(34) _
		    & "," & chr(34) & "email" & chr(34) & ":" & chr(34) & dataEmail & chr(34) _
		    & "," & chr(34) & "storeId" & chr(34) & ":" & chr(34) & dataStoreId.ToString() & chr(34) _
		    & "," & chr(34) & "active" & chr(34) & ":" & chr(34) & dataActive & chr(34) _
		    & "," & chr(34) & "username" & chr(34) & ":" & chr(34) & dataUsername & chr(34) _
		    & "," & chr(34) & "password" & chr(34) & ":" & chr(34) & dataPassword & chr(34) _
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
