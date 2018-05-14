<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/inventoryDAO.php");
    $inventory = new Inventory($_POST['parInventoryId']);
    $inventoryAux = new Inventory($_POST['parInventoryId'],$_POST['parFilmId'],$_POST['parStoreId'],$_POST['parLastUpdate']);
    $respuesta = inventoryDAO::sqlSelect($inventory);
	if ($respuesta== null){
		$respuesta = inventoryDAO::sqlInsert($inventoryAux);
	}
	else{
		$respuesta = inventoryDAO::sqlUpdate($inventoryAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
