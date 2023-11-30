//Nicolas Espel
using System;

class Program {
  public static void Main (string[] args) {
    int sum = 0;
    Console.WriteLine("Please enter a positive integer to see if it's perfect: ");
    int number = Convert.ToInt16(Console.ReadLine());

    for (int i = 1; i < number; i++) {
      if (number % i == 0) {
        sum += i;
      }
    }
    if (sum == number) {
      Console.WriteLine("Perfect Number");
    } else {
      Console.WriteLine("Not A Perfect Number");
    }
  }
}