using UnityEngine;

public class MrCube : MonoBehaviour
{
    public float speed = 10f;
    public float limitX = 3f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D or ← →
        float moveZ = Input.GetAxis("Vertical");   // W/S or ↑ ↓

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // clamp X for lane restriction
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);
        transform.position = pos;
    }
}