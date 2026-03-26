using UnityEngine;

public class MrCube : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float horizontalSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        // not complete yet
    }
}
