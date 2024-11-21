using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("hello world");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float yValue = 0.00f;
        transform.Translate(xValue, yValue, zValue);
    }
}
