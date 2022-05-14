using UnityEngine;

namespace KID
{
    public class SpawnChicken : MonoBehaviour
    {
        [SerializeField]
        private GameObject goChicken;
        [SerializeField]
        private Transform traSpawnPoint;

        public void SpawnChickenObject()
        {
            Instantiate(goChicken, traSpawnPoint.position, Quaternion.identity);
        }
    }
}

