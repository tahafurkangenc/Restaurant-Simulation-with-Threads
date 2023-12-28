using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoranv0
{
    public class Musteri
    {
        public int musteri_ID;
        public int musteri_yas;
        public Thread musteri_thread;
        static object locker = new object();
        public Musteri(int musteri_ID, int musteri_yas)
        {
            this.musteri_ID = musteri_ID;
            this.musteri_yas = musteri_yas;
        }

        public void masalaraMusteriAl()
        {
            Console.WriteLine("THREAD NAME = " + Thread.CurrentThread.Name + " ->WORKING");
            Boolean bekliyor_mu = true;
            while (bekliyor_mu)
            {
                for (int i = 0; i < Program.masaArray.Length; i++)
                {
                    lock (locker)
                    {
                        if (Program.masaArray[i].masa_numara == -1)
                        {
                            Program.masaArray[i].masa_numara = i;
                            Program.masaArray[i].masa_musteri = this;
                            Program.masaArray[i].masa_thread = new Thread(Program.masaArray[i].musteriislemleri);
                            Program.masaArray[i].masa_thread.Start();
                            //Program.musteriList.Remove(this);
                            bekliyor_mu = false;
                            break;
                        }
                    }
                }
                if (!(bekliyor_mu))
                {
                    break;
                }
            }

            //Thread.Sleep(1000);
            Console.WriteLine("THREAD NAME = " + Thread.CurrentThread.Name + " ->ENDING");
        }

        public void yemekYe()
        {
            Console.WriteLine("THREAD NAME = " + Thread.CurrentThread.Name + " ->WORKING");
            Console.WriteLine(musteri_ID + " numarali musteri yemege basladi");
            Thread.Sleep(3000);
            Console.WriteLine(musteri_ID + " numarali musteri yemegi bitirdi");
            Thread musteri_kasa_thread = new Thread(() => Program.kasa.odemeAl(this));
            musteri_kasa_thread.Name = "KASA THREAD for -> " + this.musteri_ID + " - ID CUSTOMER";
            musteri_kasa_thread.Start();
            Console.WriteLine("THREAD NAME = " + Thread.CurrentThread.Name + " ->ENDING");
        }
    }
    public class Masa
    {
        public int masa_numara;
        public Musteri masa_musteri;
        public int masa_hesap;
        public Garson masa_garson;
        public Thread masa_thread;
        static object locker = new object();
        public Masa(int masa_numara, Musteri masa_musteri)
        {
            this.masa_numara = masa_numara;
            this.masa_musteri = masa_musteri;
        }
        public void musteriislemleri()
        {
            while (true)
            {
                Boolean masaya_garson_atandi_mi = false;
                for (int i = 0; i < Program.garsonArray.Length; i++)
                {
                    lock (locker)
                    {
                        if (Program.garsonArray[i].garson_musait_mi)
                        {
                            masa_garson = Program.garsonArray[i];
                            masa_garson.garson_musait_mi = false;
                            masa_garson.garson_masa = this;
                            Console.WriteLine("Masa.masa_numara:" + this.masa_numara + " Program.garsonArray[i].garson_numara:" + Program.garsonArray[i].garson_numara);
                            masaya_garson_atandi_mi = true;
                            break;
                        }
                    }
                }
                if (masaya_garson_atandi_mi)
                {
                    break;
                }
            }
            masa_garson.garson_thread = new Thread(masa_garson.siparisAl);
            masa_garson.garson_thread.Name = "Garson Thread - " + masa_garson.garson_numara + " for -> " + masa_numara + " ID Table & " + masa_musteri.musteri_ID + " ID Customer";
            masa_garson.garson_thread.Start();
            masa_garson.garson_thread.Join();

            masa_hesap = 50;
            Console.WriteLine(masa_musteri.musteri_ID + " numarali musteriye " + masa_hesap + " TL hesap kesildi");
        }
    }
    public class Garson
    {
        public int garson_numara;
        public Thread garson_thread;
        public Masa garson_masa;
        public Boolean garson_musait_mi = true;
        static object locker = new object();
        Garson() { }

        public Garson(int garson_numara, bool garson_musait_mi)
        {
            this.garson_numara = garson_numara;
            this.garson_musait_mi = garson_musait_mi;
        }

        public void siparisAl()
        {
            Console.WriteLine(garson_thread.Name + " is start");
            //Console.Write(garson_numara + " numarali garson ");
            //Console.Write(garson_masa.masa_numara + " numarali masadaki ");
            //Console.Write(garson_masa.masa_musteri.musteri_ID + " numarali musteriden siparis aldi\n");
            // Masa siparisalinanmasa = garson_masa;
            Thread.Sleep(2000);
            Console.WriteLine(garson_numara + " numarali garson " + garson_masa.masa_numara + " numarali masadaki " + garson_masa.masa_musteri.musteri_ID + " numarali musteriden siparis aldi");
            Musteri ascininmusterisi = garson_masa.masa_musteri; // bura ile ilgilen
            //Console.WriteLine("Send this to asci_thread -> " + garson_masa.masa_musteri.musteri_ID);
            Asci siparis_gonderilecek_asci = Program.asciArray.OrderBy(p => (p.musteri_siparisiletildi.Count()+p.musteri_hazirlaniyor.Count())).FirstOrDefault();
            Thread asciicinthread = new Thread(() => siparis_gonderilecek_asci.yemekhazirla(ascininmusterisi));
            //Console.WriteLine("We Send this to asci_thread -> " + garson_masa.masa_musteri.musteri_ID);
            //Thread asciicinthread = new Thread(() => Program.asci.yemekhazirla(ascininmusterisi));
            asciicinthread.Name = "Asci Thread "+siparis_gonderilecek_asci.asci_numara+" for -> " + ascininmusterisi.musteri_ID;
            asciicinthread.Start();
            //lock (locker)
            //{

            garson_musait_mi = true;
            // garson_masa = null;
            // }
            Console.WriteLine(garson_thread.Name + " is end");

        }
    }
    public class Asci
    {
        public int asci_numara;
        public static Semaphore asci_pool = new Semaphore(initialCount: 2, maximumCount: 2);
        //public Musteri asci_musteri;
        static object locker = new object();
        public List<Musteri> musteri_siparisiletildi= new List<Musteri>();
        public List<Musteri> musteri_hazirlaniyor = new List<Musteri>();
        public List<Musteri> musteri_hazirlandi = new List<Musteri>();
        public Asci() { }

        public Asci(int asci_numara)
        {
            this.asci_numara = asci_numara;
        }

        public void yemekhazirla(Musteri musteri)
        {

            Console.WriteLine(Thread.CurrentThread.Name + " is start ");
            Console.WriteLine(musteri.musteri_ID + " numarali musterinin siparisi iletildi");
            musteri_siparisiletildi.Add(musteri);
            asci_pool.WaitOne();
            Console.WriteLine(musteri.musteri_ID + " numarali musterinin siparisi hazirlaniyor");
            musteri_siparisiletildi.Remove(musteri);
            musteri_hazirlaniyor.Add(musteri);
            Thread.Sleep(3000);
            asci_pool.Release();
            Console.WriteLine(musteri.musteri_ID + " numarali musterinin siparisi hazirlandi");
            musteri_hazirlaniyor.Remove(musteri);
            musteri_hazirlandi.Add(musteri);
            musteri.musteri_thread = new Thread(musteri.yemekYe);
            musteri.musteri_thread.Name = "MUSTERİ yemekYe() THREAD - " + musteri.musteri_ID;
            musteri.musteri_thread.Start();
            Console.WriteLine(Thread.CurrentThread.Name + " is end");
        }

    }
    public class Kasa
    {
        public int kasa_para;
        public Thread kasa_thread;
        static object locker = new object();
        public List<Musteri> kasa_odemeyapacakmusteriler = new List<Musteri>();
        public List<Musteri> kasa_odemeyapmismusteriler = new List<Musteri>();
        public Kasa()
        {
        }
        public Kasa(int kasa_para)
        {
            this.kasa_para = kasa_para;
        }
        public void odemeAl(Musteri musteri)
        {
            Console.WriteLine("THREAD NAME = " + Thread.CurrentThread.Name + " ->WORKING");
            kasa_odemeyapacakmusteriler.Add(musteri);
            lock (locker)
            {
                Console.WriteLine(musteri.musteri_ID + " numarali musteriden " + " TL tutarinda para aliniyor");
                for (int i = 0; i < Program.masaArray.Length; i++)
                {
                    if (Program.masaArray[i].masa_musteri.Equals(musteri))
                    {
                        kasa_para = kasa_para + Program.masaArray[i].masa_hesap;
                        Program.masaArray[i].masa_hesap = 0;
                        Program.masaArray[i].masa_numara = -1;
                        //Program.masaArray[i].masa_musteri = null;
                        //Program.masaArray[i].masa_garson = null;
                        break;
                    }
                }
                Thread.Sleep(1000);
                Console.WriteLine(musteri.musteri_ID + " numarali musteriden " + " TL tutarinda para alindi");
                kasa_odemeyapacakmusteriler.Remove(musteri);
                kasa_odemeyapmismusteriler.Add(musteri);
            }
            Console.WriteLine("THREAD NAME = " + Thread.CurrentThread.Name + " ->ENDING");
        }
    }
    internal static class Program
    {
        public static Random random = new Random();
        public static List<Musteri> musteriList = new List<Musteri>();
        //public static List<Musteri> mList = new List<Musteri>();
        public static Masa[] masaArray = new Masa[6];
        public static Garson[] garsonArray = new Garson[3];
        public static Asci[] asciArray = new Asci[1];
        public static Kasa kasa = new Kasa(0);
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            for (int i = 0; i < masaArray.Length; i++)
            {
                masaArray[i] = new Masa(-1, null);
            }
            for (int i = 0; i < garsonArray.Length; i++)
            {
                garsonArray[i] = new Garson(i, true);
            }
            for(int i = 0;i<asciArray.Length; i++)
            {
                asciArray[i]=new Asci(i);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}