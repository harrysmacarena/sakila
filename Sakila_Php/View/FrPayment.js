payment = new Payment();

function Payment(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrPaymentLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/PaymentMVCAjax.php"
                           ,"parPaymentId=" + document.getElementById("txPaymentId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txCustomerId").value = data.customerId;
               document.getElementById("txStaffId").value = data.staffId;
               document.getElementById("txRentalId").value = data.rentalId;
               document.getElementById("txAmount").value = data.amount;
               document.getElementById("txPaymentDate").value = data.paymentDate;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrPaymentActualizar.php"
	     var data = ventana.cmdPost("/MVC/PaymentMVCAjax.php"
                           ,"parPaymentId=" + document.getElementById("txPaymentId").value
                         + "&parCustomerId=" + document.getElementById("txCustomerId").value
                         + "&parStaffId=" + document.getElementById("txStaffId").value
                         + "&parRentalId=" + document.getElementById("txRentalId").value
                         + "&parAmount=" + document.getElementById("txAmount").value
                         + "&parPaymentDate=" + document.getElementById("txPaymentDate").value
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
	     //var data = ventana.cmdPost("/Neg/FrPaymentEliminar.php"
	     var data = ventana.cmdPost("/MVC/PaymentMVCAjax.php"
                           ,"parPaymentId=" + document.getElementById("txPaymentId").value
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
	     //var data = ventana.cmdPost("/Neg/FrPaymentBuscar.php"
	     var data = ventana.cmdPost("/MVC/PaymentMVCAjax.php"
                           ,"parPaymentId=" + document.getElementById("txPaymentId").value
                         + "&btListar=1"
                           );
	}
	
}
