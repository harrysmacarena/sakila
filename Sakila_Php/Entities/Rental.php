<?PHP
class Rental implements JsonSerializable{

   private $rentalId;
   private $rentalDate;
   private $returnDate;
   private $lastUpdate;


   public function getRentalId(){
        return $this->rentalId;
   }
   public function setRentalId($rentalId){
        $this->rentalId = $rentalId;
   }
   
   public function getRentalDate(){
        return $this->rentalDate;
   }
   public function setRentalDate($rentalDate){
        $this->rentalDate = $rentalDate;
   }
   
   public function getInventoryId(){
        return $this->inventoryId;
   }
   public function setInventoryId($inventoryId){
        $this->inventoryId = $inventoryId;
   }
   
   public function getCustomerId(){
        return $this->customerId;
   }
   public function setCustomerId($customerId){
        $this->customerId = $customerId;
   }
   
   public function getReturnDate(){
        return $this->returnDate;
   }
   public function setReturnDate($returnDate){
        $this->returnDate = $returnDate;
   }
   
   public function getStaffId(){
        return $this->staffId;
   }
   public function setStaffId($staffId){
        $this->staffId = $staffId;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Rental($rentalId,$rentalDate='',$inventoryId='',$customerId='',$returnDate='',$staffId='',$lastUpdate=''){
		   $this->setRentalId($rentalId);
		   $this->setRentalDate($rentalDate);
		   $this->setInventoryId($inventoryId);
		   $this->setCustomerId($customerId);
		   $this->setReturnDate($returnDate);
		   $this->setStaffId($staffId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($rentalId,$rentalDate='',$inventoryId='',$customerId='',$returnDate='',$staffId='',$lastUpdate='') {
		   $this->setRentalId($rentalId);
		   $this->setRentalDate($rentalDate);
		   $this->setInventoryId($inventoryId);
		   $this->setCustomerId($customerId);
		   $this->setReturnDate($returnDate);
		   $this->setStaffId($staffId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "rentalId" . chr(34) . ":" . chr(34) . $this->getRentalId() . chr(34) 
		    . "," . chr(34) . "rentalDate" . chr(34) . ":" . chr(34) . $this->getRentalDate() . chr(34) 
		    . "," . chr(34) . "inventoryId" . chr(34) . ":" . chr(34) . $this->getInventoryId() . chr(34) 
		    . "," . chr(34) . "customerId" . chr(34) . ":" . chr(34) . $this->getCustomerId() . chr(34) 
		    . "," . chr(34) . "returnDate" . chr(34) . ":" . chr(34) . $this->getReturnDate() . chr(34) 
		    . "," . chr(34) . "staffId" . chr(34) . ":" . chr(34) . $this->getStaffId() . chr(34) 
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
//$actor = new Rental();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
