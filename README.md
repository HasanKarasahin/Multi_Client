# Soket Nedir?

Soketler için istemci (Client) ve sunucu (Server) arasýndaki baðlantýnýn saðlanmasý için olan bir iletiþim kanalý diyebiliriz. Yaþam döngüsünü basitçe tarif etmek gerekirse, sunucu önceden belirlenen portu dinler, istemci ise bu porta mesaj gönderir.


 

# Uygulama Nasýl Çalýþýyor?

Uygulama iki projeden oluþmakta. Server ve Clint(lar) olmak üzere iki adet dir. Server , kod içerisinde belirtilmiþ iki kritik parametre vardýr. Ýp ve Port. Ýp bize bulunduðumuz makinenin yani server olarak kullanacaðýmýz makinen ip adresidir. Port ise dinlenecek bir dýþ baðlantý numarasý diyebiliriz. Ortak bir ip ve port üzerinde anlaþma saðlanýrsa iletiþim doðru þekilde saðlanýr.

Client ise dinlemeye baþlayan server ‘ a baðlantý isteði gönderip baþarýlý olursa iletiþim e hazýr hale gelir. Baðlý olan her cliente yeni baðlantý ile birlikte güncel online kiþi listesi gönderilir. Kiþi listesi üzerinden ilgili kiþiye server üzerinden mesaj gönderip alabiliriz. Mesajlarda Her Client ‘ ýn lokalinde tutulduðu için eski mesajlarda saklanmaktadýr.


# Server Client ‘ a nasýl Güncel Listeyi Ýletiyor?

Serverda yeni baðlantý saðlandýktan sonra client ‘ ýn ilk mesajý kullanýcý adýný göndermek oluyor. Gelen bu mesajý alýp istemci listemize ekliyoruz. Listedeki tüm clientlarý gezip her birine kendisi hariç istemci listesini gönderiyoruz.

Gönderilen mesajýn normal mesajdan farký **3$\*$\*3** ile baþlýyor olmasý. Her Clint arasýnda da $ iþareti belirttiðimizden Client aldýðý mesajý split ederken **$** iþaretinden faydalanarak düzgün ve doðru parçalayabilecektir.


# Client Server ‘ a kiþiye özel mesajý nasýl gönderiyor?

Client seçtiði kiþiye mesajýný **gönderilecek KisininAdi + "..444.." +Ýlgili Client ýn Kullanýcý Adý+" : "+Gönderilen Mesaj** þeklinde hazýrlayýp gönderiyor. Serverda nu parametreleri düzgün parçalayýp böldükten sonra listeden bulduðu Client a mesajý iletiyor.