using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageManagement_Logic
{
    public abstract class MotorizedVehicle : Vehicle
    {

        private float m_CurrentFuelAmount;
        private float m_MaxFuelAmount;
        private eFuelType m_FuelType;

        public enum eFuelType
        {
            Soler = 1,
            Octan95,
            Octan96,
            Octan98
        }

        public float CurrentFuelAmount
        {
            get { return m_CurrentFuelAmount; }

            set { m_CurrentFuelAmount = value; }
        }

        public float MaxFuelAmount
        {
            get { return m_MaxFuelAmount; }

            set
            {
                if (value <= 0)
                {
                    throw new ValueOutOfRangeException(int.MaxValue, 0, string.Format("Invalid fuel amount. The fuel amount must be positive.{0}{0}", Environment.NewLine));
                }

                m_MaxFuelAmount = value;
            }
        }

        public eFuelType FuelType
        {
            get { return m_FuelType; }
            set { m_FuelType = value; }
        }


        public override void SetVehicleData(string i_ModelName, string i_LicenseNumber, string i_WheelsManuFacturerName, float i_CurrentWheelsAirPressure)
        {
            base.SetVehicleData(i_ModelName, i_LicenseNumber, i_WheelsManuFacturerName, i_CurrentWheelsAirPressure);
            CurrentFuelAmount = (base.EnergyPercentage / 100) * MaxFuelAmount;
        }

        public void Refuel(float i_Amount, eFuelType i_FuelType)
        {
            if (i_FuelType != FuelType)
            {
                throw new Exception(string.Format("Invalid type: {1}. This vehicle requires {2} fuel.{0}{0}", Environment.NewLine, i_FuelType, FuelType));
            }

            if (i_Amount <= 0)
            {
                throw new ValueOutOfRangeException(MaxFuelAmount, 0, string.Format("Invalid fuel amount. The amount to refuel must be positive.{0}{0}", Environment.NewLine));
            }

            if (CurrentFuelAmount + i_Amount > MaxFuelAmount)
            {
                throw new ValueOutOfRangeException(MaxFuelAmount, 0, string.Format("Cannot refuel more than {1} liters of fuel.{0}{0}", Environment.NewLine, (MaxFuelAmount - CurrentFuelAmount)));
            }

            CurrentFuelAmount += i_Amount;
        }

        public override string ToString()
        {
            string message = string.Format("{1}General Details:{0}{0}Current Fuel Amount: {2}{0}Max Fuel Amout: {3}{0}Fuel Type: {4}{0}", Environment.NewLine, base.ToString(), m_CurrentFuelAmount, m_MaxFuelAmount, m_FuelType);
            return message;
        }
    }
}
