using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HomingController : MonoBehaviour // ABSTRACTION
{
    protected GameObject target;
    protected abstract void Homing(); // ABSTRACTION
}
