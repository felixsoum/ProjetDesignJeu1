using MoreMountains.CorgiEngine;
using UnityEngine;

public class TriggerCameraAnimation : MonoBehaviour
{
    [SerializeField] Animator cameraAnimator;
    [SerializeField] string triggerName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.gameObject.GetComponent<Character>())
        {
            cameraAnimator.SetTrigger(triggerName);
            gameObject.SetActive(false);
        }
    }
}
