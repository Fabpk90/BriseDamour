using UnityEngine;

public class LetterCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.GetComponent<MeshRenderer>().enabled = false;
    }
}
   
