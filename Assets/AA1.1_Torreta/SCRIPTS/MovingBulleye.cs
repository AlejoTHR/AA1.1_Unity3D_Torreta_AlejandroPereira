using Unity.VisualScripting;
using UnityEngine;

public class MovingBulleye : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public float Speed = 1;

    private void Update()
    {
        if (transform.position == A.position)Vector3.Lerp(transform.position, B.position, Speed);

        Vector3.Lerp(transform.position, A.position, Speed);


    }





}
