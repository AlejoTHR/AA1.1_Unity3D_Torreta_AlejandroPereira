using UnityEngine;


public class TurretAmmo : MonoBehaviour
{

    [SerializeField] Rigidbody _rb;
    
    public float BulletSpeed;

    private TorretMovement _Aim;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.linearVelocity = _Aim._PivotCanon.forward * BulletSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
