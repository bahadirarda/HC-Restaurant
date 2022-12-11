using System;
using HC_DOMAIN.Entities.Concrete;
using HC_INFRASTRUCTURE.Mapper.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HC_INFRASTRUCTURE.Mapper.Concrete
{
	public class AppUserMap: BaseMap<AppUser>
	{
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.FullName).IsRequired(true).HasMaxLength(96);
            builder.Property(x => x.ImagePath).IsRequired(false).HasMaxLength(3000);

            builder.Property(x => x.UserName).IsRequired(true).HasMaxLength(18);
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(96);
            builder.Property(x => x.BirthDate).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false).HasMaxLength(3000);

            base.Configure(builder);
        }
    }
}

