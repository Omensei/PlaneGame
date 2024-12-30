using UnityEngine;
using UnityEngine.InputSystem;

namespace Shmup
{
    [RequireComponent(typeof(PlayerInput))]
    public class InputReader : MonoBehaviour {

        // NOTE: Make sure to set the player Input component to c# events

        PlayerInput input;
        InputAction moveAction;

        public Vector2 Move => moveAction.ReadValue<Vector2>();

        void Start ()
        {
            input = GetComponent<PlayerInput>();
            moveAction = input.actions["Move"];
        }


    
    
    }



}
