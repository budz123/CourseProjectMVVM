using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.MVVM.Model
{
    public  class Rooms
    {
     [Key]
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Capfcity { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Price { get; set; }

    }
}
