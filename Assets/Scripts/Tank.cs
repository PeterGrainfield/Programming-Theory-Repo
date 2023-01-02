using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Vehicle
{
    public GameObject bulletPrefab;
    public GameObject barrel;
    private Vector3 bulletOffset = new Vector3(0, 3.4f, 3.4f);
    // Start is called before the first frame update
    void Start()
    {
        SetComponent();
        speed = 0.05f;
        moveStateName[3] = "Fire!";
    }

    // Update is called once per frame
    void Update()
    {
        moveVehicle();
    }

    protected override void Action()
    {
        barrel.transform.LookAt(getTarget().transform);
        Instantiate(bulletPrefab, transform.position + bulletOffset, bulletPrefab.transform.rotation);
    }
    
}
