using Unity.Cinemachine;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float Speed = 10f;
    Vector3 playerPosition;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }


    void Update()
    {

        DestroyWhenReached();
        MoveToPlayer();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * Speed);

    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            
            Destroy(gameObject);
        }
    }
   

}
