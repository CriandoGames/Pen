using UnityEngine;

namespace _Game.Script.Common
{
    public abstract class ControlAnimationCamera : MonoBehaviour
    {
        protected Animator animator;
        
                
        protected RotateBase rotate;
        protected PinManagerSpawnScript pinScript;

        public virtual void Start()
        {
            animator = GetComponent<Animator>();
            rotate = FindObjectOfType<RotateBase>();
            pinScript = FindObjectOfType<PinManagerSpawnScript>();
        }



        protected void SetEndGame()
        {
            animator.SetTrigger("EndGame");
        }
    }
}