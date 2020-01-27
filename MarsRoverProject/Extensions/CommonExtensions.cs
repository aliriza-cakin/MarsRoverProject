using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject.Extensions
{
    public static class CommonExtensions
    {
        public static Exception GetInnerException(Exception ex)
        {

            var innerException = ex;
            while (innerException != null && innerException.InnerException != null)
            {
                innerException = innerException.InnerException;
            }

            return innerException;


        }
    }
}
