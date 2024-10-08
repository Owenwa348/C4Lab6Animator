using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private const float SMOOTH_TIME = 0.3f;
    public bool LockX, LockY, LockZ;
    public float offsetZ = -3.0f;
    public float offsetY = 1.0f;
    public bool useSmoothing = true;
    public Transform target;//the target object to follow Player Character
    private Transform thisTransform;
    private Vector3 velocity = Vector3.zero;

    void Awake()
    {
        //thisTransform gets the transform of the camera
        thisTransform = transform;
        //velocity is set to a new Vector3 with the values of 0.5f, 0.5f, 0.5f for x, y, and z respectively
        velocity = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        var newPos = new Vector3();
        if (useSmoothing)
        {
            //if useSmoothing is true, the camera will smoothly follow the player character
            newPos.x = Mathf.SmoothDamp(thisTransform.position.x, target.position.x, ref velocity.x, SMOOTH_TIME);
            newPos.y = Mathf.SmoothDamp(thisTransform.position.y, target.position.y + offsetY, ref velocity.y, SMOOTH_TIME);
            //newPos.z is set to the camera's current z position plus the offsetZ
            newPos.z = Mathf.SmoothDamp(thisTransform.position.z, target.position.z + offsetZ, ref velocity.z, SMOOTH_TIME);
        }
        else
        {
            //if useSmoothing is false, the camera will follow the player character without smoothing
            newPos.x = target.position.x;
            newPos.y = target.position.y + offsetY;
            newPos.z = target.position.z + offsetZ;
        }
        if (LockX)
        {
            //if LockX is true, the camera will not move on the x axis
            newPos.x = thisTransform.position.x;
        }
        if (LockY)
        {
            //if LockY is true, the camera will not move on the y axis
            newPos.y = thisTransform.position.y;
        }
        if (LockZ)
        {
            //if LockZ is true, the camera will not move on the z axis
            newPos.z = thisTransform.position.z;
        }
        transform.position = Vector3.Slerp(thisTransform.position, newPos, Time.time);
    }
}