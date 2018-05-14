Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClCountry

   private countryId as Integer
   private country as String
   private lastUpdate as Date


   public Property DataCountryId() as Integer
        Get
            Return countryId
        End Get
        Set(ByVal Value as Integer)
            countryId = Value
        End Set        
   End Property   
   public Property DataCountry() as String
        Get
            Return country
        End Get
        Set(ByVal Value as String)
            country = Value
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

   Public Sub New (countryId    as Integer,country    as String,lastUpdate    as Date)
		   dataCountryId = countryId
		   dataCountry = country
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (countryId    as Integer)
    dataCountryId = countryId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "countryId" & chr(34) & ":" & chr(34) & dataCountryId & chr(34) _
		    & "," & chr(34) & "country" & chr(34) & ":" & chr(34) & dataCountry & chr(34) _
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
