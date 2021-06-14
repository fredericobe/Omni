using console.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.Omni
{
    public class Client : IClient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string InvestorId { get; set; }
        public ClientProfile? Profile { get; set; }
    }
}
