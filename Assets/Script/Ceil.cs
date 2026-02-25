using UnityEngine;
using UnityEngine.UIElements;

public class Ceil : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    [Range(1,10)]
    private float pos=3;


    [SerializeField]
    [Range(1,10)]
    private float posLeft=1;

        [SerializeField]
    [Range(1,10)]
    private float posRight=1;

    // Update is called once per frame
    void Update()
    {

        //  transform.position = new Vector3(Mathf.Ceil(target.position.x*3),Mathf.Ceil(target.position.y*3), Mathf.Ceil(target.position.z*3));
        transform.position = new Vector3(
            Mathf.Clamp(target.position.x *  pos, -posLeft, posRight),
            Mathf.Clamp(target.position.y * pos, -posLeft, posRight),
             Mathf.Clamp(target.position.z *pos, -posLeft, posRight));

    }
}
