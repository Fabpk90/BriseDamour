using UnityEngine;

public class LetterCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        transform.gameObject.SetActive(false);
    }
}
   
