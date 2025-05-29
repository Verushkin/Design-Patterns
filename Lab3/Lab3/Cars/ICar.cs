using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Cars
{
    public interface ICar
    {
        float Weight { get; set;}
        float Length { get; set; }
        float MaxSpeed { get; set; }

    }
}
