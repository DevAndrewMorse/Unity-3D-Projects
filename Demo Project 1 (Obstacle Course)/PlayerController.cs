using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields

    [SerializeField]
    float _moveSpeed = 10f;
    const string HORIZONTAL = "Horizontal";
    const string VERTICAL = "Vertical";

    #endregion Fields

    #region Methods

    // Callback: Start is called before the first frame update
    void Start()
    {
        
    }

    // Callback: Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        //User input
        float xValue = Input.GetAxis(HORIZONTAL) * Time.deltaTime * _moveSpeed;
        float zValue = Input.GetAxis(VERTICAL) * Time.deltaTime * _moveSpeed;

        transform.Translate(xValue, 0f, zValue);
    }

    #endregion Methods
}
