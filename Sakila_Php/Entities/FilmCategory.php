<?PHP
class FilmCategory implements JsonSerializable{

   private $lastUpdate;


   public function getFilmId(){
        return $this->filmId;
   }
   public function setFilmId($filmId){
        $this->filmId = $filmId;
   }
   
   public function getCategoryId(){
        return $this->categoryId;
   }
   public function setCategoryId($categoryId){
        $this->categoryId = $categoryId;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function FilmCategory($filmId,$categoryId,$lastUpdate=''){
		   $this->setFilmId($filmId);
		   $this->setCategoryId($categoryId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($filmId,$categoryId,$lastUpdate='') {
		   $this->setFilmId($filmId);
		   $this->setCategoryId($categoryId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "filmId" . chr(34) . ":" . chr(34) . $this->getFilmId() . chr(34) 
		    . "," . chr(34) . "categoryId" . chr(34) . ":" . chr(34) . $this->getCategoryId() . chr(34) 
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
//$actor = new FilmCategory();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
