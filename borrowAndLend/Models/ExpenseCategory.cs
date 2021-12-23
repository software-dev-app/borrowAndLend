using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace borrowAndLend.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        //[Column(TypeName = "nvarchar(100)")]
        //[DisplayName("Category Type")]
        public string CategoryType { get; set; }
    }
}
