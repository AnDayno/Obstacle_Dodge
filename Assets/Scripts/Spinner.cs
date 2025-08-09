using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
