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

   [SerializeField]
   private int size=50;
    [SerializeField]
    [Range(20,50)]
   private int border=20;

    void Start()
    {
        for(int i = 0; i < size; i++) {
         Vector3 position = new Vector3(Random.Range(-border,border),0.5f,Random.Range(-border,border));
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

    public Coin GetClosest(Vector3 point)
    {
        float minDistans = Mathf.Infinity;
        Coin closestCoin=null;
        for(int i = 0; i < coins.Count; i++) {
            float distans = Vector3.Distance(point,coins[i].transform.position);
            if (distans < minDistans)
            {
                minDistans = distans;
                closestCoin=coins[i];
            }

        }
        return closestCoin;
    }
    
}
