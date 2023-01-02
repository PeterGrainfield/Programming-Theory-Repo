using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : Vehicle
{
    public GameObject truckLoad;
    // Start is called before the first frame update
    void Start()
    {
        SetComponent();
        speed = 0.4f;
        moveStateName[3] = "LoadOff!";
    }

    // Update is called once per frame
    void Update()
    {
        moveVehicle();
        if (MoveState == 3)
        {
            Action();
        }
    }

    protected override void Action()
    {
        loadOff();
    }

    void loadOff()
    {
        Vector3 direction = getTarget().transform.position - truckLoad.transform.position;
        truckLoad.transform.Translate(direction * speed * Time.deltaTime);
    }
}
