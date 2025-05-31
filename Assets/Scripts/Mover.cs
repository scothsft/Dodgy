using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 05.0f;
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Use WASD or Arrow keys to move the object.");
        Debug.Log("Don't bump into ojects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue = 0.00f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
