using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FusionTrial.Fusion103
{
    public class Ball : NetworkBehaviour
    {
        [Networked] private TickTimer life { get; set; }
        public void Init()
        {
            life = TickTimer.CreateFromSeconds(Runner, 0.5f);
        }

        public override void FixedUpdateNetwork()
        {
            if (life.Expired(Runner))
                Runner.Despawn(Object);
            else
                transform.position += 5 * transform.forward * Runner.DeltaTime;
        }
    }
}

