Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClAddress

   private addressId as Integer
   private address as String
   private address2 as String
   private district as String
   private  cityId  as ClCity
   private postalCode as String
   private phone as String
   private lastUpdate as Date


   public Property DataAddressId() as Integer
        Get
            Return addressId
        End Get
        Set(ByVal Value as Integer)
            addressId = Value
        End Set        
   End Property   
   public Property DataAddress() as String
        Get
            Return address
        End Get
        Set(ByVal Value as String)
            address = Value
        End Set        
   End Property   
   public Property DataAddress2() as String
        Get
            Return address2
        End Get
        Set(ByVal Value as String)
            address2 = Value
        End Set        
   End Property   
   public Property DataDistrict() as String
        Get
            Return district
        End Get
        Set(ByVal Value as String)
            district = Value
        End Set        
   End Property   
   public Property DataCityId()  as ClCity
        Get
            Return cityId
        End Get
        Set(ByVal Value  as ClCity)
            cityId = Value
        End Set        
   End Property   
   public Property DataPostalCode() as String
        Get
            Return postalCode
        End Get
        Set(ByVal Value as String)
            postalCode = Value
        End Set        
   End Property   
   public Property DataPhone() as String
        Get
            Return phone
        End Get
        Set(ByVal Value as String)
            phone = Value
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

   Public Sub New (addressId    as Integer,address    as String,address2    as String,district    as String,cityId  as ClCity,postalCode    as String,phone    as String,lastUpdate    as Date)
		   dataAddressId = addressId
		   dataAddress = address
		   dataAddress2 = address2
		   dataDistrict = district
		   dataCityId = cityId
		   dataPostalCode = postalCode
		   dataPhone = phone
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (addressId    as Integer)
    dataAddressId = addressId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "addressId" & chr(34) & ":" & chr(34) & dataAddressId & chr(34) _
		    & "," & chr(34) & "address" & chr(34) & ":" & chr(34) & dataAddress & chr(34) _
		    & "," & chr(34) & "address2" & chr(34) & ":" & chr(34) & dataAddress2 & chr(34) _
		    & "," & chr(34) & "district" & chr(34) & ":" & chr(34) & dataDistrict & chr(34) _
		    & "," & chr(34) & "cityId" & chr(34) & ":" & chr(34) & dataCityId.ToString() & chr(34) _
		    & "," & chr(34) & "postalCode" & chr(34) & ":" & chr(34) & dataPostalCode & chr(34) _
		    & "," & chr(34) & "phone" & chr(34) & ":" & chr(34) & dataPhone & chr(34) _
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
