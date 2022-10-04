using System;
class HelloWorld {
  static void Method1(int n, int [] num){
      Random rand = new Random ();
      for (int i = 0; i<n; i++){
          num[i] = rand.Next(10,51);
      }
  }
  static int Method2(int[] num, int n){
      int sum = 0;
      for (int i=0; i<n; i++){
          sum = sum +num[i];
      }
      return sum;
  }
  
  static void Main() {
    Console.WriteLine("Enter an integer between 5-15: ");
    
    try{
        int x = Convert.ToInt32(Console.ReadLine());
        if ((x>=5) && (x<=15)){
            int[] numbers = new int[x];
            Method1(x, numbers);
            
            Console.WriteLine("The random array is: ");
            for(int i=0; i<x; i++){
                Console.WriteLine(numbers[i]);
            }
            int sum = Method2(numbers, x);
            Console.WriteLine("The sum is: " + sum);
        }
        else{
            Console.WriteLine("You must enter an integer between 5-15.");
            Console.WriteLine("Exit the program and try again.");
            Console.ReadKey(true);
        }
    }
    catch{
        Console.WriteLine("You must enter an integer value between 5-15");
        Console.WriteLine("Exit the program and try again.");
        Console.ReadKey(true);
    }
  }
  
}
