using System.IO;
using film;
//ALIPMJ....علی پیر محمد جماعت   پیشرفته1
//نمرات 100 دانشجو تمرین 7



string Path = "C:\\Users\\Acer\\Desktop\\c# tamrin\\tamrin\\asli\\asli\\Students.txt";
string[] Lines = File.ReadAllLines(Path);


//آرایه دانشجو ها
Student[] students = new Student[100];
for (int i = 0; i < students.Length; i++)
{
    string[] line = Lines[i].Split(",");
    Student Student = new Student();
    Student.Name = line[0]; Student.Lastname = line[1]; Student.pishraftre2 = Int32.Parse(line[2]);
    Student.pishrafte1 = Int32.Parse(line[3]); Student.algoritm = Int32.Parse(line[4]); Student.sheygerayi = Int32.Parse(line[5]);
    Student.riazi = Int32.Parse(line[6]); Student.kargah = Int32.Parse(line[7]);
    Student.tarbiat = Int32.Parse(line[8]); Student.tafsir = Int32.Parse(line[9]);
    Student.system = Int32.Parse(line[9]); Student.zaban = Int32.Parse(line[11]);
    students[i] = Student;
}


bool natije = false;
do
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Green;
    Console.Clear();
    Console.WriteLine("=>Hello every one<=");
    Console.WriteLine("==============================================================================");
    Console.WriteLine("=>DOROS:\nPishrafte1***      Algoritm**     Riazi*\nPishrafte2***      System**       Kargah*\nSheygrarayi***                    Tafsir*\n                                  Zaban*\n                                  Tarbiat*\n");
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine("=>Tedad Daneshjo = 100\n------------------------------------------------------------------------------\nMENO:");
    //ALIPMJ....علی پیر محمد جماعت   پیشرفته1
    //Menu ToolBar
    Console.WriteLine("=>1:Namayesh Moadel kol" + "\n=>2:Namayesh Moadel Doros ***" + "\n=>3:Namayesh Moadel Doros **" + "\n=>4:Namayesh Moadel Doros *" +
      "\n=>5:Namayesh Har 4 Model Ba Tartib(Sort Bandi)" + "\n=>6:Namayesh Adad Aval Nomarat Daneshjo" + "\n=>7:Namayesh Bar Asas Grade" + "\n=>8:End<=");
    Byte Option = Convert.ToByte(Console.ReadLine());

    //گزینه ای که ما میزنیم
    switch (Option)
    {
        case 1:

            foreach (var student in students)
            {
                Console.WriteLine(student.MoadelKol());
            }
            break;
        case 2:
            foreach (var student in students)
            {
                Console.WriteLine(student.Moadel3Satare());
            }
            break;
        case 3:
            foreach (var student in students)
            {
                Console.WriteLine(student.Moadel2Setare());
            }
            break;
        case 4:
            foreach (var student in students)
            {
                Console.WriteLine(student.Moadel1Setare());
            }
            break;
        case 5:
            foreach (var student in students)
            {
                Console.WriteLine(student.MoadelKol() + "  , " + student.Moadel3SatareBedonName() + "  , " + $"\n{student.Moadel2SetareBedonName()}" + "  , " + student.Moadel1SetareBedonName());

                switch (student.MoadelKolBedonName())
                {
                    case double n when n > 17:
                        Console.WriteLine(" ,  Grade:   A");
                        break;
                    case double n when n > 15 && n <= 17:
                        Console.WriteLine(" ,  Grade:   B");
                        break;

                    case double n when n > 13 && n <= 15:
                        Console.WriteLine(" ,  Grade:   C");
                        break;
                    case double n when n > 10 && n <= 13:
                        Console.WriteLine(" ,  Grade:   D");
                        break;
                    case double n when n > 7 && n <= 10:
                        Console.WriteLine(" ,  Grade:   E");
                        break;
                    case double n when n > 3 && n <= 7:
                        Console.WriteLine(" ,  Grade:   F");
                        break;
                    case double n when n <= 3:
                        Console.WriteLine(" ,  Grade:   G");
                        break;




                }
            }
            break;
        case 6:
            {
                foreach (var student in students)
                {
                    int x = Convert.ToInt32(student.MoadelKolBedonName());
                    if (x < 2)
                        Console.WriteLine(student.Asami() + " moadel aval nist");
                    for (int i = 2; i <= x; i++)
                    {
                        if (x % i == 0) ;
                        Console.WriteLine(student.Asami() + " moadel aval nist");
                    }
                    Console.WriteLine(student.Asami() + ":  " + x);
                }
            }


            break;
        case 7:
            foreach (var student in students)
            {
                switch (student.MoadelKolBedonName())
                {
                    case double n when n > 17:
                        Console.WriteLine(student.Asami() + " Grade:  A");
                        break;
                    case double n when n > 15 && n <= 17:
                        Console.WriteLine(student.Asami() + " Grade:  B");
                        break;

                    case double n when n > 13 && n <= 15:
                        Console.WriteLine(student.Asami() + " Grade:  C");
                        break;
                    case double n when n > 10 && n <= 13:
                        Console.WriteLine(student.Asami() + " Grade:  D");
                        break;
                    case double n when n > 7 && n <= 10:
                        Console.WriteLine(student.Asami() + " Grade:  E");
                        break;
                    case double n when n > 3 && n <= 7:
                        Console.WriteLine(student.Asami() + " :  F");
                        break;
                    case double n when n <= 3:
                        Console.WriteLine(student.Asami() + " :  G");
                        break;

                }
            }

            break;
        case 8:
            Console.WriteLine("============\nMOVAFAQ BASHID\n============");
            break;
    }

    Console.WriteLine("\nEDAME MIDI?(y/n)");
    string Answer = Convert.ToString(Console.ReadLine());
    if (Answer == "y")
    { natije = true; }
    else { natije = false; }


} while (natije);

//ALIPMJ....علی پیر محمد جماعت   پیشرفته1
