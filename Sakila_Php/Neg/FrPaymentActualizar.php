<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/paymentDAO.php");
    $payment = new Payment($_POST['parPaymentId']);
    $paymentAux = new Payment($_POST['parPaymentId'],$_POST['parCustomerId'],$_POST['parStaffId'],$_POST['parRentalId'],$_POST['parAmount'],$_POST['parPaymentDate'],$_POST['parLastUpdate']);
    $respuesta = paymentDAO::sqlSelect($payment);
	if ($respuesta== null){
		$respuesta = paymentDAO::sqlInsert($paymentAux);
	}
	else{
		$respuesta = paymentDAO::sqlUpdate($paymentAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
