

using Abstraction_Pratic;

// Proje Yöneticisi nesnesi oluşturuluyor ve özellikleri atanıyor
ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi(); 

projeYoneticisi.Ad = "Gamze";
projeYoneticisi.Soyad = "Bilge";

Console.WriteLine("Ben "+projeYoneticisi.Ad+" "+projeYoneticisi.Soyad);
projeYoneticisi.Gorev();

Console.WriteLine("-------------------------------------");

// Satış Temsilcisi nesnesi oluşturuluyor ve özellikleri atanıyor

SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi();

satisTemsilcisi.Ad = "Uğur";
satisTemsilcisi.Soyad = "Güler";

Console.WriteLine("Ben "+satisTemsilcisi.Ad+" "+satisTemsilcisi.Soyad);
satisTemsilcisi.Gorev();

Console.WriteLine("-------------------------------------");

// Yazılım Geliştirici nesnesi oluşturuluyor ve özellikleri atanıyor

YazilimGelistirici yazilimGeliştirici = new YazilimGelistirici();
yazilimGeliştirici.Ad = "Efe";
yazilimGeliştirici.Soyad = "Avşar";

Console.WriteLine("Ben "+yazilimGeliştirici.Ad+" "+yazilimGeliştirici.Soyad);
yazilimGeliştirici.Gorev();