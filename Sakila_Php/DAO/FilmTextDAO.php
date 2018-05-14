<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/filmText.php");
class FilmTextDAO {
   public static function sqlInsert( $filmText)
   {
        $stSql  = "insert into FilmText (";
        $stSql .= " film_id ,title ,description";
        $stSql .= " )values (";
        $stSql .= " '{$filmText->getFilmId()}'"
                . ",'{$filmText->getTitle()}'"
                . ",'{$filmText->getDescription()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $filmText)
   {
        $stSql =  "update FilmText SET ";
        $stSql .= " title='{$filmText->getTitle()}'"
                . ",description='{$filmText->getDescription()}'"
                       ;
        $stSql .= " Where  film_id='{$filmText->getFilmId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $filmText)
   {
        $stSql =  "delete from  FilmText ";
        $stSql .= " Where  film_id='{$filmText->getFilmId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $filmText)
   {
        $stSql =  "select *  from  FilmText ";
        $stSql .= " Where  film_id='{$filmText->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneFilmText( $filmText)
   {
        $stSql =  "select *  from  FilmText ";
        $stSql .= " Where  film_id='{$filmText->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $filmText->setTitle($fila["title"]);
        $filmText->setDescription($fila["description"]);
        return true;					  
   }
   public static function sqlSelectOne( $filmText)
   {
        $stSql =  "select *  from  FilmText ";
        $stSql .= " Where  film_id='{$filmText->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $filmText->setTitle($fila["title"]);
        $filmText->setDescription($fila["description"]);
   }
   public static function sqlSelect( $filmText)
   {
        $stSql =  "select *  from  FilmText ";
        $stSql .= " Where  film_id='{$filmText->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $filmText->setTitle($fila["title"]);
        $filmText->setDescription($fila["description"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  FilmText ";
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
