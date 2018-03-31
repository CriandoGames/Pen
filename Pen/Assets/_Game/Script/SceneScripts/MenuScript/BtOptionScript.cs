using UnityEngine;
using _Game.Script.Common;

namespace _Game.Script.SceneScripts.MenuScript
{
    
    public class BtOptionScript : BasePainelAction
    {
        [SerializeField] private GameObject Menu;
        [SerializeField] private GameObject Option;



       public void CallOption()
        {
            ActionMenu(Menu,Option);
            
        }
    }
}