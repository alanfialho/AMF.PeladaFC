using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Amf.PeladaFC.Infraestrutura.Dados.EntityFramework.PersistenceModel
{
    public class ApplicationUser : IdentityUser
    {
        public virtual PeladeiroEntity PeladeiroEntity { get; private set; }

        public ApplicationUser()
        {

        }

        public ApplicationUser(PeladeiroEntity peladeiroEntity)
        {
            PeladeiroEntity = peladeiroEntity;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}