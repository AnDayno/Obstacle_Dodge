using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [SerializeField] Material material;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material.color = material.color;
        Debug.Log("Something hit the object: " + collision.gameObject.name);
    }
}
