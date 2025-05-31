using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float x = 0.0f;
    [SerializeField] private float y = 1.0f;
    [SerializeField] private float z = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
