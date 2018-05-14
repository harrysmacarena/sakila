<?PHP
class Staff implements JsonSerializable{

   private $staffId;
   private $firstName;
   private $lastName;
   private $email;
   private $active;
   private $username;
   private $password;
   private $lastUpdate;


   public function getStaffId(){
        return $this->staffId;
   }
   public function setStaffId($staffId){
        $this->staffId = $staffId;
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
   
   public function getAddressId(){
        return $this->addressId;
   }
   public function setAddressId($addressId){
        $this->addressId = $addressId;
   }
   
   public function getPicture(){
        return $this->picture;
   }
   public function setPicture($picture){
        $this->picture = $picture;
   }
   
   public function getEmail(){
        return $this->email;
   }
   public function setEmail($email){
        $this->email = $email;
   }
   
   public function getStoreId(){
        return $this->storeId;
   }
   public function setStoreId($storeId){
        $this->storeId = $storeId;
   }
   
   public function getActive(){
        return $this->active;
   }
   public function setActive($active){
        $this->active = $active;
   }
   
   public function getUsername(){
        return $this->username;
   }
   public function setUsername($username){
        $this->username = $username;
   }
   
   public function getPassword(){
        return $this->password;
   }
   public function setPassword($password){
        $this->password = $password;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Staff($staffId,$firstName='',$lastName='',$addressId='',$picture='',$email='',$storeId='',$active='',$username='',$password='',$lastUpdate=''){
		   $this->setStaffId($staffId);
		   $this->setFirstName($firstName);
		   $this->setLastName($lastName);
		   $this->setAddressId($addressId);
		   $this->setPicture($picture);
		   $this->setEmail($email);
		   $this->setStoreId($storeId);
		   $this->setActive($active);
		   $this->setUsername($username);
		   $this->setPassword($password);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($staffId,$firstName='',$lastName='',$addressId='',$picture='',$email='',$storeId='',$active='',$username='',$password='',$lastUpdate='') {
		   $this->setStaffId($staffId);
		   $this->setFirstName($firstName);
		   $this->setLastName($lastName);
		   $this->setAddressId($addressId);
		   $this->setPicture($picture);
		   $this->setEmail($email);
		   $this->setStoreId($storeId);
		   $this->setActive($active);
		   $this->setUsername($username);
		   $this->setPassword($password);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "staffId" . chr(34) . ":" . chr(34) . $this->getStaffId() . chr(34) 
		    . "," . chr(34) . "firstName" . chr(34) . ":" . chr(34) . $this->getFirstName() . chr(34) 
		    . "," . chr(34) . "lastName" . chr(34) . ":" . chr(34) . $this->getLastName() . chr(34) 
		    . "," . chr(34) . "addressId" . chr(34) . ":" . chr(34) . $this->getAddressId() . chr(34) 
		    . "," . chr(34) . "picture" . chr(34) . ":" . chr(34) . $this->getPicture() . chr(34) 
		    . "," . chr(34) . "email" . chr(34) . ":" . chr(34) . $this->getEmail() . chr(34) 
		    . "," . chr(34) . "storeId" . chr(34) . ":" . chr(34) . $this->getStoreId() . chr(34) 
		    . "," . chr(34) . "active" . chr(34) . ":" . chr(34) . $this->getActive() . chr(34) 
		    . "," . chr(34) . "username" . chr(34) . ":" . chr(34) . $this->getUsername() . chr(34) 
		    . "," . chr(34) . "password" . chr(34) . ":" . chr(34) . $this->getPassword() . chr(34) 
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
//$actor = new Staff();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
