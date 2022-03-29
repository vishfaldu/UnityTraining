using UnityEngine;
public class cubeEvent : MonoBehaviour
{
    GameObject target;
    public delegate void eventDelegate();
    public static eventDelegate OnClick;
    RaycastHit hit;
    void OnEnable()
    {
        OnClick += Rotate;
        OnClick += Revolve;
    }

    /*
        Animator anim;
        void Start()
        {
            anim = GetComponent<Animator>();
            anim.enabled = false;
        }
    */

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Cube")
                    OnClick();
            }
        }
    }
    void Rotate()
    {
        //anim.enabled = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform)
                hit.transform.Rotate(Vector3.up * Time.deltaTime * 10f);
        }
        Debug.Log("Rotate event");
    }
    void Revolve()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform)
                this.transform.RotateAround(hit.transform.position, Vector3.up, 20f * Time.deltaTime);
        }
        Debug.Log("Revolve event");
    }
    void OnDisable()
    {
        OnClick -= Rotate;
        OnClick -= Revolve;
    }

}