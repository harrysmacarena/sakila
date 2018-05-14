<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/storeDAO.php");
    $store = new Store($_POST['parStoreId']);
    $storeAux = new Store($_POST['parStoreId'],$_POST['parManagerStaffId'],$_POST['parAddressId'],$_POST['parLastUpdate']);
    $respuesta = storeDAO::sqlSelect($store);
	if ($respuesta== null){
		$respuesta = storeDAO::sqlInsert($storeAux);
	}
	else{
		$respuesta = storeDAO::sqlUpdate($storeAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
