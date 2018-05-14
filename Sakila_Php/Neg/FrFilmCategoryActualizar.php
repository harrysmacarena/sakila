<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/filmCategoryDAO.php");
    $filmCategory = new FilmCategory($_POST['parFilmId'],$_POST['parCategoryId']);
    $filmCategoryAux = new FilmCategory($_POST['parFilmId'],$_POST['parCategoryId'],$_POST['parLastUpdate']);
    $respuesta = filmCategoryDAO::sqlSelect($filmCategory);
	if ($respuesta== null){
		$respuesta = filmCategoryDAO::sqlInsert($filmCategoryAux);
	}
	else{
		$respuesta = filmCategoryDAO::sqlUpdate($filmCategoryAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
