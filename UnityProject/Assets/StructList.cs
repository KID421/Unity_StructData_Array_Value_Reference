[System.Serializable]
public struct StructData
{
    public string character;
    public int lv;
    public float atk;

    public StructData(string character, int lv, float atk)
    {
        this.character = character;
        this.lv = lv;
        this.atk = atk;
    }
}