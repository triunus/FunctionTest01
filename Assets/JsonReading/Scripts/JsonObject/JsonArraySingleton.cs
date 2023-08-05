using System;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json.Linq;

namespace JsonManager
{

    public class JsonArraySingleton<T> : JsonArray where T : JsonArray
    {

        private static List<T> instance_ = null;

        protected virtual void UpdateData()
        {

        }

        // this.instance_가 아닌, JsonObjectSingleton<T>을 사용하는 이유는,
        // 서로 다른 타입의 T의 instance_를 구별하기 위해서이다.
        public static List<T> Instance_JA
        {
            get
            {
                // 기존에, 해당 타입으로 구한 instance_가 존재하지 않을 때 = true
                if(JsonArraySingleton<T>.instance_ == null)
                {
                    if (JsonArraySingleton<T>.instance_ == null) Debug.Log("Before : is Null");

                    Debug.Log("Json name : " + typeof(T).ToString());

                    TextAsset jsonString = Resources.Load(typeof(T).ToString()) as TextAsset;
                    JArray jsonArray = JArray.Parse(jsonString.ToString());

                    for (int i = 0; i < jsonArray.Count; ++i)
                    {
                        JsonArraySingleton<T>.instance_.Add((jsonArray[i] as JObject).ToObject<T>());
                    }

                    if (JsonArraySingleton<T>.instance_ == null) Debug.Log("Affter : is Null");

                    /*                    if (JsonObjectSingleton<T>.instance_ != null)
                                        {
                                            (JsonObjectSingleton<T>.instance_ as JsonObjectSingleton<T>).UpdateData();
                                        }*/
                }

                Debug.Log("a" + JsonArraySingleton<T>.instance_);
                return JsonArraySingleton<T>.instance_;
//                return JsonArraySingleton<T>.instance_.ConvertAll(temp => new T());
            }
        }
    }
}
