using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using _Game.Script.Res;

namespace _Game.Script.Common
{
    public class BaseChanceScene : MonoBehaviour
    {
        [SerializeField] private EnumSceneNames NameScene;
        [SerializeField] protected float waitTime;


        public virtual void Start()
        {
            StartCoroutine(ChangeScene());
        }


        protected IEnumerator ChangeScene()
        {
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene(NameScene.ToString());
        }
    }
}