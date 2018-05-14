<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/actor.php");
class ActorDAO {
   public static function sqlInsert( $actor)
   {
        $stSql  = "insert into Actor (";
        $stSql .= " actor_id ,first_name ,last_name ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$actor->getActorId()}'"
                . ",'{$actor->getFirstName()}'"
                . ",'{$actor->getLastName()}'"
                . ",'{$actor->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $actor)
   {
        $stSql =  "update Actor SET ";
        $stSql .= " first_name='{$actor->getFirstName()}'"
                . ",last_name='{$actor->getLastName()}'"
                . ",last_update='{$actor->getLastUpdate()}'"
                       ;
        $stSql .= " Where  actor_id='{$actor->getActorId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $actor)
   {
        $stSql =  "delete from  Actor ";
        $stSql .= " Where  actor_id='{$actor->getActorId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $actor)
   {
        $stSql =  "select *  from  Actor ";
        $stSql .= " Where  actor_id='{$actor->getActorId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneActor( $actor)
   {
        $stSql =  "select *  from  Actor ";
        $stSql .= " Where  actor_id='{$actor->getActorId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $actor->setFirstName($fila["first_name"]);
        $actor->setLastName($fila["last_name"]);
        $actor->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $actor)
   {
        $stSql =  "select *  from  Actor ";
        $stSql .= " Where  actor_id='{$actor->getActorId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $actor->setFirstName($fila["first_name"]);
        $actor->setLastName($fila["last_name"]);
        $actor->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $actor)
   {
        $stSql =  "select *  from  Actor ";
        $stSql .= " Where  actor_id='{$actor->getActorId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $actor->setFirstName($fila["first_name"]);
        $actor->setLastName($fila["last_name"]);
        $actor->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Actor ";
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
