using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.DataTransferObject
{
    public class DepartmentRequest
    {
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; } = null!;
        [Required]
        public string? Description { get; set; }
        public string Code { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
    }
}
