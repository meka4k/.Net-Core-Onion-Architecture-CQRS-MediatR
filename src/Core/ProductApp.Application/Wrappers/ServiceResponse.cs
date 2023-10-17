using ProductApp.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class ServiceResponse<T>
    {

        public T Value { get; set; }


        public ServiceResponse(T value)
        {
            Value = value;
        }

        public ServiceResponse()
        {
            
        }

        public ServiceResponse(ProductViewDto viewModel)
        {
          
        }
    }

}
