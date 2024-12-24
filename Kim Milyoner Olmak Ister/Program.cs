namespace Kim_Milyoner_olmak_ister
{

}

class Program
{
    static void Main()
    {
        int dogruCevapSayisi = 0;

        Console.WriteLine("Kim Milyoner Olmak İster Yarışmasına Hoş Geldiniz!");

        // Soru 1
        Console.WriteLine("\n1 -> Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a) Lama  b) Deve");
        string cevap1 = Console.ReadLine().ToLower();

        if (cevap1 == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Soru 2
        Console.WriteLine("\n2 -> Dünya'ya en yakın gezegen hangisidir?");
        Console.WriteLine("a) Venüs  b) Mars");
        string cevap2 = Console.ReadLine().ToLower();

        if (cevap2 == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Eğer 2 doğru cevap yoksa 3. soruyu sormayalım
        if (dogruCevapSayisi < 2)
        {
            Console.WriteLine("\nMaalesef 2 doğru cevaba ulaşamadınız. Büyük ödülü kazanamadınız.");
            return;
        }

        // Soru 3
        Console.WriteLine("\n3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
        Console.WriteLine("a) 7  b) 12");
        string cevap3 = Console.ReadLine().ToLower();

        if (cevap3 == "b")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Final Sonucu
        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("\nTebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("\nMaalesef büyük ödülü kazanamadınız.");
        }
    }
}