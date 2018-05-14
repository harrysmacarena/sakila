<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/filmDAO.php");
    $film = new Film($_POST['parFilmId']);
    $filmAux = new Film($_POST['parFilmId'],$_POST['parTitle'],$_POST['parDescription'],$_POST['parReleaseYear'],$_POST['parLanguageId'],$_POST['parOriginalLanguageId'],$_POST['parRentalDuration'],$_POST['parRentalRate'],$_POST['parLength'],$_POST['parReplacementCost'],$_POST['parRating'],$_POST['parSpecialFeatures'],$_POST['parLastUpdate']);
    $respuesta = filmDAO::sqlSelect($film);
	if ($respuesta== null){
		$respuesta = filmDAO::sqlInsert($filmAux);
	}
	else{
		$respuesta = filmDAO::sqlUpdate($filmAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
