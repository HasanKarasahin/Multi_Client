# Soket Nedir?

Soketler i�in istemci (Client) ve sunucu (Server) aras�ndaki ba�lant�n�n sa�lanmas� i�in olan bir ileti�im kanal� diyebiliriz. Ya�am d�ng�s�n� basit�e tarif etmek gerekirse, sunucu �nceden belirlenen portu dinler, istemci ise bu porta mesaj g�nderir.


 

# Uygulama Nas�l �al���yor?

Uygulama iki projeden olu�makta. Server ve Clint(lar) olmak �zere iki adet dir. Server , kod i�erisinde belirtilmi� iki kritik parametre vard�r. �p ve Port. �p bize bulundu�umuz makinenin yani server olarak kullanaca��m�z makinen ip adresidir. Port ise dinlenecek bir d�� ba�lant� numaras� diyebiliriz. Ortak bir ip ve port �zerinde anla�ma sa�lan�rsa ileti�im do�ru �ekilde sa�lan�r.

Client ise dinlemeye ba�layan server � a ba�lant� iste�i g�nderip ba�ar�l� olursa ileti�im e haz�r hale gelir. Ba�l� olan her cliente yeni ba�lant� ile birlikte g�ncel online ki�i listesi g�nderilir. Ki�i listesi �zerinden ilgili ki�iye server �zerinden mesaj g�nderip alabiliriz. Mesajlarda Her Client � �n lokalinde tutuldu�u i�in eski mesajlarda saklanmaktad�r.


# Server Client � a nas�l G�ncel Listeyi �letiyor?

Serverda yeni ba�lant� sa�land�ktan sonra client � �n ilk mesaj� kullan�c� ad�n� g�ndermek oluyor. Gelen bu mesaj� al�p istemci listemize ekliyoruz. Listedeki t�m clientlar� gezip her birine kendisi hari� istemci listesini g�nderiyoruz.

G�nderilen mesaj�n normal mesajdan fark� **3$\*$\*3** ile ba�l�yor olmas�. Her Clint aras�nda da $ i�areti belirtti�imizden Client ald��� mesaj� split ederken **$** i�aretinden faydalanarak d�zg�n ve do�ru par�alayabilecektir.


# Client Server � a ki�iye �zel mesaj� nas�l g�nderiyor?

Client se�ti�i ki�iye mesaj�n� **g�nderilecek KisininAdi + "..444.." +�lgili Client �n Kullan�c� Ad�+" : "+G�nderilen Mesaj** �eklinde haz�rlay�p g�nderiyor. Serverda nu parametreleri d�zg�n par�alay�p b�ld�kten sonra listeden buldu�u Client a mesaj� iletiyor.