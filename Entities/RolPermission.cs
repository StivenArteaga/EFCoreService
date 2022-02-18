namespace Entities
{
    public class RolPermission
    {
        public int IdRol { get; set; }
        public int IdPermission { get; set; }

        public Rol Rol { get; set; } = null!;
        public Permission Permission { get; set; } = null!;
    }
}
