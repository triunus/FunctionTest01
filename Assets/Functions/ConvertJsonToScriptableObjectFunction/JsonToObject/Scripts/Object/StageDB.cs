using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json.Linq;

namespace JsonSystem
{
    public class StageDB : JsonObject
    {
        [SerializeField]
        private List<Struct.Stage> stages_;

        public List<Struct.Stage> Stages
        {
            get
            {
                if (stages_ == null)
                {
                    this.stages_ = new List<Struct.Stage>();

                    TextAsset textAsset_ = JsonReadingSingleton<StageDB>.ReadingJsonFile;
                    this.ConvertJsonToObject(textAsset_);
                }

                return this.stages_;
            }
        }

        protected override void ConvertJsonToObject(TextAsset textAsset_)
        {
            JArray jarrayStages = JArray.Parse(textAsset_.ToString());

            for (int i = 0; i < jarrayStages.Count; ++i)
            {
                Struct.Stage stage_ = new Struct.Stage(
                    stageNumber_: (int)jarrayStages[i]["StageNumber"],
                    width_: (int)jarrayStages[i]["Width"],
                    height_: (int)jarrayStages[i]["Height"]
                    );

                this.stages_.Add(stage_);
            }
        }
    }
}
