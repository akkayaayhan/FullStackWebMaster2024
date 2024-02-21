namespace full_stack_web_lesson2;

class Program
{
    static void Main(string[] args)
    {
        /* byte skor1,skor2;
        skor1=4;
        skor2=4;

        if(skor1>skor2){

            Console.WriteLine("Skor1 Skor2 den büyüktür");
        }
        if(skor1<skor2){

            Console.WriteLine("Skor1 Skor2 den küçüktür");

        }
        if(skor1==skor2){
             Console.WriteLine("Skor1 Skor2 ye eşittir");
        } */

        //******************************************************

       /*  Console.Write("Kullanıcı adını giriniz:");
        string kullaniciAdi=Console.ReadLine();
        if(kullaniciAdi=="ayhan"){
            Console.WriteLine("Sisteme Hoşgeldin ayhan");
        }
        else{
            Console.WriteLine("Yanlış kullanıcı");
        } */

        //********************************************************

        Console.Write("Öğrencinin ortalamasını giriniz:");
        int ortalama=Convert.ToInt16(Console.ReadLine());

        if(ortalama<50){
            Console.WriteLine("Sınıfta kaldı");
        }

        else if(ortalama<70){
            Console.WriteLine("Geçti ama belge alamadı");
        }

        else if(ortalama<85){
            Console.WriteLine("Teşekkür belgesi aldı");
        }
        else if(ortalama<=100){
            Console.WriteLine("Takdir belgesi aldı");
        }

        else{
            Console.WriteLine("0--100 aralığında bir sayı giriniz");
        }


    }
}
