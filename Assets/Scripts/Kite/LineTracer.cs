using UnityEngine;

public class LineTracer : MonoBehaviour
{
    private LineRenderer line;
    public int pointsNumber = 4;
    public Transform[] objects;
    private Vector3[] points;

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        points = new Vector3[pointsNumber];
        for (int i = 0; i < pointsNumber; i++)
        {
            points[i] = objects[i].position;
        }

        line.positionCount = pointsNumber;
        line.SetPositions(points);
    }
}
