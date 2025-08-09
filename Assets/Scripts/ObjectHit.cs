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
        if (collision.gameObject.CompareTag("Player"))
        {
            meshRenderer.material.color = material.color;
            gameObject.tag = "Hit";
        }
    }
}
