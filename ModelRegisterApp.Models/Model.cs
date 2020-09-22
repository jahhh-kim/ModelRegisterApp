using Remotion.Linq.Clauses;
using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ModelRegisterApp.Models
{
    public class Model
    {
        [Key]
        public int ModelCode { get; set; }
        [Required]
        public string PartId { get; set; }
        [Required]
        public string ModelName { get; set; }
    }
}
