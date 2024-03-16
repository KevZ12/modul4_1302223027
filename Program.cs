// See https://aka.ms/new-console-template for more information
namespace modul4_1302223027
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kodeBuah = new KodeBuah();

           
            Console.WriteLine("kode buah dari " + KodeBuah.Buah.Alpukat+" adalah "+KodeBuah.getKodeBuah(KodeBuah.Buah.Alpukat));
            Console.WriteLine("kode buah dari " + KodeBuah.Buah.Paprika + " adalah " + KodeBuah.getKodeBuah(KodeBuah.Buah.Paprika));
            Console.WriteLine("kode buah dari " + KodeBuah.Buah.Semangka + " adalah " + KodeBuah.getKodeBuah(KodeBuah.Buah.Semangka));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            PosisiKarakterGame posisiState = new PosisiKarakterGame();
            posisiState.runState();

        }
    }
}
