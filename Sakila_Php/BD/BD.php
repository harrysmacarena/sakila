<?PHP
 class BD{
    private static $miConexion;
    private $enlace;
	private $miRs;
    private $stHost='20.33.7.20';
    private $stUsuario='root'; 
    private $stClave='macaloreharrys';
    private $stBd='sakila';
	public static function getInstance(){
	    if (self::$miConexion == null){
		   //echo "Instancia Nulla<br>";
		   self::$miConexion = new BD();
		}
	     return self::$miConexion;
	}
    private function BD()
    {
		//$mbd = new PDO('mysql:host=localhost;dbname=prueba', $usuario, $contraseña);
		 $this->enlace = new PDO("mysql:host=" . $this->stHost . ";dbname=" .$this->stBd,$this->stUsuario,$this->stClave);
    }
	public function sqlEjecutar($stSql)
	{
        // Prepara la sentencia sql
        // en la BD abierta, asociada al enlace
	    $sentencia = $this->enlace->prepare($stSql);
		// Ejecuta la sentencia Sql
		$resultado = $sentencia->execute();
		// Si el resultado es true ejecuta la sentencia sin problemas
		if (!$resultado) 
		    print_r($sentencia->errorInfo());
		// El hecho que se ejecute
		// , no significa que existan registros afectados
		// por lo tanto retornamos la cantidad de registros afectados
		return $sentencia->rowCount();
	}     
    // Ejecuta una sentencia SQL y devuelve un cursor	
	public function sqlSelect($stSql)
	{
	    // Prepara la sentencia, en BD asociada a enlace 
	    // Observe que se enlaza con la variable $miRs
	    // la cual se encuentra declarada en la clase
	    $this->miRs = $this->enlace->prepare($stSql);
	    // Ejecuta la sentencia sql
	    return $this->miRs->execute();
	}     
	// Permite rescatar de la BD, el siguiente registro
	// Devuelve un arreglo con el registro leído
	// por medio de la variable miRS
	public function sqlFetch()
	{
	    return $this->miRs->fetch();
	}     
	public function sqlSelectTodo($stSql)
	{
		return $this->enlace->query($stSql) ;
	}     
 }
 /*
 $sql = "insert into actor(first_name,last_name)values('juan','valdivia')";
 $cnn = BD::getInstance()->sqlEjecutar($sql);
 $cnn = BD::getInstance()->sqlEjecutar($sql);
 $cnn = BD::getInstance()->sqlEjecutar($sql);
 $cnn = BD::getInstance()->sqlEjecutar($sql);
 */
 /*
 BD::getInstance()->sqlSelect("SELECT * from actor");
 $fila = BD::getInstance()->sqlFetch();
 print_r($fila);
 echo " <<=== fila 1<br>";
 $fila = BD::getInstance()->sqlFetch();
 print_r($fila);
 echo " <<=== fila 2<br>";
 while ($fila = BD::getInstance()->sqlFetch())
 {
	 print_r($fila);
	 echo " <<=== fila n<br>";
 }
 */
 /*
 foreach(BD::getInstance()->sqlSelectTodo("SELECT * from actor") as $fila) 
 {
        print_r($fila);
		echo "<br>";
 }
 */
 ?>
