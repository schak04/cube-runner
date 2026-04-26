using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform player;

    public Vector3 offset = new Vector3(0f, 5f, -7f);
    public float positionSmoothSpeed = 5f;
    public float rotationSmoothSpeed = 5f;

    void LateUpdate() {
        if (player == null) return;

        // target position
        Vector3 targetPosition = player.position + offset;

        // smooth position
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            positionSmoothSpeed * Time.deltaTime
        );

        // smooth rotation instead of snapping
        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            rotationSmoothSpeed * Time.deltaTime
        );
    }
}