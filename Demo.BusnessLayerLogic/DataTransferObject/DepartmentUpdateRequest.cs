using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusnessLayerLogic.DataTransferObject
{
    public class DepartmentUpdateRequest
    {
        public int Id { set; get; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Code { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
    }
}
