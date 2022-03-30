using UnityEngine;
using UnityEngine.UI;
public class toggleCam : MonoBehaviour
{
    Button button;
    public Canvas canvas;
    public Camera[] cam;
    bool isOn = true;
    void Start()
    {
        //cam = GetComponent<Camera>();
        button = GetComponent<Button>();

    }
    public void OnToggle()
    {
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        //canvas.worldCamera = cam[0];
        Debug.Log("CLICK");
    }
}
