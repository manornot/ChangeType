using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using UnityEngine;

namespace PG2
{
    static class ExtensionMethods
    {
        /// <summary>
        /// Rounds Vector3.
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name="decimalPlaces"></param>
        /// <returns></returns>
        public static Vector3 Round(this Vector3 vector3, int decimalPlaces = 0)
        {
            float multiplier = 1;
            for (int i = 0; i < decimalPlaces; i++)
            {
                multiplier *= 10f;
            }
            return new Vector3(
                Mathf.Round(vector3.x * multiplier) / multiplier,
                Mathf.Round(vector3.y * multiplier) / multiplier,
                Mathf.Round(vector3.z * multiplier) / multiplier);
        }

        public static Vector3 Ceil(this Vector3 vector3)
        {
            return new Vector3(
                Mathf.Ceil(vector3.x),
                Mathf.Ceil(vector3.y),
                Mathf.Ceil(vector3.z));
        }

        public static Vector3 Floor(this Vector3 vector3)
        {

            return new Vector3(
                Mathf.Floor(vector3.x),
                Mathf.Floor(vector3.y),
                Mathf.Floor(vector3.z));
        }

        public static bool LessThan(this Vector3 vector3a, Vector3 vector3b)
            => vector3a.x < vector3b.x && vector3a.y < vector3b.y && vector3a.z < vector3b.z;

        public static bool GreaterThan(this Vector3 vector3a, Vector3 vector3b)
            => vector3a.x > vector3b.x && vector3a.y > vector3b.y && vector3a.z > vector3b.z;
    
        public static Vector3 Max(this Vector3[] vec3Array )
        {
            Vector3 result = vec3Array[0];
            foreach(Vector3 vec in vec3Array)
            {
                if (result.x < vec.x)
                    result.x = vec.x;
                if (result.y < vec.y)
                    result.y = vec.y;
                if (result.z < vec.z)
                    result.z = vec.z;
            }
            return result;
        }

        public static Vector3 Min(this Vector3[] vec3Array)
        {
            Vector3 result = vec3Array[0];
            foreach (Vector3 vec in vec3Array)
            {
                if (result.x > vec.x)
                    result.x = vec.x;
                if (result.y > vec.y)
                    result.y = vec.y;
                if (result.z > vec.z)
                    result.z = vec.z;
            }
            return result;
        }
        
    }

    
}