using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypesTestHarness
{
    public record DailyTemperature(double HighTemp, double LowTemp)
    {
        public double Mean => (HighTemp + LowTemp) / 2.0;

        public override string ToString()
        {
            return $"HighTemp:{HighTemp} | LowTemp:{LowTemp} | Mean:{Mean}";
        }
    }


}
