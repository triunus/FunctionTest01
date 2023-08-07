using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectSystem
{
    [System.Serializable]
    public class StageReference
    {
        [SerializeField]
        private StageDB stageDB_;

        public StageDB StageDB
        {
            get 
            {
                if (this.stageDB_ == null)
                {
                    this.stageDB_ = ScriptableObjectSingleton<StageDB>.Instance;
                }
                return this.stageDB_;
            }
            set
            {
                this.stageDB_ = value;
            }
        }
    }
}