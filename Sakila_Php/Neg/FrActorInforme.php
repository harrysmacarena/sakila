<?PHP
if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
require_once($rootDir . "/DAO/actorDAO.php");

?>
<div class='row-fluid'>
	<div class='span9'>
	<div class='box'>
	<form class='form-vertical well-large' id='forms-XXX'>
		<div class='box-title'>
			<table id='tblTitulo' class='table'>
				  <tr><th><h4>Datos de  Actor</h4></th>
					  <!--th><h2><INPUT  align='right' class='btn btn-primary' name='commit' value='Volver' type='reset' onclick=\"javascript:wpar.mpCusros.getCursos();\"></h2></th-->
					  <!--th><h2> <input type='text' class='input-medium required' id='txtIdTest' name='txtIdTest' maxlength='3' data-mask='999' value=''></h2></th-->
					 <!--th><h2> <INPUT  align='right' class='btn btn-primary' name='commit' value='Refrescar' type='reset' onclick='wpar.mpTest.fuTestPruebas(0);'></h2></th-->
					 <!--th><h2> <INPUT  align='right' class='btn btn-danger' name='commit' value='Partir' type='button' onclick='wpar.mpMat.partir(1,900,4);'></h2></th-->
					 
				</tr>
			  <tr>
				  <th><div class='input-append'>
					  <!--button type='button' class='btn' onclick=\"javascript:wpar.mpCursos.getCursosProfesor('');\">Search</button-->
                      <!--td><INPUT  align='right' class='btn btn-success' name='commit' value='Test' type='reset' 
									onclick=\"javascript:wpar.mpTest.fuTestHeader()\"></td>
					  <td><INPUT  align='right' class='btn btn-success' name='commit' value='Activar Test' type='reset' 
									onclick=\"\"></td-->
					  </div></th>
			</tr>
			</table>
		</div>
		<div class='box-content nopadding'>
			<table id='tblData' class='table table-striped table-bordered tablehead' cellspacing='1' cellpadding='3'  style='background:#CCC;'>
			<thead>
				<tr class='colhead'>
<td>ActorId</td><td>FirstName</td><td>LastName</td><td>LastUpdate</td>				</tr>
			</thead>
<?PHP			
   $arrDatos = actorDAO::sqlSelectTodo();
   foreach ($arrDatos as  $linea){
?>   
             <tr class='evenrow'>

<td><?PHP echo $linea['actor_id']; ?></td>
<td><?PHP echo $linea['first_name']; ?></td>
<td><?PHP echo $linea['last_name']; ?></td>
<td><?PHP echo $linea['last_update']; ?></td>              </tr>
<?PHP
			  }
?>
			  
			  
           </table>
		</div>
		</form>
		</div>                        
		</div>                 
		</div>

