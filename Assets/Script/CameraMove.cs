using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private Rigidbody playerRB;

    private List<Vector3> velosityList = new List<Vector3>();

    void Start()
    {
        for(int i = 0; i < 10; i++) {
            velosityList.Add(Vector3.zero);
        }
    }
    void FixedUpdate()
    {
        velosityList.Add(playerRB.linearVelocity);
        velosityList.RemoveAt(0);
    }
    void Update()
    {
        Vector3 summ = Vector3.zero;

        for(int i = 0; i < velosityList.Count; i++) {
         summ += velosityList[i];   
        }

        transform.position = playerTransform.position;   
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(summ), Time.deltaTime * 10); 
    }
}
