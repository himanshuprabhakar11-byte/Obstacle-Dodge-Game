using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float speed = 0f;

    Vector3 playerPosition;
    
    void Start()
    {
        playerPosition = player.transform.position;
    }

    
    void Update()
    {
        MoveAtPlayer();
     
       
    }

    void MoveAtPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
       
           Destroy(gameObject);

        }
    }
}
