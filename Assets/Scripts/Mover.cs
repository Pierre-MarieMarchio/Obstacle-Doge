using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;

    private void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }

    private static void PrintInstruction()
    {
        Debug.Log("hello world");
        Debug.Log("try to play the game with your pain !");
        Debug.Log("Bad game !");
    }
}