namespace method_overloading;
class Program
{
    static void Main(string[] args)
    {
        //out parametre
        string sayi ="999";
        bool sonuc = int.TryParse(sayi,out int outSayi);
        if(sonuc){
            Console.WriteLine("Başarılı..!");
        }
        else
        {
            Console.WriteLine("Başarısız..!");
        }

        methods metot=new methods();
        metot.Topla(4,2,out int toplamsonuc);
        Console.WriteLine(toplamsonuc);

        // Metot Aşırı Yükleme - Overloading
        int ifade=999;
        metot.Yazdir(ifade.ToString());
        metot.Yazdir(ifade);
        metot.Yazdir("Metehan","Metinoğlu");
    }
}

class methods
{
    public void Topla(int a,int b,out int toplam){
        toplam=a+b;
    }
    public void Yazdir(string value){
        Console.WriteLine(value);
    }
    public void Yazdir(int value){
        Console.WriteLine(value);
    }
    public void Yazdir(string value,string value2){
        Console.WriteLine(value+value2);
    }
}
