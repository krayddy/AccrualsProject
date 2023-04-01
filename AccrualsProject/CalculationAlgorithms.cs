using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccrualsProject
{
    public static class CalculationAlgorithms
    {
        /// <summary>
        /// Стандартный алгоритм начислений
        /// </summary>
        private static double DefaultAlgorithm(double consumptionAmount, double tariff)
        {
            var accruals = consumptionAmount * tariff;
            return accruals;
        }

        /// <summary>
        /// Потребление по показаниям приборов учета
        /// </summary>
        private static double GetConsumptionWithMeter(double currentMeterReadings, double previousMeterReadings)
        {
            var consumptionAmount = currentMeterReadings - previousMeterReadings;
            return consumptionAmount;
        }

        /// <summary>
        /// Потребление по нормативному объему
        /// </summary>
        private static double GetConsumptionByStandard(double consumptionStandartPerPerson, double personCount)
        {
            var consumptionAmount = consumptionStandartPerPerson * personCount;
            return consumptionAmount;
        }

        #region ХВС
        /// <summary>
        /// Начисления ХВС по нормативному объему
        /// </summary>
        public static double GetColdWaterAccruals(double tariff, double consumptionStandardPerPerson, double personCount)
        {
            var accruals = DefaultAlgorithm(
                GetConsumptionByStandard(consumptionStandardPerPerson, personCount),
                tariff);
            return accruals;
        }

        /// <summary>
        /// Начисления ХВС по показаниям приборов учета
        /// </summary>
        public static double GetColdWaterAccrualsWithMeter(double tariff, double currentMeterReadings, double previousMeterReadings)
        {
            var accruals = DefaultAlgorithm(
                GetConsumptionWithMeter(currentMeterReadings, previousMeterReadings),
                tariff);
            return accruals;
        }
        #endregion

        #region ГВС
        /// <summary>
        /// Начисления ГВС по показаниям приборов учета
        /// </summary>
        public static HotWaterAccruals GetHotWaterAccrualsWithMeter(double tariffHeatCarrier, double tariffHeatEnergy,
            double standardHeatEnergy, double currentMeterReadings, double previousMeterReadings)
        {
            var heatCarrierConsumption = GetConsumptionWithMeter(currentMeterReadings, previousMeterReadings);
            var heatCarrierAccruals = DefaultAlgorithm(heatCarrierConsumption, tariffHeatCarrier);

            var heatEnergyAccruals = GetHeatEnergyAccruals(heatCarrierConsumption, standardHeatEnergy, tariffHeatEnergy);

            var accruals = new HotWaterAccruals(heatCarrierAccruals, heatEnergyAccruals);
            return accruals;
        }

        /// <summary>
        /// Начисления ГВС по нормативному объему
        /// </summary>
        public static HotWaterAccruals GetHotWaterAccruals(double tariffHeatCarrier, double tariffHeatEnergy,
            double standardHeatEnergy, double consumptionStandartPerPerson, double personCount)
        {
            var heatCarrierConsumption = GetConsumptionByStandard(consumptionStandartPerPerson, personCount);
            var heatCarrierAccruals = DefaultAlgorithm(heatCarrierConsumption, tariffHeatCarrier);

            var heatEnergyAccruals = GetHeatEnergyAccruals(heatCarrierConsumption, standardHeatEnergy, tariffHeatEnergy);

            var accruals = new HotWaterAccruals(heatCarrierAccruals, heatEnergyAccruals);
            return accruals;
        }

        /// <summary>
        /// Начисления по тепловой энергии (ГВС ТЭ)
        /// </summary>
        private static double GetHeatEnergyAccruals(double heatCarrierConsumption,
            double standardHeatEnergy, double tariffHeatEnergy)
        {
            var heatEnergyConsumption = heatCarrierConsumption * standardHeatEnergy;
            var heatEnergyAccruals = DefaultAlgorithm(heatEnergyConsumption, tariffHeatEnergy);
            return heatEnergyAccruals;
        }
        #endregion

        #region ЭЭ
        /// <summary>
        /// Начисления ЭЭ по нормативному объему
        /// </summary>
        public static double GetEnergyAccruals(double tariff, double consumptionStandardPerPerson, double personCount)
        {
            var accruals = DefaultAlgorithm(
                GetConsumptionByStandard(consumptionStandardPerPerson, personCount),
                tariff);
            return accruals;
        }

        /// <summary>
        /// Начисления ЭЭ по показаниям приборов учета
        /// </summary>
        public static EnergyAccrualsWithMeter GetEnergyAccrualsWithMeter(double tariffDay, double tariffNight,
            double currentMeterReadingsDay, double previousMeterReadingsDay,
            double currentMeterReadingsNight, double previousMeterReadingsNight)
        {
            var dayAccruals = DefaultAlgorithm(
                GetConsumptionWithMeter(currentMeterReadingsDay, previousMeterReadingsDay),
                tariffDay);

            var nightAccruals = DefaultAlgorithm(
                GetConsumptionWithMeter(currentMeterReadingsNight, previousMeterReadingsNight),
                tariffNight);

            var accruals = new EnergyAccrualsWithMeter(dayAccruals, nightAccruals);
            return accruals;
        }
        #endregion
    }
}
