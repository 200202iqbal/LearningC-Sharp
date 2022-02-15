using System;

namespace Mobil
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Mobil mobil1 = new Mobil("Ferari");
            mobil1.isiBensin(10);
            

            Console.WriteLine("Mobil 1 berisi bensin : " + mobil1.bensin);
        }
    }

    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;

        public Mobil(string nama)
        {
            this.nama = nama;
        }
        public void percepat()
        {
            this.kecepatan += 10;
            this.bensin -= 5;
        }
        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }
        public void isiBensin(double bensin)
        {
            this.bensin += bensin;
        }
    }
        
}
