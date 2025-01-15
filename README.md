# Abstraction Pratik

Bu proje, bir şirketin çalışanlarını temsil eden bir programdır. Projede **abstraction** (soyutlama) kavramı kullanılarak çalışanlar arasındaki ortak özellikler ve görevler modellemiştir.

---

## Proje Özeti

- Şirket çalışanları, bir **`BaseKisi`** sınıfı ile modellenmiştir.
- Tüm çalışanların ortak özellikleri (örneğin, `Ad`, `Soyad`, `Departman`) bu sınıfta tanımlanmıştır.
- Çalışanların kendine özgü görevleri, bir **`Gorev()`** adlı abstract metod ile belirlenmiştir.
- Her çalışan tipi (örneğin, **Proje Yöneticisi**, **Satış Temsilcisi**, **Yazılım Geliştirici**) kendi görev tanımını yaparak `BaseKisi` sınıfından türetilmiştir.

---

## Özellikler

1. **Soyutlama (Abstraction):**
   - Tüm çalışanların ortak özellikleri ve görevleri tek bir abstract sınıfta tanımlanmıştır.
2. **Polimorfizm (Polymorphism):**
   - Çalışanların görev metodu (`Gorev()`) alt sınıflarda override edilerek her çalışanın farklı bir mesaj göstermesi sağlanmıştır.
3. **Ortak Metot:**
   - Tüm çalışanların bilgilerini yazdırmak için `BaseKisi` sınıfında bir metot tanımlanmıştır.

---

## Kullanım Senaryosu

- **Proje Yöneticisi:** Şirketin projelerini yönetir ve proje planlaması yapar.
- **Satış Temsilcisi:** Şirketin ürün ve hizmetlerini müşterilere tanıtarak satış yapar.
- **Yazılım Geliştirici:** Şirketin yazılım ihtiyaçlarını karşılayarak yeni uygulamalar geliştirir.

---

## Proje Yapısı

1. **BaseKisi Sınıfı:**
   - Çalışanların ortak özellikleri ve görev metodunu içerir.
2. **Alt Sınıflar:**
   - **ProjeYoneticisi:** `BaseKisi` sınıfından türeyen ve proje yönetimi görevlerini tanımlayan sınıf.
   - **SatisTemsilcisi:** `BaseKisi` sınıfından türeyen ve satış görevlerini tanımlayan sınıf.
   - **YazilimGelistirici:** `BaseKisi` sınıfından türeyen ve yazılım geliştirme görevlerini tanımlayan sınıf.
3. **Ana Program (Main):**
   - Çalışan nesnelerinin oluşturulduğu ve görevlerinin ekrana yazdırıldığı bölüm.

---


