using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;
    private void Start()
    {
        Debug.Log("Initial Hits: " + hits);
    } 
    private void OnCollisionEnter(Collision collision)
    {   
        if( !collision.gameObject.CompareTag("Hit"))
        {
            hits++;
            Debug.Log($"You've bumped into a thing {hits} times");
        }
    }
}
