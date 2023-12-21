using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement_Logic
{
    public abstract class ElectricVehicle : Vehicle
    {

        private float m_CurrentBatteryTime;
        private float m_MaxBatteryTime;

        public float MaxBatteryTime
        {
            get { return m_MaxBatteryTime; }
            set { m_MaxBatteryTime = value; }
        }

        public float CurrentBatteryTime
        {
            get { return m_CurrentBatteryTime; }

            set { m_CurrentBatteryTime = value; }
        }


        public override void SetVehicleData(string i_ModelName, string i_LicenseNumber, string i_WheelsManuFacturerName, float i_CurrentWheelsAirPressure)
        {
            base.SetVehicleData(i_ModelName, i_LicenseNumber, i_WheelsManuFacturerName, i_CurrentWheelsAirPressure);
            CurrentBatteryTime = (base.EnergyPercentage / 100) * MaxBatteryTime;
        }

        public void Charge(float i_HoursToAdd)
        {
            if (i_HoursToAdd <= 0)
            {
                throw new ValueOutOfRangeException(MaxBatteryTime, 0, string.Format("Invalid charging time. The amount to charging must be positive.{0}{0}", Environment.NewLine));
            }

            if (CurrentBatteryTime + i_HoursToAdd > MaxBatteryTime)
            {
                throw new ValueOutOfRangeException(MaxBatteryTime, 0, string.Format("Cannot charge more than {0} hours.{1}{1}", (MaxBatteryTime - CurrentBatteryTime), Environment.NewLine));
            }

            CurrentBatteryTime += i_HoursToAdd;
        }

        public override string ToString()
        {
            string message = string.Format("{3}General Details:{0}{0}Max Battery Time: {1}{0}Current Battery Time: {2}{0}", Environment.NewLine, m_MaxBatteryTime, m_CurrentBatteryTime, base.ToString());
            return message;
        }

    }
}
