<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/crudspring.php");
class CrudspringDAO {
   public static function sqlInsert( $crudspring)
   {
        $stSql  = "insert into Crudspring (";
        $stSql .= " id ,nombre ,salario ,descripcion";
        $stSql .= " )values (";
        $stSql .= " '{$crudspring->getId()}'"
                . ",'{$crudspring->getNombre()}'"
                . ",'{$crudspring->getSalario()}'"
                . ",'{$crudspring->getDescripcion()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $crudspring)
   {
        $stSql =  "update Crudspring SET ";
        $stSql .= " nombre='{$crudspring->getNombre()}'"
                . ",salario='{$crudspring->getSalario()}'"
                . ",descripcion='{$crudspring->getDescripcion()}'"
                       ;
        $stSql .= " Where  id='{$crudspring->getId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $crudspring)
   {
        $stSql =  "delete from  Crudspring ";
        $stSql .= " Where  id='{$crudspring->getId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $crudspring)
   {
        $stSql =  "select *  from  Crudspring ";
        $stSql .= " Where  id='{$crudspring->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneCrudspring( $crudspring)
   {
        $stSql =  "select *  from  Crudspring ";
        $stSql .= " Where  id='{$crudspring->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $crudspring->setNombre($fila["nombre"]);
        $crudspring->setSalario($fila["salario"]);
        $crudspring->setDescripcion($fila["descripcion"]);
        return true;					  
   }
   public static function sqlSelectOne( $crudspring)
   {
        $stSql =  "select *  from  Crudspring ";
        $stSql .= " Where  id='{$crudspring->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $crudspring->setNombre($fila["nombre"]);
        $crudspring->setSalario($fila["salario"]);
        $crudspring->setDescripcion($fila["descripcion"]);
   }
   public static function sqlSelect( $crudspring)
   {
        $stSql =  "select *  from  Crudspring ";
        $stSql .= " Where  id='{$crudspring->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $crudspring->setNombre($fila["nombre"]);
        $crudspring->setSalario($fila["salario"]);
        $crudspring->setDescripcion($fila["descripcion"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Crudspring ";
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
