using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public PlayerMovement movement;

    void OnTriggerEnter ()
    {
        movement.enabled = false;
        FindObjectOfType<GameManager>().Finish();
    }
}
