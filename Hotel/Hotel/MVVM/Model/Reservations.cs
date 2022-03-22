using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.MVVM.Model
{
   public  class Reservations
    {
       
         [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CheckInDate { get; set;}
        [Required]
        public DateTime CheckOutdate { get; set;}
        [Required]
        [ForeignKey("RoomId")]
        public Rooms RoomId { get; set; }
        [Required]
        public string ReservationsStatus { get; set; }
        [Required]
        public int TypePayment { get; set; }
        [Required]
        [ForeignKey("ClietnsId")]
        public Clients ClientsId { get; set; }
    }
}
