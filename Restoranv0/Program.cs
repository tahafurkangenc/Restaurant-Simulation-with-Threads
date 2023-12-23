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
            Console.WriteLine("THREAD NAME = " + Thread.CurrentThread.Name +" ->WORKING");
            
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
                          break;
                        }
                   }
                }
            //Thread.Sleep(1000);
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
                for (int i=0;i<Program.garsonArray.Length;i++)
                {
                    lock (locker)
                    {
                        if (Program.garsonArray[i].garson_musait_mi)
                        {
                            masa_garson = Program.garsonArray[i];
                            masa_garson.garson_musait_mi = false;
                            Console.WriteLine("Masa.masa_numara:" + this.masa_numara + " Program.garsonArray[i].garson_numara:" + Program.garsonArray[i].garson_numara);
                            masaya_garson_atandi_mi=true;
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
            masa_garson.garson_thread.Name = "Garson Thread - "+masa_garson.garson_numara;
            masa_garson.garson_thread.Start();
            masa_garson.garson_thread.Join();


        }
    }
    public class Garson
    {
        public int garson_numara;
        public Thread garson_thread;
        public Masa garson_masa;
        public Boolean garson_musait_mi=true;
        
        Garson() { }

        public Garson(int garson_numara, bool garson_musait_mi)
        {
            this.garson_numara = garson_numara;
            this.garson_musait_mi = garson_musait_mi;
        }

        public void siparisAl()
        {
            Console.WriteLine(garson_thread.Name + " is start");
            Thread.Sleep(1000);
            garson_musait_mi = true;
            Console.WriteLine(garson_thread.Name + " is end");
        }
    }
    public class Asci
    {
        public int asci_numara;
        public Thread asci_thread;
        public Garson asci_garson;
        public Asci() { }
    }
    internal static class Program
    {
        public static Random random = new Random();
        public static List<Musteri> musteriList= new List<Musteri>();
        //public static List<Musteri> mList = new List<Musteri>();
        public static Masa[] masaArray = new Masa[6];
        public static Garson[] garsonArray = new Garson[3];
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            for(int i = 0; i < masaArray.Length; i++)
            {
                masaArray[i] = new Masa(-1,null);
            }
            for(int i = 0; i < garsonArray.Length; i++)
            {
                garsonArray[i] = new Garson(i, true);
            }
            int musterisayisi_tmp = random.Next(6, 20);
            Console.WriteLine(musterisayisi_tmp);
            // Müşterileri Oluşturma
            for (int i = 0; i < musterisayisi_tmp; i++)
            {
                musteriList.Add(new Musteri(i,random.Next(5,90)));
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
