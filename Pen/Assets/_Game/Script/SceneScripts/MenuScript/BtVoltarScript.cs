using UnityEngine;
using _Game.Script.Common;
using _Game.Script.Data;

namespace _Game.Script.SceneScripts.MenuScript
{
    
    public class BtVoltarScript : BasePainelAction
    {
        [SerializeField] private GameObject Menu;
        [SerializeField] private GameObject Option;



       public void CallMenu()
        {
            
            //GameSaveLoad.Save(); falta criar o data
            ActionMenu(Menu,Option);
            
        }
    }
}