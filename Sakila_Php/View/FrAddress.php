<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/address.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($address)) $address = new address(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Address</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Address</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$addressId">AddressId</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txAddressId" name="txAddressId" maxlength="5 "  size="5 " value="<?=$address->getAddressId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$address">Address</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txAddress" name="txAddress" maxlength="50"  size="50" value="<?=$address->getAddress()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$address2">Address2</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txAddress2" name="txAddress2" maxlength="50"  size="50" value="<?=$address->getAddress2()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$district">District</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txDistrict" name="txDistrict" maxlength="20"  size="20" value="<?=$address->getDistrict()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$cityId">CityId</label>
	            <div class="col-sm-9">
	                 <select   id="cbCityId" name="cbCityId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$postalCode">PostalCode</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txPostalCode" name="txPostalCode" maxlength="10"  size="10" value="<?=$address->getPostalCode()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$phone">Phone</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txPhone" name="txPhone" maxlength="20"  size="20" value="<?=$address->getPhone()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$lastUpdate">LastUpdate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLastUpdate" name="txLastUpdate" maxlength="20"  size="20" value="<?=$address->getLastUpdate()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:address.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:address.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:address.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:address.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
