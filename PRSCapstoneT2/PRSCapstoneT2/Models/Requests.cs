using System;
using System.Collections.Generic;

namespace PRSCapstoneT2
{
    public partial class Requests
    {
        public Requests()
        {
            RequestLines = new HashSet<RequestLines>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public string DeliveryMode { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public int UserId { get; set; }
        public DateTime? DateRequested { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<RequestLines> RequestLines { get; set; }
    }
}
