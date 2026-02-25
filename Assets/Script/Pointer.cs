using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField]
    private Creator creator;

    [SerializeField]
    private Coin closestCoin;

    [SerializeField]
    private float rotationSpeed = 2f;

    [SerializeField]
    private Transform playerTransform;

    void Update()
    {
         transform.position = playerTransform.position;      
        closestCoin = creator.GetClosest(transform.position);
        Debug.DrawLine(transform.position,closestCoin.transform.position);
        
        Vector3 directionToCoin = closestCoin.transform.position - transform.position;

        directionToCoin.y = 0;

        if (directionToCoin != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(directionToCoin);

            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime * Mathf.Rad2Deg
            );
        }
    }
}
