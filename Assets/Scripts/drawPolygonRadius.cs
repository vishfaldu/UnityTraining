using UnityEngine;
using System.Collections.Generic;
public class drawPolygonRadius : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> arrayPrefab;
    LineRenderer lineRenderer;
    public int vertices;
    public int radius = 1;
    float pi = 3.14f;

    Vector3 pos = new Vector3();
    Mesh mesh;
    private void Start()
    {
        prefab = Resources.Load("Point") as GameObject;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = vertices;
        GameObject tempPrefab;
        for (int i = 0; i < vertices; i++)
        {
            if (vertices < 3)
                Debug.LogError("Vertices should be more than 2!");
            else
            {
                tempPrefab = Instantiate(prefab, pos, Quaternion.identity);
                arrayPrefab.Add(tempPrefab);

                arrayPrefab[i].transform.position = new Vector3(radius * Mathf.Cos(2 * pi / vertices * i),
                0, radius * Mathf.Sin(2 * pi / vertices * i));
                lineRenderer.SetPosition(i, arrayPrefab[i].transform.position);
                //var x = radius * Mathf.Cos(2 * i * pi / vertices);
                //var y = radius * Mathf.Sin(2 * i * pi / vertices);
                //Debug.Log(Mathf.Cos((2 * i * pi / vertices)* Mathf.Deg2Rad));
                Debug.Log("Cos: " + radius * Mathf.Cos(2 * i * pi / vertices) + "  " + (2 * i * pi / vertices));
                Debug.Log("Sin: " + radius * Mathf.Sin(2 * i * pi / vertices) + "  " + (2 * i * pi / vertices));
            }
        }
    }
}