<?PHP
class Inventory implements JsonSerializable{

   private $inventoryId;
   private $lastUpdate;


   public function getInventoryId(){
        return $this->inventoryId;
   }
   public function setInventoryId($inventoryId){
        $this->inventoryId = $inventoryId;
   }
   
   public function getFilmId(){
        return $this->filmId;
   }
   public function setFilmId($filmId){
        $this->filmId = $filmId;
   }
   
   public function getStoreId(){
        return $this->storeId;
   }
   public function setStoreId($storeId){
        $this->storeId = $storeId;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function Inventory($inventoryId,$filmId='',$storeId='',$lastUpdate=''){
		   $this->setInventoryId($inventoryId);
		   $this->setFilmId($filmId);
		   $this->setStoreId($storeId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($inventoryId,$filmId='',$storeId='',$lastUpdate='') {
		   $this->setInventoryId($inventoryId);
		   $this->setFilmId($filmId);
		   $this->setStoreId($storeId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "inventoryId" . chr(34) . ":" . chr(34) . $this->getInventoryId() . chr(34) 
		    . "," . chr(34) . "filmId" . chr(34) . ":" . chr(34) . $this->getFilmId() . chr(34) 
		    . "," . chr(34) . "storeId" . chr(34) . ":" . chr(34) . $this->getStoreId() . chr(34) 
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
//$actor = new Inventory();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
