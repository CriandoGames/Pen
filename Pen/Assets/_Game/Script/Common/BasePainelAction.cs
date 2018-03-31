using  UnityEngine;


namespace _Game.Script.Common
{
    public  abstract class BasePainelAction : MonoBehaviour
    {
        
        

        protected void ActionMenu(GameObject PainelOne, GameObject PainelTwo)
        {
            if (PainelOne.activeSelf)
            {
                PainelOne.SetActive(false);
                PainelTwo.SetActive(true);
            }
            else
            {
                PainelTwo.SetActive(false);
                PainelOne.SetActive(true);
                
            }
        }

    }
}