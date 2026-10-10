using UnityEngine;

public class TorretAmmo : MonoBehaviour
{

    public Rigidbody _rb;
    public GameObject _BrokenBulleye;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
