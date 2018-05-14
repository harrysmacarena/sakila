<?PHP
//C:\wamp\bin\apache\Apache2.2.17\bin
//http://php.net/manual/es/ref.oci8.php
//Ejemplo #1 Uso b�sico de oci_connect() utilizando la sintaxis de Easy Connect
  $conn = oci_connect('electrica', 'macarena', '10.20.64.5/xe');
  if (!$conn) {
		$e = oci_error();
		trigger_error(htmlentities($e['message'], ENT_QUOTES), E_USER_ERROR);
  }  
  echo "Conectado a Oracle con usuario electrica y clave macarena <br>";

$stid = oci_parse($conn, 'SELECT * FROM tarifa');
oci_execute($stid);

echo "<table border='1'>\n";
while ($row = oci_fetch_array($stid, OCI_ASSOC+OCI_RETURN_NULLS)) {
    echo "<tr>\n";
	//echo $row['LAST_NAME'] ."<br>\n";
    foreach ($row as $item) {
        echo "    <td>" . ($item !== null ? htmlentities($item, ENT_QUOTES) : "") . "</td>\n";
    }
    echo "</tr>\n";
}
echo "</table>\n";

// Conectar a la base de datos harrys descrita en el fichero tnsnames.ora,
// Un ejemplo de una entrada de tnsnames.ora para harrys podr�a ser:
//   harrys =
//     (DESCRIPTION =
//       (ADDRESS = (PROTOCOL = TCP)(HOST = 10.20.64.5)(PORT = 1521))
//       (CONNECT_DATA =
//         (SERVER = DEDICATED)
//         (SERVICE_NAME = XE)
//       )
//     )
$conn = oci_connect('electrica', 'macarena', 'harrys');
if (!$conn) {
    $e = oci_error();
    trigger_error(htmlentities($e['message'], ENT_QUOTES), E_USER_ERROR);
}

//Ejemplo #3 oci_connect() con un conjunto de caracteres expl�cito

$conn = oci_connect('electrica', 'macarena', 'harrys','AL32UTF8');
if (!$conn) {
    $e = oci_error();
    trigger_error(htmlentities($e['message'], ENT_QUOTES), E_USER_ERROR);
}


function create_table($conn)
{
    $stmt = oci_parse($conn, "create table hallo (test varchar2(64))");
    oci_execute($stmt);
    echo "Created table<br>\n";
}

function drop_table($conn)
{
    $stmt = oci_parse($conn, "drop table hallo");
    oci_execute($stmt);
    echo "Dropped table<br>\n";
}

function insert_data($conn)
{
    $stmt = oci_parse($conn, "insert into hallo
              values(to_char(sysdate,'DD-MON-YY HH24:MI:SS'))");
    oci_execute($stmt, OCI_DEFAULT);
    echo "inserted row without committing<br>\n";
}

function rollback( $conn)
{
    oci_rollback($conn);
    echo " rollback<br>\n";
}
function commit(){
	// Consignar los cambios de ambas tablas
	$r = oci_commit($conn);
	if (!r) {
		$e = oci_error($conn);
		trigger_error(htmlentities($e['message']), E_USER_ERROR);
	}
}
function commit_no_autocommit(){
    $stid = oci_parse($conn, 'INSERT INTO myschedule (startday) VALUES (12)');
	$r = oci_execute($stid, OCI_NO_AUTO_COMMIT);
	if (!$r) {    
		$e = oci_error($stid);
		oci_rollback($conn);  // revertir los cambios en ambas tablas
		trigger_error(htmlentities($e['message']), E_USER_ERROR);
	}
}


?>
