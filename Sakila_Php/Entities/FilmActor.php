<?PHP
class FilmActor implements JsonSerializable{

   private $lastUpdate;


   public function getActorId(){
        return $this->actorId;
   }
   public function setActorId($actorId){
        $this->actorId = $actorId;
   }
   
   public function getFilmId(){
        return $this->filmId;
   }
   public function setFilmId($filmId){
        $this->filmId = $filmId;
   }
   
   public function getLastUpdate(){
        return $this->lastUpdate;
   }
   public function setLastUpdate($lastUpdate){
        $this->lastUpdate = $lastUpdate;
   }
   

   public function FilmActor($actorId,$filmId,$lastUpdate=''){
		   $this->setActorId($actorId);
		   $this->setFilmId($filmId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __constructXX($actorId,$filmId,$lastUpdate='') {
		   $this->setActorId($actorId);
		   $this->setFilmId($filmId);
		   $this->setLastUpdate($lastUpdate);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "actorId" . chr(34) . ":" . chr(34) . $this->getActorId() . chr(34) 
		    . "," . chr(34) . "filmId" . chr(34) . ":" . chr(34) . $this->getFilmId() . chr(34) 
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
//$actor = new FilmActor();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
