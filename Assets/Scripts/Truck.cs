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
    }

    protected override void Action()
    {
        StartCoroutine(loadOff());
    }

    IEnumerator loadOff()
    {
        yield return new WaitForSeconds(5);
        Vector3 direction = getTarget().transform.position - transform.position;
        while (direction.magnitude > 0.5f)
        {
            truckLoad.transform.Translate(direction * speed * Time.deltaTime);
            direction = getTarget().transform.position - transform.position;
        }
    }
}
