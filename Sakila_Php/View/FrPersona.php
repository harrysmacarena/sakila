<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/persona.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($persona)) $persona = new persona(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Persona</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Persona</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$rut">Rut</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txRut" name="txRut" maxlength="11"  size="11" value="<?=$persona->getRut()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$dv">Dv</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txDv" name="txDv" maxlength="1"  size="1" value="<?=$persona->getDv()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$nombres">Nombres</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txNombres" name="txNombres" maxlength="50"  size="50" value="<?=$persona->getNombres()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$estatura">Estatura</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txEstatura" name="txEstatura" maxlength="10.10"  size="10.10" value="<?=$persona->getEstatura()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$sexo">Sexo</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txSexo" name="txSexo" maxlength="1"  size="1" value="<?=$persona->getSexo()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$esCasado">EsCasado</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txEsCasado" name="txEsCasado" maxlength="1"  size="1" value="<?=$persona->getEsCasado()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$emilia">Emilia</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txEmilia" name="txEmilia" maxlength="10"  size="10" value="<?=$persona->getEmilia()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$ariel">Ariel</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txAriel" name="txAriel" maxlength="2"  size="2" value="<?=$persona->getAriel()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:persona.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:persona.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:persona.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:persona.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
