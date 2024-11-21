using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject bullet, bullet2, bullet3, bullet4;

    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            // bullets = GetComponent<GameObject>();
            bullet.SetActive(true);
            bullet2.SetActive(true);
            bullet3.SetActive(true);
            bullet4.SetActive(true);
            Destroy(gameObject);
        }
    }
}
