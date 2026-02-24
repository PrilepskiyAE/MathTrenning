using UnityEngine;

public class Player : MonoBehaviour
{   [SerializeField]
    private Creator cr;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            cr.CollectCoin(other.GetComponent<Coin>());
        }
    }
}
