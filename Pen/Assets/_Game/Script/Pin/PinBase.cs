using UnityEngine;
using _Game.Script.Common;

namespace _Game.Script.Pin
{
    public class PinBase : MonoBehaviour
    {
        [SerializeField] protected float speed = 20f;
        protected Rigidbody2D rigidbody2;

        protected bool isPinded = false;

        protected virtual void Start()
        {
            rigidbody2 = GetComponent<Rigidbody2D>();
        }

        /// <summary>
        /// Set Speed Pin
        /// </summary>
        /// <param name="value"></param>
        public void SetSpeed(float value)
        {
            this.speed = value;
        }


        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag.Equals("Ball"))
            {
                transform.SetParent(other.transform);
                isPinded = true;
                FindObjectOfType<ScoreManagerScript>().SetScore();
            }
            else if(other.tag.Equals("Pin"))
            {
                print("OK");
                FindObjectOfType<ManagerGamerScript>().EndGame();
            }
        }
    }
}