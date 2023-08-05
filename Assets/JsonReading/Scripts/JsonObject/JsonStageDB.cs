
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JsonManager
{
    // 참조형식으로 전달받기로 함...
    public class JsonStageDB
    {
        private List<Stage> stages_ = new List<Stage>();
        private bool stagesIsEmpty = true;

        public List<Stage> Stages
        {
            get
            {
                if (stagesIsEmpty)
                {
                    this.stages_ = JsonArraySingleton<Stage>.Instance_JA;

                    if (stages_ != null)
                    {
                        Debug.Log("JsonStageDB - Stages : is NUll");
                        this.stagesIsEmpty = false;
                    }
                }
                return this.stages_;
//                return this.stages_.ConvertAll(temp => new Stage());
            }
        }
    }

    [Serializable]
    public class Stage : JsonArraySingleton<Stage>
    {
        private int stageNumber_;
        private int width_;
        private int height_;

        public int StageNumber { get { return this.stageNumber_; } set { this.stageNumber_ = value; } }
        public int Width { get { return this.width_; } set { this.width_ = value; } }
        public int Height { get { return this.height_; } set { this.height_ = value; } }
    }
}