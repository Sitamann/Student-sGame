using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{
    public GameObject bulletObj;
    public Transform shootingPoint;
    private float Timer;
    public float resetTimer;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Timer <= 0)
        {
            Instantiate(bulletObj, shootingPoint.position, transform.rotation);
            Timer = resetTimer;
        }
        else
        {
            Timer -= Time.deltaTime;
        }
    }
}
