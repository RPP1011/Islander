using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Islander.Player
{
    public partial class MasterModule : MonoBehaviour
    {
        public Dictionary<string, InfoAttribute> info = new Dictionary<string, InfoAttribute>();

        public void InvokeTakeDamage(int damageTaken)
        {
            if (TakeDamageEventHandler != null)
            {
                TakeDamageEventHandler(damageTaken);
            }
        }
    }
}