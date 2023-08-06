using UnityEngine;

namespace JsonManager
{

    public class JsonReadingSingleton<T> where T : JsonStruct
    {
        private static TextAsset jsonString;

        // this.instance_가 아닌, JsonObjectSingleton<T>을 사용하는 이유는,
        // 서로 다른 타입의 T의 instance_를 구별하기 위해서이다.
        public static TextAsset ReadingJsonFile
        {
            get
            {
                Debug.Log("Before jsonString : " + jsonString);
                
                // 기존에, 해당 타입으로 구한 jsonString가 존재하지 않을 때 = true
                if (JsonReadingSingleton<T>.jsonString == null)
                {
                    Debug.Log("Null Checked");
                    JsonReadingSingleton<T>.jsonString = Resources.Load(typeof(T).ToString()) as TextAsset;
                }

                Debug.Log("After jsonString : " + jsonString);
                return JsonReadingSingleton<T>.jsonString;
            }

/*            get
            {
                // 기존에, 해당 타입으로 구한 instance_가 존재하지 않을 때 = true
                if(JsonReadingSingleton.instance_ == null)
                {
                    if (JsonReadingSingleton<T>.jsonString == null) Debug.Log("Before : is Null");

                    Debug.Log("Json name : " + typeof(T).ToString());

                    TextAsset jsonString = Resources.Load(typeof(T).ToString()) as TextAsset;
                    JArray jsonArray = JArray.Parse(jsonString.ToString());

                    for (int i = 0; i < jsonArray.Count; ++i)
                    {
                        JsonReadingSingleton<T>.jsonString.Add((jsonArray[i] as JObject).ToObject<T>());
                    }

                    if (JsonReadingSingleton<T>.jsonString == null) Debug.Log("Affter : is Null");

                    *//*                    if (JsonObjectSingleton<T>.instance_ != null)
                                        {
                                            (JsonObjectSingleton<T>.instance_ as JsonObjectSingleton<T>).UpdateData();
                                        }*//*
                }

                Debug.Log("a" + JsonReadingSingleton<T>.instance_);
                return JsonReadingSingleton<T>.instance_;
//                return JsonArraySingleton<T>.instance_.ConvertAll(temp => new T());
            }*/
        }
    }
}
