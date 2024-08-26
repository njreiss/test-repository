// See https://aka.ms/new-console-template for more information
public class Program {
  public static void Main(string[] args) {
    testProgram test = new testProgram();

    // test.sayHello("poop");
    Console.WriteLine($"Hello {test.getName()}");
    test.setName("Julia");
    Console.WriteLine($"Hello {test.getName()}");
  }
}