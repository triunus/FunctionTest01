namespace Struct
{
    [System.Serializable]
    public struct Stage
    {
        [UnityEngine.SerializeField]
        private int stageNumber_;
        [UnityEngine.SerializeField]
        private int width_;
        [UnityEngine.SerializeField]
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