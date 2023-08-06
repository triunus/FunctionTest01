using System;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json.Linq;

namespace JsonManager
{
    // 참조형식으로 전달받기로 함...
    public class JsonStageDB : JsonStruct
    {
        private StagesDB stagesDB_ = new StagesDB();

        public StageDB StageDB
        {
            get
            {
                if(stagesDB_ == null)
                {

                }
                return this.stagesDB_;
            }
        }


/*        public Stages Stages
        {
            get
            {
                if (stages_ == null)
                {
                    TextAsset jsonString = JsonReadingSingleton<Stages>.ReadingJsonFile;
                    this.stages_ =
                }
                return this.stages_;
                //                return this.stages_.ConvertAll(temp => new Stage());
            }
        }*/
    }

    [Serializable]
    public class StagesDB : JsonStruct
    {
        [SerializeField]
        public List<Stage> stages_;
        private TextAsset textAsset_;

        public List<Stage> Stages
        {
            get
            {
                if (stages_ == null)
                {
                    this.textAsset_ = JsonReadingSingleton<StagesDB>.ReadingJsonFile;
                    this.ConvertJsonToObject();
                }

                return this.stages_;
            }
        }

        protected override void ConvertJsonToObject()
        {
            JArray jarrayStages = JArray.Parse(this.textAsset_.ToString());

            for(int i = 0; i < jarrayStages.Count; ++i)
            {
                Stage stage_ = new Stage(
                    stageNumber_: (int)jarrayStages[i]["StageNumber"],
                    width_: (int)jarrayStages[i]["Width"],
                    height_: (int)jarrayStages[i]["Height"]
                    );

                this.stages_.Add(stage_);
            }
        }
    }

    [Serializable]
    public struct Stage
    {
        private int stageNumber_;
        private int width_;
        private int height_;

        public Stage(int stageNumber_, int width_, int height_)
        {
            this.stageNumber_ = stageNumber_;
            this.width_ = width_;
            this.height_ = height_;
        }

        public int StageNumber { get { return this.stageNumber_; } set { this.stageNumber_ = value; } }
        public int Width { get { return this.width_; } set { this.width_ = value; } }
        public int Height { get { return this.height_; } set { this.height_ = value; } }
    }
}