using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Nama: Bib Nugraha Kasmara
//NPM: 207064516086
namespace UAS_ALGOPEM
{
    class gapok
    {
        public double bonusgapok = 0, bonusgapok1 = 0;
    }

    class jumlah
    {
        public double bonus(double a, double b)//Output dan Menghitung Jumlah Bonus
        {
            Console.WriteLine("|    Jumlah Bonus        : Rp {2} ", a, b, (a + b));
            return a + b;
        }
        public double gaji(double c, double d, double e)//Output dan Menghitung Total Gaji
        {
            Console.WriteLine("|    Total Gaji          : Rp {3} ", c, d, e, (c + d + e));
            return c + d + e;
        }
    }

    class keterangan
    {
        public double bog(double bo, double g)
        {
            Console.WriteLine("Anda mendapat Bonus Gaji sebesar Rp {0} karena telah bekerja selama {1} Tahun", bo, g);
            return bo;
        }
        public double thr(double th, double r)
        {
            Console.WriteLine("Anda mendapat THR sebesar Rp {0} karena telah bekerja selama {1} Tahun", th, r);
            return th;
        }
    }
    
    class Array
    {
        public string[] ketik = new string[3] { "Nama", "NIP", "Jabatan" };//array

    }
    class Program
    {
        static void Main(string[] args)
        {
            gapok bonus = new gapok();
            jumlah x = new jumlah();
            Array a = new Array();
            keterangan bo = new keterangan();


            //string[] ketik = new string[3] { "Nama", "NIP", "Jabatan" }; // Array

            string yesno;
            bool yes = false;
            double LamaKerja = 0, totalgaji = 0, THR = 0, THR1 = 0, gajipokok = 0;

        start:
            //Input Nama
            Console.Write("Masukkan Nama = ");
            a.ketik[0] = Convert.ToString(Console.ReadLine());
            //Input NIP
            Console.Write("Masukkan NIP = ");
            a.ketik[1] = Convert.ToString(Console.ReadLine());
            //Input Jabatan
            Console.Write("Masukkan Jabatan = ");
            a.ketik[2] = Convert.ToString(Console.ReadLine());

            //Menentukan Gaji Pokok
            if (a.ketik[2] == "Pimpinan" || a.ketik[2] == "pimpinan")
            {
                gajipokok = 18000000;
            }
            else if (a.ketik[2] == "Manajer" || a.ketik[2] == "manajer")
            {
                gajipokok = 12000000;
            }
            else if (a.ketik[2] == "Supervisor" || a.ketik[2] == "supervisor")
            {
                gajipokok = 9000000;
            }
            else if (a.ketik[2] == "Staff" || a.ketik[2] == "staff")
            {
                gajipokok = 5000000;
            }

            //Input Lama Kerja
            Console.Write("Masukkan Lama Kerja = ");
            LamaKerja = int.Parse(Console.ReadLine());
            Console.Clear();

            //Menghitung Bonus Gaji Pokok Awal
            if (LamaKerja <= 2)
            {
                bonus.bonusgapok = gajipokok * 1;
            }
            else if (LamaKerja > 10)
            {
                bonus.bonusgapok = gajipokok * 2;
            }
            else
            {
                bonus.bonusgapok = gajipokok * 1.5;
            }

            //Menghitung Bonus Gaji Pokok Akhir
            if (LamaKerja <= 2 || LamaKerja > 5 || LamaKerja > 10)
            {
                bonus.bonusgapok1 = bonus.bonusgapok - gajipokok;
            }
       
            //Menghitung Jumlah THR Awal
            if (LamaKerja <= 5)
            {
                THR = gajipokok + 500000;
            }
            else if (LamaKerja > 10)
            {
                THR = gajipokok + 2000000;
            }
            else
            {
                THR = gajipokok + 1000000;
            }

            // Menghitung Jumlah THR Akhir
            if (LamaKerja <= 5 || LamaKerja > 5 || LamaKerja > 10)
            {
                THR1 = THR - gajipokok;
            }
            
            //jumlahbonus = THR1 + bonus.bonusgapok1;

            //totalgaji = gajipokok + bonus.bonusgapok1 + THR1;

            //Output
            Console.WriteLine("Nama = " + a.ketik[0]);
            Console.WriteLine("NIP = " + a.ketik[1]);
            Console.WriteLine("Jabatan = " + a.ketik[2]);
            Console.WriteLine("Lama Kerja = " + LamaKerja);
            Console.WriteLine("THR = " + THR1);
            Console.WriteLine("");
            Console.WriteLine("Keterangan = ");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|    Gaji Pokok Anda     : Rp " + gajipokok, "            |");
            Console.WriteLine("|    Bonus Gaji Pokok    : Rp " + bonus.bonusgapok1, "    |");
            Console.WriteLine("|    THR                 : Rp " + THR1, "                 |");
            x.gaji(gajipokok, bonus.bonusgapok1, THR1);
            Console.WriteLine("-----------------------------------------------------------");
            x.bonus(THR1, bonus.bonusgapok1);
            Console.WriteLine("-----------------------------------------------------------");
            bo.bog(bonus.bonusgapok1, LamaKerja);
            bo.thr(THR1, LamaKerja);
            Console.WriteLine("");

            
            //Loop
            while (!yes)
            {
                Console.Write("Apakah anda ingin mengulangnya lagi? [Y/N] : ");
                yesno = Console.ReadLine();

                if (yesno == "Y" || yesno == "y")
                {
                    Console.Clear();
                    goto start;
                }
                else if (yesno == "N" || yesno == "n")
                {
                    break;
                }
            }
        }

    }
}