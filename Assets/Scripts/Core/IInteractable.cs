using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Islander
{
    public interface IInteractable
    {
        void StartInteract();

        void StopInteract();
    }
}