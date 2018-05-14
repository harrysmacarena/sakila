<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/personaDAO.php");
    $persona = new Persona($_POST['parRut']);
    $personaAux = new Persona($_POST['parRut'],$_POST['parDv'],$_POST['parNombres'],$_POST['parEstatura'],$_POST['parSexo'],$_POST['parEsCasado'],$_POST['parEmilia'],$_POST['parAriel']);
    $respuesta = personaDAO::sqlSelect($persona);
	if ($respuesta== null){
		$respuesta = personaDAO::sqlInsert($personaAux);
	}
	else{
		$respuesta = personaDAO::sqlUpdate($personaAux);
	}
	$respuesta = array("okey"=>true,"msg"=>"Okey");
	echo json_encode($respuesta);
	
?>
