<?PHP
	if (!isset($rootDir)) $rootDir = $_SERVER['DOCUMENT_ROOT'];
	require_once($rootDir . "/Entities/rental.php");

  // Este código solo sirve para la primera vez que se 
  // despliega el formulario ya que $actor no existe.
  if (!isset($rental)) $rental = new rental(0);
?>
      <section class="content">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="box">
                                <div class="box-header">
    <table id="tblTitulo1" class="table1" width="100%">
          <tr><td><h2><b>Datos Rental</b></h2></td>
              <td align="right"><button    align='right' class='btn btn-danger ' name='commit' value='Modificar' type='reset' onclick="javascript:wpar.mpRamo.editaRamo('-1')"><i class='glyphicon glyphicon-plus'></i> Crear</button></td>
          </tr>
    </table>
                                </div>
    <div class="container_table box-title">
      <form class="form-horizontal" role="form" id="contact-form">
			<fieldset>
			  <!--legend>Datos Rental</legend-->
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$rentalId">RentalId</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txRentalId" name="txRentalId" maxlength="11"  size="11" value="<?=$rental->getRentalId()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$rentalDate">RentalDate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txRentalDate" name="txRentalDate" maxlength="20"  size="20" value="<?=$rental->getRentalDate()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$inventoryId">InventoryId</label>
	            <div class="col-sm-9">
	                 <select   id="cbInventoryId" name="cbInventoryId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$customerId">CustomerId</label>
	            <div class="col-sm-9">
	                 <select   id="cbCustomerId" name="cbCustomerId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$returnDate">ReturnDate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txReturnDate" name="txReturnDate" maxlength="20"  size="20" value="<?=$rental->getReturnDate()?>">
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$staffId">StaffId</label>
	            <div class="col-sm-9">
	                 <select   id="cbStaffId" name="cbStaffId"  style='width:350px'></select>
	            </div>
	          </div>
	          <div class="form-group">
	            <label class="col-sm-2 control-label" for="input01" for="$lastUpdate">LastUpdate</label>
	            <div class="col-sm-9">
	                 <input type="text" class="input-xxlarge required" id="txLastUpdate" name="txLastUpdate" maxlength="20"  size="20" value="<?=$rental->getLastUpdate()?>">
	            </div>
	          </div>
			  <div class="form-actions">
				<button type="button" onclick="javascript:rental.fuActualizar();" class="btn btn-primary">Actualizar</button>
				<button type="button" onclick="javascript:rental.fuEliminar();" class="btn btn-primary">Eliminar</button>
				<button type="button" onclick="javascript:rental.fuLeer();" class="btn btn-primary">Leer</button>
				<button type="button" onclick="javascript:rental.fuBuscar();" class="btn btn-primary">Buscar</button>
				<button type="reset" class="btn">Cancelar</button>
			  </div>
			</fieldset>
      </form>
    </div>
  </div>
</div>
</div>
</section>
	
