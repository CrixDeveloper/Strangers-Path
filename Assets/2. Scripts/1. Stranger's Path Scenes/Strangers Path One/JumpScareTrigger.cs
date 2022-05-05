using System.Collections;
using UnityEngine;

public class JumpScareTrigger : MonoBehaviour
{
    #region Variables to use: 

    [Header("References: ")]
    public GameObject fpsPlayerCamera;
    public GameObject jumpScareCamera;
    public GameObject flashImage;
    public AudioSource jumpScareSound;
    public AudioSource scaredBreathSound;
    public AudioSource jumpScareScreamSound;

    #endregion

    #region Methods to use: 

    private void OnTriggerEnter(Collider other)
    {
        jumpScareSound.Play();
        jumpScareScreamSound.Play();
        jumpScareCamera.SetActive(true);
        fpsPlayerCamera.SetActive(false);
        flashImage.SetActive(true);
        StartCoroutine(EndJumpScare());
    }

    private IEnumerator EndJumpScare()
    {
        yield return new WaitForSeconds(2.2f);
        scaredBreathSound.Play();
        fpsPlayerCamera.SetActive(true);
        jumpScareCamera.SetActive(false);
        flashImage.SetActive(false);
        this.GetComponent<BoxCollider>().enabled = false;
    }
    #endregion
}
