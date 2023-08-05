using UnityEngine;

public class ConvertJsonToScriptableObject : MonoBehaviour
{
    private JsonManager.JsonStageDB jsonStageDB;

    private void Awake()
    {
        this.jsonStageDB = new JsonManager.JsonStageDB();

        this.Test();
    }

    private void Test()
    {
        for(int i = 0; i < this.jsonStageDB.Stages.Count; ++i)
        {
            Debug.Log(this.jsonStageDB.Stages[i].StageNumber + ", " +
                this.jsonStageDB.Stages[i].Width + ", " +
                this.jsonStageDB.Stages[i].Height);
        }
    }
}
