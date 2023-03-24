using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using LeaveManagement.Web.Constants;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                { 
                    Id = "dfe8eacd-e07a-4621-a452-7b5d7cae8433",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "dfe9eacd-e08a-4621-a546-7b5d7cae8433",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                }

               );
        }
    }
}