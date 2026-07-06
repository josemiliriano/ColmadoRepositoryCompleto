using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class MyDataContext: DbContext
    {
        public MyDataContext( DbContextOptions<MyDataContext>options):base(options)
        {

        }
    }
}
