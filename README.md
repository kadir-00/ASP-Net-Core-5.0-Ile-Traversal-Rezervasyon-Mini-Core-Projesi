![.NET Core](https://img.shields.io/badge/.NET%20Core-5.0-512BD4?logo=dotnet&logoColor=white)
![Architecture](https://img.shields.io/badge/Architecture-CQRS%20%26%20MediatR-blue?style=flat&logo=csharp)
![RealTime](https://img.shields.io/badge/RealTime-SignalR-lightgrey?style=flat)
![Database](https://img.shields.io/badge/Database-MSSQL-CC2927?logo=microsoft-sql-server&logoColor=white)
![API](https://img.shields.io/badge/Integration-RESTful%20API-green)

# 🌍 Traversal - Seyahat Rezervasyon & Yönetim Sistemi

**Traversal**, bir seyahat acentesinin tüm iş süreçlerini dijitalleştirmek, kullanıcıların tur rezervasyonlarını yönetmek ve yöneticilere kapsamlı bir raporlama sunmak amacıyla geliştirilmiş, uçtan uca bir web uygulamasıdır.

Bu proje, **Murat Yücedağ** rehberliğinde (38 Saat / 100 Derslik Eğitim) **ASP.NET Core 5.0** altyapısı kullanılarak geliştirilmiştir. Projenin en önemli özelliği, **CQRS (Command Query Responsibility Segregation)** ve **MediatR** desenleri kullanılarak inşa edilmiş modern ve ölçeklenebilir mimarisidir.

---

## 🏗️ Mimari ve Tasarım Desenleri (Architecture)

Proje, klasik katmanlı mimarinin ötesine geçerek, sorumlulukların ayrıştırıldığı gelişmiş desenleri barındırır:

* **CQRS & MediatR:** Okuma (Query) ve Yazma (Command) işlemlerinin ayrıştırılması sayesinde performans ve yönetilebilirlik artırılmıştır.
* **Repository Design Pattern:** Veri erişimi soyutlanarak kod tekrarı önlenmiştir.
* **AutoMapper:** Veri transfer nesneleri (DTO) ile entity'ler arasındaki eşleşmeler otomatikleştirilmiştir.
* **FluentValidation:** Sunucu taraflı doğrulama kuralları katı bir şekilde uygulanmıştır.

---

## 📸 Proje Arayüzleri

Proje; **Vitrin (UI)**, **Misafir (User)** ve **Yönetim (Admin)** olmak üzere 3 temel modülden oluşur.

### 1. ✨ Web Sitesi (Vitrin)
Ziyaretçilerin rotaları incelediği ön yüz.
* **Rotalar & Blog:** Tur detayları, blog yazıları ve kullanıcı yorumları.
* **Rehberler:** Aktif tur rehberlerinin listelenmesi.
* **Etkileşim:** İletişim formu ve bülten (Mail) aboneliği.

### 2. 🌞 Kullanıcı Paneli (Member)
Kayıtlı kullanıcıların kendi işlemlerini yönettiği alan.
* **Rezervasyon Yönetimi:**
    * 🟢 Aktif Rezervasyonlar
    * 🟡 Onay Bekleyen Rezervasyonlar
    * 🔴 Geçmiş Rezervasyonlar
* **Çoklu Dil Desteği (Localization):** Panel dili **Türkçe, İngilizce veya Fransızca** olarak değiştirilebilir.
* **Profil:** Bilgi güncelleme, fotoğraf yükleme ve yorum yönetimi.

### 3. 🔑 Admin Paneli
Acentenin tüm operasyonel süreçlerinin yönetildiği merkez.
* **Raporlama:** Kullanıcı ve tur verilerinin **Excel** ve **PDF** formatında dışarı aktarılması.
* **Hızlı İşlemler (AJAX):** Sayfa yenilenmeden rota ekleme/silme/güncelleme.
* **İletişim:** Mail gönderme, duyuru yayınlama ve mesaj kutusu yönetimi.
* **Rol Yönetimi:** Admin ve kullanıcı yetkilendirmeleri.
* **Dashboard:** Site istatistikleri ve grafiksel analizler.

## 🚀 Öne Çıkan Teknolojik Özellikler

### 📡 SignalR (Gerçek Zamanlı İletişim)
Projede **SignalR** teknolojisi kullanılarak, anlık ziyaretçi sayıları ve grafik verileri **canlı olarak (real-time)** dashboard üzerinde güncellenmektedir.

### 📧 Gelişmiş Mail & SMTP Entegrasyonu
Proje, kullanıcı etkileşimini artırmak için **MimeKit** ve **MailKit** kütüphaneleri ile güçlendirilmiş bir mail servisine sahiptir.
* **Onay ve Bildirimler:** Yeni kayıt olan kullanıcılara "Hoş Geldiniz" maili ve rezervasyon onayı gönderimi.
* **Şifre Sıfırlama:** "Şifremi Unuttum" senaryosunda güvenli token içeren mail gönderimi.
* **Toplu İletişim:** Admin panelinden tüm kullanıcılara veya belirli bir aboneye html formatında duyuru maili atabilme.

### 🌐 API Entegrasyonları
* **Google Maps / Map API:** Tur rotalarının harita üzerinde gösterimi.
* **RESTful API:** Proje, dış servislere veri sağlayacak API uçlarına sahiptir.
* **Rapid API:** (Booking veya IMDb API gibi) Dış kaynaklardan veri çekme işlemleri.

### 📊 Veri Analizi ve Raporlama
Admin panelinde oluşturulan dinamik listeler, tek tıkla **Excel** veya **PDF** formatında raporlanabilir.

## 🛠 Kullanılan Teknolojiler

| Kategori | Teknoloji / Kütüphane |
| :--- | :--- |
| **Backend** | ASP.NET Core 5.0 |
| **Mimari** | **CQRS, MediatR**, Onion Architecture |
| **Veritabanı** | MSSQL Server, Entity Framework Core |
| **Real-Time** | **SignalR** |
| **Frontend** | HTML5, CSS3, Bootstrap, jQuery, **AJAX** |
| **Validasyon** | FluentValidation |
| **Mapping** | AutoMapper |
| **Localization** | Çoklu Dil Desteği (TR/EN/FR) |


---

## 📸 Proje Ekran Görüntüleri

### 🏠 Ana Sayfa ve Kullanıcı Arayüzü (UI)
<p align="center">
  <img src="screenshots/anasayfa-1.png" alt="Ana Sayfa Görünümü" width="30%" />
  &nbsp;
  <img src="screenshots/anasayfa-2.png" alt="Rota Detayları" width="30%" />
  &nbsp;
  <img src="screenshots/anasayfa-3.png" alt="Kullanıcı Paneli" width="30%" />
</p>

### 🛠️ Admin Yönetim Paneli
<p align="center">
  <img src="screenshots/admin-1.png" alt="Admin Dashboard" width="30%" />
  &nbsp;
  <img src="screenshots/admin-2.png" alt="Admin Rota İşlemleri" width="30%" />
  &nbsp;
  <img src="screenshots/admin-3.png" alt="Admin İstatistikler" width="30%" />
</p>

---

### 🏗️ CQRS Mimari Yapısı (Klasör Düzeni)
<p align="center">
  <img src="screenshots/cqrs-pattern.png" alt="CQRS Mimari Yapısı" width="75%" />
</p>

### 🌐 Rapid API Entegrasyonu
<p align="center">
  <img src="screenshots/rapid-api.png" alt="Rapid API Entegrasyonu" width="75%" />
</p>

### 📩 Mail Gönderme Servisi
<p align="center">
  <img src="screenshots/mail-service.png" alt="Mail Gönderme İşlemi" width="75%" />
</p>

---