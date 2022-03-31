using UnityEngine;
using UnityEngine.UI;
public class playerMoves : MonoBehaviour
{
    public Toggle toggle;
    public Camera[] cam;
    void Start()
    {

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
