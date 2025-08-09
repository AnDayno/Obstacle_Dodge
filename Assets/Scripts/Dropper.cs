using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    void Update()
    {
        if (Time.time > timeToWait)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
