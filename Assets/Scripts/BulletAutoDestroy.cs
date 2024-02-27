using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAutoDestroy : MonoBehaviour
{
    public float bulletSpeed;
    public int timeToDestroy; 

    // Start is called before the first frame update
    void Start()
    {
        Invoke("AutoDestroyBullet", timeToDestroy);
    }

    private void Update()
    {
        transform.position = transform.position + (transform.up * Time.deltaTime * bulletSpeed / 100); 
    }

    void AutoDestroyBullet()
    {
        Destroy(gameObject);
    }
}
