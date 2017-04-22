using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRead.Model
{
    public class NewPriceListDto
    {
        public NewPriceListDto()
        {
            NewPriceListProductDtoItems = new List<NewPriceListProductDto>();
        }

        public string PriceListName { get; set; }
        public string PriceListType { get; set; }
        public string UpdatedOn { get; set; }
        public List<NewPriceListProductDto> NewPriceListProductDtoItems { get; set; }
    }
}
