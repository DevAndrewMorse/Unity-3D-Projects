using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateController : MonoBehaviour
{
    #region Methods

    // Start is called before the first frame update
    void Start()
    {
        SetFrameRate();
    }

    /// <summary>
    /// Sets the framerate to the existing refreshrate of the user's screen.
    /// </summary>
    private void SetFrameRate()
    {
        Application.targetFrameRate = Screen.currentResolution.refreshRate;
    }

    #endregion Methods
}
