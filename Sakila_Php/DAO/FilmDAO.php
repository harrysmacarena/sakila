<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/film.php");
class FilmDAO {
   public static function sqlInsert( $film)
   {
        $stSql  = "insert into Film (";
        $stSql .= " film_id ,title ,description ,release_year ,language_id ,original_language_id ,rental_duration ,rental_rate ,length ,replacement_cost ,rating ,special_features ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$film->getFilmId()}'"
                . ",'{$film->getTitle()}'"
                . ",'{$film->getDescription()}'"
                . ",'{$film->getReleaseYear()}'"
                . ",'{$film->getLanguageId()}'"
                . ",'{$film->getOriginalLanguageId()}'"
                . ",'{$film->getRentalDuration()}'"
                . ",'{$film->getRentalRate()}'"
                . ",'{$film->getLength()}'"
                . ",'{$film->getReplacementCost()}'"
                . ",'{$film->getRating()}'"
                . ",'{$film->getSpecialFeatures()}'"
                . ",'{$film->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $film)
   {
        $stSql =  "update Film SET ";
        $stSql .= " title='{$film->getTitle()}'"
                . ",description='{$film->getDescription()}'"
                . ",release_year='{$film->getReleaseYear()}'"
                . ",language_id='{$film->getLanguageId()}'"
                . ",original_language_id='{$film->getOriginalLanguageId()}'"
                . ",rental_duration='{$film->getRentalDuration()}'"
                . ",rental_rate='{$film->getRentalRate()}'"
                . ",length='{$film->getLength()}'"
                . ",replacement_cost='{$film->getReplacementCost()}'"
                . ",rating='{$film->getRating()}'"
                . ",special_features='{$film->getSpecialFeatures()}'"
                . ",last_update='{$film->getLastUpdate()}'"
                       ;
        $stSql .= " Where  film_id='{$film->getFilmId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $film)
   {
        $stSql =  "delete from  Film ";
        $stSql .= " Where  film_id='{$film->getFilmId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $film)
   {
        $stSql =  "select *  from  Film ";
        $stSql .= " Where  film_id='{$film->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneFilm( $film)
   {
        $stSql =  "select *  from  Film ";
        $stSql .= " Where  film_id='{$film->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $film->setTitle($fila["title"]);
        $film->setDescription($fila["description"]);
        $film->setReleaseYear($fila["release_year"]);
        $film->setLanguageId($fila["language_id"]);
        $film->setOriginalLanguageId($fila["original_language_id"]);
        $film->setRentalDuration($fila["rental_duration"]);
        $film->setRentalRate($fila["rental_rate"]);
        $film->setLength($fila["length"]);
        $film->setReplacementCost($fila["replacement_cost"]);
        $film->setRating($fila["rating"]);
        $film->setSpecialFeatures($fila["special_features"]);
        $film->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $film)
   {
        $stSql =  "select *  from  Film ";
        $stSql .= " Where  film_id='{$film->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $film->setTitle($fila["title"]);
        $film->setDescription($fila["description"]);
        $film->setReleaseYear($fila["release_year"]);
        $film->setLanguageId($fila["language_id"]);
        $film->setOriginalLanguageId($fila["original_language_id"]);
        $film->setRentalDuration($fila["rental_duration"]);
        $film->setRentalRate($fila["rental_rate"]);
        $film->setLength($fila["length"]);
        $film->setReplacementCost($fila["replacement_cost"]);
        $film->setRating($fila["rating"]);
        $film->setSpecialFeatures($fila["special_features"]);
        $film->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $film)
   {
        $stSql =  "select *  from  Film ";
        $stSql .= " Where  film_id='{$film->getFilmId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $film->setTitle($fila["title"]);
        $film->setDescription($fila["description"]);
        $film->setReleaseYear($fila["release_year"]);
        $film->setLanguageId($fila["language_id"]);
        $film->setOriginalLanguageId($fila["original_language_id"]);
        $film->setRentalDuration($fila["rental_duration"]);
        $film->setRentalRate($fila["rental_rate"]);
        $film->setLength($fila["length"]);
        $film->setReplacementCost($fila["replacement_cost"]);
        $film->setRating($fila["rating"]);
        $film->setSpecialFeatures($fila["special_features"]);
        $film->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Film ";
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
