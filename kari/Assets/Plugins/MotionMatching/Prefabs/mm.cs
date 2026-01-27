using UnityEngine;
using MxM;

public class mm : MonoBehaviour
{
    public MxMLocomotionController locomotionController;
    public float moveSpeed = 2f;

    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 move = new Vector3(input.x, 0f, input.y).normalized * moveSpeed;

        if (locomotionController != null)
        {
            locomotionController.SetMovement(move);
        }
    }
}
