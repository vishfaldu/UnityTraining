using UnityEngine;
using UnityEngine.EventSystems;

public class EventLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool myBool;
    public GameObject player;

    void Update()
    {
        if (myBool)
            player.transform.Translate(Vector3.left * Time.deltaTime);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        myBool = true;
        Debug.Log("pointer down");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        myBool = false;
        Debug.Log("pointer up");
    }
}