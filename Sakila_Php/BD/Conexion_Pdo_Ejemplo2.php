<?PHP

// Nos Conectamos con a nuestra base de datos.
$mbd = new PDO('mysql:host=20.33.7.20;dbname=sakila', "root", "macaloreharrys");
// Observe que en vez de :nomval utilizamos el signo de pregunta.
$sentencia = $mbd->prepare("insert into actor(first_name,last_name)values(?,?)");
// Asociamos los parámetros por medio de las posiciones
// Osea el 1 con el primer ?
//      el 2 con el segundo ? 
$sentencia->bindParam(1, $nombre);
$sentencia->bindParam(2, $apellido);

// insertar una fila
$nombre = "Harrys 3333";
$apellido = "Informatica 3333";
//$valor = 1;   // si fuera numérico

$sentencia->execute();

$nombre = "Harrys 4444";
$apellido = "Informatica  4444";
$sentencia->execute();
echo "Todo Okey";
?>
