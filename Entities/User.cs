namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int IdRol { get; set; }

        public Rol Rol { get; set; } = null!;
    }
}
