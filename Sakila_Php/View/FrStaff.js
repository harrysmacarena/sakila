staff = new Staff();

function Staff(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrStaffLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/StaffMVCAjax.php"
                           ,"parStaffId=" + document.getElementById("txStaffId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txFirstName").value = data.firstName;
               document.getElementById("txLastName").value = data.lastName;
               document.getElementById("txAddressId").value = data.addressId;
               document.getElementById("txPicture").value = data.picture;
               document.getElementById("txEmail").value = data.email;
               document.getElementById("txStoreId").value = data.storeId;
               document.getElementById("txActive").value = data.active;
               document.getElementById("txUsername").value = data.username;
               document.getElementById("txPassword").value = data.password;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrStaffActualizar.php"
	     var data = ventana.cmdPost("/MVC/StaffMVCAjax.php"
                           ,"parStaffId=" + document.getElementById("txStaffId").value
                         + "&parFirstName=" + document.getElementById("txFirstName").value
                         + "&parLastName=" + document.getElementById("txLastName").value
                         + "&parAddressId=" + document.getElementById("txAddressId").value
                         + "&parPicture=" + document.getElementById("txPicture").value
                         + "&parEmail=" + document.getElementById("txEmail").value
                         + "&parStoreId=" + document.getElementById("txStoreId").value
                         + "&parActive=" + document.getElementById("txActive").value
                         + "&parUsername=" + document.getElementById("txUsername").value
                         + "&parPassword=" + document.getElementById("txPassword").value
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
	     //var data = ventana.cmdPost("/Neg/FrStaffEliminar.php"
	     var data = ventana.cmdPost("/MVC/StaffMVCAjax.php"
                           ,"parStaffId=" + document.getElementById("txStaffId").value
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
	     //var data = ventana.cmdPost("/Neg/FrStaffBuscar.php"
	     var data = ventana.cmdPost("/MVC/StaffMVCAjax.php"
                           ,"parStaffId=" + document.getElementById("txStaffId").value
                         + "&btListar=1"
                           );
	}
	
}
