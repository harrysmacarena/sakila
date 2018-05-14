<?PHP
class Payment implements JsonSerializable{

   private $paymentId;
   private $amount;
   private $paymentDate;
   private $lastUpdate;


   public function getPaymentId(){
        return $this->paymentId;
   }
   public function setPaymentId($paymentId){
        $this->paymentId = $paymentId;
   }
   
   public function getCustomerId(){
        return $this->customerId;
   }
   public function setCustomerId($customerId){
        $this->customerId = $customerId;
   }
   
   public function getStaffId(){
        return $this->staffId;
   }
   public function setStaffId($staffId){
        $this->staffId = $staffId;
   }
   
   public function getRentalId(){
        return $this->rentalId;
   }
   public function setRentalId($rentalId){
        $this->rentalId = $rentalId;
   }
   
   public function getAmount(){
        return $this->amount;
   }
   public function setAmount($amount){
        $this->amount = $amount;
   }
   
   public function getPaymentDate(){
        return $this->paymentDate;
   }
   public function setPaymentDate($paymentDate){
        $this->paymentDate = $paymentDate;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Payment($paymentId,$customerId='',$staffId='',$rentalId='',$amount='',$paymentDate='',$lastUpdate=''){
		   $this->setPaymentId($paymentId);
		   $this->setCustomerId($customerId);
		   $this->setStaffId($staffId);
		   $this->setRentalId($rentalId);
		   $this->setAmount($amount);
		   $this->setPaymentDate($paymentDate);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($paymentId,$customerId='',$staffId='',$rentalId='',$amount='',$paymentDate='',$lastUpdate='') {
		   $this->setPaymentId($paymentId);
		   $this->setCustomerId($customerId);
		   $this->setStaffId($staffId);
		   $this->setRentalId($rentalId);
		   $this->setAmount($amount);
		   $this->setPaymentDate($paymentDate);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "paymentId" . chr(34) . ":" . chr(34) . $this->getPaymentId() . chr(34) 
		    . "," . chr(34) . "customerId" . chr(34) . ":" . chr(34) . $this->getCustomerId() . chr(34) 
		    . "," . chr(34) . "staffId" . chr(34) . ":" . chr(34) . $this->getStaffId() . chr(34) 
		    . "," . chr(34) . "rentalId" . chr(34) . ":" . chr(34) . $this->getRentalId() . chr(34) 
		    . "," . chr(34) . "amount" . chr(34) . ":" . chr(34) . $this->getAmount() . chr(34) 
		    . "," . chr(34) . "paymentDate" . chr(34) . ":" . chr(34) . $this->getPaymentDate() . chr(34) 
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
//$actor = new Payment();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
