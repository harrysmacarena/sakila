<?PHP
class Film implements JsonSerializable{

   private $filmId;
   private $title;
   private $description;
   private $releaseYear;
   private $rentalDuration;
   private $rentalRate;
   private $length;
   private $replacementCost;
   private $rating;
   private $specialFeatures;
   private $lastUpdate;


   public function getFilmId(){
        return $this->filmId;
   }
   public function setFilmId($filmId){
        $this->filmId = $filmId;
   }
   
   public function getTitle(){
        return $this->title;
   }
   public function setTitle($title){
        $this->title = $title;
   }
   
   public function getDescription(){
        return $this->description;
   }
   public function setDescription($description){
        $this->description = $description;
   }
   
   public function getReleaseYear(){
        return $this->releaseYear;
   }
   public function setReleaseYear($releaseYear){
        $this->releaseYear = $releaseYear;
   }
   
   public function getLanguageId(){
        return $this->languageId;
   }
   public function setLanguageId($languageId){
        $this->languageId = $languageId;
   }
   
   public function getOriginalLanguageId(){
        return $this->originalLanguageId;
   }
   public function setOriginalLanguageId($originalLanguageId){
        $this->originalLanguageId = $originalLanguageId;
   }
   
   public function getRentalDuration(){
        return $this->rentalDuration;
   }
   public function setRentalDuration($rentalDuration){
        $this->rentalDuration = $rentalDuration;
   }
   
   public function getRentalRate(){
        return $this->rentalRate;
   }
   public function setRentalRate($rentalRate){
        $this->rentalRate = $rentalRate;
   }
   
   public function getLength(){
        return $this->length;
   }
   public function setLength($length){
        $this->length = $length;
   }
   
   public function getReplacementCost(){
        return $this->replacementCost;
   }
   public function setReplacementCost($replacementCost){
        $this->replacementCost = $replacementCost;
   }
   
   public function getRating(){
        return $this->rating;
   }
   public function setRating($rating){
        $this->rating = $rating;
   }
   
   public function getSpecialFeatures(){
        return $this->specialFeatures;
   }
   public function setSpecialFeatures($specialFeatures){
        $this->specialFeatures = $specialFeatures;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Film($filmId,$title='',$description='',$releaseYear='',$languageId='',$originalLanguageId='',$rentalDuration='',$rentalRate='',$length='',$replacementCost='',$rating='',$specialFeatures='',$lastUpdate=''){
		   $this->setFilmId($filmId);
		   $this->setTitle($title);
		   $this->setDescription($description);
		   $this->setReleaseYear($releaseYear);
		   $this->setLanguageId($languageId);
		   $this->setOriginalLanguageId($originalLanguageId);
		   $this->setRentalDuration($rentalDuration);
		   $this->setRentalRate($rentalRate);
		   $this->setLength($length);
		   $this->setReplacementCost($replacementCost);
		   $this->setRating($rating);
		   $this->setSpecialFeatures($specialFeatures);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($filmId,$title='',$description='',$releaseYear='',$languageId='',$originalLanguageId='',$rentalDuration='',$rentalRate='',$length='',$replacementCost='',$rating='',$specialFeatures='',$lastUpdate='') {
		   $this->setFilmId($filmId);
		   $this->setTitle($title);
		   $this->setDescription($description);
		   $this->setReleaseYear($releaseYear);
		   $this->setLanguageId($languageId);
		   $this->setOriginalLanguageId($originalLanguageId);
		   $this->setRentalDuration($rentalDuration);
		   $this->setRentalRate($rentalRate);
		   $this->setLength($length);
		   $this->setReplacementCost($replacementCost);
		   $this->setRating($rating);
		   $this->setSpecialFeatures($specialFeatures);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "filmId" . chr(34) . ":" . chr(34) . $this->getFilmId() . chr(34) 
		    . "," . chr(34) . "title" . chr(34) . ":" . chr(34) . $this->getTitle() . chr(34) 
		    . "," . chr(34) . "description" . chr(34) . ":" . chr(34) . $this->getDescription() . chr(34) 
		    . "," . chr(34) . "releaseYear" . chr(34) . ":" . chr(34) . $this->getReleaseYear() . chr(34) 
		    . "," . chr(34) . "languageId" . chr(34) . ":" . chr(34) . $this->getLanguageId() . chr(34) 
		    . "," . chr(34) . "originalLanguageId" . chr(34) . ":" . chr(34) . $this->getOriginalLanguageId() . chr(34) 
		    . "," . chr(34) . "rentalDuration" . chr(34) . ":" . chr(34) . $this->getRentalDuration() . chr(34) 
		    . "," . chr(34) . "rentalRate" . chr(34) . ":" . chr(34) . $this->getRentalRate() . chr(34) 
		    . "," . chr(34) . "length" . chr(34) . ":" . chr(34) . $this->getLength() . chr(34) 
		    . "," . chr(34) . "replacementCost" . chr(34) . ":" . chr(34) . $this->getReplacementCost() . chr(34) 
		    . "," . chr(34) . "rating" . chr(34) . ":" . chr(34) . $this->getRating() . chr(34) 
		    . "," . chr(34) . "specialFeatures" . chr(34) . ":" . chr(34) . $this->getSpecialFeatures() . chr(34) 
		    . "," . chr(34) . "lastUpdate" . chr(34) . ":" . chr(34) . $this->getLastUpdate() . chr(34) 
		 . "}";
   }   
   public function imprimir()
   {
        echo $this->__toString();
   }
   public function jsonSerialize()
   {
        return get_object_vars($this);
   }   
}
// Para realizar pruebas
//$actor = new Film();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
