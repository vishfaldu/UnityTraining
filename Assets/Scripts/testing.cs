using System.Collections;
using UnityEngine;

public class testing : MonoBehaviour
{
    delegate IEnumerator myDel();
    myDel del;
    
    void OnEnable()
    {
        del += MyCoroutine;
    }
    void Update()
    {
        if(Input.anyKey)
            StartCoroutine(del());
    }
    IEnumerator MyCoroutine()
    {
        yield return null;
        transform.Rotate(Vector3.up);
    }
    void OnDisable()
    {
        del -= MyCoroutine;
    }
}
