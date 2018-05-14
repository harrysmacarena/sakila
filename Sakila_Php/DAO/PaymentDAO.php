<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/payment.php");
class PaymentDAO {
   public static function sqlInsert( $payment)
   {
        $stSql  = "insert into Payment (";
        $stSql .= " payment_id ,customer_id ,staff_id ,rental_id ,amount ,payment_date ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$payment->getPaymentId()}'"
                . ",'{$payment->getCustomerId()}'"
                . ",'{$payment->getStaffId()}'"
                . ",'{$payment->getRentalId()}'"
                . ",'{$payment->getAmount()}'"
                . ",'{$payment->getPaymentDate()}'"
                . ",'{$payment->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $payment)
   {
        $stSql =  "update Payment SET ";
        $stSql .= " customer_id='{$payment->getCustomerId()}'"
                . ",staff_id='{$payment->getStaffId()}'"
                . ",rental_id='{$payment->getRentalId()}'"
                . ",amount='{$payment->getAmount()}'"
                . ",payment_date='{$payment->getPaymentDate()}'"
                . ",last_update='{$payment->getLastUpdate()}'"
                       ;
        $stSql .= " Where  payment_id='{$payment->getPaymentId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $payment)
   {
        $stSql =  "delete from  Payment ";
        $stSql .= " Where  payment_id='{$payment->getPaymentId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $payment)
   {
        $stSql =  "select *  from  Payment ";
        $stSql .= " Where  payment_id='{$payment->getPaymentId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOnePayment( $payment)
   {
        $stSql =  "select *  from  Payment ";
        $stSql .= " Where  payment_id='{$payment->getPaymentId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $payment->setCustomerId($fila["customer_id"]);
        $payment->setStaffId($fila["staff_id"]);
        $payment->setRentalId($fila["rental_id"]);
        $payment->setAmount($fila["amount"]);
        $payment->setPaymentDate($fila["payment_date"]);
        $payment->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $payment)
   {
        $stSql =  "select *  from  Payment ";
        $stSql .= " Where  payment_id='{$payment->getPaymentId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $payment->setCustomerId($fila["customer_id"]);
        $payment->setStaffId($fila["staff_id"]);
        $payment->setRentalId($fila["rental_id"]);
        $payment->setAmount($fila["amount"]);
        $payment->setPaymentDate($fila["payment_date"]);
        $payment->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $payment)
   {
        $stSql =  "select *  from  Payment ";
        $stSql .= " Where  payment_id='{$payment->getPaymentId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $payment->setCustomerId($fila["customer_id"]);
        $payment->setStaffId($fila["staff_id"]);
        $payment->setRentalId($fila["rental_id"]);
        $payment->setAmount($fila["amount"]);
        $payment->setPaymentDate($fila["payment_date"]);
        $payment->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Payment ";
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
