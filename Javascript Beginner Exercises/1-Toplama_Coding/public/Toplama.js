/**
 * 
 */

 function topla() {
	 var birinciSayi=+document.getElementById("input1").value;
	 var ikinciSayi=+document.getElementById("input2").value;
	 var toplam = birinciSayi + ikinciSayi;
	 
	 document.getElementById("p1").innerHTML = toplam;
 }