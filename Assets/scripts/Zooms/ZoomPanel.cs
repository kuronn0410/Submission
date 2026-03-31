using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Transform objParent;
    GameObject zoomObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        panel.SetActive(false);

    }
    public void ShowP()
    {
        
        Item item = ItemBox.instance.GetSelectedItem();
        if(item != null)
        {
            Destroy(zoomObj);
            panel.SetActive(true);
            //アイテム表示
            //Objparentにアイテムを生成する
            GameObject zoomObjPrefab = ItemGenerater.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objParent);

        }
    }

    // Update is called once per frame
    public void CloseP()
    {
        panel.SetActive(false);
        Destroy(zoomObj);
    }
}
