using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Bus : Vehicle
{
    // Start is called before the first frame update
    void Start()
    {
        SetComponent();
        speed = 0.1f;
        moveStateName[3] = "DoNothing!";
    }

    // Update is called once per frame
    void Update()
    {
        moveVehicle();
    }
}
