<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/empleado.php");
class EmpleadoDAO {
   public static function sqlInsert( $empleado)
   {
        $stSql  = "insert into Empleado (";
        $stSql .= " id ,nombre ,salario ,descripcion";
        $stSql .= " )values (";
        $stSql .= " '{$empleado->getId()}'"
                . ",'{$empleado->getNombre()}'"
                . ",'{$empleado->getSalario()}'"
                . ",'{$empleado->getDescripcion()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $empleado)
   {
        $stSql =  "update Empleado SET ";
        $stSql .= " nombre='{$empleado->getNombre()}'"
                . ",salario='{$empleado->getSalario()}'"
                . ",descripcion='{$empleado->getDescripcion()}'"
                       ;
        $stSql .= " Where  id='{$empleado->getId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $empleado)
   {
        $stSql =  "delete from  Empleado ";
        $stSql .= " Where  id='{$empleado->getId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $empleado)
   {
        $stSql =  "select *  from  Empleado ";
        $stSql .= " Where  id='{$empleado->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneEmpleado( $empleado)
   {
        $stSql =  "select *  from  Empleado ";
        $stSql .= " Where  id='{$empleado->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $empleado->setNombre($fila["nombre"]);
        $empleado->setSalario($fila["salario"]);
        $empleado->setDescripcion($fila["descripcion"]);
        return true;					  
   }
   public static function sqlSelectOne( $empleado)
   {
        $stSql =  "select *  from  Empleado ";
        $stSql .= " Where  id='{$empleado->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $empleado->setNombre($fila["nombre"]);
        $empleado->setSalario($fila["salario"]);
        $empleado->setDescripcion($fila["descripcion"]);
   }
   public static function sqlSelect( $empleado)
   {
        $stSql =  "select *  from  Empleado ";
        $stSql .= " Where  id='{$empleado->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $empleado->setNombre($fila["nombre"]);
        $empleado->setSalario($fila["salario"]);
        $empleado->setDescripcion($fila["descripcion"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Empleado ";
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
