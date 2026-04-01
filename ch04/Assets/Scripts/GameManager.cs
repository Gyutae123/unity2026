using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject car;
    //public GameObject flag;
    //public GameObject distance;
    public TextMeshProUGUI distance;
    public Transform car;
    public Transform flag;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //float length = flag.transform.position.x - car.transform.position.x;
        //distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("f2") + "m";
        float length = flag.position.x - car.position.x;
        distance.text = "°Å¸®: " + length.ToString("f2") + "m";

    }
}
