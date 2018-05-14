<?PHP
class Empleado implements JsonSerializable{

   private $id;
   private $nombre;
   private $salario;
   private $descripcion;


   public function getId(){
        return $this->id;
   }
   public function setId($id){
        $this->id = $id;
   }
   
   public function getNombre(){
        return $this->nombre;
   }
   public function setNombre($nombre){
        $this->nombre = $nombre;
   }
   
   public function getSalario(){
        return $this->salario;
   }
   public function setSalario($salario){
        $this->salario = $salario;
   }
   
   public function getDescripcion(){
        return $this->descripcion;
   }
   public function setDescripcion($descripcion){
        $this->descripcion = $descripcion;
   }
   

   public function Empleado($id,$nombre='',$salario='',$descripcion=''){
		   $this->setId($id);
		   $this->setNombre($nombre);
		   $this->setSalario($salario);
		   $this->setDescripcion($descripcion);
   }
   public function __constructXX($id,$nombre='',$salario='',$descripcion='') {
		   $this->setId($id);
		   $this->setNombre($nombre);
		   $this->setSalario($salario);
		   $this->setDescripcion($descripcion);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "id" . chr(34) . ":" . chr(34) . $this->getId() . chr(34) 
		    . "," . chr(34) . "nombre" . chr(34) . ":" . chr(34) . $this->getNombre() . chr(34) 
		    . "," . chr(34) . "salario" . chr(34) . ":" . chr(34) . $this->getSalario() . chr(34) 
		    . "," . chr(34) . "descripcion" . chr(34) . ":" . chr(34) . $this->getDescripcion() . chr(34) 
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
//$actor = new Empleado();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
