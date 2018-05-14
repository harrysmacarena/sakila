<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/eventosDAO.php");
    $eventos = new Eventos($_POST['parId']);
    $eventosAux = new Eventos($_POST['parId'],$_POST['parTitle'],$_POST['parBody'],$_POST['parUrl'],$_POST['parClass'],$_POST['parStart'],$_POST['parEnd'],$_POST['parInicioNormal'],$_POST['parFinalNormal']);
    $respuesta = eventosDAO::sqlSelect($eventos);
	if ($respuesta== null){
		$respuesta = eventosDAO::sqlInsert($eventosAux);
	}
	else{
		$respuesta = eventosDAO::sqlUpdate($eventosAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
