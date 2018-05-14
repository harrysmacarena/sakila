<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/store.php");
class StoreDAO {
   public static function sqlInsert( $store)
   {
        $stSql  = "insert into Store (";
        $stSql .= " store_id ,manager_staff_id ,address_id ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$store->getStoreId()}'"
                . ",'{$store->getManagerStaffId()}'"
                . ",'{$store->getAddressId()}'"
                . ",'{$store->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $store)
   {
        $stSql =  "update Store SET ";
        $stSql .= " manager_staff_id='{$store->getManagerStaffId()}'"
                . ",address_id='{$store->getAddressId()}'"
                . ",last_update='{$store->getLastUpdate()}'"
                       ;
        $stSql .= " Where  store_id='{$store->getStoreId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $store)
   {
        $stSql =  "delete from  Store ";
        $stSql .= " Where  store_id='{$store->getStoreId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $store)
   {
        $stSql =  "select *  from  Store ";
        $stSql .= " Where  store_id='{$store->getStoreId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneStore( $store)
   {
        $stSql =  "select *  from  Store ";
        $stSql .= " Where  store_id='{$store->getStoreId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $store->setManagerStaffId($fila["manager_staff_id"]);
        $store->setAddressId($fila["address_id"]);
        $store->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $store)
   {
        $stSql =  "select *  from  Store ";
        $stSql .= " Where  store_id='{$store->getStoreId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $store->setManagerStaffId($fila["manager_staff_id"]);
        $store->setAddressId($fila["address_id"]);
        $store->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $store)
   {
        $stSql =  "select *  from  Store ";
        $stSql .= " Where  store_id='{$store->getStoreId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $store->setManagerStaffId($fila["manager_staff_id"]);
        $store->setAddressId($fila["address_id"]);
        $store->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Store ";
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
