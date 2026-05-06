using UnityEngine;

public class BamGener : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bamsongi;
    public float throwForce = 10f;
    public float startY;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startY = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            GameObject bamsong = Instantiate(bamsongi);
            bamsong.transform.position = transform.position;

            float power = Input.mousePosition.y - startY;

            Vector3 dir = transform.forward + transform.up;
            bamsong.GetComponent<Bamcontroller>().Shoot(dir * power * throwForce);
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //bamsong.GetComponent<Bamcontroller>().Shoot(ray.direction.normalized);
        }
    }
}
