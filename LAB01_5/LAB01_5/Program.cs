using System.Text;
using LAB01_5;

internal class Program
{
    public static List<Student> students = new List<Student>()
    {
        new Student() { studentId = "1", studentName = "Nguyen Van A", age = 20, phone = "0333912821", address = "Hà Nội" },
        new Student() { studentId = "2", studentName = "Nguyen Van B", age = 20, phone = "0333912822", address = "Phú Thọ" },
        new Student() { studentId = "3", studentName = "Nguyen Van C", age = 20, phone = "0333912823", address = "Thái Bình" },
        new Student() { studentId = "4", studentName = "Nguyen Van D", age = 20, phone = "0333912824", address = "Hưng Yên" },
        new Student() { studentId = "5", studentName = "Nguyen Van E", age = 20, phone = "0333912825", address = "Hà Nội" },
    };

    public static bool addStudent(Student student)
    {
        try
        {
            bool isExist = students.Any(x => x.studentId == student.studentId);
            if (isExist)
                throw new Exception("Sinh viên đã tồn tại!");
            students.Add(student);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }

    public static bool editStudent(Student student)
    {
        foreach (var item in students)
        {
            if (item.studentId == student.studentId)
            {
                item.studentName = student.studentName;
                item.age = student.age;
                item.address = student.address;
                item.phone = student.phone;
                return true;
            }
        }
        return false;
    }

    public static bool deleteStudent(Student student)
    {
        try
        {
            students.Remove(student);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static void getStudents()
    {
        Console.WriteLine("ID\tNAME\t\tAGE\tPHONE\t\tADDRESS");
        foreach (var item in students)
        {
            Console.WriteLine($"{item.studentId}\t{item.studentName}\t{item.age}\t{item.phone}\t{item.address}");
        }
    }

    public static void alert(bool isSuccess, string action)
    {
        string message = isSuccess ? $"{action} thành công!" : $"{action} thất bại!";
        Console.WriteLine(message);
        Console.WriteLine("Nhấn phím bất kỳ để tiếp tục...");
        Console.ReadKey();
    }

    public static void getMenu()
    {
        int n;
        do
        {
            Console.Clear();
            Console.WriteLine("------------------ Quản lý sinh viên ------------------\n");
            getStudents();
            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Sửa sinh viên");
            Console.WriteLine("3. Xoá sinh viên");
            Console.WriteLine("4. Thoát");

            do
            {
                Console.Write("\n- Mời bạn chọn chức năng: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 4);

            Console.Clear();

            switch (n)
            {
                case 1:
                    {
                        Student student = new Student();
                        Console.Write("- Nhập ID: ");
                        student.studentId = Console.ReadLine();
                        Console.Write("- Nhập họ tên: ");
                        student.studentName = Console.ReadLine();
                        Console.Write("- Nhập tuổi: ");
                        student.age = int.Parse(Console.ReadLine());
                        Console.Write("- Nhập địa chỉ: ");
                        student.address = Console.ReadLine();
                        Console.Write("- Nhập số điện thoại: ");
                        student.phone = Console.ReadLine();

                        alert(addStudent(student), "Thêm");
                    }
                    break;

                case 2:
                    {
                        Console.Write("- Nhập ID sinh viên cần sửa: ");
                        string id = Console.ReadLine();
                        Student student = students.FirstOrDefault(x => x.studentId == id);
                        if (student != null)
                        {
                            Console.Write("- Nhập họ tên: ");
                            student.studentName = Console.ReadLine();
                            Console.Write("- Nhập tuổi: ");
                            student.age = int.Parse(Console.ReadLine());
                            Console.Write("- Nhập địa chỉ: ");
                            student.address = Console.ReadLine();
                            Console.Write("- Nhập số điện thoại: ");
                            student.phone = Console.ReadLine();

                            alert(editStudent(student), "Sửa");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên.");
                            Console.ReadKey();
                        }
                    }
                    break;

                case 3:
                    {
                        Console.Write("- Nhập ID sinh viên cần xoá: ");
                        string id = Console.ReadLine();
                        Student student = students.FirstOrDefault(x => x.studentId == id);
                        alert(deleteStudent(student), "Xoá");
                    }
                    break;
            }

        } while (n != 4);
    }

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        getMenu();
    }
}
