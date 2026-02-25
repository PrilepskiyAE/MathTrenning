using UnityEngine;

public class SinCosEx : MonoBehaviour
{
    void Update()
    {
        transform.localPosition = new Vector3(0f,Mathf.Sin(Time.time),0f);
        transform.localScale = Vector3.one * (Mathf.Sin(Time.time * 10f) * 0.1f + 1);
    }
}
