using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockController : MonoBehaviour {

    [SerializeField] private GameObject[] blocks;
    [SerializeField] private GameObject showPoint;

    private GameObject block;
    private int blockNumber;

    [SerializeField] private Text description;

    private void Start () {
        blockNumber = 0;
        for(int i=0;i<description.text.Length;i++)
        {
            Debug.Log(description.text.Substring(0));
        }
        Debug.Log(description.text.Length);
    }

	private void Update () {

        if (block == null)
        {
             block = Instantiate(blocks[blockNumber]) as GameObject;
            block.transform.parent = showPoint.transform;
            block.transform.localPosition = Vector3.zero;
            description.text = block.GetComponent<Text>().text;
        }

       
    }

    public int GetBlockNumber()
    {
        return blockNumber;
    }
    public void SetBlockbumber(int i)
    {
        blockNumber = i;
    }
    public void DestroyBlock()
    {
        Destroy(block);
    }
    public bool HasNext()
    {
        if (blockNumber < blocks.Length-1)
            return true;
        else return false;
    }
    public int GetBlockArraySize()
    {
        return blocks.Length;
    }
}
