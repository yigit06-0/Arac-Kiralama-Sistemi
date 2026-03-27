Araç Kiralama Otomasyonu (C# & OOP)

Bu proje, *Bandırma Onyedi Eylül Üniversitesi* Bilgisayar Mühendisliği eğitimi kapsamında, Nesne Yönelimli Programlama (OOP) prensiplerini gerçek bir senaryo üzerinde uygulamak amacıyla geliştirilmiş bir Windows Forms uygulamasıdır.


Uygulama; otomobil, motosiklet ve minibüs gibi farklı araç türlerinin sisteme eklenmesini, bu araçların müşterilere kiralanmasını ve teslim alınma süreçlerini yönetir. Projenin temel odak noktası kodun sürdürülebilirliği ve nesne odaklı mimaridir.

 Teknik Özellikler ve OOP Prensipleri
Proje içerisinde aşağıdaki mühendislik yaklaşımları kullanılmıştır:

*Soyutlama (Abstraction):** `Arac` sınıfı `abstract` olarak tanımlanarak, tüm araçların ortak özelliklerini (Plaka, Marka) ve metotlarını (`AracBilgisi`) tek bir çatıda toplamıştır.
*Kalıtım (Inheritance):** `Otomobil`, `Motosiklet` ve `Minibus` sınıfları `Arac` sınıfından türetilerek kod tekrarı önlenmiştir.
*Çok Biçimlilik (Polymorphism):** Farklı araç tipleri için kiralama ücretleri, araç türüne özel nesne davranışları üzerinden dinamik olarak hesaplanmaktadır.
*Koleksiyon Yönetimi:** Araç ve müşteri verileri `List<T>` koleksiyonları kullanılarak bellek üzerinde dinamik olarak yönetilmiştir.
*Dosya İşlemleri (I/O):** Sisteme eklenen araçlar `araclar.txt` dosyası üzerinden okunarak verilerin kalıcılığı sağlanmıştır.


*Dil: C#
*Framework:.NET Framework 4.7.2
*Arayüz: Windows Forms (WinForms)
*IDE: Visual Studio

