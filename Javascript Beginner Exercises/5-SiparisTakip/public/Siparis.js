const bilgiIletisi = "Siparişleriniz burada görüntülenir...";
const tesekkur = "Teşekkür ederiz...";
const sabitSiparisAdedi = 10;

function sayfaYukle(){
	document.getElementById("p1").innerHTML = bilgiIletisi;
}
function temizle(){
	document.getElementById("input1").value = "";
	document.getElementById("input2").value = "";
	document.getElementById("p1").innerHTML = bilgiIletisi;
}

function adetSiparis(){
	var urun = document.getElementById("input1").value;
	var siparisAdedi;
	var geciciDizgi = tesekkur;
	var donguDenetim;
	
	if(arguments[0] == "ADET")
		siparisAdedi = ~~document.getElementById("input2").value;
	else if(arguments[0] == "ON")
		siparisAdedi = sabitSiparisAdedi;
	
	if(siparisAdedi < 1)
		siparisAdedi = 1;
	
	for(donguDenetim = 0; donguDenetim < siparisAdedi; donguDenetim++)
		geciciDizgi += " " + urun;
	
	document.getElementById("p1").innerHTML = geciciDizgi;
}