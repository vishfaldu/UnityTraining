using UnityEngine;

public class Force : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        rb.AddForce(Vector3.forward * speed);
        Debug.Log("tap!");
    }
}
