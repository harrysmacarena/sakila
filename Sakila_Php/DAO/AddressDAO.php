<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/address.php");
class AddressDAO {
   public static function sqlInsert( $address)
   {
        $stSql  = "insert into Address (";
        $stSql .= " address_id ,address ,address2 ,district ,city_id ,postal_code ,phone ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$address->getAddressId()}'"
                . ",'{$address->getAddress()}'"
                . ",'{$address->getAddress2()}'"
                . ",'{$address->getDistrict()}'"
                . ",'{$address->getCityId()}'"
                . ",'{$address->getPostalCode()}'"
                . ",'{$address->getPhone()}'"
                . ",'{$address->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $address)
   {
        $stSql =  "update Address SET ";
        $stSql .= " address='{$address->getAddress()}'"
                . ",address2='{$address->getAddress2()}'"
                . ",district='{$address->getDistrict()}'"
                . ",city_id='{$address->getCityId()}'"
                . ",postal_code='{$address->getPostalCode()}'"
                . ",phone='{$address->getPhone()}'"
                . ",last_update='{$address->getLastUpdate()}'"
                       ;
        $stSql .= " Where  address_id='{$address->getAddressId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $address)
   {
        $stSql =  "delete from  Address ";
        $stSql .= " Where  address_id='{$address->getAddressId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $address)
   {
        $stSql =  "select *  from  Address ";
        $stSql .= " Where  address_id='{$address->getAddressId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneAddress( $address)
   {
        $stSql =  "select *  from  Address ";
        $stSql .= " Where  address_id='{$address->getAddressId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $address->setAddress($fila["address"]);
        $address->setAddress2($fila["address2"]);
        $address->setDistrict($fila["district"]);
        $address->setCityId($fila["city_id"]);
        $address->setPostalCode($fila["postal_code"]);
        $address->setPhone($fila["phone"]);
        $address->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $address)
   {
        $stSql =  "select *  from  Address ";
        $stSql .= " Where  address_id='{$address->getAddressId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $address->setAddress($fila["address"]);
        $address->setAddress2($fila["address2"]);
        $address->setDistrict($fila["district"]);
        $address->setCityId($fila["city_id"]);
        $address->setPostalCode($fila["postal_code"]);
        $address->setPhone($fila["phone"]);
        $address->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $address)
   {
        $stSql =  "select *  from  Address ";
        $stSql .= " Where  address_id='{$address->getAddressId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $address->setAddress($fila["address"]);
        $address->setAddress2($fila["address2"]);
        $address->setDistrict($fila["district"]);
        $address->setCityId($fila["city_id"]);
        $address->setPostalCode($fila["postal_code"]);
        $address->setPhone($fila["phone"]);
        $address->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Address ";
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
