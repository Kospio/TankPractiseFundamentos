using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingAndShooting : MonoBehaviour
{
    public Camera cam;

    public GameObject Bullet;
    public GameObject SpawnPoint; 
    void Update()
    {
        Aim();

        if (Input.GetMouseButtonDown(0))
        {
            Shoot(); 
        }
    }

    void Shoot()
    {
        Instantiate(Bullet, SpawnPoint.transform.position, SpawnPoint.transform.rotation);

    }

    void Aim()
    {
        Vector2 mouseScreenPosition = cam.ScreenToWorldPoint(Input.mousePosition);

        transform.up = new Vector2(transform.position.x - mouseScreenPosition.x, transform.position.y - mouseScreenPosition.y).normalized;

    }

}
