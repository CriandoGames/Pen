using UnityEngine;
using UnityEngine.Experimental.UIElements;
using _Game.Script.Common;

namespace _Game.Script.SceneScripts.MenuScript
{
    public class BtPlayScript : BaseChanceScene
    {
        public override void Start()
        {
            
        }


        public void StartGame()
        {
            StartCoroutine(ChangeScene());
        }
    }
}