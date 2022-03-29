using UnityEngine;
public class otherCubeEvent : MonoBehaviour
{
    public GameObject target;
    void OnEnable()
    {
        cubeEvent.OnClick += Revolve;
    }
    /*
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }
    */
    void Revolve()
    {
        //anim.enabled = true;
        transform.RotateAround(target.transform.position, Vector3.up, 50f * Time.deltaTime);
        Debug.Log("Revolves(other cubes)");
    }
    void OnDisable()
    {
        cubeEvent.OnClick -= Revolve;
    }
}