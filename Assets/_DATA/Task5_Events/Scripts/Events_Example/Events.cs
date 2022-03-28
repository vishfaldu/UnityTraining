using UnityEngine;
public class Events : MonoBehaviour
{
    public delegate void testDelegate();
    testDelegate test;
    public static testDelegate test2;
    void OnEnable()
    {
        test += myFunction1;
        test += myFunction2;
        test2 += myFunction3;
    }
    void Start()
    {
        test2();
    }

    void Update()
    {
        test();
    }

    void myFunction1()
    {
        Debug.Log("First function");
    }

    void myFunction2()
    {
        Debug.Log("Second function");
    }

    void myFunction3()
    {
        Debug.Log("Third function");
    }
    void OnDisable()
    {
        test -= myFunction1;
        test -= myFunction2;
        test2 -= myFunction3;
    }
}
