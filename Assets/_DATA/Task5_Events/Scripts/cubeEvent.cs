using UnityEngine;
public class cubeEvent : MonoBehaviour
{
    public delegate void eventDelegate();
    public static eventDelegate OnClick;
    void OnEnable()
    {
        OnClick += OnMouseDown;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            OnClick();
    }

    void OnMouseDown()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 50f);
        Debug.Log("tap!");
    }
    void OnDisable()
    {
        OnClick -= OnMouseDown;
    }
}
