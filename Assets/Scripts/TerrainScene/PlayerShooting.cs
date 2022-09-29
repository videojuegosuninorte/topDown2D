using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float shootingInterval = 0.3f;
    private float period = 0.0f;
    private bool startShotting = false;

    //https://www.youtube.com/watch?v=LNLVOjbrQj4

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PowerSource")
        {
            startShotting = true;
        }
    }

    void Update()
    {
        if (!startShotting)
            return;

        if (period > shootingInterval)
        {
            shoot();
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
    }

    private void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
