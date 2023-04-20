using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormUI.Models.Interfaces
{
    public interface IRental
    {
        ICustomer Customer { get; set; }
        IMovie Movie { get; set; }
        decimal RentPrice { get; set; }
        DateTimeOffset RentDate { get; set; }

        string FullInfo { get; }
      
        string FullInfoAndCustomer { get; }

    }
}
