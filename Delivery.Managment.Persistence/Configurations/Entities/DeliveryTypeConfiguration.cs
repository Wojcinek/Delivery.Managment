using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delivery.Managment.Persistence.Configurations.Entities
{
    public class DeliveryTypeConfiguration : IEntityTypeConfiguration<DeliveryType>
    {
        public void Configure(EntityTypeBuilder<DeliveryType> builder) 
        {
            builder.HasData(
                new DeliveryType
                {
                    Id = 1,
                    Name = "Priority",

                },
                new DeliveryType
                {
                    Id = 2,
                    Name = "Normal",
                },
                new DeliveryType
                {
                    Id= 3,
                    Name = "Pallet"
                },
                new DeliveryType
                {
                    Id = 4,
                    Name = "National"
                },
                new DeliveryType
                {
                    Id = 5,
                    Name = "International"
                }

                );
                
        }


    }
}
