<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/inventory.php");
class InventoryDAO {
   public static function sqlInsert( $inventory)
   {
        $stSql  = "insert into Inventory (";
        $stSql .= " inventory_id ,film_id ,store_id ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$inventory->getInventoryId()}'"
                . ",'{$inventory->getFilmId()}'"
                . ",'{$inventory->getStoreId()}'"
                . ",'{$inventory->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $inventory)
   {
        $stSql =  "update Inventory SET ";
        $stSql .= " film_id='{$inventory->getFilmId()}'"
                . ",store_id='{$inventory->getStoreId()}'"
                . ",last_update='{$inventory->getLastUpdate()}'"
                       ;
        $stSql .= " Where  inventory_id='{$inventory->getInventoryId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $inventory)
   {
        $stSql =  "delete from  Inventory ";
        $stSql .= " Where  inventory_id='{$inventory->getInventoryId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $inventory)
   {
        $stSql =  "select *  from  Inventory ";
        $stSql .= " Where  inventory_id='{$inventory->getInventoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneInventory( $inventory)
   {
        $stSql =  "select *  from  Inventory ";
        $stSql .= " Where  inventory_id='{$inventory->getInventoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $inventory->setFilmId($fila["film_id"]);
        $inventory->setStoreId($fila["store_id"]);
        $inventory->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $inventory)
   {
        $stSql =  "select *  from  Inventory ";
        $stSql .= " Where  inventory_id='{$inventory->getInventoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $inventory->setFilmId($fila["film_id"]);
        $inventory->setStoreId($fila["store_id"]);
        $inventory->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $inventory)
   {
        $stSql =  "select *  from  Inventory ";
        $stSql .= " Where  inventory_id='{$inventory->getInventoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $inventory->setFilmId($fila["film_id"]);
        $inventory->setStoreId($fila["store_id"]);
        $inventory->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Inventory ";
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
