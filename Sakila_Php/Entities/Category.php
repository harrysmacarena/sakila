<?PHP
class Category implements JsonSerializable{

   private $categoryId;
   private $name;
   private $lastUpdate;


   public function getCategoryId(){
        return $this->categoryId;
   }
   public function setCategoryId($categoryId){
        $this->categoryId = $categoryId;
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
   

   public function Category($categoryId,$name='',$lastUpdate=''){
		   $this->setCategoryId($categoryId);
		   $this->setName($name);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($categoryId,$name='',$lastUpdate='') {
		   $this->setCategoryId($categoryId);
		   $this->setName($name);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "categoryId" . chr(34) . ":" . chr(34) . $this->getCategoryId() . chr(34) 
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
//$actor = new Category();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
