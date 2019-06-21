using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteUpdater : MonoBehaviour
{
    public GameObject center;
    public float angleOffset = 0;
    public float distanceOut = 11;

    private Vector3 basePosition;
    public Vector3 BasePosition
    {
        get
        {
            if (basePosition == Vector3.zero)
            {
                basePosition = center.transform.position;
                basePosition.y = transform.position.y;
            }
            return basePosition;
        }
    }

    private Collider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
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
        transform.position = BasePosition + 
            distanceOut * center.transform.forward.RotateY(angleOffset);
        coll.enabled = transform.position.z <= 0;
    }
}
