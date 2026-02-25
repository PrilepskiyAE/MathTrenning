using UnityEngine;

public class MoveTowards1 : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private float targetY;

    private float _yAngle;
   
    void Update()
    {
    _yAngle=Mathf.MoveTowards(_yAngle,targetY,Time.deltaTime*rotationSpeed);
    transform.eulerAngles = new Vector3(0f,_yAngle,0f);
    }
}
