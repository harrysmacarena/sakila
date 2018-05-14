<?PHP
class Store implements JsonSerializable{

   private $storeId;
   private $lastUpdate;


   public function getStoreId(){
        return $this->storeId;
   }
   public function setStoreId($storeId){
        $this->storeId = $storeId;
   }
   
   public function getManagerStaffId(){
        return $this->managerStaffId;
   }
   public function setManagerStaffId($managerStaffId){
        $this->managerStaffId = $managerStaffId;
   }
   
   public function getAddressId(){
        return $this->addressId;
   }
   public function setAddressId($addressId){
        $this->addressId = $addressId;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Store($storeId,$managerStaffId='',$addressId='',$lastUpdate=''){
		   $this->setStoreId($storeId);
		   $this->setManagerStaffId($managerStaffId);
		   $this->setAddressId($addressId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($storeId,$managerStaffId='',$addressId='',$lastUpdate='') {
		   $this->setStoreId($storeId);
		   $this->setManagerStaffId($managerStaffId);
		   $this->setAddressId($addressId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "storeId" . chr(34) . ":" . chr(34) . $this->getStoreId() . chr(34) 
		    . "," . chr(34) . "managerStaffId" . chr(34) . ":" . chr(34) . $this->getManagerStaffId() . chr(34) 
		    . "," . chr(34) . "addressId" . chr(34) . ":" . chr(34) . $this->getAddressId() . chr(34) 
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
//$actor = new Store();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
