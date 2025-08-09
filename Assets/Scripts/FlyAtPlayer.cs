 using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 0.1f;
    Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
;        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
