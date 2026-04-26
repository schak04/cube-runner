using UnityEngine;

public class MrCube : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float horizontalSpeed = 5f;
    public float limitX = 3f;

    void Update()
    {
        // constant forward movement
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // left/right input
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveX * horizontalSpeed * Time.deltaTime);

        // clamp position so cube doesn't go out of bounds
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);
        transform.position = pos;
    }
}