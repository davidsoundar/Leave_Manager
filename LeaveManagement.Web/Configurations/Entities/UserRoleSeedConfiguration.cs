using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "dfe8eacd-e07a-4621-a452-7b5d7cae8433",
                    UserId = "ab0c6b3d-adde-4553-94b6-2aa4e3eb85b2"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "dfe9eacd-e08a-4621-a546-7b5d7cae8433",
                    UserId = "1b22d292-ab06-47a0-9528-f54e8d3075ea"
                }
            );
        }
    }
}