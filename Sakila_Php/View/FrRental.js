rental = new Rental();

function Rental(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrRentalLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/RentalMVCAjax.php"
                           ,"parRentalId=" + document.getElementById("txRentalId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txRentalDate").value = data.rentalDate;
               document.getElementById("txInventoryId").value = data.inventoryId;
               document.getElementById("txCustomerId").value = data.customerId;
               document.getElementById("txReturnDate").value = data.returnDate;
               document.getElementById("txStaffId").value = data.staffId;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrRentalActualizar.php"
	     var data = ventana.cmdPost("/MVC/RentalMVCAjax.php"
                           ,"parRentalId=" + document.getElementById("txRentalId").value
                         + "&parRentalDate=" + document.getElementById("txRentalDate").value
                         + "&parInventoryId=" + document.getElementById("txInventoryId").value
                         + "&parCustomerId=" + document.getElementById("txCustomerId").value
                         + "&parReturnDate=" + document.getElementById("txReturnDate").value
                         + "&parStaffId=" + document.getElementById("txStaffId").value
                         + "&parLastUpdate=" + document.getElementById("txLastUpdate").value
                         + "&btActualizar=1"
                           );
          if (data.okey){
		     alert(data.msg);
		  }
		  else {
		      alert(data.msg);
		  }						   
	}
	
	//*************************
	this.fuEliminar = function(){
	     //var data = ventana.cmdPost("/Neg/FrRentalEliminar.php"
	     var data = ventana.cmdPost("/MVC/RentalMVCAjax.php"
                           ,"parRentalId=" + document.getElementById("txRentalId").value
                         + "&btEliminar=1"
                           );
          if (data.okey){
		     alert(data.msg);
		  }
		  else {
		      alert(data.msg);
		  }						   
	}
	
	//*************************
	this.fuBuscar = function(){
	     //var data = ventana.cmdPost("/Neg/FrRentalBuscar.php"
	     var data = ventana.cmdPost("/MVC/RentalMVCAjax.php"
                           ,"parRentalId=" + document.getElementById("txRentalId").value
                         + "&btListar=1"
                           );
	}
	
}
