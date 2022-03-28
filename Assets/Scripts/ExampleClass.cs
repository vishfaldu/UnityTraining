using UnityEngine;
using UnityEngine.UI;

public class ExampleClass : MonoBehaviour
{
    public Transform target;
    public Button button;
    public Camera cam;
    Vector3 btnPos;


    void Start()
    {
        //cam = GetComponent<Camera>();
        Vector3 screenPos = cam.WorldToScreenPoint(target.transform.position);
        Debug.Log("World to screen pos of player: " + screenPos);
        btnPos = button.transform.position;
        btnPos = screenPos;
    }

    void Update()
    {
        Debug.Log(btnPos);
        button.transform.Translate(btnPos);

        /*
        Vector3 worldPos = cam.ScreenToWorldPoint(button.transform.position);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            button.transform.Translate(screenPos);
        }

        Debug.Log("Screen to world pos of UI: " + worldPos);
        Debug.Log(button.transform.position);
        */
    }
}