using UnityEngine;
using UnityEngine.UI;
public class UIandCamera : MonoBehaviour
{
    public Canvas canvas;
    public Camera[] cam;
    public Toggle toggle;
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

    void OnMouseDrag()
    {
        if (toggle.isOn == false)
        {
            transform.position = cam[1].ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, cam[1].WorldToScreenPoint(transform.position).z));
            Debug.Log(transform.position);
        }
        else
        {
            transform.position = cam[0].ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, cam[0].WorldToScreenPoint(transform.position).z));
            Debug.Log(transform.position);
        }
    }
}