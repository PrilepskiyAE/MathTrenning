using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Door : MonoBehaviour
{
    [SerializeField]
    private float minAngle;
    [SerializeField]
    private float maxAngle;

    [SerializeField]
    [Range(0,1)]
    private float value;


    // Update is called once per frame
    void Update()
    {
            
    // value += 0.01f * Time.deltaTime; 

   
    // if (value >= 1f)
    // {
    //     value = 0f;
    // }

    float pingPongValue = Mathf.PingPong(Time.time * 0.5f, 1f);
    
    value = 0.1f + pingPongValue * 0.9f;
        float zAngle = Mathf.Lerp(minAngle, maxAngle, value);
        transform.localEulerAngles = new Vector3(0f, 0f, zAngle);
    }
}
