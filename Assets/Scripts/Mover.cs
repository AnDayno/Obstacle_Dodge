using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{

    Vector2 moveInput;
    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer ();
    }

    private void MovePlayer()
    {
        float xValue = moveInput.x * Time.deltaTime * 10f;
        float yValue = 0f;
        float zValue = moveInput.y * Time.deltaTime * 10f;
        transform.Translate(xValue, yValue, zValue);
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
