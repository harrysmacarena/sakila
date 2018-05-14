<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/actorDAO.php");
    $actor = new Actor($_POST['parActorId']);
    $actorAux = new Actor($_POST['parActorId'],$_POST['parFirstName'],$_POST['parLastName'],$_POST['parLastUpdate']);
    $respuesta = actorDAO::sqlSelect($actor);
	if ($respuesta== null){
		$respuesta = actorDAO::sqlInsert($actorAux);
	}
	else{
		$respuesta = actorDAO::sqlUpdate($actorAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
