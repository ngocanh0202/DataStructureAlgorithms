
namespace Person
{
    public abstract class Person
    {
        String id;
        String name;
        String? address;
        private String? number;
        public override string ToString()
        {
            return $" have {this.id}, {this.name}, {this.address}, {this.number}";
        }
        public Person(){
            this.id = "12334";
            this.name = "NgocAnh";
            this.address = enumAddress.DaNang.ToString();
            this.number = "123456789";
        }
        public Person(String id, String name, String address,String number){
            this.id = id;
            this.name = name;
            this.address = address;
            this.number = number;
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string? Adress { get => address; set => address = value; }
        public string? Number { get => number; set => number = value; }
        public virtual void sound(){
            Console.WriteLine(this.ToString());
        }
    }
}