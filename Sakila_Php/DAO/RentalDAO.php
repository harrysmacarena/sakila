<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/rental.php");
class RentalDAO {
   public static function sqlInsert( $rental)
   {
        $stSql  = "insert into Rental (";
        $stSql .= " rental_id ,rental_date ,inventory_id ,customer_id ,return_date ,staff_id ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$rental->getRentalId()}'"
                . ",'{$rental->getRentalDate()}'"
                . ",'{$rental->getInventoryId()}'"
                . ",'{$rental->getCustomerId()}'"
                . ",'{$rental->getReturnDate()}'"
                . ",'{$rental->getStaffId()}'"
                . ",'{$rental->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $rental)
   {
        $stSql =  "update Rental SET ";
        $stSql .= " rental_date='{$rental->getRentalDate()}'"
                . ",inventory_id='{$rental->getInventoryId()}'"
                . ",customer_id='{$rental->getCustomerId()}'"
                . ",return_date='{$rental->getReturnDate()}'"
                . ",staff_id='{$rental->getStaffId()}'"
                . ",last_update='{$rental->getLastUpdate()}'"
                       ;
        $stSql .= " Where  rental_id='{$rental->getRentalId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $rental)
   {
        $stSql =  "delete from  Rental ";
        $stSql .= " Where  rental_id='{$rental->getRentalId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $rental)
   {
        $stSql =  "select *  from  Rental ";
        $stSql .= " Where  rental_id='{$rental->getRentalId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneRental( $rental)
   {
        $stSql =  "select *  from  Rental ";
        $stSql .= " Where  rental_id='{$rental->getRentalId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $rental->setRentalDate($fila["rental_date"]);
        $rental->setInventoryId($fila["inventory_id"]);
        $rental->setCustomerId($fila["customer_id"]);
        $rental->setReturnDate($fila["return_date"]);
        $rental->setStaffId($fila["staff_id"]);
        $rental->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $rental)
   {
        $stSql =  "select *  from  Rental ";
        $stSql .= " Where  rental_id='{$rental->getRentalId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $rental->setRentalDate($fila["rental_date"]);
        $rental->setInventoryId($fila["inventory_id"]);
        $rental->setCustomerId($fila["customer_id"]);
        $rental->setReturnDate($fila["return_date"]);
        $rental->setStaffId($fila["staff_id"]);
        $rental->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $rental)
   {
        $stSql =  "select *  from  Rental ";
        $stSql .= " Where  rental_id='{$rental->getRentalId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $rental->setRentalDate($fila["rental_date"]);
        $rental->setInventoryId($fila["inventory_id"]);
        $rental->setCustomerId($fila["customer_id"]);
        $rental->setReturnDate($fila["return_date"]);
        $rental->setStaffId($fila["staff_id"]);
        $rental->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Rental ";
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
