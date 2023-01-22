using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 offsetCamera = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        offsetCamera = transform.position - targetTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lastPosition = targetTransform.position + offsetCamera;

        transform.position = lastPosition;
    }
}
