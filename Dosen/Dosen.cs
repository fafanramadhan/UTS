internal class Dosen
{
    public int Id { get; set; }
    public string Nama { get; set; }
    public int Nik { get; set; }
    public string Gender { get; set; }
    public string Course { get; set; }
    public string OtCourse { get; set; }


    //method
    public void DosenPengampu() 
    {
        Console.WriteLine("Nama Dosen   : Kamarudin, M.Kom");
        Console.WriteLine("Mata Kuliah  :Pemrograman");        
    }

    public void InfoDosen()
    {
        Console.WriteLine("ID Dosen\t: {0}", Id);
        Console.WriteLine("Nama Dosen\t: {0}", Nama);
        Console.WriteLine("Nik\t\t: {0}", Nik);
        Console.WriteLine("Gender\t\t: {0}", Gender);        
        Console.WriteLine("Mata kuliah\t: {0}", Course + "," + OtCourse);
    }
    
    public void Matkul()
    {
        
        Console.WriteLine("Mata kuliah Lain: ");
       OtCourse = Console.ReadLine();
    }
}