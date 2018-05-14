<?PHP
// Utilizando PDO nos conectamos a nuestra base de datos
// Modificamos los siguientes parámetros
//        Host     ==> servidor 20.33.7.20
//        dbname   ==> Nombre de la base de datos
//        root     ==> usuario con el cual nos conectamos
//        macarena ==> clave del usuario de conexión
// retorna el enlace de la conexión realizada
//     , en este caso la almacenamosen $mbd
//     , ya que la utilizaremos para realizar más acciones 
$mbd = new PDO('mysql:host=20.33.7.20;dbname=sakila', "root", "macaloreharrys");

// Utilizamos la instrucción prepare, para crear nuestra sentencia sql
// Si Observamos en los values declaramos dos campos con ":"
// esto significa que los valores se entregaran por bind
$sentencia = $mbd->prepare("insert into actor(first_name,last_name)values(:nomval,:apeval)");
// entregamos el primer parámetro llamado nombre con la variable nombre
$sentencia->bindParam(':nomval', $nombre);
// entregamos el segundo parámetro llamado apellido con la variable apellido
$sentencia->bindParam(':apeval', $apellido);

//  asignamos los valores a las variables asociadas
$nombre = "Harrys";
$apellido = "Informatica";
//$valor = 1;   // si fuera numérico

// Ejecutamos la sentencia
$sentencia->execute();

// Volvemos a modificar las variables asociadas
$nombre = "Harrys 222";
$apellido = "Informatica  222";

// Realizamos un nuevo insert
$sentencia->execute();
echo "Todo Okey";
?>
