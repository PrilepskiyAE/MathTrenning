using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creator : MonoBehaviour
{
   [SerializeField]
   private GameObject coinPrefab;
   [SerializeField]
   private List<Coin> coins = new List<Coin>();
   [SerializeField]
   private Text text; 

    void Start()
    {
        for(int i = 0; i < 50; i++) {
         Vector3 position = new Vector3(Random.Range(-20,20),0.5f,Random.Range(-20,20));
         GameObject nC = Instantiate(coinPrefab,position,Quaternion.identity);
         coins.Add(nC.GetComponent<Coin>());   
        }
        text.text = "Осталось собрать: " + coins.Count.ToString();
    }

    public void CollectCoin(Coin coin)
    {
        coins.Remove(coin);
        Destroy(coin.gameObject);
        text.text = "Осталось собрать: " + coins.Count.ToString();
    }
    
}
