using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public GameObject projectile;
    public Transform tip;
    private float timeBetweenShots;
    public float firingRate;
    private bool canFire = true;


    // Update is called once per frame
    void Update()
    {
        if (timeBetweenShots <= 0)
        {
            timeBetweenShots = firingRate;
            canFire = true;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(canFire)
            {
                shootWeapon();
                canFire = false;
            }
        }


    }

    void shootWeapon()
    {
        //create the bullet
        Instantiate(projectile, tip.position, transform.rotation);

    }
}
