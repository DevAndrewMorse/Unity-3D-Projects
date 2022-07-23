using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields

    Rigidbody _rigidBody;
    [SerializeField]
    private float _thrustAmt = 1000f;
    [SerializeField]
    private float _rotationAmt = 100f;

    #endregion Fields

    #region Methods

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();     
    }

    // Update is called once per frame
    private void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            _rigidBody.AddRelativeForce(Vector3.up * _thrustAmt * Time.deltaTime);
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-_rotationAmt);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(_rotationAmt);
        }
    }

    private void ApplyRotation(float rotationAmt)
    {
        transform.Rotate(Vector3.forward * rotationAmt * Time.deltaTime);
    }

    #endregion Methods
}
