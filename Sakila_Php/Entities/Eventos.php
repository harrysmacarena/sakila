<?PHP
class Eventos implements JsonSerializable{

   private $id;
   private $title;
   private $body;
   private $url;
   private $class;
   private $start;
   private $end;
   private $inicioNormal;
   private $finalNormal;


   public function getId(){
        return $this->id;
   }
   public function setId($id){
        $this->id = $id;
   }
   
   public function getTitle(){
        return $this->title;
   }
   public function setTitle($title){
        $this->title = $title;
   }
   
   public function getBody(){
        return $this->body;
   }
   public function setBody($body){
        $this->body = $body;
   }
   
   public function getUrl(){
        return $this->url;
   }
   public function setUrl($url){
        $this->url = $url;
   }
   
   public function getClass(){
        return $this->class;
   }
   public function setClass($class){
        $this->class = $class;
   }
   
   public function getStart(){
        return $this->start;
   }
   public function setStart($start){
        $this->start = $start;
   }
   
   public function getEnd(){
        return $this->end;
   }
   public function setEnd($end){
        $this->end = $end;
   }
   
   public function getInicioNormal(){
        return $this->inicioNormal;
   }
   public function setInicioNormal($inicioNormal){
        $this->inicioNormal = $inicioNormal;
   }
   
   public function getFinalNormal(){
        return $this->finalNormal;
   }
   public function setFinalNormal($finalNormal){
        $this->finalNormal = $finalNormal;
   }
   

   public function Eventos($id,$title='',$body='',$url='',$class='',$start='',$end='',$inicioNormal='',$finalNormal=''){
		   $this->setId($id);
		   $this->setTitle($title);
		   $this->setBody($body);
		   $this->setUrl($url);
		   $this->setClass($class);
		   $this->setStart($start);
		   $this->setEnd($end);
		   $this->setInicioNormal($inicioNormal);
		   $this->setFinalNormal($finalNormal);
   }
   public function __constructXX($id,$title='',$body='',$url='',$class='',$start='',$end='',$inicioNormal='',$finalNormal='') {
		   $this->setId($id);
		   $this->setTitle($title);
		   $this->setBody($body);
		   $this->setUrl($url);
		   $this->setClass($class);
		   $this->setStart($start);
		   $this->setEnd($end);
		   $this->setInicioNormal($inicioNormal);
		   $this->setFinalNormal($finalNormal);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "id" . chr(34) . ":" . chr(34) . $this->getId() . chr(34) 
		    . "," . chr(34) . "title" . chr(34) . ":" . chr(34) . $this->getTitle() . chr(34) 
		    . "," . chr(34) . "body" . chr(34) . ":" . chr(34) . $this->getBody() . chr(34) 
		    . "," . chr(34) . "url" . chr(34) . ":" . chr(34) . $this->getUrl() . chr(34) 
		    . "," . chr(34) . "class" . chr(34) . ":" . chr(34) . $this->getClass() . chr(34) 
		    . "," . chr(34) . "start" . chr(34) . ":" . chr(34) . $this->getStart() . chr(34) 
		    . "," . chr(34) . "end" . chr(34) . ":" . chr(34) . $this->getEnd() . chr(34) 
		    . "," . chr(34) . "inicioNormal" . chr(34) . ":" . chr(34) . $this->getInicioNormal() . chr(34) 
		    . "," . chr(34) . "finalNormal" . chr(34) . ":" . chr(34) . $this->getFinalNormal() . chr(34) 
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
//$actor = new Eventos();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
