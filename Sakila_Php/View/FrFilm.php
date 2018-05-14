<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/film.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($film)) $film = new film(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Film</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Film</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$filmId">FilmId</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txFilmId" name="txFilmId" maxlength="5 "  size="5 " value="<?=$film->getFilmId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$title">Title</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txTitle" name="txTitle" maxlength="255"  size="255" value="<?=$film->getTitle()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$description">Description</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txDescription" name="txDescription" maxlength="1000"  size="1000" value="<?=$film->getDescription()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$releaseYear">ReleaseYear</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txReleaseYear" name="txReleaseYear" maxlength="4"  size="4" value="<?=$film->getReleaseYear()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$languageId">LanguageId</label>
	            <div class="col-sm-9">
	                 <select   id="cbLanguageId" name="cbLanguageId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$originalLanguageId">OriginalLanguageId</label>
	            <div class="col-sm-9">
	                 <select   id="cbOriginalLanguageId" name="cbOriginalLanguageId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$rentalDuration">RentalDuration</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txRentalDuration" name="txRentalDuration" maxlength="3 "  size="3 " value="<?=$film->getRentalDuration()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$rentalRate">RentalRate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txRentalRate" name="txRentalRate" maxlength="4,2"  size="4,2" value="<?=$film->getRentalRate()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$length">Length</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLength" name="txLength" maxlength="5 "  size="5 " value="<?=$film->getLength()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$replacementCost">ReplacementCost</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txReplacementCost" name="txReplacementCost" maxlength="5,2"  size="5,2" value="<?=$film->getReplacementCost()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$rating">Rating</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txRating" name="txRating" maxlength="50"  size="50" value="<?=$film->getRating()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$specialFeatures">SpecialFeatures</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txSpecialFeatures" name="txSpecialFeatures" maxlength="50"  size="50" value="<?=$film->getSpecialFeatures()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$lastUpdate">LastUpdate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLastUpdate" name="txLastUpdate" maxlength="20"  size="20" value="<?=$film->getLastUpdate()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:film.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:film.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:film.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:film.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
