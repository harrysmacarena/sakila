<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/customerDAO.php");
    $customer = new Customer($_POST['parCustomerId']);
    $customerAux = new Customer($_POST['parCustomerId'],$_POST['parStoreId'],$_POST['parFirstName'],$_POST['parLastName'],$_POST['parEmail'],$_POST['parAddressId'],$_POST['parActive'],$_POST['parCreateDate'],$_POST['parLastUpdate']);
    $respuesta = customerDAO::sqlSelect($customer);
	if ($respuesta== null){
		$respuesta = customerDAO::sqlInsert($customerAux);
	}
	else{
		$respuesta = customerDAO::sqlUpdate($customerAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
