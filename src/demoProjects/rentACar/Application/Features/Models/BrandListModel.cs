using Application.Features.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models
{
    public class BrandListModel:BasePageableModel
    {
        public IList<BrandListDto>  Items { get; set; }
    }
}
