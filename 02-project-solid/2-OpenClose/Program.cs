using OpenClose;

showSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Manuel juan", 200)
});


void showSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
           Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
        
    }
}