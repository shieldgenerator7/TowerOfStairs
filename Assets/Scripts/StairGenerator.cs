using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairGenerator : MonoBehaviour
{
    public int stairCount = 10;
    public float distanceOut = 2.7f;
    public GameObject center;
    public GameObject container;

    public float startY = 0;
    public float startAngle = 0;

    public float yIncrement = 0.15f;
    public float angleIncrement = 0.15f;

    public GameObject stairPrefab;

    public float nextY = 0;
    public float nextAngle = 0;
    
    public void generate()
    {
        nextY = startY;
        nextAngle = startAngle;
        for (int i = 0; i < stairCount; i++)
        {
            GameObject stair = Instantiate(stairPrefab);
            SatelliteUpdater su = stair.GetComponent<SatelliteUpdater>();
            su.distanceOut = distanceOut;
            su.center = center;
            Vector3 pos = su.transform.position;
            pos.y = nextY;
            su.transform.position = pos;
            su.angleOffset = nextAngle;
            su.position();
            su.transform.parent = container.transform;

            //
            nextY += yIncrement;
            nextAngle += angleIncrement;
        }
    }
}
