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
    public Collider2D Collider
    {
        get
        {
            if (coll == null)
            {
                coll = GetComponent<Collider2D>();
            }
            return coll;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
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
        Collider.enabled = transform.position.z <= 0;
    }
}
