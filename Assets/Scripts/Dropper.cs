using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToDrop = 3f;
    private bool hasDropped = false;
    private MeshRenderer meshRenderer;
    private Rigidbody rigidBody;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false; // Hide the mesh renderer at the start
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
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
        rigidBody.useGravity = true;
        rigidBody.isKinematic = false;
    }
}
