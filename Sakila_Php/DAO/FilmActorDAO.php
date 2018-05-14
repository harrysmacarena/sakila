<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/filmActor.php");
class FilmActorDAO {
   public static function sqlInsert( $filmActor)
   {
        $stSql  = "insert into FilmActor (";
        $stSql .= " actor_id ,film_id ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$filmActor->getActorId()}'"
                . ",'{$filmActor->getFilmId()}'"
                . ",'{$filmActor->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $filmActor)
   {
        $stSql =  "update FilmActor SET ";
        $stSql .= " last_update='{$filmActor->getLastUpdate()}'"
                       ;
        $stSql .= " Where  actor_id='{$filmActor->getActorId()}'"
                . "   and film_id='{$filmActor->getFilmId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $filmActor)
   {
        $stSql =  "delete from  FilmActor ";
        $stSql .= " Where  actor_id='{$filmActor->getActorId()}'"
                . "   and film_id='{$filmActor->getFilmId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $filmActor)
   {
        $stSql =  "select *  from  FilmActor ";
        $stSql .= " Where  actor_id='{$filmActor->getActorId()}'"
                . "   and film_id='{$filmActor->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneFilmActor( $filmActor)
   {
        $stSql =  "select *  from  FilmActor ";
        $stSql .= " Where  actor_id='{$filmActor->getActorId()}'"
                . "   and film_id='{$filmActor->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $filmActor->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $filmActor)
   {
        $stSql =  "select *  from  FilmActor ";
        $stSql .= " Where  actor_id='{$filmActor->getActorId()}'"
                . "   and film_id='{$filmActor->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $filmActor->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $filmActor)
   {
        $stSql =  "select *  from  FilmActor ";
        $stSql .= " Where  actor_id='{$filmActor->getActorId()}'"
                . "   and film_id='{$filmActor->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $filmActor->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  FilmActor ";
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
