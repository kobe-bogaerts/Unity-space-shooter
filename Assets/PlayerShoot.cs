using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bullet;
    public float shootRate = 1.5f;

    private float timer = 1.5f;
    private bool start;

    void Start()
    {
        timer = shootRate;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && timer >= shootRate)
        {
            GameObject copyBullet = Instantiate(bullet, transform.position + transform.forward, bullet.gameObject.transform.rotation);
            copyBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 500, ForceMode.VelocityChange);
            start = true;
            timer = 0f;
        }

        if (start)
        {
            if(timer < shootRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = shootRate;
                start = false;
            }
        }
    }
}
