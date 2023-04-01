using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccrualsProject
{
    public class HotWaterAccruals
    {
        /// <summary>
        /// ГВС Теплоноситель
        /// </summary>
        public double HeatCarrier;

        /// <summary>
        /// ГВС Тепловая Энергия
        /// </summary>
        public double HeatEnergy;

        public HotWaterAccruals(double heatCarrier, double heatEnergy)
        {
            HeatCarrier = heatCarrier;
            HeatEnergy = heatEnergy;
        }
    }

    public class EnergyAccrualsWithMeter
    {
        /// <summary>
        /// По дневному тарифу
        /// </summary>
        public double DayAccruals;

        /// <summary>
        /// По ночному тарифу
        /// </summary>
        public double NightAccruals;

        public EnergyAccrualsWithMeter(double dayAccruals, double nightAccruals)
        {
            DayAccruals = dayAccruals;
            NightAccruals = nightAccruals;
        }
    }
}
