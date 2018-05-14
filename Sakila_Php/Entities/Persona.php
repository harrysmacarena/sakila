<?PHP
class Persona implements JsonSerializable{

   private $rut;
   private $dv;
   private $nombres;
   private $estatura;
   private $sexo;
   private $esCasado;
   private $emilia;
   private $ariel;


   public function getRut(){
        return $this->rut;
   }
   public function setRut($rut){
        $this->rut = $rut;
   }
   
   public function getDv(){
        return $this->dv;
   }
   public function setDv($dv){
        $this->dv = $dv;
   }
   
   public function getNombres(){
        return $this->nombres;
   }
   public function setNombres($nombres){
        $this->nombres = $nombres;
   }
   
   public function getEstatura(){
        return $this->estatura;
   }
   public function setEstatura($estatura){
        $this->estatura = $estatura;
   }
   
   public function getSexo(){
        return $this->sexo;
   }
   public function setSexo($sexo){
        $this->sexo = $sexo;
   }
   
   public function getEsCasado(){
        return $this->esCasado;
   }
   public function setEsCasado($esCasado){
        $this->esCasado = $esCasado;
   }
   
   public function getEmilia(){
        return $this->emilia;
   }
   public function setEmilia($emilia){
        $this->emilia = $emilia;
   }
   
   public function getAriel(){
        return $this->ariel;
   }
   public function setAriel($ariel){
        $this->ariel = $ariel;
   }
   

   public function Persona($rut,$dv='',$nombres='',$estatura='',$sexo='',$esCasado='',$emilia='',$ariel=''){
		   $this->setRut($rut);
		   $this->setDv($dv);
		   $this->setNombres($nombres);
		   $this->setEstatura($estatura);
		   $this->setSexo($sexo);
		   $this->setEsCasado($esCasado);
		   $this->setEmilia($emilia);
		   $this->setAriel($ariel);
   }
   public function __constructXX($rut,$dv='',$nombres='',$estatura='',$sexo='',$esCasado='',$emilia='',$ariel='') {
		   $this->setRut($rut);
		   $this->setDv($dv);
		   $this->setNombres($nombres);
		   $this->setEstatura($estatura);
		   $this->setSexo($sexo);
		   $this->setEsCasado($esCasado);
		   $this->setEmilia($emilia);
		   $this->setAriel($ariel);
   }
   public function __toString(){
        // Registro JSon
		return "{" 
		    . "," . chr(34) . "rut" . chr(34) . ":" . chr(34) . $this->getRut() . chr(34) 
		    . "," . chr(34) . "dv" . chr(34) . ":" . chr(34) . $this->getDv() . chr(34) 
		    . "," . chr(34) . "nombres" . chr(34) . ":" . chr(34) . $this->getNombres() . chr(34) 
		    . "," . chr(34) . "estatura" . chr(34) . ":" . chr(34) . $this->getEstatura() . chr(34) 
		    . "," . chr(34) . "sexo" . chr(34) . ":" . chr(34) . $this->getSexo() . chr(34) 
		    . "," . chr(34) . "esCasado" . chr(34) . ":" . chr(34) . $this->getEsCasado() . chr(34) 
		    . "," . chr(34) . "emilia" . chr(34) . ":" . chr(34) . $this->getEmilia() . chr(34) 
		    . "," . chr(34) . "ariel" . chr(34) . ":" . chr(34) . $this->getAriel() . chr(34) 
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
//$actor = new Persona();
//echo "Imprimiendo ";$actor->imprimir();
//echo "ToString : " . $actor;
?>
