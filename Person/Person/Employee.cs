
namespace Person
{
    public class Employee : Person, Function
    {
        String salary;
        String price;
        public Employee(){
            this.salary = "0";
            this.price = "0";
        }
        public Employee(String id, String name, String address,String number, String salary, String price) 
        : base(id, name, address,number)
        {
            this.salary = salary;
            this.price = price;
        }
        public override string ToString()
        {
            return $"This is employee, and this is infomation {base.ToString()}, {this.salary}, {this.price}";
        }
        public string Salary { get => salary; set => salary = value; }
        public string Price { get => price; set => price = value; }

        public override void sound()
        {
            Console.WriteLine(this.ToString());
        }

        public float Calculator()
        {
            throw new NotImplementedException();
        }
    }
}