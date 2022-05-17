
Dosen dodef = new Dosen();
dodef.DosenPengampu();

Console.WriteLine();//space

Console.WriteLine("\t Dosen ");

Console.WriteLine();//space

Dosen dos1 = new Dosen();
Console.Write("Id\t\t: ");
dos1.Id = int.Parse(Console.ReadLine()); // sama kek convert.toint32
Console.Write("Nama Dosen\t: ");
dos1.Nama = Console.ReadLine();
Console.Write("NIK Dosen\t: ");
dos1.Nik = int.Parse(Console.ReadLine());
Console.Write("Gender\t\t: ");
dos1.Gender = Console.ReadLine();
Console.Write("Course\t\t: ");
dos1.Course = Console.ReadLine();
Console.ReadKey();

Console.Clear();
Console.WriteLine("\t Dosen ");
dodef.DosenPengampu();
Console.WriteLine();
dos1.Matkul();
Console.WriteLine();
dos1.InfoDosen();



