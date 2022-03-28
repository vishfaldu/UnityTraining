using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherCubeEvent : MonoBehaviour
{
    public GameObject target;
    void OnEnable()
    {
        cubeEvent.OnClick += Revolve;
    }
    void Update()
    {
        cubeEvent.OnClick();
    }
    void Revolve()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 50f * Time.deltaTime);
        Debug.Log("Revolves");
    }
    void OnDisable()
    {
        cubeEvent.OnClick -= Revolve;
    }
}
