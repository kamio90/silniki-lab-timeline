using UnityEngine;

public class WitcherLogic : MonoBehaviour {
    public WitcherVisualisation ui;
    public bool reduceBarPermanently = false;
    public float barReductionPerSecond = 5;


    void Update() {
        ui.PointX = ui.MouseX;
        if (IsMouseOverBar())
            ui.BarX++;
        else
            ui.BarX--;

        if(reduceBarPermanently)
            ui.BarWidth -= barReductionPerSecond * Time.deltaTime;
        else
            ui.BarWidth = (1000 - ui.BarX) / 4;
    }

    bool IsMouseOverBar() {
        return Mathf.Abs(ui.BarX - ui.MouseX) < ui.BarWidth / 2;
    }
}
