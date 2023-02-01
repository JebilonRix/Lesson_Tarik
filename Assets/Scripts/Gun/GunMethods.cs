using System.Collections.Generic;
using UnityEngine;

namespace Lesson
{
    public static class GunMethods
    {
        public static void Shoot(Gun gun)
        {
            //Mermi var mi? Yoksa ugrasma.
            if (gun.CurrentBulletsCount <= 0)
            {
                Debug.Log("Mermi yok");
                return;
            }

            //Bir el ates et.
            gun.CurrentBulletsCount--;

            Debug.Log($"Ate�!! Kalan mermi = {gun.CurrentBulletsCount}");
        }

        public static void Reload(Gun gun)
        {
            //Mermi var mi? Yoksa ugrasma.
            if (gun.CurrentBulletsCount == gun.Magazine)
            {
                Debug.Log("�arj�r dolu.");
                return;
            }

            //Mermiyi fulle
            gun.CurrentBulletsCount = gun.Magazine;

            Debug.Log("�arj�r fullendi.");
        }

        public static void CheckGun(GunHandler handler, Gun gun)
        {
            //Silah listesini �ektik.
            List<Gun> guns = handler.Guns;

            Debug.Log("Silah i�indeki mermi say�s� = " + gun.CurrentBulletsCount);

            for (int i = 0; i < guns.Count; i++)
            {
                //silah listede varsa mermi ekle yoksa silah� ekle.
                if (guns[i].GunName == gun.GunName)
                {
                    guns[i].TotalBulletCount += gun.CurrentBulletsCount;
                    return;
                }
            }

            //Yok Ekle
            guns.Add(gun);
        }
    }
}