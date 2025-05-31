using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Collision detected with: " + collision.gameObject.name);
        if( collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit"; 
        }   
    }

}
