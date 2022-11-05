internal class Program
{
    private static void Main(string[] args)
    {
       
       try
       {
        Console.WriteLine("Bir sayı giriniz.");
        int sayı = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmiş olduğunuz sayı:"+ sayı);
       }
       catch(Exception ex)
       {
        Console.WriteLine("Hata:"+ ex.Message.ToString());  

       }
       finally
       {
        Console.WriteLine("İşlem tamamlandı.");
       }

       try
       {
        int a = int.Parse(null);
        int ab = int.Parse("test");
        //int ac = int.Parse(Console.ReadLine());
        //int ad = int.Parse(Console.ReadLine());     
       }
       catch (ArgumentNullException ex)
       {
        Console.WriteLine("Boş değer girdiniz.");
        Console.WriteLine(ex);
        
       }
       catch(FormatException ex)
       {
        Console.WriteLine("Veri tipi uygun değil.");
        Console.WriteLine(ex); 
       }
       catch(OverflowException ex)
       {
        Console.WriteLine("Çok büyük veya çok küçük değer girdiniz.");
        Console.WriteLine(ex); 
       }
       finally
       {
        Console.WriteLine("İşlem başarıyla tamamlandı.");
       }









        
    }
}