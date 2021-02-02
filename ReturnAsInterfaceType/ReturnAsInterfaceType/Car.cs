using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnAsInterfaceType
{
    public interface Car
    {
        // public abstract void StartEngine();
        void StartEngine();
    }

    class Sample
    {
        private Car myCar;

        public Sample(Car car)
        {
            this.myCar = car;
        }

        public Car getMyCar()
        {
            return this.myCar;
        }

        public void setMyCar(Car car)
        {
            this.myCar = car;
        }

        public void DoAnything()
        {
            Car localCar = null;
            localCar = this.myCar;
            localCar.StartEngine();
        }
    }
}
