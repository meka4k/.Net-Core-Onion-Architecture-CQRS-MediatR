using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    internal class PagedResponse<T>:ServiceResponse<T>
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }



        public PagedResponse()
        {
            PageSize = 10;

            PageNumber = 1;
        }

        public PagedResponse(T value,int pageSize,int pageNumber):base (value)
        {
            PageSize =pageSize;
            PageNumber =pageNumber;
        }
    }
}
