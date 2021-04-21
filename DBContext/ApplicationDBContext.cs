using HustlerNation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HustlerNation.DBContext
{
    public class ApplicationDBContext :DbContext
    {
		public DbSet<Students> Student_Reg { get; set; }

		

		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
			: base(options)
		{
		}
	}
}
