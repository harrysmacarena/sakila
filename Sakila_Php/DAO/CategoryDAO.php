<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/BD/bd.php");
require_once($rootDir . "/Entities/category.php");
class CategoryDAO {
   public static function sqlInsert( $category)
   {
        $stSql  = "insert into Category (";
        $stSql .= " category_id ,name ,last_update";
        $stSql .= " )values (";
        $stSql .= " '{$category->getCategoryId()}'"
                . ",'{$category->getName()}'"
                . ",'{$category->getLastUpdate()}'"
                . ")";

		return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlUpdate( $category)
   {
        $stSql =  "update Category SET ";
        $stSql .= " name='{$category->getName()}'"
                . ",last_update='{$category->getLastUpdate()}'"
                       ;
        $stSql .= " Where  category_id='{$category->getCategoryId()}'"
                       ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlDelete( $category)
   {
        $stSql =  "delete from  Category ";
        $stSql .= " Where  category_id='{$category->getCategoryId()}'"
                          ;
        return BD::getInstance()->sqlEjecutar($stSql);
   }
   public static function sqlSelectExists( $category)
   {
        $stSql =  "select *  from  Category ";
        $stSql .= " Where  category_id='{$category->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        return true;					  
   }
   public static function sqlSelectOneCategory( $category)
   {
        $stSql =  "select *  from  Category ";
        $stSql .= " Where  category_id='{$category->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
		if (!$fila) return false;
        $category->setName($fila["name"]);
        $category->setLastUpdate($fila["last_update"]);
        return true;					  
   }
   public static function sqlSelectOne( $category)
   {
        $stSql =  "select *  from  Category ";
        $stSql .= " Where  category_id='{$category->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return null;
		$fila= BD::getInstance()->sqlFetch();
        $category->setName($fila["name"]);
        $category->setLastUpdate($fila["last_update"]);
   }
   public static function sqlSelect( $category)
   {
        $stSql =  "select *  from  Category ";
        $stSql .= " Where  category_id='{$category->getCategoryId()}'"
                          ;
        $resultado= BD::getInstance()->sqlSelect($stSql);
		if(!$resultado) return false;
		return true;
   }
   public static function sqlFetch()
   {
		$fila= BD::getInstance()->sqlFetch();
        $category->setName($fila["name"]);
        $category->setLastUpdate($fila["last_update"]);
        return true;						  
   }
   
   public static function sqlSelectTodo1( )
   {
        $stSql =  "select *  from  Category ";
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
