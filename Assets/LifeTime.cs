using UnityEngine;

public class LifeTime : MonoBehaviour
{
    float timer = 0f;
    public float lifeTime = 3f;
    
    // Update is called once per frame
    void Update()
    {
        if(timer < lifeTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }   
    }
}
