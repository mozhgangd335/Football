using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Teams.Contract.Dto
{
   public class AddTeamDTO
    {
        public string FullName { get; set; }

        public Color Firstcolor { get; set; }
        public Color Secondcolor { get; set; }
    }
}
