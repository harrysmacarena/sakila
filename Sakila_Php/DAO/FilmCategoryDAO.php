<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/filmCategory.php");
class FilmCategoryDAO {
   public static function sqlInsert( $filmCategory)
   {
        $stSql  = "insert into FilmCategory (";
        $stSql .= " film_id ,category_id ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$filmCategory->getFilmId()}'"
                . ",'{$filmCategory->getCategoryId()}'"
                . ",'{$filmCategory->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $filmCategory)
   {
        $stSql =  "update FilmCategory SET ";
        $stSql .= " last_update='{$filmCategory->getLastUpdate()}'"
                       ;
        $stSql .= " Where  film_id='{$filmCategory->getFilmId()}'"
                . "   and category_id='{$filmCategory->getCategoryId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $filmCategory)
   {
        $stSql =  "delete from  FilmCategory ";
        $stSql .= " Where  film_id='{$filmCategory->getFilmId()}'"
                . "   and category_id='{$filmCategory->getCategoryId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $filmCategory)
   {
        $stSql =  "select *  from  FilmCategory ";
        $stSql .= " Where  film_id='{$filmCategory->getFilmId()}'"
                . "   and category_id='{$filmCategory->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneFilmCategory( $filmCategory)
   {
        $stSql =  "select *  from  FilmCategory ";
        $stSql .= " Where  film_id='{$filmCategory->getFilmId()}'"
                . "   and category_id='{$filmCategory->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $filmCategory->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $filmCategory)
   {
        $stSql =  "select *  from  FilmCategory ";
        $stSql .= " Where  film_id='{$filmCategory->getFilmId()}'"
                . "   and category_id='{$filmCategory->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $filmCategory->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $filmCategory)
   {
        $stSql =  "select *  from  FilmCategory ";
        $stSql .= " Where  film_id='{$filmCategory->getFilmId()}'"
                . "   and category_id='{$filmCategory->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $filmCategory->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  FilmCategory ";
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
