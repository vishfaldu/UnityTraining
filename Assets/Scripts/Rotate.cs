using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Rigidbody rb;
    public float force;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //Quaternion myRotation = Quaternion.Euler(0, 90, 0);
    }

    private void OnMouseDown()
    {
        rb.transform.Rotate(0, 90, 0);
        //rb.AddTorque(transform.up, ForceMode.Impulse);
        //rb.AddForce(transform.up, ForceMode.Impulse);
        Debug.Log("tap");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
            Debug.Log("HIT!");
    }

}
