using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    void Start()
    {
        MyCoroutine();
    }
    IEnumerator MyCoroutine()
    {
        Debug.Log("Hello world");
        yield return null;
    }

}
