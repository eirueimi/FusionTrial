using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FusionTrial.Fusion103
{
    public struct NetworkInputData : INetworkInput
    {
        public const byte MOUSEBUTTON1 = 0x01;

        public byte buttons;
        public Vector3 direction;
    }
}

