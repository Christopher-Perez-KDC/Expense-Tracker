using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TranscationId { get; set; }

        //CategoryId
        public int CategoryId { get; set; }
        public Category Category { get; set; }//foreign key 


        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note {  get; set; }

        public DateTime Date { get; set; } = DateTime.Now; //Current date 
    }
}
