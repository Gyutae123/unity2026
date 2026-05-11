using UnityEngine;

public class TargetController : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("BamGen");
    }
    private void Update()
    {
        transform.LookAt(player.transform);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bam"))
        {
            Destroy(gameObject);
        }
    }
}
