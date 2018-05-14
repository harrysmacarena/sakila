<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/actorDAO.php");
	//echo "hola como tas";
	//$respuesta = [{"0":"1","id_fruta":"1","1":"Manzana","nombre_fruta":"Manzana","2":"100","cantidad":"100"},{"0":"2","id_fruta":"2","1":"Platano","nombre_fruta":"Platano","2":"167","cantidad":"167"},{"0":"3","id_fruta":"3","1":"Pera","nombre_fruta":"Pera","2":"820","cantidad":"820"}]
//	$respuesta = array("okey"=>"true"
//	                    ,"msg"=>"Hola Como Tas"
//						,"regionId"=>"2"
//						,"regionName"=>"prueba");
    $actor = new Actor($_POST['parActorId']);
    $respuesta = actorDAO::sqlSelect($actor);
	if ($respuesta== null){
	    $respuesta = array("okey"=>false,"msg"=>"Error No Existe Registro");
	}
	else {
	$respuesta = $respuesta + array("okey"=>true,"msg"=>"Okey");
	}
	echo json_encode($respuesta);
?>
