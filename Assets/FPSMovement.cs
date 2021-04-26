using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    private Rigidbody _rb;
    
    [SerializeField] 
    private float _speed;

    

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xWalk = Input.GetAxisRaw("Horizontal");

        float zWalk = Input.GetAxisRaw("Vertical");

        Vector3 moveBy = transform.right * xWalk + transform.forward * zWalk;

        // Move the rigidbody (player)
        _rb.MovePosition(transform.position + moveBy.normalized * _speed * Time.deltaTime);

        
    }
}
