using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.DataTransferObject
{
    public class DepartmentResponse
    {
        public int Id { set; get; }
        public string Name { get; set; } = null!;
        public string? Descreption {  get; set; }
        public string Code { get; set; } = null!;

        public DateTime CreatedAt { get; set; }  




    }
}
