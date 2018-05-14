<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/eventos.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($eventos)) $eventos = new eventos(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Eventos</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Eventos</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$id">Id</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txId" name="txId" maxlength="10 "  size="10 " value="<?=$eventos->getId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$title">Title</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txTitle" name="txTitle" maxlength="150"  size="150" value="<?=$eventos->getTitle()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$body">Body</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txBody" name="txBody" maxlength="1000"  size="1000" value="<?=$eventos->getBody()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$url">Url</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txUrl" name="txUrl" maxlength="150"  size="150" value="<?=$eventos->getUrl()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$class">Class</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txClass" name="txClass" maxlength="45"  size="45" value="<?=$eventos->getClass()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$start">Start</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txStart" name="txStart" maxlength="15"  size="15" value="<?=$eventos->getStart()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$end">End</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txEnd" name="txEnd" maxlength="15"  size="15" value="<?=$eventos->getEnd()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$inicioNormal">InicioNormal</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txInicioNormal" name="txInicioNormal" maxlength="50"  size="50" value="<?=$eventos->getInicioNormal()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$finalNormal">FinalNormal</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txFinalNormal" name="txFinalNormal" maxlength="50"  size="50" value="<?=$eventos->getFinalNormal()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:eventos.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:eventos.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:eventos.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:eventos.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
