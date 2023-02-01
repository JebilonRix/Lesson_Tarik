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

            Debug.Log($"Ateþ!! Kalan mermi = {gun.CurrentBulletsCount}");
        }

        public static void Reload(Gun gun)
        {
            //Mermi var mi? Yoksa ugrasma.
            if (gun.CurrentBulletsCount == gun.Magazine)
            {
                Debug.Log("Þarjör dolu.");
                return;
            }

            //Mermiyi fulle
            gun.CurrentBulletsCount = gun.Magazine;

            Debug.Log("Þarjör fullendi.");
        }

        public static void CheckGun(GunHandler handler, Gun gun)
        {
            //Silah listesini çektik.
            List<Gun> guns = handler.Guns;

            Debug.Log("Silah içindeki mermi sayýsý = " + gun.CurrentBulletsCount);

            for (int i = 0; i < guns.Count; i++)
            {
                //silah listede varsa mermi ekle yoksa silahý ekle.
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