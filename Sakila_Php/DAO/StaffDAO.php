<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/staff.php");
class StaffDAO {
   public static function sqlInsert( $staff)
   {
        $stSql  = "insert into Staff (";
        $stSql .= " staff_id ,first_name ,last_name ,address_id ,picture ,email ,store_id ,active ,username ,password ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$staff->getStaffId()}'"
                . ",'{$staff->getFirstName()}'"
                . ",'{$staff->getLastName()}'"
                . ",'{$staff->getAddressId()}'"
                . ",'{$staff->getPicture()}'"
                . ",'{$staff->getEmail()}'"
                . ",'{$staff->getStoreId()}'"
                . ",'{$staff->getActive()}'"
                . ",'{$staff->getUsername()}'"
                . ",'{$staff->getPassword()}'"
                . ",'{$staff->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $staff)
   {
        $stSql =  "update Staff SET ";
        $stSql .= " first_name='{$staff->getFirstName()}'"
                . ",last_name='{$staff->getLastName()}'"
                . ",address_id='{$staff->getAddressId()}'"
                . ",picture='{$staff->getPicture()}'"
                . ",email='{$staff->getEmail()}'"
                . ",store_id='{$staff->getStoreId()}'"
                . ",active='{$staff->getActive()}'"
                . ",username='{$staff->getUsername()}'"
                . ",password='{$staff->getPassword()}'"
                . ",last_update='{$staff->getLastUpdate()}'"
                       ;
        $stSql .= " Where  staff_id='{$staff->getStaffId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $staff)
   {
        $stSql =  "delete from  Staff ";
        $stSql .= " Where  staff_id='{$staff->getStaffId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $staff)
   {
        $stSql =  "select *  from  Staff ";
        $stSql .= " Where  staff_id='{$staff->getStaffId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneStaff( $staff)
   {
        $stSql =  "select *  from  Staff ";
        $stSql .= " Where  staff_id='{$staff->getStaffId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $staff->setFirstName($fila["first_name"]);
        $staff->setLastName($fila["last_name"]);
        $staff->setAddressId($fila["address_id"]);
        $staff->setPicture($fila["picture"]);
        $staff->setEmail($fila["email"]);
        $staff->setStoreId($fila["store_id"]);
        $staff->setActive($fila["active"]);
        $staff->setUsername($fila["username"]);
        $staff->setPassword($fila["password"]);
        $staff->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $staff)
   {
        $stSql =  "select *  from  Staff ";
        $stSql .= " Where  staff_id='{$staff->getStaffId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $staff->setFirstName($fila["first_name"]);
        $staff->setLastName($fila["last_name"]);
        $staff->setAddressId($fila["address_id"]);
        $staff->setPicture($fila["picture"]);
        $staff->setEmail($fila["email"]);
        $staff->setStoreId($fila["store_id"]);
        $staff->setActive($fila["active"]);
        $staff->setUsername($fila["username"]);
        $staff->setPassword($fila["password"]);
        $staff->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $staff)
   {
        $stSql =  "select *  from  Staff ";
        $stSql .= " Where  staff_id='{$staff->getStaffId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $staff->setFirstName($fila["first_name"]);
        $staff->setLastName($fila["last_name"]);
        $staff->setAddressId($fila["address_id"]);
        $staff->setPicture($fila["picture"]);
        $staff->setEmail($fila["email"]);
        $staff->setStoreId($fila["store_id"]);
        $staff->setActive($fila["active"]);
        $staff->setUsername($fila["username"]);
        $staff->setPassword($fila["password"]);
        $staff->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Staff ";
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
