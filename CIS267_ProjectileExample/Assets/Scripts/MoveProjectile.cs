using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public float bulletDamage;
    public float bulletSpeed;
    public float bulletLife;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyProjectile", bulletLife);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * bulletSpeed * Time.deltaTime);
    }

    void destroyProjectile()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyHealth>().deductHealth(bulletDamage);
            destroyProjectile();
        }
    }
}
