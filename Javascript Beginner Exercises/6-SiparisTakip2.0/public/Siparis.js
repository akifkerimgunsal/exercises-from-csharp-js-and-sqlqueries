const bilgiIletisi = "Siparişleriniz burada görüntülenir...";
const tesekkur = "Teşekkür ederiz...";
const sabitSiparisAdedi = 10;
const adetSabit = "ADET";
const onSabit = "ON";
const meyve_1 = "elma";
const meyve_2 = "armut";
const sebze_1 = "patates";
const sebze_2 = "domates";


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
	var adetSipariseBasildi = false;
	var siparisOnayla = true;
	
	switch(arguments[0]){
		case adetSabit:
			adetSipariseBasildi = true;
			siparisAdedi = ~~document.getElementById("input2").value;
			break;
		case onSabit:
			siparisAdedi = sabitSiparisAdedi;
			break;
		default:
			alert("Hatalı sipariş adedi girişi...");
	}
	
	switch(urun){
		case meyve_1: case meyve_2:
			alert("Meyve stoklarımız yeterlidir. Teşekkür ederiz");
			break;
		case sebze_1: case sebze_2:
			alert("Sebzelerimiz kendi bahçemizden, teşekkür ederiz.");
			break;
		default: 
			if(siparisAdedi > 99){
				alert("Stoklarımızda" + siparisAdedi +"adet"+ urun + "bulunmamaktadır, üzgünüz.");
				siparisOnayla = false;
				geciciDizgi = "Siparişiniz onaylanmadı, <br/> Özür dileriz...";
			}
			else
				alert("Stoklarımızda" + siparisAdedi + " adet "+ urun + " mevcuttur. Teşekkür ederiz...");
	}
	
	if(siparisOnayla == true){
		if(siparisAdedi < 1)
		siparisAdedi = 1;
	
	for(donguDenetim = 0; donguDenetim < siparisAdedi; donguDenetim++)
		geciciDizgi += " " + urun;
	}	
	document.getElementById("p1").innerHTML = geciciDizgi;		
}