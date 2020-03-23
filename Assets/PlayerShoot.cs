using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bullet;
    public float shootRate = 3f;

    private float timer = 3f;
    private bool start;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && timer >= shootRate)
        {
            GameObject copyBullet = Instantiate(bullet, transform.position + transform.forward, bullet.gameObject.transform.rotation);
            copyBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 100, ForceMode.Acceleration);
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
