<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/categoryDAO.php");
    $category = new Category($_POST['parCategoryId']);
    $categoryAux = new Category($_POST['parCategoryId'],$_POST['parName'],$_POST['parLastUpdate']);
    $respuesta = categoryDAO::sqlSelect($category);
	if ($respuesta== null){
		$respuesta = categoryDAO::sqlInsert($categoryAux);
	}
	else{
		$respuesta = categoryDAO::sqlUpdate($categoryAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
