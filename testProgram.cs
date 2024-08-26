public class testProgram {
  private string name = "John";
  public void setName(string newName) {
    name = newName;
  }
  public string getName() {
    return name;
  }

  public void sayHello() {
    Console.WriteLine("Hello Mike!");
  }
  public void sayHello(string name) {
    Console.WriteLine($"Hello {name}!");
  }
  // public void add(int a, int b) {
  //   return a + b;
  // }
  // // overloaded methods need to have different signitures
  // public void add(float a, int b) {
  //   return a + b;
  // }
}