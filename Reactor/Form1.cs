using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Reactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task.Factory.StartNew(() => {
                Model();
            });
        }

        public void Model()
        {
            float ControlRods = 100f;
            float Reactivity = 0f;
            RodInsertion = ControlRods;
            float ReactivityCoefficiant = 0f;
            float NeutronDensity = 0f;
            float ThermalPower = 0f;
            float MinimumWorth = -99.0f;
            float ThermalPowerMinDensity = 10.00f;
            float Xenon = 0f;
            float XenonCoefficiant = 0f;
            while(true){
                try
                {
                    ReactivityCoefficiant = 0f;
                    Reactivity = 0f;
                    // 1.5 is a small offset to make it feel a little more realistic
                    ReactivityCoefficiant -= RodInsertion * 1.5f + MinimumWorth + Xenon / 200;
                    Reactivity += ReactivityCoefficiant / 2;

                    // Slowly decrease neutron density if reactivity is negative
                    if (Reactivity < 0f && NeutronDensity > 0f)
                    {
                        NeutronDensity += Reactivity / 20 - Xenon / 4;
                    }

                    // Make density zero if its below.
                    if (NeutronDensity < 0)
                    {
                        NeutronDensity = 0;
                    }


                    // This is not a very realistic way of simulating xenon,
                    // but doing it correctly is hard.

                    string XenonDebug = "Xenon debug: ";

                    // If power is low, increase xenon coefficiant
                    if (NeutronDensity < 2400 && NeutronDensity != 0 )
                    {
                        // just some random math i have no idea how this works
                        float CoefficiantIncrease = NeutronDensity / 1000 * -2;
                        XenonCoefficiant -= CoefficiantIncrease;
                        XenonDebug += "Coefficiant Increase: " + CoefficiantIncrease + " | ";
                    }

                    if (NeutronDensity > 2400 && Xenon != 0.01f && XenonCoefficiant > -100)
                    {
                        // just some random math i have no idea how this works
                        XenonCoefficiant += NeutronDensity / 100 * -2;
                    }
                    if(Xenon > -1f)
                    {
                        Xenon += XenonCoefficiant / 2500;
                    }
                    else {
                        Xenon = -0.01f;
                    }
                    
                    XenonDebug += "Coefficiant: " + XenonCoefficiant + " | Xenon: " + Xenon;
                    Console.WriteLine(XenonDebug);

                    // If we have positive reactivity, we increase neutron density.
                    if (Reactivity > 0)
                    {
                        NeutronDensity += Reactivity / 4;
                    }

                    // If we have enough density, increase thermal power.
                    // Also, decrease thermal power if neutron density is negative.
                    if ((NeutronDensity > ThermalPowerMinDensity) || (NeutronDensity < 0f && ThermalPower > 0f))
                    {
                        ThermalPower += Reactivity / 4 + NeutronDensity / 100000;
                    }

                    // Make thermal power 0 if it became negative
                    if (ThermalPower < 0)
                    {
                        ThermalPower = 0f;
                    }

                    // Now we set GUI stuff
                    Invoke(new MethodInvoker(delegate () {
                        ReactivityLabel.Text = Convert.ToString(Reactivity);
                        InsertionLabel.Text = Convert.ToString(RodInsertion);
                        DensityLabel.Text = Convert.ToString(NeutronDensity);
                        ThermalPowerLabel.Text = Convert.ToString(ThermalPower) + "MWe";
                    }));
                    Thread.Sleep(100);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void RodsHold_Click(object sender, EventArgs e)
        {
            RodsMoving = 0;
        }
        private void RodsIn_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => {
                MoveRods(2);
            });
        }
        private void RodsOut_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => {
                MoveRods(1);
            });
        }
        private void TripReactor()
        {
            ReactorTripActive = true;
            RodsMoving = 0;
            while(RodInsertion < 100)
            {
                RodInsertion++;
                Thread.Sleep(3);
            }
            RodInsertion = 100;
        }
        private void ResetReactorTrip()
        {
            ReactorTripActive = false;
        }
        private void MoveRods(int direction)
        {
            float amount;
            switch (direction)
            {
                case 1:
                    amount = -0.1f;
                    break;
                case 2:
                    amount = 0.1f;
                    break;
                default:
                    return;
            }
            RodsMoving = direction;
            while (ReactorTripActive == false && RodsMoving == direction)
            {
                if (RodInsertion < 0.2 && amount < 0)
                {
                    RodInsertion = 0;
                    break;
                }
                else if (RodInsertion > 99.8 && amount > 0)
                {
                    RodInsertion = 100;
                    break;
                }
                else
                {
                    RodInsertion += amount;
                    Thread.Sleep(100);

                }

            }
        }

        private void ReactorTripButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => {
                TripReactor();
            });
        }

        private void ReactorTripResetButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => {
                ResetReactorTrip();
            });
        }
    }
}
