﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Managment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Delivery.Managment.Persistence.Configurations.Entities
{
    public class DeliveryAllocationConfiguration : IEntityTypeConfiguration<DeliveryAllocation>
    {
        public void Configure(EntityTypeBuilder<DeliveryAllocation> builder)
        {
            
        }
    }
}
