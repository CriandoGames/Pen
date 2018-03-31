using UnityEngine;
using _Game.Script.Pin;

namespace _Game.Script.Common
{
    public class ManagerGamerScript : ControlAnimationCamera
    {
        private bool hasEndGame = false;



        public override void Start()
        {
            base.Start();
        }

        public void EndGame()
        {
            if (hasEndGame)
                return;
            
            base.SetEndGame();
            rotate.enabled = false;
            pinScript.enabled = false;
            hasEndGame = true;
            
        }

        /// <summary>
        /// set True or False HasgAme
        /// </summary>
        public void SethasGame()
        {
            hasEndGame = true;
        }

        /// <summary>
        /// Return HasEndGame
        /// </summary>
        /// <returns></returns>
        public bool GetHasEndGame()
        {
            return this.hasEndGame;
        }
    }
}