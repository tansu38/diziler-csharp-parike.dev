// Dizi tanımlama
string[] renkler = new string[5];

string[] hayvanlar = {"kedi","Köpek","Kuş","Maymun"};

int[] dizi;
dizi = new int[5];

// Dizilere Değer Atama ve Erişim
renkler[0] = "Mavi";

dizi[3]= 10;
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngülerle ile dizi kullanımı
// Klavyeden girilen n tane sayının ortalamasını hesaplayan program
Console.WriteLine("Lütfen dizinin eleman sayisini giriniz:");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for(int i = 0;i<diziUzunlugu;i++)
{
    Console.WriteLine($"{i+1}'ninci elemani giriniz:");
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}
int toplam = 0;
foreach (var sayi in sayiDizisi)
    toplam += sayi;
Console.WriteLine("Ortalama: "+ toplam/diziUzunlugu);
