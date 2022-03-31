using UnityEngine;
public class camPaning : MonoBehaviour
{
    Vector3 rotation;
    public float speed = 3;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotation.y += Input.GetAxis("Mouse X");
            rotation.x += -(Input.GetAxis("Mouse Y"));
            transform.eulerAngles = rotation * speed;
            //transform.Rotate();
        }
    }
}

