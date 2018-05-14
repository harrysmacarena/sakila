<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/customer.php");
class CustomerDAO {
   public static function sqlInsert( $customer)
   {
        $stSql  = "insert into Customer (";
        $stSql .= " customer_id ,store_id ,first_name ,last_name ,email ,address_id ,active ,create_date ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$customer->getCustomerId()}'"
                . ",'{$customer->getStoreId()}'"
                . ",'{$customer->getFirstName()}'"
                . ",'{$customer->getLastName()}'"
                . ",'{$customer->getEmail()}'"
                . ",'{$customer->getAddressId()}'"
                . ",'{$customer->getActive()}'"
                . ",'{$customer->getCreateDate()}'"
                . ",'{$customer->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $customer)
   {
        $stSql =  "update Customer SET ";
        $stSql .= " store_id='{$customer->getStoreId()}'"
                . ",first_name='{$customer->getFirstName()}'"
                . ",last_name='{$customer->getLastName()}'"
                . ",email='{$customer->getEmail()}'"
                . ",address_id='{$customer->getAddressId()}'"
                . ",active='{$customer->getActive()}'"
                . ",create_date='{$customer->getCreateDate()}'"
                . ",last_update='{$customer->getLastUpdate()}'"
                       ;
        $stSql .= " Where  customer_id='{$customer->getCustomerId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $customer)
   {
        $stSql =  "delete from  Customer ";
        $stSql .= " Where  customer_id='{$customer->getCustomerId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $customer)
   {
        $stSql =  "select *  from  Customer ";
        $stSql .= " Where  customer_id='{$customer->getCustomerId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneCustomer( $customer)
   {
        $stSql =  "select *  from  Customer ";
        $stSql .= " Where  customer_id='{$customer->getCustomerId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $customer->setStoreId($fila["store_id"]);
        $customer->setFirstName($fila["first_name"]);
        $customer->setLastName($fila["last_name"]);
        $customer->setEmail($fila["email"]);
        $customer->setAddressId($fila["address_id"]);
        $customer->setActive($fila["active"]);
        $customer->setCreateDate($fila["create_date"]);
        $customer->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $customer)
   {
        $stSql =  "select *  from  Customer ";
        $stSql .= " Where  customer_id='{$customer->getCustomerId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $customer->setStoreId($fila["store_id"]);
        $customer->setFirstName($fila["first_name"]);
        $customer->setLastName($fila["last_name"]);
        $customer->setEmail($fila["email"]);
        $customer->setAddressId($fila["address_id"]);
        $customer->setActive($fila["active"]);
        $customer->setCreateDate($fila["create_date"]);
        $customer->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $customer)
   {
        $stSql =  "select *  from  Customer ";
        $stSql .= " Where  customer_id='{$customer->getCustomerId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $customer->setStoreId($fila["store_id"]);
        $customer->setFirstName($fila["first_name"]);
        $customer->setLastName($fila["last_name"]);
        $customer->setEmail($fila["email"]);
        $customer->setAddressId($fila["address_id"]);
        $customer->setActive($fila["active"]);
        $customer->setCreateDate($fila["create_date"]);
        $customer->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Customer ";
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
