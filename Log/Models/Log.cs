namespace Log.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        [Key]
        public int LogsId { get; set; }

        public string UserIP { get; set; }

        public DateTime? DateVisit { get; set; }

        public string UserName { get; set; }

        public string Page { get; set; }
    }
}
