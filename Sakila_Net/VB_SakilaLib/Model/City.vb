Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClCity

   private cityId as Integer
   private city as String
   private  countryId  as ClCountry
   private lastUpdate as Date


   public Property DataCityId() as Integer
        Get
            Return cityId
        End Get
        Set(ByVal Value as Integer)
            cityId = Value
        End Set        
   End Property   
   public Property DataCity() as String
        Get
            Return city
        End Get
        Set(ByVal Value as String)
            city = Value
        End Set        
   End Property   
   public Property DataCountryId()  as ClCountry
        Get
            Return countryId
        End Get
        Set(ByVal Value  as ClCountry)
            countryId = Value
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

   Public Sub New (cityId    as Integer,city    as String,countryId  as ClCountry,lastUpdate    as Date)
		   dataCityId = cityId
		   dataCity = city
		   dataCountryId = countryId
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (cityId    as Integer)
    dataCityId = cityId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "cityId" & chr(34) & ":" & chr(34) & dataCityId & chr(34) _
		    & "," & chr(34) & "city" & chr(34) & ":" & chr(34) & dataCity & chr(34) _
		    & "," & chr(34) & "countryId" & chr(34) & ":" & chr(34) & dataCountryId.ToString() & chr(34) _
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
