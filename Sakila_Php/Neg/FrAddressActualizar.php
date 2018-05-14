<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/addressDAO.php");
    $address = new Address($_POST['parAddressId']);
    $addressAux = new Address($_POST['parAddressId'],$_POST['parAddress'],$_POST['parAddress2'],$_POST['parDistrict'],$_POST['parCityId'],$_POST['parPostalCode'],$_POST['parPhone'],$_POST['parLastUpdate']);
    $respuesta = addressDAO::sqlSelect($address);
	if ($respuesta== null){
		$respuesta = addressDAO::sqlInsert($addressAux);
	}
	else{
		$respuesta = addressDAO::sqlUpdate($addressAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
