using System;
using System.IO;

using UnityEngine;

namespace JsonSystem
{

    public class JsonReadingSingleton<T> where T : JsonObject
    {
        private static TextAsset jsonString;

        // this.instance_가 아닌, JsonObjectSingleton<T>을 사용하는 이유는,
        // 서로 다른 타입의 T의 instance_를 구별하기 위해서이다.
        public static TextAsset ReadingJsonFile
        {
            get
            {                
                // 기존에, 해당 타입으로 구한 jsonString가 존재하지 않을 때 = true
                if (JsonReadingSingleton<T>.jsonString == null)
                {
                    Debug.Log("JsonData/" + typeof(T).ToString());
                    JsonReadingSingleton<T>.jsonString = Resources.Load("JsonData/" + typeof(T).ToString()) as TextAsset;
                }

                Debug.Log("Result Reading JsonFile : " + jsonString);
                return JsonReadingSingleton<T>.jsonString;
            }
        }

/*        public static TextAsset ReadingJsonFileFromLocal
        {
            get
            {
                // 기존에, 해당 타입으로 구한 jsonString가 존재하지 않을 때 = true
                if (JsonReadingSingleton<T>.jsonString == null)
                {
                    Debug.Log("JsonData/" + typeof(T).ToString());
                    JsonReadingSingleton<T>.jsonString = Resources.Load("JsonData/" + typeof(T).ToString()) as TextAsset;
                }

                Debug.Log("Result Reading JsonFile : " + jsonString);
                return JsonReadingSingleton<T>.jsonString;
            }
        }
    }

    public class ConvertJsonToTextAsset
    {
        public static TextAsset ReadJsonFile(string path)
        {
            byte[] array = Read(path);

            Stream stream = new MemoryStream(Read(path), 0, array.Length);


            byte[] array = this.Read(path);
            return new MemoryStream(this.Read(path), 0, array.Length);

            using (Stream stream = )
        }*/
    }
}
