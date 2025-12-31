using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

 public record Sale
(

    int id,
    int id_product,
    int min_amount,
    double min_price,
    bool for_who,
    DateTime start_sale,
    DateTime end

)
{

}
