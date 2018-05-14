<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/countryDAO.php");
    $country = new Country($_POST['parCountryId']);    $respuesta = countryDAO::sqlSelect($country);
	if ($respuesta== null){
	   $respuesta = array("okey"=>false,"msg"=>"Error No Existe Registro");
	   echo json_encode($respuesta);
	   die();
	}

    $respuesta = countryDAO::sqlDelete($country);
	if ($respuesta== null){
	    $respuesta = array("okey"=>true,"msg"=>"Okey");
	}
	else {
	$respuesta = $respuesta + array("Error"=>true,"msg"=>"Error Interno");
	}
	echo json_encode($respuesta);
?>
