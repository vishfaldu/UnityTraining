using UnityEngine;
using System.Collections;
public class otherCubeEventCor : MonoBehaviour
{
    public GameObject target;
    void OnEnable()
    {
        cubeEventCor.OnClick += MyCoroutine2;
    }
    IEnumerator MyCoroutine2()
    {
        yield return null;
        Debug.Log("Coroutine2: revolving cubes");
        transform.RotateAround(target.transform.position, Vector3.up, 50f * Time.deltaTime);
    }
    void OnDisable()
    {
        cubeEventCor.OnClick += MyCoroutine2;
    }
}