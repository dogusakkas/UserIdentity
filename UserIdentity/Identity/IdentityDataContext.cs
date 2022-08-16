using Microsoft.AspNet.Identity.EntityFramework;

namespace UserIdentity.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("identityConnection")
        {

        }
    }
}
