﻿using RED.Interfaces;

namespace RED.Models
{
    internal class KeyboardInputModel
    {
        internal int ManualDeadzone;
        internal bool AutoDeadzone = false;

        internal float speedMultiplier = 1.0f;
        internal bool Connected;

        internal float WheelsLeft; // Key Q / Key A
        internal float WheelsRight; // Keys E / Key D
        internal float ElbowBend;
        internal float ElbowTwist; 
        internal float WristBend; 
        internal float WristTwist; 
        internal float GripperOpen; 
        internal float GripperClose; 
        internal bool ToolNext; 
        internal bool ToolPrev; 
        internal bool ArmReset; 
        internal bool DrillClockwise; 
        internal bool DrillCounterClockwise; 
        internal bool ModeNext; 
        internal bool ModePrev; 
        internal bool ToolNextDebounced; 
        internal bool ToolPrevDebounced; 
        internal bool ArmResetDebounced; 
        internal bool DrillClockwiseDebounced; 
        internal bool DrillCounterClockwiseDebounced; 
        internal bool ModeNextDebounced; 
        internal bool ModePrevDebounced; 
        internal bool BaseCounterClockwise; 
        internal bool BaseClockwise; 
        internal bool ActuatorForward; 
        internal bool ActuatorBackward; 
    }
}