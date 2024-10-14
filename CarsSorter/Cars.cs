using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSorter
{
    public class Cars
    {
        
        private string carBrand;
        private string carModel;
        private double carEngineSize;
        
        public string CarBrand
        {
            get { return carBrand; }
            set { carBrand = value; }
        }
        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }

        }
        public double CarEngineSize
        {
            get { return carEngineSize; }
            set { carEngineSize = value; }
        }
        
        public Cars(string carBrand, string carModel, double carEngineSize)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            CarEngineSize = carEngineSize;
        }



    }
}
