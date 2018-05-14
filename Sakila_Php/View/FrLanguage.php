<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/language.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($language)) $language = new language(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Language</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Language</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$languageId">LanguageId</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLanguageId" name="txLanguageId" maxlength="3 "  size="3 " value="<?=$language->getLanguageId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$name">Name</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txName" name="txName" maxlength="20"  size="20" value="<?=$language->getName()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$lastUpdate">LastUpdate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLastUpdate" name="txLastUpdate" maxlength="20"  size="20" value="<?=$language->getLastUpdate()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:language.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:language.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:language.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:language.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
