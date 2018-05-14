<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/persona.php");
class PersonaDAO {
   public static function sqlInsert( $persona)
   {
        $stSql  = "insert into Persona (";
        $stSql .= " rut ,dv ,nombres ,estatura ,sexo ,esCasado ,emilia ,ariel";
        $stSql .= " )values (";
        $stSql .= " '{$persona->getRut()}'"
                . ",'{$persona->getDv()}'"
                . ",'{$persona->getNombres()}'"
                . ",'{$persona->getEstatura()}'"
                . ",'{$persona->getSexo()}'"
                . ",'{$persona->getEsCasado()}'"
                . ",'{$persona->getEmilia()}'"
                . ",'{$persona->getAriel()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $persona)
   {
        $stSql =  "update Persona SET ";
        $stSql .= " dv='{$persona->getDv()}'"
                . ",nombres='{$persona->getNombres()}'"
                . ",estatura='{$persona->getEstatura()}'"
                . ",sexo='{$persona->getSexo()}'"
                . ",esCasado='{$persona->getEsCasado()}'"
                . ",emilia='{$persona->getEmilia()}'"
                . ",ariel='{$persona->getAriel()}'"
                       ;
        $stSql .= " Where  rut='{$persona->getRut()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $persona)
   {
        $stSql =  "delete from  Persona ";
        $stSql .= " Where  rut='{$persona->getRut()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $persona)
   {
        $stSql =  "select *  from  Persona ";
        $stSql .= " Where  rut='{$persona->getRut()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOnePersona( $persona)
   {
        $stSql =  "select *  from  Persona ";
        $stSql .= " Where  rut='{$persona->getRut()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $persona->setDv($fila["dv"]);
        $persona->setNombres($fila["nombres"]);
        $persona->setEstatura($fila["estatura"]);
        $persona->setSexo($fila["sexo"]);
        $persona->setEsCasado($fila["esCasado"]);
        $persona->setEmilia($fila["emilia"]);
        $persona->setAriel($fila["ariel"]);
        return true;					  
   }
   public static function sqlSelectOne( $persona)
   {
        $stSql =  "select *  from  Persona ";
        $stSql .= " Where  rut='{$persona->getRut()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $persona->setDv($fila["dv"]);
        $persona->setNombres($fila["nombres"]);
        $persona->setEstatura($fila["estatura"]);
        $persona->setSexo($fila["sexo"]);
        $persona->setEsCasado($fila["esCasado"]);
        $persona->setEmilia($fila["emilia"]);
        $persona->setAriel($fila["ariel"]);
   }
   public static function sqlSelect( $persona)
   {
        $stSql =  "select *  from  Persona ";
        $stSql .= " Where  rut='{$persona->getRut()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $persona->setDv($fila["dv"]);
        $persona->setNombres($fila["nombres"]);
        $persona->setEstatura($fila["estatura"]);
        $persona->setSexo($fila["sexo"]);
        $persona->setEsCasado($fila["esCasado"]);
        $persona->setEmilia($fila["emilia"]);
        $persona->setAriel($fila["ariel"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Persona ";
        return BD::getInstance()->sqlSelectTodo($stSql);
   }
  public static function sqlSelectTodo( )
   {
        $stSql =  "select *  from  Actor ";
		// Ejecutamos sqlSelectTodo, el cual nos devuleve un arreglo
		$miArreglo = BD::getInstance()->sqlSelectTodo($stSql);
		// Iniciamos el arreglo $pila como array()
		$pila = array();
		// Recorremos el Arreglo $miArreglo
		foreach($miArreglo as $fila){
 		      // Por cada registro $fila creamos un Actor
		      $actorAux = new Actor($fila["actor_id"]
					   ,$fila["first_name"]
				           ,$fila["last_name"]
				           ,$fila["last_update"]);
                       // Agregamos el Actor a la $pila			
			array_push($pila, $actorAux);
		}
		// Retornamos el Arreglo $pila Lleno
        return $pila;
   }   
}
?>
