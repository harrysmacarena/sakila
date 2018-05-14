<?PHP
// Nos conectamos a la base de datos
$mbd = new PDO('mysql:host=20.33.7.20;dbname=sakila', "root", "macaloreharrys");
// realizamos un select por medio del prepare observe el ?
$sentencia = $mbd->prepare("select * from actor where actor_id > ?");
// Ejecutamosla sentencia pasando un parámetro 50
$sentencia->execute(array(50));
  while ($fila = $sentencia->fetch()) {
    // Lee registro a registro e imprime los datos
    print_r($fila);
	echo "<br>";
  }
?>
