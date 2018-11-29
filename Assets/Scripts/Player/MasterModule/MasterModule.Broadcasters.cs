using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Islander.Player
{
    public partial class MasterModule : MonoBehaviour
    {
        public event Action<int> TakeDamageEventHandler;
    }
}