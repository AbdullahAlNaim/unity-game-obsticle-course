using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 10f;
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
        MoveToPlayer();
        if (transform.position == playerPosition) 
        {
            DestroyWhenReached();
        }
    }

    void DestroyWhenReached()
    {
        Destroy(gameObject);
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
