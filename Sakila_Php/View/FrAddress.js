address = new Address();

function Address(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrAddressLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/AddressMVCAjax.php"
                           ,"parAddressId=" + document.getElementById("txAddressId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txAddress").value = data.address;
               document.getElementById("txAddress2").value = data.address2;
               document.getElementById("txDistrict").value = data.district;
               document.getElementById("txCityId").value = data.cityId;
               document.getElementById("txPostalCode").value = data.postalCode;
               document.getElementById("txPhone").value = data.phone;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrAddressActualizar.php"
	     var data = ventana.cmdPost("/MVC/AddressMVCAjax.php"
                           ,"parAddressId=" + document.getElementById("txAddressId").value
                         + "&parAddress=" + document.getElementById("txAddress").value
                         + "&parAddress2=" + document.getElementById("txAddress2").value
                         + "&parDistrict=" + document.getElementById("txDistrict").value
                         + "&parCityId=" + document.getElementById("txCityId").value
                         + "&parPostalCode=" + document.getElementById("txPostalCode").value
                         + "&parPhone=" + document.getElementById("txPhone").value
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
	     //var data = ventana.cmdPost("/Neg/FrAddressEliminar.php"
	     var data = ventana.cmdPost("/MVC/AddressMVCAjax.php"
                           ,"parAddressId=" + document.getElementById("txAddressId").value
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
	     //var data = ventana.cmdPost("/Neg/FrAddressBuscar.php"
	     var data = ventana.cmdPost("/MVC/AddressMVCAjax.php"
                           ,"parAddressId=" + document.getElementById("txAddressId").value
                         + "&btListar=1"
                           );
	}
	
}
