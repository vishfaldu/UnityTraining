using UnityEngine;
using System.Collections.Generic;
public class test : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    LineRenderer lineRenderer;
    public int vertices;
    public List<GameObject> arrayPrefab;
    //Vector3[] pos = new Vector3[arrayPrefab.Count];
    Vector3 pos = new Vector3();

    private void Start()
    {
        prefab = Resources.Load("Point") as GameObject;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = vertices;
        GameObject tempPrefab;
        //int total_angle = (vertices - 3) * 180 + 180;
        //int angle_change = total_angle / vertices;
        int angle_change = ((180 / vertices) * (vertices - 2));
        float direction = (Mathf.Cos(angle_change * Mathf.Deg2Rad));
        //Debug.LogError(direction);
        Debug.LogError("Cos: " + Mathf.Cos(180 * Mathf.Deg2Rad));
        Debug.LogError("Sin: " + Mathf.Sin(360 * Mathf.Deg2Rad));

        for (int i = 0; i < vertices; i++)
        {
            if (vertices < 3)
                Debug.LogError("vertices must be more than 2");
            else
            {
                tempPrefab = Instantiate(prefab, pos, Quaternion.identity);        //as Gameobject??
                arrayPrefab.Add(tempPrefab);
                //lineRenderer.SetPosition(i, pos[i]);
                if (i == 0)
                {
                    lineRenderer.SetPosition(i, arrayPrefab[i].transform.position);
                    arrayPrefab[i].transform.position = Vector3.zero;
                    lineRenderer.SetPosition(i, arrayPrefab[i].transform.position);
                    continue;
                }

                else if (i == 1)
                {
                    arrayPrefab[i].transform.position = new Vector3(1, 0, 0);
                    continue;
                }
                else if (i == 2)
                {
                    arrayPrefab[i].transform.position = new Vector3(direction, 1, 0);
                    continue;
                }
                else if (i == 3)
                {
                    arrayPrefab[i].transform.position = new Vector3(Mathf.Abs(direction) + 1, 1, 0);
                    continue;
                }
                direction = (Mathf.Cos((angle_change / 2) * Mathf.Deg2Rad));
                arrayPrefab[i].transform.position = new Vector3(Mathf.Abs(direction), direction + 1, 0);
            }
        }
        /*
        if (vertices % 2 == 0)
        {
            for (int j = 0; j < vertices - 4; j++)
            {
                arrayPrefab[i].transform.position = new Vector3(direction, i, 0);
                lineRenderer.SetPosition(i, arrayPrefab[i].transform.position);
            }
        }
        */
    }
}

