<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/countryDAO.php");
    $country = new Country($_POST['parCountryId']);
    $countryAux = new Country($_POST['parCountryId'],$_POST['parCountry'],$_POST['parLastUpdate']);
    $respuesta = countryDAO::sqlSelect($country);
	if ($respuesta== null){
		$respuesta = countryDAO::sqlInsert($countryAux);
	}
	else{
		$respuesta = countryDAO::sqlUpdate($countryAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
