using System.Collections.Generic;

namespace Entities
{
    public class Permission
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<RolPermission> RolPermission { get; set; } = null!;
    }
}
