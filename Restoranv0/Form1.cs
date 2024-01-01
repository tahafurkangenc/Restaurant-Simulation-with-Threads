using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoranv0
{
    public partial class Form1 : Form
    {
        static object locker = new object();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteriDataGridView.ColumnCount = 2;
            musteriDataGridView.Columns[0].Name = "Müşteri ID";
            musteriDataGridView.Columns[1].Name = "Müşteri Yaş";

            masalarDataGridView.ColumnCount = 3;
            masalarDataGridView.Columns[0].Name = "Masa ID";
            masalarDataGridView.Columns[1].Name = "Müşteri ID";
            masalarDataGridView.Columns[2].Name = "Müşteri Yaş";

            garsonlarDataGridView.ColumnCount = 3;
            garsonlarDataGridView.Columns[0].Name = "Garson ID";
            garsonlarDataGridView.Columns[1].Name = "Masa ID";
            garsonlarDataGridView.Columns[2].Name = "Müşteri ID";

            asciDataGridView.ColumnCount = 3;
            asciDataGridView.Columns[0].Name = "Asçı ID";
            asciDataGridView.Columns[1].Name = "Müşteri ID";
            asciDataGridView.Columns[2].Name = "Sipariş Durumu";

            kasaDataGridView.ColumnCount = 2;
            kasaDataGridView.Columns[0].Name = "Müşteri ID";
            kasaDataGridView.Columns[1].Name = "Ödeme Durumu";
        }

        private void btn_masayamusterial_Click(object sender, EventArgs e)
        {
            Thread masayamusterial_thread = new Thread(masayamusterial_Thread);
            masayamusterial_thread.Start();
            //Console.WriteLine("Program.masaArray[0].masa_musteri.musteri_ID =" + Program.masaArray[0].masa_musteri.musteri_ID);
            //Console.WriteLine("Program.masaArray[0].masa_numara =" + Program.masaArray[0].masa_numara);
            
        }

        public void masayamusterial_Thread()
        {
            List<Musteri> eklenecekmusteriler_list = new List<Musteri>();
            int musterisayisi_tmp = Program.random.Next(1, 10);
            Console.WriteLine(musterisayisi_tmp);
            // Müşterileri Oluşturma
            for (int i = 0; i < musterisayisi_tmp; i++)
            {
                lock (locker)
                {
                    Musteri ekle_musteri = new Musteri(Program.musteriList.Count, Program.random.Next(5, 90));
                    eklenecekmusteriler_list.Add(ekle_musteri);
                    Program.musteriList.Add(ekle_musteri);
                }

            }
            for (int i = 0; i < eklenecekmusteriler_list.Count; i++)
            {
                eklenecekmusteriler_list[i].musteri_thread = new Thread(eklenecekmusteriler_list[i].masalaraMusteriAl);
                eklenecekmusteriler_list[i].musteri_thread.Name = "Musteri Thread - " + eklenecekmusteriler_list[i].musteri_ID;
                eklenecekmusteriler_list[i].musteri_thread.Priority = ThreadPriority.Normal;
                if (eklenecekmusteriler_list[i].musteri_yas >= 65)
                {
                    eklenecekmusteriler_list[i].musteri_thread.Priority = ThreadPriority.Highest;
                    eklenecekmusteriler_list[i].musteri_thread.Start();
                    eklenecekmusteriler_list[i].musteri_thread.Join();
                }
            }
            for (int i = 0; i < eklenecekmusteriler_list.Count; i++)
            {
                if (eklenecekmusteriler_list[i].musteri_yas < 65)
                {
                    //eklenecekmusteriler_list[i].musteri_thread.Priority = ThreadPriority.Highest;
                    eklenecekmusteriler_list[i].musteri_thread.Start();
                    eklenecekmusteriler_list[i].musteri_thread.Join();
                }
            }
        }

        private void yenilebutton_Click(object sender, EventArgs e)
        {
            yenileMethod();
        }

        public void yenileMethod()
        {
            lbl_kasabakiye.Text = "Kasa : " + Program.kasa.kasa_para + " TL";
            musteriDataGridView.Rows.Clear();
            for (int i = 0; i < Program.musteriList.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(musteriDataGridView);
                row.Cells[0].Value = Program.musteriList[i].musteri_ID;
                row.Cells[1].Value = Program.musteriList[i].musteri_yas;
                //Console.WriteLine(Program.musteriList[i].musteri_ID + " " + Program.musteriList[i].musteri_yas);
                musteriDataGridView.Rows.Add(row);
            }
            masalarDataGridView.Rows.Clear();
            for (int i = 0; i < Program.masaArray.Length; i++)
            {
                //if (Program.masaArrayEquals(null))
                //{
                //    Console.WriteLine("BREAKING");
                //    break;
                //}
                if (Program.masaArray[i].masa_musteri != null)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(masalarDataGridView);
                    row.Cells[0].Value = i;
                    row.Cells[1].Value = Program.masaArray[i].masa_musteri.musteri_ID;
                    row.Cells[2].Value = Program.masaArray[i].masa_musteri.musteri_yas;
                    masalarDataGridView.Rows.Add(row);
                }
            }
            garsonlarDataGridView.Rows.Clear();
            for (int i = 0; i < Program.garsonArray.Length; i++)
            {
                if (Program.garsonArray[i].garson_masa != null)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(garsonlarDataGridView);
                    row.Cells[0].Value = Program.garsonArray[i].garson_numara;
                    if (Program.garsonArray[i].garson_masa.masa_numara == -1)
                    {
                        row.Cells[1].Value = "BOŞ";
                        row.Cells[2].Value = "YOK";
                    }
                    else
                    {
                        row.Cells[1].Value = Program.garsonArray[i].garson_masa.masa_numara;
                        row.Cells[2].Value = Program.garsonArray[i].garson_masa.masa_musteri.musteri_ID;
                    }
                    garsonlarDataGridView.Rows.Add(row);
                }
            }
            asciDataGridView.Rows.Clear();
            for(int j=0;j<Program.asciArray.Length;j++)
            {
                
                for (int i = 0; i < Program.asciArray[j].musteri_siparisiletildi.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(asciDataGridView);
                    row.Cells[0].Value = Program.asciArray[j].asci_numara;
                    row.Cells[1].Value = Program.asciArray[j].musteri_siparisiletildi[i].musteri_ID;
                    row.Cells[2].Value = "Sipariş İletildi";
                    asciDataGridView.Rows.Add(row);
                }
                for (int i = 0; i < Program.asciArray[j].musteri_hazirlaniyor.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(asciDataGridView);
                    row.Cells[0].Value = Program.asciArray[j].asci_numara;
                    row.Cells[1].Value = Program.asciArray[j].musteri_hazirlaniyor[i].musteri_ID;
                    row.Cells[2].Value = "Hazırlanıyor";
                    asciDataGridView.Rows.Add(row);
                }
                for (int i = 0; i < Program.asciArray[j].musteri_hazirlandi.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(asciDataGridView);
                    row.Cells[0].Value = Program.asciArray[j].asci_numara;
                    row.Cells[1].Value = Program.asciArray[j].musteri_hazirlandi[i].musteri_ID;
                    row.Cells[2].Value = "Sipariş Hazır";
                    asciDataGridView.Rows.Add(row);
                }
            }
            
            kasaDataGridView.Rows.Clear();
            for (int i = 0; i < Program.kasa.kasa_odemeyapacakmusteriler.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(kasaDataGridView);
                row.Cells[0].Value = Program.kasa.kasa_odemeyapacakmusteriler[i].musteri_ID;
                row.Cells[1].Value = "Ödeme Yapacak";

                kasaDataGridView.Rows.Add(row);
            }
            for (int i = 0; i < Program.kasa.kasa_odemeyapmismusteriler.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(kasaDataGridView);
                row.Cells[0].Value = Program.kasa.kasa_odemeyapmismusteriler[i].musteri_ID;
                row.Cells[1].Value = "Ödeme Yaptı";
                kasaDataGridView.Rows.Add(row);
            }
        }

        private void btn_problem2_Click(object sender, EventArgs e)
        {
            int siradakimusterisayisi = int.Parse(musteriSayisiTextBox.Text.Trim());
            if (siradakimusterisayisi <= 100)
            {
                Console.WriteLine(siradakimusterisayisi);
                int maxkazanc = 0;
                int maxkazanc_masasayisi = siradakimusterisayisi;
                int maxkazanc_garsonsayisi = siradakimusterisayisi;
                int maxkazanc_ascisayisi = siradakimusterisayisi;
                for (int masasayisi = 1; masasayisi < siradakimusterisayisi; masasayisi++)
                {
                    for (int garsonsayisi = 1; garsonsayisi < siradakimusterisayisi; garsonsayisi++)
                    {
                        for (int ascisayisi = 1; ascisayisi < siradakimusterisayisi; ascisayisi++)
                        {
                            int eldeedilenkazanc = pb2_kazanchesapla(siradakimusterisayisi, masasayisi, garsonsayisi, ascisayisi);
                            if (eldeedilenkazanc > maxkazanc)
                            {
                                maxkazanc = eldeedilenkazanc;
                                maxkazanc_ascisayisi = ascisayisi;
                                maxkazanc_garsonsayisi = garsonsayisi;
                                maxkazanc_masasayisi = masasayisi;
                            }
                        }
                    }
                }
                Console.WriteLine("MAX KAZANC IHTİMALİ");
                Console.WriteLine("MUSTERİ SAYİSİ :" + siradakimusterisayisi);
                Console.WriteLine("KAZANC :" + maxkazanc);
                Console.WriteLine("MASA SAYISI :" + maxkazanc_masasayisi);
                Console.WriteLine("GARSON SAYISI :" + maxkazanc_garsonsayisi);
                Console.WriteLine("ASCI SAYISI :" + maxkazanc_ascisayisi);

                lbl_kazanc.Text = "Kazanç : " + maxkazanc;
                lbl_masasayisi.Text = "Masa Sayısı : " + maxkazanc_masasayisi;
                lbl_garsonsayisi.Text = "Garson Sayısı : " + maxkazanc_garsonsayisi;
                lbl_ascisayisi.Text = "Aşçı Sayısı : " + maxkazanc_ascisayisi;
            }
            
        }

        public int pb2_kazanchesapla (int siradakimusterisayisi, int masasayisi , int garsonsayisi , int ascisayisi)
        {
            Masa_pb2[] masa_pb2 = new Masa_pb2[masasayisi];
            for (int i = 0; i < masa_pb2.Length; i++)
            {
                masa_pb2[i] = new Masa_pb2(0, false, false, false);
            }
            int[] garson = new int[garsonsayisi];
            for (int i = 0; i < garson.Length; i++)
            {
                garson[i] = 0;
            }
            int[] asci = new int[ascisayisi];
            for (int i = 0; i < asci.Length; i++)
            {
                asci[i] = 0;
            }
            int kasa = 0;
            int toplammusterisayisi = 0;
            for (int toplamsure = 0; toplamsure < 20; toplamsure++) // toplam 20 saniye araştıracağız
            {
              //  Console.WriteLine("\n\n" + toplamsure + ". SECOND");
                for (int i = 0; i < masa_pb2.Length; i++) // tüm masaları dönüyoruz
                {
                    if (masa_pb2[i].masatoplamsure <= toplamsure) // eğer masanın durumu müsait ise (ek bir kontrol)
                    {
                        if (masa_pb2[i].siparisaldimi == false && masa_pb2[i].masatoplamsure <= toplamsure) // masa sipariş almamış
                        {
                            for (int j = 0; j < garson.Length; j++) // tüm garsonlara bakıyoruz
                            {
                                if (garson[j] <= toplamsure) // eğer garson müsait ise
                                {
                                    toplammusterisayisi++;
                                    //Console.WriteLine(i + " numarali masaya " + j + " numarali garson atandi \n Toplam müşteri : " + toplammusterisayisi);
                                    garson[j] = toplamsure + 2; //2 saniye meşguliyet veriyoruz
                                    masa_pb2[i].masatoplamsure = toplamsure + 2; // masaya da aynı meşguliyeti veriyoruz
                                    //Console.WriteLine("Masa -)" + i + " süresi ->" + masa_pb2[i].masatoplamsure);
                                    masa_pb2[i].siparisaldimi = true;
                                    break;
                                }
                            }
                        }
                        if (masa_pb2[i].siparisaldimi == true && masa_pb2[i].yemekyapildimi == false && masa_pb2[i].masatoplamsure <= toplamsure) // masa yemeğini almamışsa
                        {
                            for (int j = 0; j < asci.Length; j++) // tüm garsonlara bakıyoruz
                            {
                                if (asci[j] <= toplamsure) // eğer garson müsait ise
                                {
                                  //  Console.WriteLine(i + " numarali masaya " + j + " numarali asci atandi");
                                    asci[j] = toplamsure + 3; //3 saniye meşguliyet veriyoruz
                                    masa_pb2[i].masatoplamsure = toplamsure + 6; // asci ile beraber 6 saniyelik süre veriyoruz
                                   // Console.WriteLine("Masa -)" + i + " süresi ->" + masa_pb2[i].masatoplamsure);
                                    masa_pb2[i].yemekyapildimi = true;
                                    break;
                                }
                            }
                        }
                        if (masa_pb2[i].siparisaldimi == true && masa_pb2[i].yemekyapildimi == true && masa_pb2[i].odendimi == false && masa_pb2[i].masatoplamsure <= toplamsure) // masa yemeğini almamışsa
                        {
                            if (kasa <= toplamsure) // eğer kasa müsait ise
                            {
                                //Console.WriteLine(i + " numarali masa odemeye gitti ");
                                kasa = toplamsure + 1; // bir saniye meşguliyet veriyoruz
                                masa_pb2[i].masatoplamsure = toplamsure + 1; // masaya da aynı süreyi veriyoruz
                               // Console.WriteLine("Masa -)" + i + " süresi ->" + masa_pb2[i].masatoplamsure);
                                masa_pb2[i].odendimi = true;

                            }
                        }
                        if (masa_pb2[i].siparisaldimi == true && masa_pb2[i].yemekyapildimi == true && masa_pb2[i].odendimi == true) // masa yemeğini almamışsa
                        {
                            masa_pb2[i].siparisaldimi = false;
                            masa_pb2[i].yemekyapildimi = false;
                            masa_pb2[i].odendimi = false;
                           // Console.WriteLine(i + " numarali masadaki musteri gitti");
                            //masa_pb2[i].masatoplamsure = toplamsure;
                        }
                    }
                }
            }
            //Console.WriteLine("Toplam müşteri : " + toplammusterisayisi);
            //Console.WriteLine("Toplam Kazanc:" + (toplammusterisayisi - (masa_pb2.Length + garson.Length + (asci.Length / 2))));

            if (siradakimusterisayisi >= toplammusterisayisi)
            {
                //Console.WriteLine("Toplam Kazanc (masa:" + masa_pb2.Length + ",garson:" + garson.Length + ",asci:" + asci.Length + ") RETURN:" + (toplammusterisayisi - (masa_pb2.Length + garson.Length + (asci.Length / 2))));
                return toplammusterisayisi - (masa_pb2.Length + garson.Length + (asci.Length / 2));
            }
            else
            {
                //Console.WriteLine("Toplam Kazanc (masa:"+masa_pb2.Length+",garson:"+garson.Length+",asci:"+asci.Length+") RETURN:" + (siradakimusterisayisi - (masa_pb2.Length + garson.Length + (asci.Length / 2))));
                return siradakimusterisayisi - (masa_pb2.Length + garson.Length + (asci.Length / 2));
            }
        }

        private void btn_problem2_sureli_Click(object sender, EventArgs e)
        {
            int siradakimusterisayisi = int.Parse(simulasyonSuresiTextBox.Text.Trim())*60/ int.Parse(musteriPeriyoduTextBox.Text.Trim());
            if (siradakimusterisayisi <= 100)
            {
                Console.WriteLine(siradakimusterisayisi);
                int maxkazanc = 0;
                int maxkazanc_masasayisi = siradakimusterisayisi;
                int maxkazanc_garsonsayisi = siradakimusterisayisi;
                int maxkazanc_ascisayisi = siradakimusterisayisi;
                for (int masasayisi = 1; masasayisi < siradakimusterisayisi; masasayisi++)
                {
                    for (int garsonsayisi = 1; garsonsayisi < siradakimusterisayisi; garsonsayisi++)
                    {
                        for (int ascisayisi = 1; ascisayisi < siradakimusterisayisi; ascisayisi++)
                        {
                            int eldeedilenkazanc = pb2_kazanchesapla(siradakimusterisayisi, masasayisi, garsonsayisi, ascisayisi);
                            if (eldeedilenkazanc > maxkazanc)
                            {
                                maxkazanc = eldeedilenkazanc;
                                maxkazanc_ascisayisi = ascisayisi;
                                maxkazanc_garsonsayisi = garsonsayisi;
                                maxkazanc_masasayisi = masasayisi;
                            }
                        }
                    }
                }
                Console.WriteLine("MAX KAZANC IHTİMALİ");
                Console.WriteLine("MUSTERİ SAYİSİ :" + siradakimusterisayisi);
                Console.WriteLine("KAZANC :" + maxkazanc);
                Console.WriteLine("MASA SAYISI :" + maxkazanc_masasayisi);
                Console.WriteLine("GARSON SAYISI :" + maxkazanc_garsonsayisi);
                Console.WriteLine("ASCI SAYISI :" + maxkazanc_ascisayisi);

                lbl_kazanc.Text = "Kazanç : " + maxkazanc;
                lbl_masasayisi.Text = "Masa Sayısı : " + maxkazanc_masasayisi;
                lbl_garsonsayisi.Text = "Garson Sayısı : " + maxkazanc_garsonsayisi;
                lbl_ascisayisi.Text = "Aşçı Sayısı : " + maxkazanc_ascisayisi;
            }
            
        }

    }

    public class Masa_pb2
    {
        public int masatoplamsure;
        public Boolean siparisaldimi;
        public Boolean yemekyapildimi;
        public Boolean odendimi;

        public Masa_pb2() 
        {
            this.masatoplamsure = 0;
            this.siparisaldimi = false;
            this.yemekyapildimi = false;
            this.odendimi = false;
        }

        public Masa_pb2(int masatoplamsure, bool siparisaldimi, bool yemekyapildimi, bool odendimi)
        {
            this.masatoplamsure = masatoplamsure;
            this.siparisaldimi = siparisaldimi;
            this.yemekyapildimi = yemekyapildimi;
            this.odendimi = odendimi;
        }
    }
}