using UnityEngine;
using UniUiRx;

public class UiTest : MonoBehaviour {

    [SerializeField] private VBox vboxTemplate;
    
    [SerializeField] private Label labelTemplate;
    
    [SerializeField] private Pane parent;
    
    
    private void Start() {
        
        VBox vbox = (VBox) Instantiate<VBox>(vboxTemplate).WithParent(parent);
        Instantiate(labelTemplate).WithParent(vbox);
        Instantiate(labelTemplate).WithParent(vbox);

    }
}
