using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    public GameObject explosion;
    public Counter counter;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bullet")
        {
            print("hit");
            
            counter.countUp();

            Instantiate(explosion, transform.position, transform.rotation);
            
            Destroy(gameObject);
        }  
    }
}
