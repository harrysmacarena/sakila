<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/languageDAO.php");
    $language = new Language($_POST['parLanguageId']);
    $languageAux = new Language($_POST['parLanguageId'],$_POST['parName'],$_POST['parLastUpdate']);
    $respuesta = languageDAO::sqlSelect($language);
	if ($respuesta== null){
		$respuesta = languageDAO::sqlInsert($languageAux);
	}
	else{
		$respuesta = languageDAO::sqlUpdate($languageAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
