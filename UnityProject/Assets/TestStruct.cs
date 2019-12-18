using UnityEngine;

public class TestStruct : MonoBehaviour
{
    public StructData character1 = new StructData("KID", 50, 70.5f);
    public StructData character2 = new StructData("TOM", 30, 20.2f);

    public StructData[] characters =
    {
        new StructData("KID", 50, 70.5f),
        new StructData("TOM", 30, 20.2f)
    };

    public StructData[] charactersArray1 =
    {
        new StructData("KID", 50, 70.5f),
        new StructData("TOM", 30, 20.2f)
    };

    public StructData[] charactersArray2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            character2 = character1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            character2.lv = 1;

            print("<color=blue>Character 2 Lv : " + character2.lv + "</color>");
            print("<color=blue>Character 1 Lv : " + character1.lv + "</color>");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            characters[1] = characters[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            characters[1].lv = 1;

            print("<color=red>Character 2 Lv : " + characters[1].lv + "</color>");
            print("<color=red>Character 1 Lv : " + characters[0].lv + "</color>");
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // 陣列會變為參考型別
            charactersArray2 = charactersArray1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            charactersArray2[1].lv = 1;

            print("<color=yellow>Character 2 Lv : " + charactersArray2[1].lv + "</color>");
            print("<color=yellow>Character 1 Lv : " + charactersArray1[1].lv + "</color>");
        }
    }
}
