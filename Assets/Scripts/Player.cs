using UnityEngine;




namespace SingleResponsibility
{
    [RequireComponent(typeof(PlayerAudio), typeof(PlayerInput),typeof(PlayerMovement))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerAudio playerAudio;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private PlayerMovement playerMovement;

        void Start()
        {
            playerAudio = GetComponent<PlayerAudio>();
            playerInput = GetComponent<PlayerInput>();
            playerMovement = GetComponent<PlayerMovement>();
        }
    }

    public class PlayerAudio : MonoBehaviour
    {

    }
    public class PlayerInput : MonoBehaviour
    {

    }
    public class PlayerMovement : MonoBehaviour
    {

    }
}

