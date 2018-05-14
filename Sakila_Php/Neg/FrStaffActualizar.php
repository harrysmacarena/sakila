<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/staffDAO.php");
    $staff = new Staff($_POST['parStaffId']);
    $staffAux = new Staff($_POST['parStaffId'],$_POST['parFirstName'],$_POST['parLastName'],$_POST['parAddressId'],$_POST['parPicture'],$_POST['parEmail'],$_POST['parStoreId'],$_POST['parActive'],$_POST['parUsername'],$_POST['parPassword'],$_POST['parLastUpdate']);
    $respuesta = staffDAO::sqlSelect($staff);
	if ($respuesta== null){
		$respuesta = staffDAO::sqlInsert($staffAux);
	}
	else{
		$respuesta = staffDAO::sqlUpdate($staffAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
