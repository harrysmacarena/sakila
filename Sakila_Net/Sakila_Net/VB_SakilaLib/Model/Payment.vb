Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClPayment

   private paymentId as Integer
   private  customerId  as ClCustomer
   private  staffId  as ClStaff
   private  rentalId  as ClRental
   private amount as Integer
   private paymentDate as Date
   private lastUpdate as Date


   public Property DataPaymentId() as Integer
        Get
            Return paymentId
        End Get
        Set(ByVal Value as Integer)
            paymentId = Value
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
   public Property DataStaffId()  as ClStaff
        Get
            Return staffId
        End Get
        Set(ByVal Value  as ClStaff)
            staffId = Value
        End Set        
   End Property   
   public Property DataRentalId()  as ClRental
        Get
            Return rentalId
        End Get
        Set(ByVal Value  as ClRental)
            rentalId = Value
        End Set        
   End Property   
   public Property DataAmount() as Integer
        Get
            Return amount
        End Get
        Set(ByVal Value as Integer)
            amount = Value
        End Set        
   End Property   
   public Property DataPaymentDate() as Date
        Get
            Return paymentDate
        End Get
        Set(ByVal Value as Date)
            paymentDate = Value
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

   Public Sub New (paymentId    as Integer,customerId  as ClCustomer,staffId  as ClStaff,rentalId  as ClRental,amount    as Integer,paymentDate    as Date,lastUpdate    as Date)
		   dataPaymentId = paymentId
		   dataCustomerId = customerId
		   dataStaffId = staffId
		   dataRentalId = rentalId
		   dataAmount = amount
		   dataPaymentDate = paymentDate
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (paymentId    as Integer)
    dataPaymentId = paymentId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "paymentId" & chr(34) & ":" & chr(34) & dataPaymentId & chr(34) _
		    & "," & chr(34) & "customerId" & chr(34) & ":" & chr(34) & dataCustomerId.ToString() & chr(34) _
		    & "," & chr(34) & "staffId" & chr(34) & ":" & chr(34) & dataStaffId.ToString() & chr(34) _
		    & "," & chr(34) & "rentalId" & chr(34) & ":" & chr(34) & dataRentalId.ToString() & chr(34) _
		    & "," & chr(34) & "amount" & chr(34) & ":" & chr(34) & dataAmount & chr(34) _
		    & "," & chr(34) & "paymentDate" & chr(34) & ":" & chr(34) & dataPaymentDate & chr(34) _
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
