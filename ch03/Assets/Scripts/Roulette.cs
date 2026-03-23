using UnityEngine;

public class Roulette : MonoBehaviour
{
    public float startSpeed = 10f;
    public float decreaseSpeed = 0.97f;
    float rotSpeed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60; //휴대폰 사양마다 달라짐
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = startSpeed;

        }
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= decreaseSpeed;
    }
}
