using System.Collections.Generic;

namespace PropertyRead.Model
{
    public class NewPriceListEmailDto
    {
        public NewPriceListEmailDto()
        {
            NewPriceListDtoItems = new List<NewPriceListDto>();
        }
        public List<NewPriceListDto> NewPriceListDtoItems { get; set; }
    }
}
