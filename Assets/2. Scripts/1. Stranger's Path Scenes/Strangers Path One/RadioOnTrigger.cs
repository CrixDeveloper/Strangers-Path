using System.Collections;
using UnityEngine;

public class RadioOnTrigger : MonoBehaviour
{
    #region Variables to use: 

    [Header("References: ")]
    public AudioSource radioOnClip;

    #endregion

    #region Methods to use: 

    private void OnTriggerEnter(Collider other)
    {
        radioOnClip.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        radioOnClip.Stop();
    }

    #endregion
}
