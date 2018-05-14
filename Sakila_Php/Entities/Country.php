<?PHP
class Country implements JsonSerializable{

   private $countryId;
   private $country;
   private $lastUpdate;


   public function getCountryId(){
        return $this->countryId;
   }
   public function setCountryId($countryId){
        $this->countryId = $countryId;
   }
   
   public function getCountry(){
        return $this->country;
   }
   public function setCountry($country){
        $this->country = $country;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Country($countryId,$country='',$lastUpdate=''){
		   $this->setCountryId($countryId);
		   $this->setCountry($country);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($countryId,$country='',$lastUpdate='') {
		   $this->setCountryId($countryId);
		   $this->setCountry($country);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "countryId" . chr(34) . ":" . chr(34) . $this->getCountryId() . chr(34) 
		    . "," . chr(34) . "country" . chr(34) . ":" . chr(34) . $this->getCountry() . chr(34) 
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
//$actor = new Country();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
