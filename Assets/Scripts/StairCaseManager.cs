using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairCaseManager : MonoBehaviour
{

    public float spiralXPosition = 0;

    public List<Rotator> rotators;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Rotator rot in rotators)
        {
            Vector3 rotation = rot.transform.eulerAngles;
            rotation.y = spiralXPosition;
            rot.transform.eulerAngles = rotation;
        }
    }
}
