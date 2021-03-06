using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotDBService.Entities
{
    public class BOT_SCENARIO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SCENARIO_ID { get; set; }
        [StringLength(100)]
        public string NAME { get; set; }
        public Nullable<int> DOMAIN_ID { get; set; }
        [StringLength(100)]
        public string DOMAIN_NAME { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
        public Nullable<int> RECORD_STATUS { get; set; }
    }
}
