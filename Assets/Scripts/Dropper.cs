using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToDrop = 3f;
    private bool hasDropped = false;
    private MeshRenderer meshRenderer;
    private Rigidbody rigidbody;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false; // Hide the mesh renderer at the start
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    void Update()
    {
        //Debug.Log($"{Time.time} - {gameObject.name} is updating");
        if( Time.time > timeToDrop && !hasDropped)
        {
            Drop();
            hasDropped = true;
        }   
    }
    void Drop()
    {
        meshRenderer.enabled = true;
        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;
    }
}
