using System;

public class Program 
{
  public static void Main() 
  {
    string numero = Console.ReadLine();
    if(numero.Contains("13")){
      Console.WriteLine($"{numero} es de Mala Suerte);
    }
    else{
      Console.WriteLine($"{numero} NO es de Mala Suerte);
      
      
    }
    
  }
}