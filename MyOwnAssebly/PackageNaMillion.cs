using UnityEngine;

namespace MyOwnAssebly
{
    public static class PackageNaMillion 
    {
        public static void AddPosX(this Transform t, float x)
        {
            Vector3 newPosition = new Vector3(x, 0, 0);
            t.position += newPosition;
        }
    }
    
}
