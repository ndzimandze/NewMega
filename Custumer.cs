namespace STUDENT.Models
{
    public class Customer
    {
        [BsonId]
       
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string? Name { get; set; }

        [BsonElement("Email")]
        public string? Email { get; set; }

        [BsonElement("Password")]
        public string? Password { get; set; }
    }

    internal class BsonType
    {
    }

    internal record struct NewStruct(object[] Item1, object Item2)
    {
        public static implicit operator (object[], object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object[], object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
