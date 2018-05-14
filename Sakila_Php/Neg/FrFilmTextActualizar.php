<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/filmTextDAO.php");
    $filmText = new FilmText($_POST['parFilmId']);
    $filmTextAux = new FilmText($_POST['parFilmId'],$_POST['parTitle'],$_POST['parDescription']);
    $respuesta = filmTextDAO::sqlSelect($filmText);
	if ($respuesta== null){
		$respuesta = filmTextDAO::sqlInsert($filmTextAux);
	}
	else{
		$respuesta = filmTextDAO::sqlUpdate($filmTextAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
