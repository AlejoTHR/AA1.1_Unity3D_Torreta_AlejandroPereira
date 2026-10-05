using UnityEngine;


public class TurretAmmo : MonoBehaviour
{

    [SerializeField] Rigidbody _rb;
    public float BulletSpeed;



    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        //_rb.linearVelocity = Vector3.up * BulletSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
