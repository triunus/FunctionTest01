using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectSystem
{
    [CreateAssetMenu(fileName = "ScriptableObjectSystem_StageDB", menuName = "ScriptableObject System/StageDB")]
    public class StageDB : ScriptableObjectSingleton<StageDB>
    {
        [SerializeField]
        public List<Struct.Stage> stages_;

        public void ReSetting(List<Struct.Stage> stages_)
        {
            this.stages_.Clear();

            this.stages_ = stages_.ConvertAll(tmp => new Struct.Stage(stageNumber_: tmp.StageNumber, width_: tmp.Width, height_: tmp.Width));
        }

/*        public List<Struct.Stage> Stages
        {
            get
            {
                if(this.stages_ == null)
                {
                    this.stages_ = ScriptableObjectSingleton<StageDB>.Instance.Stages;
                }
                return this.stages_;
            }
        }*/
    }
}
