using UnityEngine;

public class MrCube : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float horizontalSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime); 
        float moveX = Input.GetAxis("Horizontal"); // get left/right input
        transform.Translate(Vector3.right * moveX * horizontalSpeed * Time.deltaTime); // move left/right
    }
}
