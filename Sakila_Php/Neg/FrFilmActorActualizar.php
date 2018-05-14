<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/filmActorDAO.php");
    $filmActor = new FilmActor($_POST['parActorId'],$_POST['parFilmId']);
    $filmActorAux = new FilmActor($_POST['parActorId'],$_POST['parFilmId'],$_POST['parLastUpdate']);
    $respuesta = filmActorDAO::sqlSelect($filmActor);
	if ($respuesta== null){
		$respuesta = filmActorDAO::sqlInsert($filmActorAux);
	}
	else{
		$respuesta = filmActorDAO::sqlUpdate($filmActorAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
