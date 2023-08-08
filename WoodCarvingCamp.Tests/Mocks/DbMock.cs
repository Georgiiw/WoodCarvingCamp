using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data;

namespace WoodCarvingCamp.Tests.Mocks
{
    public static class DbMock
    {
        public static WoodCarvingCampDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<WoodCarvingCampDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

                return new WoodCarvingCampDbContext(dbContextOptions);
            }
        }
    }
}
