store = new Store();

function Store(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrStoreLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/StoreMVCAjax.php"
                           ,"parStoreId=" + document.getElementById("txStoreId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txManagerStaffId").value = data.managerStaffId;
               document.getElementById("txAddressId").value = data.addressId;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrStoreActualizar.php"
	     var data = ventana.cmdPost("/MVC/StoreMVCAjax.php"
                           ,"parStoreId=" + document.getElementById("txStoreId").value
                         + "&parManagerStaffId=" + document.getElementById("txManagerStaffId").value
                         + "&parAddressId=" + document.getElementById("txAddressId").value
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
	     //var data = ventana.cmdPost("/Neg/FrStoreEliminar.php"
	     var data = ventana.cmdPost("/MVC/StoreMVCAjax.php"
                           ,"parStoreId=" + document.getElementById("txStoreId").value
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
	     //var data = ventana.cmdPost("/Neg/FrStoreBuscar.php"
	     var data = ventana.cmdPost("/MVC/StoreMVCAjax.php"
                           ,"parStoreId=" + document.getElementById("txStoreId").value
                         + "&btListar=1"
                           );
	}
	
}
