using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventFromOther : MonoBehaviour
{

    void OnEnable()
    {
        Events.test2 += myFunction;
    }
    void Start()
    {

    }

    void Update()
    {
        Events.test2();
    }

    void myFunction()
    {
        Debug.LogError("I'm from other script ;)");
    }
    void OnDisable()
    {
        Events.test2 += myFunction;
    }
}
