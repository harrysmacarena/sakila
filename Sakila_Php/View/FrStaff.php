<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/staff.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($staff)) $staff = new staff(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Staff</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Staff</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$staffId">StaffId</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txStaffId" name="txStaffId" maxlength="3 "  size="3 " value="<?=$staff->getStaffId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$firstName">FirstName</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txFirstName" name="txFirstName" maxlength="45"  size="45" value="<?=$staff->getFirstName()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$lastName">LastName</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLastName" name="txLastName" maxlength="45"  size="45" value="<?=$staff->getLastName()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$addressId">AddressId</label>
	            <div class="col-sm-9">
	                 <select   id="cbAddressId" name="cbAddressId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$picture">Picture</label>
	            <div class="col-sm-9">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$email">Email</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txEmail" name="txEmail" maxlength="50"  size="50" value="<?=$staff->getEmail()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$storeId">StoreId</label>
	            <div class="col-sm-9">
	                 <select   id="cbStoreId" name="cbStoreId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$active">Active</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txActive" name="txActive" maxlength="1"  size="1" value="<?=$staff->getActive()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$username">Username</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txUsername" name="txUsername" maxlength="16"  size="16" value="<?=$staff->getUsername()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$password">Password</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txPassword" name="txPassword" maxlength="40"  size="40" value="<?=$staff->getPassword()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$lastUpdate">LastUpdate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLastUpdate" name="txLastUpdate" maxlength="20"  size="20" value="<?=$staff->getLastUpdate()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:staff.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:staff.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:staff.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:staff.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
