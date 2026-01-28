# 🌍 Traversal - Seyahat Rezervasyon Projesi

![.NET Core](https://img.shields.io/badge/.NET%20Core-5.0%2F6.0-512BD4?style=flat&logo=dotnet)
![PostgreSQL](https://img.shields.io/badge/Database-PostgreSQL-336791?style=flat&logo=postgresql)
![Architecture](https://img.shields.io/badge/Architecture-CQRS%20%26%20Onion-blue?style=flat)
![SignalR](https://img.shields.io/badge/RealTime-SignalR-lightgrey?style=flat)

**Traversal**, seyahat severlerin tur rotalarını inceleyebildiği, rezervasyon yapabildiği ve blog yazılarını okuyabildiği kapsamlı bir rezervasyon web uygulamasıdır.

Bu proje, **Murat Yücedağ**'ın YouTube kanalındaki kapsamlı eğitim serisi takip edilerek geliştirilmiştir. Projede **SOLID** prensiplerine sadık kalınmış ve endüstri standardı olan **Design Pattern**'ler (CQRS, Mediator, Unit of Work) aktif olarak kullanılmıştır.

---

## 📸 Proje Ekran Görüntüleri

*(Ekran görüntüleri eklenecektir...)*

---

## 🏗️ Mimari ve Tasarım Desenleri

Bu proje, sadece bir web sitesi değil, aynı zamanda ileri seviye bir mimari çalışmasıdır.

* **CQRS (Command Query Responsibility Segregation):** Okuma ve Yazma işlemlerini **MediatR** kütüphanesi ile ayırarak daha ölçeklenebilir bir yapı kuruldu.
* **Repository Design Pattern:** Veri erişim katmanı soyutlanarak kod tekrarı önlendi.
* **Unit of Work:** Veritabanı işlemlerinin toplu ve güvenli (transactional) bir şekilde yürütülmesi sağlandı.
* **Dependency Injection (DI):** Bağımlılıklar gevşek bağlı (loosely coupled) hale getirildi.

---

## 🚀 Öne Çıkan Özellikler

### 🔐 Kimlik ve Güvenlik (Identity)
* Kullanıcı Kayıt (Register) ve Giriş (Login) işlemleri.
* Rol Bazlı Yetkilendirme (Admin, Member, Editor vb.).
* "Şifremi Unuttum" (Password Reset) senaryoları.

### 🌐 Web & İletişim
* **SignalR:** Anlık bildirimler ve canlı veri akışı (Örn: Anlık ziyaretçi sayısı veya admin bildirimleri).
* **Localization:** Çoklu dil desteği altyapısı.
* **Mail Gönderme:** SMTP protokolü ile kullanıcı bilgilendirme mailleri.
* **Ajax:** Sayfa yenilenmeden yapılan asenkron işlemler.

### 💾 Veri ve Raporlama
* **PostgreSQL:** Veritabanı olarak PostgreSQL kullanıldı.
* **Raporlama:** Verilerin **Excel** ve **PDF** formatında dışarı aktarılması (Export).
* **Search:** Site içi dinamik arama motoru.

### 🔌 API Entegrasyonları
* **Web API:** Projenin mobil veya diğer servislerle haberleşmesi için RESTful servisler.
* **Rapid API:** Dış kaynaklardan (Booking, IMDb vb. gibi servislerden) veri çekme işlemleri.

---

## 🛠 Kullanılan Teknolojiler ve Kütüphaneler

| Kategori | Teknoloji / Kütüphane |
| :--- | :--- |
| **Framework** | .NET Core MVC |
| **Veritabanı** | PostgreSQL |
| **ORM** | Entity Framework Core |
| **Mimari Desenler** | CQRS, Mediator, Unit of Work, Repository Pattern |
| **Mapping** | AutoMapper |
| **Validasyon** | Fluent Validation |
| **Frontend** | HTML5, CSS3, Bootstrap, View Component |
| **Real-Time** | SignalR |
| **Diğer** | Areas, DTOs, Linq |


---

## 👏 Teşekkür

Bu projenin geliştirilmesindeki kapsamlı anlatımı ve rehberliği için **Murat Yücedağ** hocama teşekkür ederim.

* **Kurs Platformu:** YouTube
* **Eğitmen:** Murat Yücedağ

---