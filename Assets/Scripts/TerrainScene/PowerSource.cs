using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSource : MonoBehaviour
{
    public int HP = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit by a bullet");
            HP -= 20;
            Destroy(collision.gameObject);
            if (HP < 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
