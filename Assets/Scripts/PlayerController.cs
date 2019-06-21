using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50;

    public StairCaseManager stairCase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            stairCase.spiralXPosition += moveSpeed * horizontal * Time.deltaTime;
        }
    }
}
