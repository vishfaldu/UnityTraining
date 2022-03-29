using UnityEngine;
using System.Collections;
public class cubeEventCor : MonoBehaviour
{
    public delegate IEnumerator eventDelegate();
    public static eventDelegate OnClick;
    void OnEnable()
    {
        OnClick += MyCoroutine1;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube")
                    foreach (eventDelegate handler in OnClick.GetInvocationList())
                    {
                        StartCoroutine(handler.Invoke());
                        //StartCoroutine(OnClick());
                    }
            }
        }
    }
        IEnumerator MyCoroutine1()
        {
            yield return null;
            Debug.Log("Coroutine1: Center cube rotation");
            transform.Rotate(Vector3.up);
        }
        void OnDisable()
        {
            OnClick -= MyCoroutine1;
        }
    }