using UnityEngine;

public class ArrowController : MonoBehaviour
{

    GameObject player;
    GameObject manager;
    float minDistance = 1.1f;
    public float dropSpeed = 0.1f;


    // Start is called once beforpe the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("player");
        manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);

        if(transform.position.y < -7)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        float distance = (p1 - p2).magnitude;
        if(distance < minDistance)
        {
            manager.GetComponent<GameManager>().DecreaseHP();
            Destroy(gameObject);

        }
    }
}
