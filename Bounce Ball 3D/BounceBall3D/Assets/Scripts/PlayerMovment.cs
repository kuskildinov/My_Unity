using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BounceBallInput
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(PlayerInputScript))]

    public class PlayerMovment : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private float jumpForce = 5.0f;
        private Rigidbody playerRb;
        private Vector3 movement;
        private Vector3 jumpVector = new Vector3(0,1,0);
        private bool jump;
        private bool characterOnFloor = true;
        private PlayerInputScript inputs;
        private Animator anim;

        private void Awake()
        {
            playerRb = GetComponent<Rigidbody>();
            inputs = GetComponent<PlayerInputScript>();
            anim = GetComponent<Animator>();
        }
        void FixedUpdate()
        {
            movement = inputs.movement;
            jump = inputs.jump;
            MoveCharacter(movement);
            if(jump && characterOnFloor)
            {
                JumpCharacter();
                characterOnFloor = false;
                
            }

        }

        /// <summary>
        /// Передвижение игрока в опредененном направлении
        /// </summary>
        /// <param name="movement"></param>
        void MoveCharacter(Vector3 movement)
        {
            playerRb.AddForce(movement.normalized * speed);
        }

        /// <summary>
        /// Прыжок игрока
        /// </summary>
        void JumpCharacter()
        {
            playerRb.AddForce(jumpVector.normalized * jumpForce, ForceMode.Impulse);
            anim.SetBool("jump", true);
        }

        /// <summary>
        /// Метод, проверяющий что игрок стоит на полу
        /// </summary>
        /// <param name="collision"></param>
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag =="floor")
            {
                characterOnFloor = true;
                anim.SetBool("jump", false);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "nextLevelZone")
            {
                Debug.Log("Level");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

#if UNITY_EDITOR
        [ContextMenu("Reset values")]
     public void ResetValues()
        {
            speed = 2.0f;
        }
#endif
    }
}
