using System; 

class URI {

    static void Main(string[] args) { 
        
  double raio = double.Parse( Console.ReadLine());
    double n = 3.14159;
    double area= n*(raio*raio);
    Console.WriteLine("A=" + area.ToString("F4"));

    }

}