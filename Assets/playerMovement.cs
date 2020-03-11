using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerMovement : MonoBehaviour
{
    public float xSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = 0;
        if (horizontal != 0)
        {
            xOffset = horizontal + Time.deltaTime * xSpeed;
        }
        float newXPos = xOffset + transform.localPosition.x;
        transform.localPosition = new Vector3(Mathf.Clamp(newXPos, -15, 15), transform.localPosition.y, transform.localPosition.z);
    }
}
