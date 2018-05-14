<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/storeDAO.php");
    $store = new Store($_POST['parStoreId']);    $respuesta = storeDAO::sqlSelect($store);
	if ($respuesta== null){
	   $respuesta = array("okey"=>false,"msg"=>"Error No Existe Registro");
	   echo json_encode($respuesta);
	   die();
	}

    $respuesta = storeDAO::sqlDelete($store);
	if ($respuesta== null){
	    $respuesta = array("okey"=>true,"msg"=>"Okey");
	}
	else {
	$respuesta = $respuesta + array("Error"=>true,"msg"=>"Error Interno");
	}
	echo json_encode($respuesta);
?>
