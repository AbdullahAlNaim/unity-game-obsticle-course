using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    [SerializeField] MeshRenderer myMeshRenderer;
    [SerializeField] Rigidbody myRigidBody;

    void start() 
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
    }
    void Update()
    {
        // DropperTime();
        if (Time.time > timeToWait)
        {
            Debug.Log("I'M FALLING!!!!!!!!");
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }

    // void DropperTime()
    // {
    //     if (Time.time > timeToWait)
    //     {
    //         Debug.Log("I'M FALLING!!!!!!!!");
    //         myMeshRenderer.enabled = true;
    //         myRidgidBody.useGravity = true;
    //     }
    // }
}
