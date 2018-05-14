<?PHP
class Language implements JsonSerializable{

   private $languageId;
   private $name;
   private $lastUpdate;


   public function getLanguageId(){
        return $this->languageId;
   }
   public function setLanguageId($languageId){
        $this->languageId = $languageId;
   }
   
   public function getName(){
        return $this->name;
   }
   public function setName($name){
        $this->name = $name;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Language($languageId,$name='',$lastUpdate=''){
		   $this->setLanguageId($languageId);
		   $this->setName($name);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($languageId,$name='',$lastUpdate='') {
		   $this->setLanguageId($languageId);
		   $this->setName($name);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "languageId" . chr(34) . ":" . chr(34) . $this->getLanguageId() . chr(34) 
		    . "," . chr(34) . "name" . chr(34) . ":" . chr(34) . $this->getName() . chr(34) 
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
//$actor = new Language();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
