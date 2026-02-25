using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Transform cameraChenter;
    [SerializeField]
    private float speed;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
            rb.maxAngularVelocity = 500f;
        }

    }

     private void FixedUpdate() {
        rb.AddTorque(cameraChenter.right*Input.GetAxis("Vertical")* speed);
         rb.AddTorque(-cameraChenter.forward*Input.GetAxis("Horizontal")*speed);      
    }
}
