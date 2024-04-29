using System;

public class Mahasiswa
{
    public string Nama { get; set; }
    public string Nim { get; set; }
    public int year { get; set; }
    public  List<string> Course { get; set; }
    public Mahasiswa()
    {
    }
    public Mahasiswa(string Nama, string Nim,int year, List<string> Course)
    {
        this.Nama = Nama;
        this.Nim = Nim;
        this.year = year;
        this.Course=Course;
    }
}