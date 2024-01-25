using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__4
{
    interface IOrganization
    {
        public string? OrganizationName { get; set; }
        public string? Description { get; set; }
        public int? OrganizationId { get; set; }
    }
}
