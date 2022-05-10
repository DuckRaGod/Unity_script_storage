using UnityEngine;
using UnityEditor;

public class {ScriptName}: EditorWindow{

    [MenuItem("Window/Tool")]
    public static void ShowWindow(){  // Show at window, tab called Tool.
        GetWindow<{ScriptName}>();
    }
    
    void OnGUI(){
        // Render window.
    }
}
