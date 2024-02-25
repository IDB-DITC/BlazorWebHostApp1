using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebHostApp1.Shared
{
	public class Employee
	{

        public int Id { get; set; }


        public string EmpName { get; set; }

        public DateTime Join { get; set; }
        public DateOnly JoinDate => DateOnly.FromDateTime(this.Join);


        public string? ImagePath { get; set; }

        [NotMapped]
		public ImageData? ImageData { get; set; }

	}


    public class ImageData
    {
        public Stream? Stream { get; set; } = null;
		public string FileName { get; set; }

        public ImageData(Stream str, string name)
        {
            Stream = str;
            FileName = name;

		}
    }

}
