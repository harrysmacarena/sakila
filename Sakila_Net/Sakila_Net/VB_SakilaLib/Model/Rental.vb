Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClRental

   private rentalId as Integer
   private rentalDate as Date
   private  inventoryId  as ClInventory
   private  customerId  as ClCustomer
   private returnDate as Date
   private  staffId  as ClStaff
   private lastUpdate as Date


   public Property DataRentalId() as Integer
        Get
            Return rentalId
        End Get
        Set(ByVal Value as Integer)
            rentalId = Value
        End Set        
   End Property   
   public Property DataRentalDate() as Date
        Get
            Return rentalDate
        End Get
        Set(ByVal Value as Date)
            rentalDate = Value
        End Set        
   End Property   
   public Property DataInventoryId()  as ClInventory
        Get
            Return inventoryId
        End Get
        Set(ByVal Value  as ClInventory)
            inventoryId = Value
        End Set        
   End Property   
   public Property DataCustomerId()  as ClCustomer
        Get
            Return customerId
        End Get
        Set(ByVal Value  as ClCustomer)
            customerId = Value
        End Set        
   End Property   
   public Property DataReturnDate() as Date
        Get
            Return returnDate
        End Get
        Set(ByVal Value as Date)
            returnDate = Value
        End Set        
   End Property   
   public Property DataStaffId()  as ClStaff
        Get
            Return staffId
        End Get
        Set(ByVal Value  as ClStaff)
            staffId = Value
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

   Public Sub New (rentalId    as Integer,rentalDate    as Date,inventoryId  as ClInventory,customerId  as ClCustomer,returnDate    as Date,staffId  as ClStaff,lastUpdate    as Date)
		   dataRentalId = rentalId
		   dataRentalDate = rentalDate
		   dataInventoryId = inventoryId
		   dataCustomerId = customerId
		   dataReturnDate = returnDate
		   dataStaffId = staffId
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (rentalId    as Integer)
    dataRentalId = rentalId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "rentalId" & chr(34) & ":" & chr(34) & dataRentalId & chr(34) _
		    & "," & chr(34) & "rentalDate" & chr(34) & ":" & chr(34) & dataRentalDate & chr(34) _
		    & "," & chr(34) & "inventoryId" & chr(34) & ":" & chr(34) & dataInventoryId.ToString() & chr(34) _
		    & "," & chr(34) & "customerId" & chr(34) & ":" & chr(34) & dataCustomerId.ToString() & chr(34) _
		    & "," & chr(34) & "returnDate" & chr(34) & ":" & chr(34) & dataReturnDate & chr(34) _
		    & "," & chr(34) & "staffId" & chr(34) & ":" & chr(34) & dataStaffId.ToString() & chr(34) _
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
