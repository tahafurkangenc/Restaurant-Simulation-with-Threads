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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteriDataGridView.ColumnCount = 2;
            musteriDataGridView.Columns[0].Name = "Müşteri ID";
            musteriDataGridView.Columns[1].Name = "Müşteri Yaş";
            for (int i = 0; i < Program.musteriList.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(musteriDataGridView);
                row.Cells[0].Value = Program.musteriList[i].musteri_ID;
                row.Cells[1].Value = Program.musteriList[i].musteri_yas;
                Console.WriteLine(Program.musteriList[i].musteri_ID + " " + Program.musteriList[i].musteri_yas);
                musteriDataGridView.Rows.Add(row);
            }
        }

        private void btn_masayamusterial_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.musteriList.Count; i++)
            {
                Program.musteriList[i].musteri_thread = new Thread(Program.musteriList[i].masalaraMusteriAl);
                Program.musteriList[i].musteri_thread.Name = "Musteri Thread - " + i;
                Program.musteriList[i].musteri_thread.Priority = ThreadPriority.Normal;
                if (Program.musteriList[i].musteri_yas >= 65)
                {
                    Program.musteriList[i].musteri_thread.Priority = ThreadPriority.Highest;
                }
            }
            for (int i = 0; i < Program.musteriList.Count; i++)
            {
                Program.musteriList[i].musteri_thread.Start();
                Program.musteriList[i].musteri_thread.Join();
            }
            masalarDataGridView.ColumnCount = 3;
            masalarDataGridView.Columns[0].Name = "Masa ID";
            masalarDataGridView.Columns[1].Name = "Müşteri ID";
            masalarDataGridView.Columns[2].Name = "Müşteri Yaş";
            //Console.WriteLine("Program.masaArray[0].masa_musteri.musteri_ID =" + Program.masaArray[0].masa_musteri.musteri_ID);
            //Console.WriteLine("Program.masaArray[0].masa_numara =" + Program.masaArray[0].masa_numara);
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
        }
    }
}