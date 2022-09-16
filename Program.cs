public class Program
{
    
    public static Info AllInfo(string Uni_Name, string Lib_Name, string Address, string Tel_Num, string Name, string Surname, string ID_Num, double Ft, double Pay){
        return new Info(Uni_Name, Lib_Name, Address, Tel_Num, Name, Surname, ID_Num, Ft, Pay);
    }
    
   
    static void UniversityInformation(Info info) {
        Console.WriteLine("*******************************");
        Console.WriteLine("{0}", info.Uni_Name);
        Console.WriteLine("{0} Library", info.Lib_Name);
        Console.WriteLine("Address : {0}", info.Address);
        Console.WriteLine("Telephone Number : {0}", info.Tel_Num);
        Console.WriteLine("*******************************");
    }

    static void UniversityRepresent(Info info) {
        Console.WriteLine("*******************************");
        Console.WriteLine("{0}", info.Uni_Name);
        Console.WriteLine("Name : Mr.{0} {1}", info.Name, info.Surname);
        Console.WriteLine("ID Number : {0}", info.ID_Num);
        Console.WriteLine("*******************************");
    }

    static void PayInfo(Info info) {
        Console.WriteLine("*******************************");
        Console.WriteLine("{0}", info.Uni_Name);
        Console.WriteLine("{0} Library", info.Lib_Name);
        Console.WriteLine("Electricity Usage (FT) : {0}", info.ID_Num);
        Console.WriteLine("PayRange : {0}", info.ID_Num);
        Console.WriteLine("*******************************");
    }

    public static void Main(string[] args) {
        Info Uni1 = new Info ("Chulalongkorn University", "Rak-Dee", "Pathumwan District, Krungtep Mahanakron", "02-215-3555", "Chaidee", "Rakdee","153-698-4561237", 79.6, 7911);
        Info Uni2 = new Info ("Mahidol University", "RakLok", "Salaya District, NakornPhatom", "02-849-6211", "Nondee", "Jaidee", "742-112-5687412", 70.7, 7725);
        Info Uni3 = new Info ("King Mongkut's Institude of Technology Ladkrabang", "GayGee", "Ladkrabang District, Krungtep Mahanakorn", "02-329-8000", "Aphaidee", "Reaindee", "541-772-3215689", 249, 25172);
        Info Uni4 = new Info ("Khon Kaen University", "Vaattana", "NaiMeong, Khonkaen", "043-002539", "Tumdee", "Ngaandee", "777-772-4578923", 30.2, 4369);
        Info Uni5 = new Info ("King Mongkut's University of Technology Thonburi", "Artorn", "Thungkuru District, Krungtep Mahanakorn", "02-470-8000", "Nondee", "Riapdee", "003-852-4752000", 208.9, 21470);

        UniversityInformation(Uni1);
        UniversityRepresent(Uni1);
        
}
public class Info{
    public string Uni_Name;
    public string Lib_Name;
    public string Address;
    public string Tel_Num;
    public string Name;
    public string Surname;
    public string ID_Num;
    public double Ft;
    public double Pay;
    public Info(string Uni_Name, string Lib_Name, string Address, string Tel_Num, string Name, string Surname, string ID_Num, double Ft, double Pay){
        this.Uni_Name = Uni_Name;
        this.Lib_Name = Lib_Name;
        this.Address = Address;
        this.Tel_Num = Tel_Num;
        this.Name = Name;
        this.Surname = Surname;
        this.ID_Num = ID_Num;
        this.Ft = Ft;
        this.Pay = Pay;
    }

    public string Bill() {
        return "Move Forward";
    }

    public string BillAll() {
        return "Move Backward";
    }
}
}