<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/rentalDAO.php");
    $rental = new Rental($_POST['parRentalId']);
    $rentalAux = new Rental($_POST['parRentalId'],$_POST['parRentalDate'],$_POST['parInventoryId'],$_POST['parCustomerId'],$_POST['parReturnDate'],$_POST['parStaffId'],$_POST['parLastUpdate']);
    $respuesta = rentalDAO::sqlSelect($rental);
	if ($respuesta== null){
		$respuesta = rentalDAO::sqlInsert($rentalAux);
	}
	else{
		$respuesta = rentalDAO::sqlUpdate($rentalAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
