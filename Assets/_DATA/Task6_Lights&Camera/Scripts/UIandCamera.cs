using UnityEngine;
using UnityEngine.UI;
public class UIandCamera : MonoBehaviour
{
    public Canvas canvas;
    public Camera[] cam;
    public Toggle toggle;
    void Update()
    {
        //Zooming with mouse-scroll
        Debug.Log(Input.mouseScrollDelta);
        if (toggle.isOn == false)
            cam[1].transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel"));
        else
            cam[0].transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel"));
    }
    public void OnToggle()
    {
        if (toggle.isOn == false)
        {
            cam[0].enabled = false;
            cam[1].enabled = true;
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = cam[1];
            cam[1].targetDisplay = 0;
            Debug.Log("Do something");
        }
        else
        {
            cam[0].enabled = true;
            cam[1].enabled = false;
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = cam[0];
            cam[0].targetDisplay = 0;
            Debug.Log("Do something not");
        }
    }

    public void OnZoomIn()
    {
        if (toggle.isOn == false)
        {
            cam[1].transform.Translate(0, 0, 1);
            Debug.Log("ZoomIn");
        }
        else
            cam[0].transform.Translate(0, 0, 1);
    }
    public void OnZoomOut()
    {
        if (toggle.isOn == false)
        {
            cam[1].transform.Translate(0, 0, -1);
            Debug.Log("ZoomOut");
        }
        else
            cam[0].transform.Translate(0, 0, -1);
    }
}