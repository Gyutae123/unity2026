using UnityEngine;

public class ItemCon : MonoBehaviour
{
    public float dropSpeed = -1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed * Time.deltaTime, 0);
        if(transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
