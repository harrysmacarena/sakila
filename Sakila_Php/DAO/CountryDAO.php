<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/country.php");
class CountryDAO {
   public static function sqlInsert( $country)
   {
        $stSql  = "insert into Country (";
        $stSql .= " country_id ,country ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$country->getCountryId()}'"
                . ",'{$country->getCountry()}'"
                . ",'{$country->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $country)
   {
        $stSql =  "update Country SET ";
        $stSql .= " country='{$country->getCountry()}'"
                . ",last_update='{$country->getLastUpdate()}'"
                       ;
        $stSql .= " Where  country_id='{$country->getCountryId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $country)
   {
        $stSql =  "delete from  Country ";
        $stSql .= " Where  country_id='{$country->getCountryId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $country)
   {
        $stSql =  "select *  from  Country ";
        $stSql .= " Where  country_id='{$country->getCountryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneCountry( $country)
   {
        $stSql =  "select *  from  Country ";
        $stSql .= " Where  country_id='{$country->getCountryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $country->setCountry($fila["country"]);
        $country->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $country)
   {
        $stSql =  "select *  from  Country ";
        $stSql .= " Where  country_id='{$country->getCountryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $country->setCountry($fila["country"]);
        $country->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $country)
   {
        $stSql =  "select *  from  Country ";
        $stSql .= " Where  country_id='{$country->getCountryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $country->setCountry($fila["country"]);
        $country->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Country ";
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
