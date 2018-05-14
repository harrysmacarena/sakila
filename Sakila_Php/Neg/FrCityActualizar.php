<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/cityDAO.php");
    $city = new City($_POST['parCityId']);
    $cityAux = new City($_POST['parCityId'],$_POST['parCity'],$_POST['parCountryId'],$_POST['parLastUpdate']);
    $respuesta = cityDAO::sqlSelect($city);
	if ($respuesta== null){
		$respuesta = cityDAO::sqlInsert($cityAux);
	}
	else{
		$respuesta = cityDAO::sqlUpdate($cityAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
