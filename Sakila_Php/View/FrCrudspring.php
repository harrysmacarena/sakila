<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/crudspring.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($crudspring)) $crudspring = new crudspring(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Crudspring</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Crudspring</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$id">Id</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txId" name="txId" maxlength="11"  size="11" value="<?=$crudspring->getId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$nombre">Nombre</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txNombre" name="txNombre" maxlength="100"  size="100" value="<?=$crudspring->getNombre()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$salario">Salario</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txSalario" name="txSalario" maxlength="10,0"  size="10,0" value="<?=$crudspring->getSalario()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$descripcion">Descripcion</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txDescripcion" name="txDescripcion" maxlength="100"  size="100" value="<?=$crudspring->getDescripcion()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:crudspring.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:crudspring.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:crudspring.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:crudspring.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
