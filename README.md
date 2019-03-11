# Soket Nedir?

Soketler için istemci (Client) ve sunucu (Server) arasındaki bağlantının sağlanması için olan bir iletişim kanalı diyebiliriz. Yaşam döngüsünü basitçe tarif etmek gerekirse, sunucu önceden belirlenen portu dinler, istemci ise bu porta mesaj gönderir.

<p align="center">
  <img width="460" height="300" src="![ss](https://user-images.githubusercontent.com/16051653/54145782-b6ae1080-443f-11e9-8a7b-283c94924031.png)">
</p>


 

# Uygulama Nasıl Çalışıyor?

Uygulama iki projeden oluşmakta. Server ve Clint(lar) olmak üzere iki adet dir. Server , kod içerisinde belirtilmiş iki kritik parametre vardır. İp ve Port. İp bize bulunduğumuz makinenin yani server olarak kullanacağımız makinen ip adresidir. Port ise dinlenecek bir dış bağlantı numarası diyebiliriz. Ortak bir ip ve port üzerinde anlaşma sağlanırsa iletişim doğru şekilde sağlanır.

Client ise dinlemeye başlayan server ‘ a bağlantı isteği gönderip başarılı olursa iletişim e hazır hale gelir. Bağlı olan her cliente yeni bağlantı ile birlikte güncel online kişi listesi gönderilir. Kişi listesi üzerinden ilgili kişiye server üzerinden mesaj gönderip alabiliriz. Mesajlarda Her Client ‘ ın lokalinde tutulduğu için eski mesajlarda saklanmaktadır.


# Server Client ‘ a nasıl Güncel Listeyi İletiyor?

Serverda yeni bağlantı sağlandıktan sonra client ‘ ın ilk mesajı kullanıcı adını göndermek oluyor. Gelen bu mesajı alıp istemci listemize ekliyoruz. Listedeki tüm clientları gezip her birine kendisi hariç istemci listesini gönderiyoruz.

Gönderilen mesajın normal mesajdan farkı **3$\*$\*3** ile başlıyor olması. Her Clint arasında da $ işareti belirttiğimizden Client aldığı mesajı split ederken **$** işaretinden faydalanarak düzgün ve doğru parçalayabilecektir.


# Client Server ‘ a kişiye özel mesajı nasıl gönderiyor?

Client seçtiği kişiye mesajını **gönderilecek KisininAdi + "..444.." +İlgili Client ın Kullanıcı Adı+" : "+Gönderilen Mesaj** şeklinde hazırlayıp gönderiyor. Serverda nu parametreleri düzgün parçalayıp böldükten sonra listeden bulduğu Client a mesajı iletiyor.
