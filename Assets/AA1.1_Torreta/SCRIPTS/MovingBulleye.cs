using Unity.VisualScripting;
using UnityEngine;

public class MovingBulleye : MonoBehaviour
{
    public Transform A;
    public Transform B;
    [SerializeField] Vector3 Next;
    public float Speed = 1;



    private void Start()
    {
        Next = B.position;
    }

    private void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, Next, Speed*Time.deltaTime);

        if (transform.position == Next) Next = (Next == A.position) ? B.position : A.position;



    }





}
