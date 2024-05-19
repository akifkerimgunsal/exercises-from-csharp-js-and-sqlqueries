/**
 * 
 */
const bilgiSatiri = "Sonuçlar burada gösterilecek...";

function sayfaYukle(){
	document.getElementById("p1").innerHTML = bilgiSatiri;
	document.getElementById("buton2").disabled = true;
}

function veriGirisi(){
	if( document.getElementById("buton2").disabled ){
		document.getElementById("buton2").disabled = false;
	}
}

function fibonacci(n){
	switch (n){
		case 1: case 2:
			return 1;
		default:
			return (fibonacci(n-1) + fibonacci(n-2));
	}
	
}

function listeleOzyineli(){
	var sayiAdedi = ~~document.getElementById("input1").value;
	var geciciDizgi ="";
	var kacinciFibo;
	
	if(sayiAdedi < 3)
		alert("2'den fazla sayı giriniz. İlk iki Fibonacci sayısı: 1,1'dir.")		
	else{
		geciciDizgi = "İlk " + sayiAdedi + " adet Fibonacci sayısı: 1,1";
		
		for(kacinciFibo = 3; kacinciFibo <= sayiAdedi; kacinciFibo++){
			geciciDizgi = geciciDizgi + "," + fibonacci(kacinciFibo);
		}
		document.getElementById("p1").innerHTML = geciciDizgi;
	}
	
}

function temizle(){
	 document.getElementById("input1").value = "";
	 document.getElementById("p1").innerHTML = bilgiSatiri;
	 document.getElementById("buton2").disabled = true;
}