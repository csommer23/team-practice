namespace Team.Practice.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Cliente {Name}, com código de registro {Id} foi cadastrado com sucesso em nosso sistema";
        }
    }
}
