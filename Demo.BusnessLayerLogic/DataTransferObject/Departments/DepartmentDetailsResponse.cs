using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.DataTransferObject.Departments
{
    public class DepartmentDetailsResponse
    {
        public int Id {  get; set; }
        public bool IsDeleted { get; set; } 
        public int CreateBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int LastModifyBy { get; set; }
        public DateTime LastModifyOn { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }









    }
}
