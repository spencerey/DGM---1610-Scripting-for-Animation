using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public Transform firePoint ;
    public GameObject projectile ; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            projectile.transform.Rotate(0, -90, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            projectile.transform.Rotate(0,90,0);
        }
    }

    void Shoot()
    {
        Instantiate (projectile,firePoint.position,firePoint.rotation);
    }
}
