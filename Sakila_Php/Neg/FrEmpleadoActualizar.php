<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/empleadoDAO.php");
    $empleado = new Empleado($_POST['parId']);
    $empleadoAux = new Empleado($_POST['parId'],$_POST['parNombre'],$_POST['parSalario'],$_POST['parDescripcion']);
    $respuesta = empleadoDAO::sqlSelect($empleado);
	if ($respuesta== null){
		$respuesta = empleadoDAO::sqlInsert($empleadoAux);
	}
	else{
		$respuesta = empleadoDAO::sqlUpdate($empleadoAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
