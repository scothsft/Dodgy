using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();  
    }

    void DestroyWhenReached()
    {
        if (Vector3.Distance(transform.position, playerPosition) < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        transform.LookAt(Camera.main.transform);
        DestroyWhenReached();
    }
}
