using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace _Game.Script.Pin
{
    public class PinScript : PinBase
    {
        protected override void Start()
        {
            base.Start();
        }


        private void Update()
        {
            Shot();
        }


        private void Shot()
        {
            if(!isPinded)
            rigidbody2.MovePosition(rigidbody2.position + Vector2.up * speed * Time.deltaTime);
        }


        protected override void OnTriggerEnter2D(Collider2D other)
        {
            base.OnTriggerEnter2D(other);
        }
    }
}