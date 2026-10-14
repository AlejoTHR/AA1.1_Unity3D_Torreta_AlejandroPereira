using TreeEditor;
using UnityEngine;

public class CameraCollisions : MonoBehaviour
{

    public GameObject _ToMove;

    public Vector3 hitPosition;
    public float Distance;


    private void Update()
    {
        RaycastHit hit;

        Physics.Raycast(transform.position, -transform.forward, out hit, Distance);
        Debug.Log(Physics.Raycast(transform.position, -transform.forward, out hit, Distance));

        if (Physics.Raycast(transform.position, -transform.forward, out hit, Distance))
        {
            hitPosition = hit.point;
        }
        else
        {
            hitPosition = transform.position - transform.forward * Distance;
        }


        _ToMove.transform.position = hitPosition;

    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, -transform.forward);
        

    }



}
