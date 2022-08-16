using Microsoft.AspNet.Identity.EntityFramework;

namespace UserIdentity.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
