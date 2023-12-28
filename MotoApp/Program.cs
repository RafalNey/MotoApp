// using MotoApp.Entities;
// using MotoApp.Repositories;

// var employeeRepository = new GenericRepository<Employee, int>();
// employeeRepository.Add(new Employee { FirstName = "Adam" });
// employeeRepository.Add(new Employee { FirstName = "Piotr" });
// employeeRepository.Add(new Employee { FirstName = "Zuzia" });
// employeeRepository.Save();

using MotoApp;

var stack = new BasicStack();

stack.Push(4.5);
stack.Push(43);
stack.Push(333.6);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}
Console.WriteLine($"Suma: {sum}");