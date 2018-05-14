<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/film_text.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($filmText)) $filmText = new film_text(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos FilmText</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos FilmText</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$filmId">FilmId</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txFilmId" name="txFilmId" maxlength="6"  size="6" value="<?=$filmText->getFilmId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$title">Title</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txTitle" name="txTitle" maxlength="255"  size="255" value="<?=$filmText->getTitle()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$description">Description</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txDescription" name="txDescription" maxlength="1000"  size="1000" value="<?=$filmText->getDescription()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:filmText.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:filmText.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:filmText.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:filmText.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
