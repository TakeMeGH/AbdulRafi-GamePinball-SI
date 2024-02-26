using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallPosition : MonoBehaviour
{
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            transform.position = startPosition;
        }
    }
}
