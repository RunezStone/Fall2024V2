using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float cameraSpeed = 2f;
    public float offset = 1f;
    public Transform target;

    void Update()
    {
        Vector3 tarPos = new Vector3(target.position.x, target.position.y + offset, -10f);
        transform.position = Vector3.Slerp(transform.position, tarPos, cameraSpeed * Time.deltaTime);
    }
}
