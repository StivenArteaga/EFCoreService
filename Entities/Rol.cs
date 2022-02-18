using System.Collections.Generic;

namespace Entities
{
    public class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public User User { get; set; } = null!;
        public ICollection<RolPermission> RolPermission { get; set; } = null!;
    }
}
