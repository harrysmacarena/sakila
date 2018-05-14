inventory = new Inventory();

function Inventory(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrInventoryLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/InventoryMVCAjax.php"
                           ,"parInventoryId=" + document.getElementById("txInventoryId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txFilmId").value = data.filmId;
               document.getElementById("txStoreId").value = data.storeId;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrInventoryActualizar.php"
	     var data = ventana.cmdPost("/MVC/InventoryMVCAjax.php"
                           ,"parInventoryId=" + document.getElementById("txInventoryId").value
                         + "&parFilmId=" + document.getElementById("txFilmId").value
                         + "&parStoreId=" + document.getElementById("txStoreId").value
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
	     //var data = ventana.cmdPost("/Neg/FrInventoryEliminar.php"
	     var data = ventana.cmdPost("/MVC/InventoryMVCAjax.php"
                           ,"parInventoryId=" + document.getElementById("txInventoryId").value
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
	     //var data = ventana.cmdPost("/Neg/FrInventoryBuscar.php"
	     var data = ventana.cmdPost("/MVC/InventoryMVCAjax.php"
                           ,"parInventoryId=" + document.getElementById("txInventoryId").value
                         + "&btListar=1"
                           );
	}
	
}
