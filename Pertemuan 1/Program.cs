
using System;

PBO.Person person1 = new PBO.Person();
person1.Nama = "Naziel Ilham";
person1.JenisKelamin = "Laki-Laki";
person1.Profesi = "Penyanyi";
person1.TanggalLahir = "16 Sep 1981";
person1.JumlahKendaraan = 3;

PBO.Person person2 = new PBO.Person();
person2.Nama = "Chelsea Islan";
person2.JenisKelamin = "Perempuan";
person2.Profesi = "Aktris Film";
person2.TanggalLahir = "2 Juni 1995";
person2.JumlahKendaraan = 1;

PBO.Person person3 = new PBO.Person();
person3.Nama = "Iqbaal Ramadhan";
person3.JenisKelamin = "Laki-Laki";
person3.Profesi = "Aktor Film";
person3.TanggalLahir = "28 Des 1999";
person3.JumlahKendaraan = 2;

Console.WriteLine("Nama : " + person1.Nama);
Console.WriteLine("Jenis Kelamin : " + person1.JenisKelamin);
Console.WriteLine("Profesi : " + person1.Profesi);
Console.WriteLine("Tanggal Lahir : " + person1.TanggalLahir);
Console.WriteLine("Jumlah Kendaraan : " + person1.JumlahKendaraan);
Console.WriteLine("ini adalah tes git");

namespace PBO
{
    class Person
    {
        public string Nama;
        public string JenisKelamin;
        public string Profesi;
        public string TanggalLahir;
        public int JumlahKendaraan;
    }
}
