using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Fibonacci Derinliği:");
            string derinlik;
            derinlik = Console.ReadLine();
            
            List<int> fibo = new List<int>();
            fibo = Fibonacci.seriOlustur(Convert.ToInt32(derinlik));
            Console.WriteLine("Ortalama:" + FiboOrtalama.ortalamaHesapla(fibo).ToString());

        }
    }
}

class Fibonacci {
    public static List<int> seriOlustur(int seri) {
        List<int> fiboList = new List<int>();
        fiboList.Add(1);
        fiboList.Add(1);
        if(seri<3){
            return fiboList;
        }
        for(int i=2; i<seri; i++) {
            fiboList.Add(fiboList[i-1] + fiboList [i-2]);
        }

        return fiboList;
    }
}

class FiboOrtalama {
    static double toplam = 0;
    static double listeUzunluk;

    public static double ortalamaHesapla(List<int> fiboListe) {
        listeUzunluk = fiboListe.Count;
        for(int i=0; i<fiboListe.Count; i++) {
            toplam += fiboListe[i];
        }
        return toplam/listeUzunluk;
    }
}