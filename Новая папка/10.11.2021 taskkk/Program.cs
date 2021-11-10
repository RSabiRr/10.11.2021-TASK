using System;

namespace _10._11._2021_taskkk
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choise = 255;
            DepartmentService departmentService = new DepartmentService();

            do
            {
                Console.WriteLine("Emeliyyati secin: ");
                Console.WriteLine();
                Console.WriteLine("1.Yaratmaq");
                Console.WriteLine("2.Deyismek");
                Console.WriteLine("3.Silmek");
                Console.WriteLine("4.Ekrana cixar");
                Console.WriteLine("0.Exit");
                Console.WriteLine();

                if (byte.TryParse(Console.ReadLine(), out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            Department newdepatment = new Department();
                            newdepatment.Id = departmentService.FindId();

                            Console.WriteLine("Adini daxil edin");
                            newdepatment.Name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Soyadini daxil edin:");
                            newdepatment.SurName = Convert.ToString(Console.ReadLine());
                            departmentService.Create(newdepatment);
                            Console.WriteLine("Elave bitmisdir");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Deyismek istediyiniz ID daxil edin: ");
                            foreach (var item in departmentService.Read())
                            {
                                Console.WriteLine($"Id: {item.Id}, Adi: {item.Name}, Soyadi: {item.SurName}");
                            }
                            int dpId = Convert.ToInt32(Console.ReadLine());

                            Department department = departmentService.Find(dpId);

                            Console.WriteLine($"Deyiseceyniz Adi daxil edin: {department.Name}:");
                            department.Name = Console.ReadLine();

                            Console.WriteLine($"Deyiseceyniz Soyadi daxil edin: {department.SurName}:");
                            department.SurName = Console.ReadLine();

                            departmentService.Update(dpId, department);

                            Console.WriteLine("Deyisdirildi!");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Silmek istediyiniz id secin: ");
                            Department[] departments2 = departmentService.Read();
                            for (int i = 0; i < departments2.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id: {departments2[i].Id},Ad: {departments2[i].Name},Soyad: {departments2[i].SurName} ");
                            }
                            int idfordelete = Convert.ToInt32(Console.ReadLine());
                            departmentService.Delete(idfordelete);
                            Console.WriteLine("Silindi! ");
                            Console.WriteLine();
                            break;
                        case 4:
                            Department[] departments = departmentService.Read();
                            for (int i = 0; i < departments.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id: {departments[i].Id},Ad: {departments[i].Name},Soyad: {departments[i].SurName} ");
                            }
                            Console.WriteLine();
                            break;
                        case 0:
                            Console.WriteLine("Emeliyyat bitdi!");
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Emeliyyat yoxdur!");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Emeliyyat yoxdur!");
                    Console.WriteLine();
                    choise = 255;
                }
            } while (choise != 0); 
        }
    }
}
