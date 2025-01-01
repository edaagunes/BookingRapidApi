# Booking Api ile Otel Projesi

🏨 Bu projede [RapidApi](https://rapidapi.com/) üzerinde bulunan Booking API kullanılarak geliştirilmiş bir otel listeleme uygulamasıdır. Kullanıcıların belirlediği kriterlere uygun otelleri listeleme işlemi gerçekleştirilmiştir.

## Anasayfa

🔍 Kullanıcılardan aşağıdaki bilgiler alınır:

* 🗺️ Filtrelemek istedikleri şehir bilgisi

* 📅 Giriş ve çıkış tarihleri

* 👤 Yetişkin kişi sayısı

✔️ Girilen kriterlere uyan oteller liste halinde gösterilir.

ℹ️ Kullanıcılar listelenen otellerin şu bilgilerine erişebilir:

* 🏠 Otel adı

* 💵 Gecelik konaklama ücreti

* ⭐ Otel puanı


## 🛠️ Kullanılan Teknolojiler

💻 Asp.Net Core(6.0) ile geliştirildi.

🏗️ Tek katmanlı yapı ile işlemler gerçekleştirildi.

🌐 Booking API'nin iki farklı endpoint'i kullanıldı:

🔍 Search Hotel Destination Endpoint:

* Kullanıcının girdiği şehir bilgisine karşılık gelen şehir ID'si elde edildi.

🏨 Search Hotels Endpoint:

* Elde edilen şehir ID'si ve diğer filtreleme kriterleri kullanılarak otellerin listesi çekildi.

📦 ViewModel Kullanımı:

* API'den gelen JSON verilerini karşılamak ve yönetmek için ViewModel yapıları oluşturuldu, bu veriler ilgili modeller aracılığıyla işlenmiştir.

## 📌 Proje Detayları

1️⃣ API entegrasyonu sırasında şehir ID'sine ulaşmak için öncelikle Search Hotel Destination Endpoint'ine istek gönderilir.

2️⃣ Bu ID, sonrasında Search Hotels Endpoint'ine gönderilerek kriterlere uygun otel bilgileri alınır.

3️⃣ JSON veri yapısı, ViewModel'ler ile düzenlenip proje içerisinde kullanılabilir hale getirilmiştir.


## 🖼️ Görseller

![5](https://github.com/user-attachments/assets/dc96a020-dfc3-49cf-8128-ddd42b425082)

![6](https://github.com/user-attachments/assets/eb2c6b0f-35b5-4a5e-b620-5373826e6b6b)

![7](https://github.com/user-attachments/assets/4810387d-5e8b-40b8-9153-959e1f9a11f3)

![9](https://github.com/user-attachments/assets/7c349c1a-6eb6-40a3-abec-45630d5036d7)



