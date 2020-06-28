using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButttonController : MonoBehaviour {

    private BlockController blockController;

    

	private void Start () {
        blockController = GetComponent<BlockController>();
	}
	
	
	private void Update () {
		
	}

    public void OnNextBtnClick()
    {
        int i = blockController.GetBlockNumber();
        blockController.DestroyBlock();
        if (blockController.HasNext())
        {
            blockController.SetBlockbumber(i + 1);
        }
        else blockController.SetBlockbumber(0);


    }
    public void OnPrevoisBtnClick()
    {
        int i = blockController.GetBlockNumber();
        blockController.DestroyBlock();
        if(i<=0)
        {
            blockController.SetBlockbumber(blockController.GetBlockArraySize()-1);
        }
        else blockController.SetBlockbumber(i - 1);
    }

    public void OnExitBtnClick()
    {
        SceneManager.LoadScene("PlayScene");
    }

}
