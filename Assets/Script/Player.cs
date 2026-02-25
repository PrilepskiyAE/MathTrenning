using UnityEngine;

public class Player : MonoBehaviour
{   [SerializeField]
    private Creator cr;
    public float scaleStep = 0.1f;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            cr.CollectCoin(other.GetComponent<Coin>());
            transform.localScale += new Vector3(scaleStep, scaleStep, scaleStep);
        }
    }
}
