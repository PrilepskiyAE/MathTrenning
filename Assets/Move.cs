using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private AudioSource stepsAudio;
    
    [SerializeField]
    [Range(3,10)]
    float speed;
    private Rigidbody rb;

    void Start()
    {
       rb= GetComponent<Rigidbody>();
    }

 void FixedUpdate() 
    {
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector3(horizontal*speed,0f,0f);
        stepsAudio.volume = Mathf.Abs(horizontal);
    }
}
