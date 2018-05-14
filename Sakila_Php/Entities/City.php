<?PHP
class City implements JsonSerializable{

   private $cityId;
   private $city;
   private $lastUpdate;


   public function getCityId(){
        return $this->cityId;
   }
   public function setCityId($cityId){
        $this->cityId = $cityId;
   }
   
   public function getCity(){
        return $this->city;
   }
   public function setCity($city){
        $this->city = $city;
   }
   
   public function getCountryId(){
        return $this->countryId;
   }
   public function setCountryId($countryId){
        $this->countryId = $countryId;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function City($cityId,$city='',$countryId='',$lastUpdate=''){
		   $this->setCityId($cityId);
		   $this->setCity($city);
		   $this->setCountryId($countryId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($cityId,$city='',$countryId='',$lastUpdate='') {
		   $this->setCityId($cityId);
		   $this->setCity($city);
		   $this->setCountryId($countryId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "cityId" . chr(34) . ":" . chr(34) . $this->getCityId() . chr(34) 
		    . "," . chr(34) . "city" . chr(34) . ":" . chr(34) . $this->getCity() . chr(34) 
		    . "," . chr(34) . "countryId" . chr(34) . ":" . chr(34) . $this->getCountryId() . chr(34) 
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
//$actor = new City();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
