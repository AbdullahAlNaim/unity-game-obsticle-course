using UnityEngine;

public class Scorer : MonoBehaviour
{
    float hit = 0;
    private void OnCollisionEnter(Collision other) {
        hit += 1;
        Debug.Log(hit);
    }
}
