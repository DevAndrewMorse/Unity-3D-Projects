using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropController : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private float _waitTime = 5f;

    MeshRenderer _mesh;
    Rigidbody _rigidbody;

    #endregion Fields

    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _mesh = GetComponent<MeshRenderer>();
        _mesh.enabled = false;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _waitTime)
        {
            _mesh.enabled = true;
            _rigidbody.useGravity = true;
        }
    }

    #endregion Methods
}
