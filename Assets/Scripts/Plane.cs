using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    public GameObject propeller;
    private float propellarSpeed  = 200;

    // Start is called before the first frame update
    void Start()
    {
        SetComponent();
        speed = 1.0f;
        moveStateName[3] = "I have no idea XD";
    }

    // Update is called once per frame
    void Update()
    {
        moveVehicle();
        if (MoveState == 1 || MoveState == 2)
        {
            propeller.transform.Rotate(Vector3.forward * propellarSpeed * Time.deltaTime);
        }
    }

    protected override Vector3 getDirectionToTarget()
    {
        Vector3 direction = getTarget().transform.position - transform.position;
        transform.LookAt(getTarget().transform);
        return direction;
    }
}
