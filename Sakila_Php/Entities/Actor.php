<?PHP
class Actor implements JsonSerializable{

   private $actorId;
   private $firstName;
   private $lastName;
   private $lastUpdate;


   public function getActorId(){
        return $this->actorId;
   }
   public function setActorId($actorId){
        $this->actorId = $actorId;
   }
   
   public function getFirstName(){
        return $this->firstName;
   }
   public function setFirstName($firstName){
        $this->firstName = $firstName;
   }
   
   public function getLastName(){
        return $this->lastName;
   }
   public function setLastName($lastName){
        $this->lastName = $lastName;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Actor($actorId,$firstName='',$lastName='',$lastUpdate=''){
		   $this->setActorId($actorId);
		   $this->setFirstName($firstName);
		   $this->setLastName($lastName);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($actorId,$firstName='',$lastName='',$lastUpdate='') {
		   $this->setActorId($actorId);
		   $this->setFirstName($firstName);
		   $this->setLastName($lastName);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "actorId" . chr(34) . ":" . chr(34) . $this->getActorId() . chr(34) 
		    . "," . chr(34) . "firstName" . chr(34) . ":" . chr(34) . $this->getFirstName() . chr(34) 
		    . "," . chr(34) . "lastName" . chr(34) . ":" . chr(34) . $this->getLastName() . chr(34) 
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
//$actor = new Actor();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
