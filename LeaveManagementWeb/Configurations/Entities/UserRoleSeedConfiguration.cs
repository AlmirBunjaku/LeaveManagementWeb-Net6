using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "c7050ad9-9481-4430-bd8a-74da2a672457",
                    UserId = "bd4a5daf-b375-4cef-b77f-badc03669012"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "24dfaed2-aee3-49c8-be73-94508607c2f5",
                    UserId = "c3858f5f-535a-490e-a5e8-558f58c4b4c9"
                }
            );
        }
    }
}