using UnityEngine;



public class Player : MonoBehaviour
{   [SerializeField]
    private Creator Creator;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            Creator.CollectCoin(other.GetComponent<Coin>());
        }
    }
}
