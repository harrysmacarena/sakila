Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClCustomer

   private customerId as Integer
   private  storeId  as ClStore
   private firstName as String
   private lastName as String
   private email as String
   private  addressId  as ClAddress
   private active as Integer
   private createDate as Date
   private lastUpdate as Date


   public Property DataCustomerId() as Integer
        Get
            Return customerId
        End Get
        Set(ByVal Value as Integer)
            customerId = Value
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
   public Property DataEmail() as String
        Get
            Return email
        End Get
        Set(ByVal Value as String)
            email = Value
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
   public Property DataActive() as Integer
        Get
            Return active
        End Get
        Set(ByVal Value as Integer)
            active = Value
        End Set        
   End Property   
   public Property DataCreateDate() as Date
        Get
            Return createDate
        End Get
        Set(ByVal Value as Date)
            createDate = Value
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

   Public Sub New (customerId    as Integer,storeId  as ClStore,firstName    as String,lastName    as String,email    as String,addressId  as ClAddress,active    as Integer,createDate    as Date,lastUpdate    as Date)
		   dataCustomerId = customerId
		   dataStoreId = storeId
		   dataFirstName = firstName
		   dataLastName = lastName
		   dataEmail = email
		   dataAddressId = addressId
		   dataActive = active
		   dataCreateDate = createDate
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (customerId    as Integer)
    dataCustomerId = customerId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "customerId" & chr(34) & ":" & chr(34) & dataCustomerId & chr(34) _
		    & "," & chr(34) & "storeId" & chr(34) & ":" & chr(34) & dataStoreId.ToString() & chr(34) _
		    & "," & chr(34) & "firstName" & chr(34) & ":" & chr(34) & dataFirstName & chr(34) _
		    & "," & chr(34) & "lastName" & chr(34) & ":" & chr(34) & dataLastName & chr(34) _
		    & "," & chr(34) & "email" & chr(34) & ":" & chr(34) & dataEmail & chr(34) _
		    & "," & chr(34) & "addressId" & chr(34) & ":" & chr(34) & dataAddressId.ToString() & chr(34) _
		    & "," & chr(34) & "active" & chr(34) & ":" & chr(34) & dataActive & chr(34) _
		    & "," & chr(34) & "createDate" & chr(34) & ":" & chr(34) & dataCreateDate & chr(34) _
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
