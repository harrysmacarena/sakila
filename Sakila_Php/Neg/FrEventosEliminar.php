<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/eventosDAO.php");
    $eventos = new Eventos($_POST['parId']);    $respuesta = eventosDAO::sqlSelect($eventos);
	if ($respuesta== null){
	   $respuesta = array("okey"=>false,"msg"=>"Error No Existe Registro");
	   echo json_encode($respuesta);
	   die();
	}

    $respuesta = eventosDAO::sqlDelete($eventos);
	if ($respuesta== null){
	    $respuesta = array("okey"=>true,"msg"=>"Okey");
	}
	else {
	$respuesta = $respuesta + array("Error"=>true,"msg"=>"Error Interno");
	}
	echo json_encode($respuesta);
?>
