using UnityEngine;

public class BamGener : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bamsongi;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsong = Instantiate(bamsongi);

        }
    }
}
