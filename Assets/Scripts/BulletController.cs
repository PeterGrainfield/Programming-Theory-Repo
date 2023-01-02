using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : HomingController
{
    protected private float speed = 1.2f;
    public ParticleSystem explosionParticle;
    public ParticleSystem smokeParticle;
    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Main Camera");
        smokeParticle.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        Homing();
    }

    protected override void Homing() 
    {
        transform.LookAt(target.transform);
        Vector3 direction = target.transform.position - transform.position;
        if (direction.magnitude > 1.0f)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else
        {
            explosionParticle.Play();
            ammo.SetActive(false);
            Destroy(gameObject, 3.0f);
        }
    }
    
}
