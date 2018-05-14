<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/language.php");
class LanguageDAO {
   public static function sqlInsert( $language)
   {
        $stSql  = "insert into Language (";
        $stSql .= " language_id ,name ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$language->getLanguageId()}'"
                . ",'{$language->getName()}'"
                . ",'{$language->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $language)
   {
        $stSql =  "update Language SET ";
        $stSql .= " name='{$language->getName()}'"
                . ",last_update='{$language->getLastUpdate()}'"
                       ;
        $stSql .= " Where  language_id='{$language->getLanguageId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $language)
   {
        $stSql =  "delete from  Language ";
        $stSql .= " Where  language_id='{$language->getLanguageId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $language)
   {
        $stSql =  "select *  from  Language ";
        $stSql .= " Where  language_id='{$language->getLanguageId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneLanguage( $language)
   {
        $stSql =  "select *  from  Language ";
        $stSql .= " Where  language_id='{$language->getLanguageId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $language->setName($fila["name"]);
        $language->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $language)
   {
        $stSql =  "select *  from  Language ";
        $stSql .= " Where  language_id='{$language->getLanguageId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $language->setName($fila["name"]);
        $language->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $language)
   {
        $stSql =  "select *  from  Language ";
        $stSql .= " Where  language_id='{$language->getLanguageId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $language->setName($fila["name"]);
        $language->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Language ";
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
