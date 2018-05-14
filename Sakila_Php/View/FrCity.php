<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/city.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($city)) $city = new city(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos City</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos City</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$cityId">CityId</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txCityId" name="txCityId" maxlength="5 "  size="5 " value="<?=$city->getCityId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$city">City</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txCity" name="txCity" maxlength="50"  size="50" value="<?=$city->getCity()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$countryId">CountryId</label>
	            <div class="col-sm-9">
	                 <select   id="cbCountryId" name="cbCountryId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$lastUpdate">LastUpdate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLastUpdate" name="txLastUpdate" maxlength="20"  size="20" value="<?=$city->getLastUpdate()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:city.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:city.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:city.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:city.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
