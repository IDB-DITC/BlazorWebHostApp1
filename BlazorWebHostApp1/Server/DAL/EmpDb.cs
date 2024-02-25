using BlazorWebHostApp1.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebHostApp1.Server.DAL
{
	public class EmpDb:DbContext
	{
        public DbSet<Employee> Employees { get; set; }

        public EmpDb(DbContextOptions o):base(o)
        {
            
        }
    }
}
