<?PHP
class Address implements JsonSerializable{

   private $addressId;
   private $address;
   private $address2;
   private $district;
   private $postalCode;
   private $phone;
   private $lastUpdate;


   public function getAddressId(){
        return $this->addressId;
   }
   public function setAddressId($addressId){
        $this->addressId = $addressId;
   }
   
   public function getAddress(){
        return $this->address;
   }
   public function setAddress($address){
        $this->address = $address;
   }
   
   public function getAddress2(){
        return $this->address2;
   }
   public function setAddress2($address2){
        $this->address2 = $address2;
   }
   
   public function getDistrict(){
        return $this->district;
   }
   public function setDistrict($district){
        $this->district = $district;
   }
   
   public function getCityId(){
        return $this->cityId;
   }
   public function setCityId($cityId){
        $this->cityId = $cityId;
   }
   
   public function getPostalCode(){
        return $this->postalCode;
   }
   public function setPostalCode($postalCode){
        $this->postalCode = $postalCode;
   }
   
   public function getPhone(){
        return $this->phone;
   }
   public function setPhone($phone){
        $this->phone = $phone;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Address($addressId,$address='',$address2='',$district='',$cityId='',$postalCode='',$phone='',$lastUpdate=''){
		   $this->setAddressId($addressId);
		   $this->setAddress($address);
		   $this->setAddress2($address2);
		   $this->setDistrict($district);
		   $this->setCityId($cityId);
		   $this->setPostalCode($postalCode);
		   $this->setPhone($phone);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($addressId,$address='',$address2='',$district='',$cityId='',$postalCode='',$phone='',$lastUpdate='') {
		   $this->setAddressId($addressId);
		   $this->setAddress($address);
		   $this->setAddress2($address2);
		   $this->setDistrict($district);
		   $this->setCityId($cityId);
		   $this->setPostalCode($postalCode);
		   $this->setPhone($phone);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "addressId" . chr(34) . ":" . chr(34) . $this->getAddressId() . chr(34) 
		    . "," . chr(34) . "address" . chr(34) . ":" . chr(34) . $this->getAddress() . chr(34) 
		    . "," . chr(34) . "address2" . chr(34) . ":" . chr(34) . $this->getAddress2() . chr(34) 
		    . "," . chr(34) . "district" . chr(34) . ":" . chr(34) . $this->getDistrict() . chr(34) 
		    . "," . chr(34) . "cityId" . chr(34) . ":" . chr(34) . $this->getCityId() . chr(34) 
		    . "," . chr(34) . "postalCode" . chr(34) . ":" . chr(34) . $this->getPostalCode() . chr(34) 
		    . "," . chr(34) . "phone" . chr(34) . ":" . chr(34) . $this->getPhone() . chr(34) 
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
//$actor = new Address();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
