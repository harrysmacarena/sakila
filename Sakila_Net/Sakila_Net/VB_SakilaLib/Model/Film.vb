Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace Model
public class ClFilm

   private filmId as Integer
   private title as String
   private description as String
   private releaseYear as Integer
   private  languageId  as ClLanguage
   private originalLanguageId as Integer
   private rentalDuration as Integer
   private rentalRate as Integer
   private length as Integer
   private replacementCost as Integer
   private rating as String
   private specialFeatures as String
   private lastUpdate as Date


   public Property DataFilmId() as Integer
        Get
            Return filmId
        End Get
        Set(ByVal Value as Integer)
            filmId = Value
        End Set        
   End Property   
   public Property DataTitle() as String
        Get
            Return title
        End Get
        Set(ByVal Value as String)
            title = Value
        End Set        
   End Property   
   public Property DataDescription() as String
        Get
            Return description
        End Get
        Set(ByVal Value as String)
            description = Value
        End Set        
   End Property   
   public Property DataReleaseYear() as Integer
        Get
            Return releaseYear
        End Get
        Set(ByVal Value as Integer)
            releaseYear = Value
        End Set        
   End Property   
   public Property DataLanguageId()  as ClLanguage
        Get
            Return languageId
        End Get
        Set(ByVal Value  as ClLanguage)
            languageId = Value
        End Set        
   End Property   
   public Property DataOriginalLanguageId() as Integer
        Get
            Return originalLanguageId
        End Get
        Set(ByVal Value as Integer)
            originalLanguageId = Value
        End Set        
   End Property   
   public Property DataRentalDuration() as Integer
        Get
            Return rentalDuration
        End Get
        Set(ByVal Value as Integer)
            rentalDuration = Value
        End Set        
   End Property   
   public Property DataRentalRate() as Integer
        Get
            Return rentalRate
        End Get
        Set(ByVal Value as Integer)
            rentalRate = Value
        End Set        
   End Property   
   public Property DataLength() as Integer
        Get
            Return length
        End Get
        Set(ByVal Value as Integer)
            length = Value
        End Set        
   End Property   
   public Property DataReplacementCost() as Integer
        Get
            Return replacementCost
        End Get
        Set(ByVal Value as Integer)
            replacementCost = Value
        End Set        
   End Property   
   public Property DataRating() as String
        Get
            Return rating
        End Get
        Set(ByVal Value as String)
            rating = Value
        End Set        
   End Property   
   public Property DataSpecialFeatures() as String
        Get
            Return specialFeatures
        End Get
        Set(ByVal Value as String)
            specialFeatures = Value
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

   Public Sub New (filmId    as Integer,title    as String,description    as String,releaseYear    as Integer,languageId  as ClLanguage,originalLanguageId    as Integer,rentalDuration    as Integer,rentalRate    as Integer,length    as Integer,replacementCost    as Integer,rating    as String,specialFeatures    as String,lastUpdate    as Date)
		   dataFilmId = filmId
		   dataTitle = title
		   dataDescription = description
		   dataReleaseYear = releaseYear
		   dataLanguageId = languageId
		   dataOriginalLanguageId = originalLanguageId
		   dataRentalDuration = rentalDuration
		   dataRentalRate = rentalRate
		   dataLength = length
		   dataReplacementCost = replacementCost
		   dataRating = rating
		   dataSpecialFeatures = specialFeatures
		   dataLastUpdate = lastUpdate
   End Sub
   Public Sub New (filmId    as Integer)
    dataFilmId = filmId
   End Sub


   public Overrides Function  ToString() As String
        '// Registro JSon
		return "{" _ 
		    & "," & chr(34) & "filmId" & chr(34) & ":" & chr(34) & dataFilmId & chr(34) _
		    & "," & chr(34) & "title" & chr(34) & ":" & chr(34) & dataTitle & chr(34) _
		    & "," & chr(34) & "description" & chr(34) & ":" & chr(34) & dataDescription & chr(34) _
		    & "," & chr(34) & "releaseYear" & chr(34) & ":" & chr(34) & dataReleaseYear & chr(34) _
		    & "," & chr(34) & "languageId" & chr(34) & ":" & chr(34) & dataLanguageId.ToString() & chr(34) _
		    & "," & chr(34) & "originalLanguageId" & chr(34) & ":" & chr(34) & dataOriginalLanguageId & chr(34) _
		    & "," & chr(34) & "rentalDuration" & chr(34) & ":" & chr(34) & dataRentalDuration & chr(34) _
		    & "," & chr(34) & "rentalRate" & chr(34) & ":" & chr(34) & dataRentalRate & chr(34) _
		    & "," & chr(34) & "length" & chr(34) & ":" & chr(34) & dataLength & chr(34) _
		    & "," & chr(34) & "replacementCost" & chr(34) & ":" & chr(34) & dataReplacementCost & chr(34) _
		    & "," & chr(34) & "rating" & chr(34) & ":" & chr(34) & dataRating & chr(34) _
		    & "," & chr(34) & "specialFeatures" & chr(34) & ":" & chr(34) & dataSpecialFeatures & chr(34) _
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
