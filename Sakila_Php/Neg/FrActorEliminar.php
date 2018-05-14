<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/actorDAO.php");
    $actor = new Actor($_POST['parActorId']);    $respuesta = actorDAO::sqlSelect($actor);
	if ($respuesta== null){
	   $respuesta = array("okey"=>false,"msg"=>"Error No Existe Registro");
	   echo json_encode($respuesta);
	   die();
	}

    $respuesta = actorDAO::sqlDelete($actor);
	if ($respuesta== null){
	    $respuesta = array("okey"=>true,"msg"=>"Okey");
	}
	else {
	$respuesta = $respuesta + array("Error"=>true,"msg"=>"Error Interno");
	}
	echo json_encode($respuesta);
?>
