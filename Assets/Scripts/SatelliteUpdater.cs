using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteUpdater : MonoBehaviour
{
    public GameObject center;
    public float angleOffset = 0;
    public float distanceOut = 11;

    private Vector3 basePosition;

    // Start is called before the first frame update
    void Start()
    {
        basePosition = center.transform.position;
        basePosition.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        position();
    }

    /// <summary>
    /// Repositions this satellite to the correct location
    /// </summary>
    public void position()
    {
        transform.position = basePosition + 
            distanceOut * center.transform.forward.RotateY(angleOffset);
    }
}
