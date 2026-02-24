using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Creator : MonoBehaviour
{
    [SerializeField]
    private GameObject coinPrefab;
    [SerializeField]
    private Text text;
    [SerializeField]
    private List<Coin> list = new List<Coin>();
    private int size = 50; 
    void Start()
    {

        for(int i = 0; i < size; i++) {
        Vector3 position = new Vector3(Random.Range(-20,20),0.5f,Random.Range(-20,20));
        GameObject nC = Instantiate(coinPrefab,position,Quaternion.identity);
        list.Add(nC.GetComponent<Coin>());   
        }
        text.text="Осталось собрать "+list.Count.ToString();
    }

    public void CollectCoin(Coin coin)
    {
        list.Remove(coin);
        Destroy(coin.gameObject);
        text.text="Осталось собрать "+list.Count.ToString();
    }


}
