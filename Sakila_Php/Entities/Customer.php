<?PHP
class Customer implements JsonSerializable{

   private $customerId;
   private $firstName;
   private $lastName;
   private $email;
   private $active;
   private $createDate;
   private $lastUpdate;


   public function getCustomerId(){
        return $this->customerId;
   }
   public function setCustomerId($customerId){
        $this->customerId = $customerId;
   }
   
   public function getStoreId(){
        return $this->storeId;
   }
   public function setStoreId($storeId){
        $this->storeId = $storeId;
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
   
   public function getEmail(){
        return $this->email;
   }
   public function setEmail($email){
        $this->email = $email;
   }
   
   public function getAddressId(){
        return $this->addressId;
   }
   public function setAddressId($addressId){
        $this->addressId = $addressId;
   }
   
   public function getActive(){
        return $this->active;
   }
   public function setActive($active){
        $this->active = $active;
   }
   
   public function getCreateDate(){
        return $this->createDate;
   }
   public function setCreateDate($createDate){
        $this->createDate = $createDate;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Customer($customerId,$storeId='',$firstName='',$lastName='',$email='',$addressId='',$active='',$createDate='',$lastUpdate=''){
		   $this->setCustomerId($customerId);
		   $this->setStoreId($storeId);
		   $this->setFirstName($firstName);
		   $this->setLastName($lastName);
		   $this->setEmail($email);
		   $this->setAddressId($addressId);
		   $this->setActive($active);
		   $this->setCreateDate($createDate);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($customerId,$storeId='',$firstName='',$lastName='',$email='',$addressId='',$active='',$createDate='',$lastUpdate='') {
		   $this->setCustomerId($customerId);
		   $this->setStoreId($storeId);
		   $this->setFirstName($firstName);
		   $this->setLastName($lastName);
		   $this->setEmail($email);
		   $this->setAddressId($addressId);
		   $this->setActive($active);
		   $this->setCreateDate($createDate);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "customerId" . chr(34) . ":" . chr(34) . $this->getCustomerId() . chr(34) 
		    . "," . chr(34) . "storeId" . chr(34) . ":" . chr(34) . $this->getStoreId() . chr(34) 
		    . "," . chr(34) . "firstName" . chr(34) . ":" . chr(34) . $this->getFirstName() . chr(34) 
		    . "," . chr(34) . "lastName" . chr(34) . ":" . chr(34) . $this->getLastName() . chr(34) 
		    . "," . chr(34) . "email" . chr(34) . ":" . chr(34) . $this->getEmail() . chr(34) 
		    . "," . chr(34) . "addressId" . chr(34) . ":" . chr(34) . $this->getAddressId() . chr(34) 
		    . "," . chr(34) . "active" . chr(34) . ":" . chr(34) . $this->getActive() . chr(34) 
		    . "," . chr(34) . "createDate" . chr(34) . ":" . chr(34) . $this->getCreateDate() . chr(34) 
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
//$actor = new Customer();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
