<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/crudspringDAO.php");
    $crudspring = new Crudspring($_POST['parId']);
    $crudspringAux = new Crudspring($_POST['parId'],$_POST['parNombre'],$_POST['parSalario'],$_POST['parDescripcion']);
    $respuesta = crudspringDAO::sqlSelect($crudspring);
	if ($respuesta== null){
		$respuesta = crudspringDAO::sqlInsert($crudspringAux);
	}
	else{
		$respuesta = crudspringDAO::sqlUpdate($crudspringAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
