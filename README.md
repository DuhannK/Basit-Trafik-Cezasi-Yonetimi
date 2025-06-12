# Trafik Cezası Takip ve Yönetim Sistemi

Bu proje, Windows Forms ile geliştirilmiş bir **trafik cezası sorgulama ve ceza yönetimi uygulamasıdır**. Hem **kullanıcı** hem de **polis** için iki ayrı arayüz sunar.

## Kullanım

Aşağıda uygulamanın genel işleyişini gösteren kullanım videosu bulunmaktadır:

### Tam Kullanım Videosu

[Uygulamanın Tüm Özelliklerini Gösteren YouTube Linki](https://youtu.be/3UPmUNYTioY)




https://github.com/user-attachments/assets/46e495f2-fece-47a1-af3c-1849f4bd59e3





---

## Özellikler

* **Kullanıcı Arayüzü**

  * İsmini giren kullanıcı, kendi ceza listesini ve toplam borcunu görebilir.
  * Sadece ödenmemiş cezaları görebilir.
  * Tek tek veya tüm cezalarını ödeyebilir.

* **Polis Arayüzü**

  * Yeni sürücü ekleyebilir.
  * Seçili sürücüye ceza ekleyebilir.
  * Yanlış eklenen cezayı silebilir.
  * Cezaları ve toplam borcu görebilir.

* **Ana Menü**

  * Uygulama ilk açıldığında “Ceza Sorgulama” ve “Ceza İşlemleri” olmak üzere iki arayüz seçeneği sunar.
  * Her iki ekrandan ana menüye kolayca dönebilirsiniz.

* **Kod yapısı**

  * Ceza türleri enum olarak tanımlanmıştır. Yeni ceza türü eklemek çok kolaydır.
  * IOdenecek arayüzü ile ceza işlemleri daha düzenli ve sürdürülebilir hale getirilmiştir.
  * Tüm formlar arası veri paylaşımı sağlanmış, veri kaybı olmadan geçiş yapılmaktadır.

---

## Kısa Notlar

* **Yeni ceza türü eklemek için:**
  `CezaTuru` enumuna yeni bir değer ekleyip, ilgili ceza sınıfını türetmeniz yeterlidir.
* **Veriler arası geçiş ve veri kaybı olmaması için:**
  Tüm uygulama boyunca tek bir sürücü listesi kullanılmaktadır.

---

**Hazırlayan:**

Duhan Köse - 230260070

Veli Yener - 230260074
