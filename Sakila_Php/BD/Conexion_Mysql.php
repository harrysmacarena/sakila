<?PHP
 class BD{
    private $enlace;
    private $stHost='localhost';
    private $stUsuario='root'; 
    private $stClave='macaloreharrys1';
    private $stBd='sakila';
    function __construct()
    {
		//$mbd = new PDO('mysql:host=localhost;dbname=prueba', $usuario, $contraseña);
		 $this->enlace =  new PDO("mysql:host=" . $this->stHost . ";dbname=" .$this->stBd,$this->stUsuario,$this->stClave);
        //echo "constructor bd";
    }
	public function sqlEjecutar($stsql)
	{
		$mydb = mysql_select_db($this->stBd,$enlace)  or die("me cai en Seleccionar bd"  . mysql_error() );
		$myRs = mysql_query($stsql,$enlace)  or die("me cai en insertar==>"  . mysql_error() );
	}     
	public function sqlSelect($stsql)
	{
		$enlace =  mysql_connect($this->stHost,$this->stUsuario, $this->stClave)   
											  or die("me cai en conexion"  . mysql_error() );
		$mydb = mysql_select_db($this->stBd,$enlace)  or die("me cai en Seleccionar bd"  . mysql_error() );
		$myRs = mysql_query($stsql,$enlace)  or die("me cai en insertar==>"  . mysql_error() );
		if (!$myRs) return null;
		$row = mysql_fetch_array($myRs);
		return $row; 
	}     
	public function sqlSelectTodo($stsql)
	{
		$enlace =  mysql_connect($this->stHost,$this->stUsuario, $this->stClave)   
											  or die("me cai en conexion"  . mysql_error() );
		$mydb = mysql_select_db($this->stBd,$enlace)  or die("me cai en Seleccionar bd"  . mysql_error() );
		$myRs = mysql_query($stsql,$enlace)  or die("me cai en insertar==>"  . mysql_error() );
		if (!$myRs) return null;
		while ($row = mysql_fetch_array($myRs)) {
			$resultado[] = $row;
		}
		mysql_free_result($myRs);
		return $resultado;
	}     
 }
 $cnn = new BD();
 echo "Todo Okey";
 ?>
