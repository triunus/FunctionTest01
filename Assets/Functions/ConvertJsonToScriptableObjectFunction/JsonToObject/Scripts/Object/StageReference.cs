using UnityEngine;

namespace JsonSystem
{
    // 참조형식으로 전달받기로 함...
    public class StageReference
    {
        [SerializeField]
        private StageDB stageDB_;

        public StageDB StageDB
        {
            get
            {
                if(stageDB_ == null)
                {
                    this.stageDB_ = new StageDB();
                }
                return this.stageDB_;
            }
        }
    }
}