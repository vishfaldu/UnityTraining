using UnityEngine;
public class polygonLines : MonoBehaviour
{
    public int vertices;
    public GameObject[] point;
    float angleReq;
    [SerializeField] GameObject prefab;
    public LineRenderer lineRenderer;
    private void Start()
    {
        prefab = Resources.Load("Point") as GameObject;
        prefab = Instantiate(prefab, Vector3.one, Quaternion.identity);

        Vector3[] pos = new Vector3[point.Length];
        lineRenderer.positionCount = point.Length;
        angleReq = ((180 / vertices) * (vertices - 2));
        //float tanAngle = Mathf.Rad2Deg * (Mathf.Atan2(pointB.y - pointA.y, pointB.x - pointA.x));
        Vector3 targetDir = point[1].transform.position - transform.position;
        float angle = Vector3.Angle(targetDir, point[3].transform.position);

        for (int i = 0; i < vertices; i++)
            {
            if (vertices < 3f)
                Debug.LogError("Vertices must be more than or equal to 3!");
            else
            {
                pos[i] = point[i].transform.position;
                Debug.Log(pos[i]);
                lineRenderer.SetPosition(i, pos[i]);
            }
        }
    }
}
