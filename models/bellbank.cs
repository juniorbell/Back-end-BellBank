using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_bellbank.models
{
    public class Bellbank
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public BankCategory Category { get; set; }
    }

    public enum BankCategory
    {
        Digital = 0,
        Comercial = 1,
        Investimento = 2,
        Varejo = 3,


    }
}