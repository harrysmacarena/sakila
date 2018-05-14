customer = new Customer();

function Customer(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrCustomerLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/CustomerMVCAjax.php"
                           ,"parCustomerId=" + document.getElementById("txCustomerId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txStoreId").value = data.storeId;
               document.getElementById("txFirstName").value = data.firstName;
               document.getElementById("txLastName").value = data.lastName;
               document.getElementById("txEmail").value = data.email;
               document.getElementById("txAddressId").value = data.addressId;
               document.getElementById("txActive").value = data.active;
               document.getElementById("txCreateDate").value = data.createDate;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrCustomerActualizar.php"
	     var data = ventana.cmdPost("/MVC/CustomerMVCAjax.php"
                           ,"parCustomerId=" + document.getElementById("txCustomerId").value
                         + "&parStoreId=" + document.getElementById("txStoreId").value
                         + "&parFirstName=" + document.getElementById("txFirstName").value
                         + "&parLastName=" + document.getElementById("txLastName").value
                         + "&parEmail=" + document.getElementById("txEmail").value
                         + "&parAddressId=" + document.getElementById("txAddressId").value
                         + "&parActive=" + document.getElementById("txActive").value
                         + "&parCreateDate=" + document.getElementById("txCreateDate").value
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
	     //var data = ventana.cmdPost("/Neg/FrCustomerEliminar.php"
	     var data = ventana.cmdPost("/MVC/CustomerMVCAjax.php"
                           ,"parCustomerId=" + document.getElementById("txCustomerId").value
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
	     //var data = ventana.cmdPost("/Neg/FrCustomerBuscar.php"
	     var data = ventana.cmdPost("/MVC/CustomerMVCAjax.php"
                           ,"parCustomerId=" + document.getElementById("txCustomerId").value
                         + "&btListar=1"
                           );
	}
	
}
