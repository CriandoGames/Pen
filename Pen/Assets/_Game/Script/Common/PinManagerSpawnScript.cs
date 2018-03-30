using UnityEngine;

namespace _Game.Script.Common
{
    public class PinManagerSpawnScript : MonoBehaviour
    {
        public GameObject PinPrefabs;


        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SpawnPin();
            }
        }

        private void SpawnPin()
        {
            Instantiate(PinPrefabs, transform.position, transform.rotation);
        }
    }
}