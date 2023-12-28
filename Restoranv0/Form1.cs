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
            int musterisayisi_tmp = Program.random.Next(6, 20);
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
                }
            }
            for (int i = 0; i < eklenecekmusteriler_list.Count; i++)
            {
                eklenecekmusteriler_list[i].musteri_thread.Start();
                eklenecekmusteriler_list[i].musteri_thread.Join();
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
    }
}