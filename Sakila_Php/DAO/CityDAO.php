<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/city.php");
class CityDAO {
   public static function sqlInsert( $city)
   {
        $stSql  = "insert into City (";
        $stSql .= " city_id ,city ,country_id ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$city->getCityId()}'"
                . ",'{$city->getCity()}'"
                . ",'{$city->getCountryId()}'"
                . ",'{$city->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $city)
   {
        $stSql =  "update City SET ";
        $stSql .= " city='{$city->getCity()}'"
                . ",country_id='{$city->getCountryId()}'"
                . ",last_update='{$city->getLastUpdate()}'"
                       ;
        $stSql .= " Where  city_id='{$city->getCityId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $city)
   {
        $stSql =  "delete from  City ";
        $stSql .= " Where  city_id='{$city->getCityId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $city)
   {
        $stSql =  "select *  from  City ";
        $stSql .= " Where  city_id='{$city->getCityId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneCity( $city)
   {
        $stSql =  "select *  from  City ";
        $stSql .= " Where  city_id='{$city->getCityId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $city->setCity($fila["city"]);
        $city->setCountryId($fila["country_id"]);
        $city->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $city)
   {
        $stSql =  "select *  from  City ";
        $stSql .= " Where  city_id='{$city->getCityId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $city->setCity($fila["city"]);
        $city->setCountryId($fila["country_id"]);
        $city->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $city)
   {
        $stSql =  "select *  from  City ";
        $stSql .= " Where  city_id='{$city->getCityId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $city->setCity($fila["city"]);
        $city->setCountryId($fila["country_id"]);
        $city->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  City ";
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
