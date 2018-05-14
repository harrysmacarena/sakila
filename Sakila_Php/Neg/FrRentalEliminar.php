<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/rentalDAO.php");
    $rental = new Rental($_POST['parRentalId']);    $respuesta = rentalDAO::sqlSelect($rental);
	if ($respuesta== null){
	   $respuesta = array("okey"=>false,"msg"=>"Error No Existe Registro");
	   echo json_encode($respuesta);
	   die();
	}

    $respuesta = rentalDAO::sqlDelete($rental);
	if ($respuesta== null){
	    $respuesta = array("okey"=>true,"msg"=>"Okey");
	}
	else {
	$respuesta = $respuesta + array("Error"=>true,"msg"=>"Error Interno");
	}
	echo json_encode($respuesta);
?>
