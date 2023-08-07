using UnityEngine;

public class ConvertJsonToScriptableObject : MonoBehaviour
{
    private JsonSystem.StageReference jsonStageReference;
    [SerializeField]
    private ScriptableObjectSystem.StageReference STOStageReference;

    private void Awake()
    {
        this.jsonStageReference = new JsonSystem.StageReference();
        this.STOStageReference = new ScriptableObjectSystem.StageReference();

        this.Test();
    }

    private void Test()
    {
        Debug.Log(this.STOStageReference.StageDB.stages_[0].StageNumber);

        this.STOStageReference.StageDB.ReSetting(this.jsonStageReference.StageDB.Stages);
    }
}
