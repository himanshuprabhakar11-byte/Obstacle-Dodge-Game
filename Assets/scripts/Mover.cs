using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 10f;


    
    
    void Start()
    {
        PrintInstruction();
    }

   
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into wall");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        float yValue = 0.0f;
        transform.Translate(xValue, yValue, zValue);



    }
}
