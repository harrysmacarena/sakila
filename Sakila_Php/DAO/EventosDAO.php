<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/eventos.php");
class EventosDAO {
   public static function sqlInsert( $eventos)
   {
        $stSql  = "insert into Eventos (";
        $stSql .= " id ,title ,body ,url ,class ,start ,end ,inicio_normal ,final_normal";
        $stSql .= " )values (";
        $stSql .= " '{$eventos->getId()}'"
                . ",'{$eventos->getTitle()}'"
                . ",'{$eventos->getBody()}'"
                . ",'{$eventos->getUrl()}'"
                . ",'{$eventos->getClass()}'"
                . ",'{$eventos->getStart()}'"
                . ",'{$eventos->getEnd()}'"
                . ",'{$eventos->getInicioNormal()}'"
                . ",'{$eventos->getFinalNormal()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $eventos)
   {
        $stSql =  "update Eventos SET ";
        $stSql .= " title='{$eventos->getTitle()}'"
                . ",body='{$eventos->getBody()}'"
                . ",url='{$eventos->getUrl()}'"
                . ",class='{$eventos->getClass()}'"
                . ",start='{$eventos->getStart()}'"
                . ",end='{$eventos->getEnd()}'"
                . ",inicio_normal='{$eventos->getInicioNormal()}'"
                . ",final_normal='{$eventos->getFinalNormal()}'"
                       ;
        $stSql .= " Where  id='{$eventos->getId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $eventos)
   {
        $stSql =  "delete from  Eventos ";
        $stSql .= " Where  id='{$eventos->getId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $eventos)
   {
        $stSql =  "select *  from  Eventos ";
        $stSql .= " Where  id='{$eventos->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneEventos( $eventos)
   {
        $stSql =  "select *  from  Eventos ";
        $stSql .= " Where  id='{$eventos->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $eventos->setTitle($fila["title"]);
        $eventos->setBody($fila["body"]);
        $eventos->setUrl($fila["url"]);
        $eventos->setClass($fila["class"]);
        $eventos->setStart($fila["start"]);
        $eventos->setEnd($fila["end"]);
        $eventos->setInicioNormal($fila["inicio_normal"]);
        $eventos->setFinalNormal($fila["final_normal"]);
        return true;					  
   }
   public static function sqlSelectOne( $eventos)
   {
        $stSql =  "select *  from  Eventos ";
        $stSql .= " Where  id='{$eventos->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $eventos->setTitle($fila["title"]);
        $eventos->setBody($fila["body"]);
        $eventos->setUrl($fila["url"]);
        $eventos->setClass($fila["class"]);
        $eventos->setStart($fila["start"]);
        $eventos->setEnd($fila["end"]);
        $eventos->setInicioNormal($fila["inicio_normal"]);
        $eventos->setFinalNormal($fila["final_normal"]);
   }
   public static function sqlSelect( $eventos)
   {
        $stSql =  "select *  from  Eventos ";
        $stSql .= " Where  id='{$eventos->getId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $eventos->setTitle($fila["title"]);
        $eventos->setBody($fila["body"]);
        $eventos->setUrl($fila["url"]);
        $eventos->setClass($fila["class"]);
        $eventos->setStart($fila["start"]);
        $eventos->setEnd($fila["end"]);
        $eventos->setInicioNormal($fila["inicio_normal"]);
        $eventos->setFinalNormal($fila["final_normal"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Eventos ";
        return BD::getInstance()->sqlSelectTodo($stSql);
   }
  public static function sqlSelectTodo( )
   {
        $stSql =  "select *  from  Actor ";
		// Ejecutamos sqlSelectTodo, el cual nos devuleve un arreglo
		$miArreglo = BD::getInstance()->sqlSelectTodo($stSql);
		// Iniciamos el arreglo $pila como array()
		$pila = array();
		// Recorremos el Arreglo $miArreglo
		foreach($miArreglo as $fila){
 		      // Por cada registro $fila creamos un Actor
		      $actorAux = new Actor($fila["actor_id"]
					   ,$fila["first_name"]
				           ,$fila["last_name"]
				           ,$fila["last_update"]);
                       // Agregamos el Actor a la $pila			
			array_push($pila, $actorAux);
		}
		// Retornamos el Arreglo $pila Lleno
        return $pila;
   }   
}
?>
