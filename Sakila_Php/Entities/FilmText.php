<?PHP
class FilmText implements JsonSerializable{

   private $filmId;
   private $title;
   private $description;


   public function getFilmId(){
        return $this->filmId;
   }
   public function setFilmId($filmId){
        $this->filmId = $filmId;
   }
   
   public function getTitle(){
        return $this->title;
   }
   public function setTitle($title){
        $this->title = $title;
   }
   
   public function getDescription(){
        return $this->description;
   }
   public function setDescription($description){
        $this->description = $description;
   }
   

   public function FilmText($filmId,$title='',$description=''){
		   $this->setFilmId($filmId);
		   $this->setTitle($title);
		   $this->setDescription($description);
   }
   public function __constructXX($filmId,$title='',$description='') {
		   $this->setFilmId($filmId);
		   $this->setTitle($title);
		   $this->setDescription($description);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "filmId" . chr(34) . ":" . chr(34) . $this->getFilmId() . chr(34) 
		    . "," . chr(34) . "title" . chr(34) . ":" . chr(34) . $this->getTitle() . chr(34) 
		    . "," . chr(34) . "description" . chr(34) . ":" . chr(34) . $this->getDescription() . chr(34) 
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
//$actor = new FilmText();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
