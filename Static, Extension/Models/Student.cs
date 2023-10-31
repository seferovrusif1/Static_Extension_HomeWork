using Static__Extension.Checkers;
namespace Static__Extension.Models;
internal class Student
{
    private int _id;
    public int Id { get;}
    public string Fullname { get; set; }
    public string GroupNo {get; set;}
    public int Age { get; set; }
    public Student(string fulname,string groupname,int age)
    {
        _id++;
        Id = _id;
        Fullname = fulname;
        GroupNo = groupname;
        Age = age;
    }
    public override string ToString()
    {
        return $"Id:    {Id}\nFullName: {Fullname}\nGroupNo: {GroupNo}\nAge: {Age}";
    }
}

////ilk once set de check eledim ama program cs-de check etmek daha optimal olduqunu dusundum deye yoruma aldim bunlari
///
//private int _id;
//private string _fullName;
//private string _groupNo;
//public int Id { get; }
//public string Fullname
//{
//    get => _fullName;
//    set
//    {
//        if (value.CheckFullnamee())
//        {
//            _fullName = value;
//        }
//        else
//        {
//            Console.WriteLine("Tam adi yeniden daxil edin:");
//            Fullname = Console.ReadLine();
//        }
//    }
//}
//public string GroupNo
//{
//    get => _groupNo;
//    set
//    {
//        if (value.CheckGroupNoo())
//        {
//            _groupNo = value;
//        }
//        else
//        {
//            Console.WriteLine("Qrupu yeniden daxil edin:");
//            GroupNo = Console.ReadLine();
//        }
//    }
//}
//public int Age { get; set; }
//public Student(string fulname, string groupname, int age)
//{
//    _id++;
//    Id = _id;
//    Fullname = fulname;
//    GroupNo = groupname;
//    Age = age;
//}
//}