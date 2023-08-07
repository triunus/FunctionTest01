using UnityEngine;

namespace ScriptableObjectSystem
{

        // T 클래스는 ScriptableObject를 상속받은 상태라는 것을 명시해준다.
    public class ScriptableObjectSingleton<T> : ScriptableObject where T : ScriptableObject
    {
        private static T instance_;

        protected virtual void UpdateData()
        {

        }

        // 초기화와 동시에, ScriptableObject 값을 가져온다.
        public static T Instance
        {
            get
            {
                if (ScriptableObjectSingleton<T>.instance_ == null)
                {
                    Debug.Log("ScriptableObject/" + typeof(T).ToString());
                    ScriptableObjectSingleton<T>.instance_ = Resources.Load<T>("ScriptableObject/" + typeof(T).ToString());

                    if (ScriptableObjectSingleton<T>.instance_ != null)
                    {
                        (ScriptableObjectSingleton<T>.instance_ as ScriptableObjectSingleton<T>).UpdateData();
                    }
                }
                return ScriptableObjectSingleton<T>.instance_;
            }
        }
    }
}
