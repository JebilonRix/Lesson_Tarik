using UnityEngine;

namespace Lesson
{
    [RequireComponent(typeof(BoxCollider))]
    public class GunTouchHandler : MonoBehaviour
    {
        [SerializeField] private Gun gun;

        private void Start()
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }

            GunMethods.CheckGun(other.GetComponentInChildren<GunHandler>(), gun);

            gameObject.SetActive(false);
        }
    }
}