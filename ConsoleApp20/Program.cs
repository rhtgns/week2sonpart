//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Merhaba");
//        Console.WriteLine("Nasılsın ?");
//        Console.WriteLine("İyiyim");
//        Console.WriteLine("Sen nasılsın ?");
//    }
//}
using System;
using System.Diagnostics.Metrics;
class Program { 

     static void Main(string[] args)
//    {

    // Metinsel veri tutan değişken
        string metin = "Merhaba Dünya";

    // Tam sayı verisi tutan değişken
    int sayi = 42;

    // Değişkenlerin değerlerini ekrana yazdırma
    Console.WriteLine("Metinsel veri: " + metin);
        Console.WriteLine("Tam sayı verisi: " + sayi);
    }
}
    }
}
  // Rastgele sayı üretmek için Random sınıfını kullandım
        Random random = new Random();

// Rastgele bir tamsayı ürettim
int rastgeleSayi = random.Next();

// Rastgele sayıyı ekrana yazdırdım
Console.WriteLine("Rastgele sayı: " + rastgeleSayi);
    }

/* Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız*/

 Random random1 = new Random();

int sayi = random1.Next();

int kalan = rastgeleSayi % 3;

// Rastgele sayıyı ve kalan değerini ekrana yazdır
Console.WriteLine("Rastgele sayı: " + rastgeleSayi);
Console.WriteLine("3'e bölümünden kalan: " + kalan);
    }


// Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.


 string yasStr = Console.ReadLine();

// Yaşı bir tam sayı olarak parse et
int yas;
bool basarili = int.TryParse(yasStr, out yas);

// Parse işlemi başarılı olduysa yaşa göre karar ver
if (basarili)
{
    if (yas > 18)
    {
        Console.WriteLine("+");
    }
    else
    {
        Console.WriteLine("-");
    }
}

for (int i = 0; i < =10; i++)
{
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem");



}


// Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.


Console.Write("Lütfen ilk metni giriniz: ");
string metin1 = Console.ReadLine();

// Kullanıcıdan ikinci metinsel değeri al
Console.Write("Lütfen ikinci metni giriniz: ");
string metin2 = Console.ReadLine();

// Yer değiştirme işlemi
string temp = metin1;
metin1 = metin2;
metin2 = temp;

// Sonuçları ekrana yazdır
Console.WriteLine("Yer değiştirdikten sonra:");
Console.WriteLine("İlk metin: " + metin1);
Console.WriteLine("İkinci metin: " + metin2)


    //Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

    C


     static void BenDegerDondurmem()

{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");

}
static void Main(string[] args)
{
    // Metodu çağır
    BenDegerDondurmem();
}

//- İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

Console.WriteLine("lutfen iki sayi giriniz");

static int Topla()
{

    return sayi1 + sayi2;
}
static void Main(string[] args)
{
    Console.Write("Lütfen ilk sayıyı giriniz: ");
    int sayi1 = int.Parse(Console.ReadLine());

    // Kullanıcıdan ikinci sayıyı al
    Console.Write("Lütfen ikinci sayıyı giriniz: ");
    int sayi2 = int.Parse(Console.ReadLine());

    int Toplam = Topla(sayi1, sayi2);
}
Console.WriteLine("İki sayının toplamı: " + toplam);

//- Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
//bunu anlayamadımm malsef 


//3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
static int EnYasliYas(int yas1, int yas2, int yas3)
{
    // Üç yaş arasında en yüksek olanını döndür
    return Math.Max(yas1, Math.Max(yas2, yas3));
}

static void Main(string[] args)
{
    // Kullanıcıdan üç kişinin yaşını al
    Console.Write("Birinci kişinin yaşını giriniz: ");
    int yas1 = int.Parse(Console.ReadLine());

    Console.Write("İkinci kişinin yaşını giriniz: ");
    int yas2 = int.Parse(Console.ReadLine());

    Console.Write("Üçüncü kişinin yaşını giriniz: ");
    int yas3 = int.Parse(Console.ReadLine());

    // En yaşlı kişinin yaşını hesapla
    int enYasliYas = EnYasliYas(yas1, yas2, yas3);

    // Sonucu ekrana yazdır
    Console.WriteLine("En yaşlı kişinin yaşı: " + enYasliYas);
}
}


//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.



///Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız
///
using System;

class Program
{
    // İki ismin yerlerini değiştiren metot
    static void YerDegistir(ref string isim1, ref string isim2)
    {
        // Geçici bir değişken kullanarak isimlerin yerlerini değiştir
        string temp = isim1;
        isim1 = isim2;
        isim2 = temp;
    }

    static void Main(string[] args)
    {
        // Kullanıcıdan iki ismi al
        Console.Write("Birinci ismi giriniz: ");
        string isim1 = Console.ReadLine();

        Console.Write("İkinci ismi giriniz: ");
        string isim2 = Console.ReadLine();

        // İsimlerin yerlerini değiştir
        YerDegistir(ref isim1, ref isim2);

        // Yer değiştirme işleminden sonra isimleri ekrana yazdır
        Console.WriteLine("İsimlerin yer değiştirildikten sonraki halleri:");
        Console.WriteLine("Birinci isim: " + isim1);
        Console.WriteLine("İkinci isim: " + isim2);
    }
}

//Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
static bool TekMiCiftMi(int sayi)
{
    // Sayının çift olup olmadığını kontrol et
    return sayi % 2 == 0;
}

static void Main(string[] args)
{
    // Kullanıcıdan bir sayı al
    Console.Write("Bir sayı giriniz: ");
    int sayi = int.Parse(Console.ReadLine());

    // Tek mi çift mi olduğunu belirle
    bool sonuc = TekMiCiftMi(sayi);

    // Sonucu ekrana yazdır
    if (sonuc)
    {
        Console.WriteLine("Girdiğiniz sayı çift.");
    }
    else
    {
        Console.WriteLine("Girdiğiniz sayı tek.");
    }
}
}


// Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.


static double YoluHesapla(double hiz, double zaman)
{
    // Yol hesaplaması: d = v * t
    return hiz * zaman;
}

static void Main(string[] args)
{
    // Kullanıcıdan hız bilgisini al
    Console.Write("Hızı (km/saat) giriniz: ");
    double hiz = double.Parse(Console.ReadLine());

    // Kullanıcıdan zaman bilgisini al
    Console.Write("Zamanı (saat) giriniz: ");
    double zaman = double.Parse(Console.ReadLine());

    // Gidilen yolu hesapla
    double yol = YoluHesapla(hiz, zaman);

    // Sonucu ekrana yazdır
    Console.WriteLine("Gidilen yol: " + yol + " km");
}
}

// Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
static double AlanHesapla(double yaricap)
{
    // Pi sayısının değeri
    const double PI = 3.141592653589793;

    // Dairenin alanını hesapla: Alan = π * r^2
    return PI * yaricap * yaricap;
}

static void Main(string[] args)
{
    // Kullanıcıdan yarıçap bilgisi al
    Console.Write("Dairenin yarıçapını giriniz: ");
    double yaricap = double.Parse(Console.ReadLine());

    // Dairenin alanını hesapla
    double alan = AlanHesapla(yaricap);

    // Sonucu ekrana yazdır
    Console.WriteLine("Dairenin alanı: " + alan);
}



}

//"Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
lass Program
{
    static void Main(string[] args)
{
    // Kullanıcıdan cümle al
    Console.Write("Bir cümle giriniz: ");
    string cumle = Console.ReadLine();

    // Cümleyi tamamen büyük harfle yazdır
    string buyukHarf = cumle.ToUpper();
    Console.WriteLine("Tamamen büyük harflerle: " + buyukHarf);

    // Cümleyi tamamen küçük harfle yazdır
    string kucukHarf = cumle.ToLower();
    Console.WriteLine("Tamamen küçük harflerle: " + kucukHarf);
}
}
// Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
lass Program
{
    static void Main(string[] args)
{
    // Başındaki ve sonundaki boşlukları olan bir metni değişkene ata
    string metin = "   Selamlar   ";

    // Başındaki ve sonundaki boşlukları kaldır
    metin = metin.Trim();

    // Sonucu ekrana yazdır
    Console.WriteLine("Temizlenmiş metin: '" + metin + "'");
}
}