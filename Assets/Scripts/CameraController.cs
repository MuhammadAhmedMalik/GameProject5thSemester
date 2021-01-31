using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform cameraFollow;

    public float leftLimit;
    public float RightLimit;
    public float UpperLimit;
    public float lowerLimit;

    // Start is called before the first frame update
    void Start()
    {
        cameraFollow = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x = cameraFollow.position.x + 3f;
        temp.y = cameraFollow.position.y + 3f;
        transform.position = temp;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftLimit, RightLimit),
            Mathf.Clamp(transform.position.y, UpperLimit, lowerLimit),
            transform.position.z
            );

    }
}
