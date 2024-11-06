namespace STUDENT.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation("BsonType.ObjectId")]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public Person(string name, int age) 
        {
            this.Name = name;
                this.Age = age;
               
        }
                public string Name { get; set; }

        [BsonElement("Email")]
        public string? Email { get; set; }

        [BsonElement("Password")]
        public string? Password { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }
    }

    internal class BsonRepresentationAttribute : Attribute
    {
        private string v;

        public BsonRepresentationAttribute(string v)
        {
            this.v = v;
        }
    }

    internal class BsonElementAttribute : Attribute
    {
        private string v;

        public BsonElementAttribute(string v)
        {
            this.v = v;
        }
    }
}


    internal class BsonIdAttribute : Attribute
    {
    }

