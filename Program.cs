using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using VRage;
using VRage.Collections;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.GUI.TextPanel;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ModAPI.Ingame.Utilities;
using VRage.Game.ObjectBuilders.Definitions;
using VRageMath;

namespace IngameScript
{
    public partial class Program : MyGridProgram
    {
        public Program()
        {
            Runtime.UpdateFrequency = UpdateFrequency.Update10;
        }
        public void Main(string argument, UpdateType updateSource)
        {
            IMyMotorStator backWheelRotor = GridTerminalSystem.GetBlockWithName("Rotor Motorcycle Back Wheel") as IMyMotorStator;
            if (backWheelRotor != null)
            {
                Echo("Back Wheel Rotor found.");
                if (backWheelRotor.TargetVelocityRPM == 60)
                {
                    backWheelRotor.TargetVelocityRPM = -59;
                }
                else if (backWheelRotor.TargetVelocityRPM == -60)
                {
                    backWheelRotor.TargetVelocityRPM = 59;
                }
            }
            else
            {
                Echo("Back Wheel Rotor not found.");
            }
        }
    }
}
