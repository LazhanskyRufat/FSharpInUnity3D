namespace FSharpCore

open UnityEngine;
open UnityEngine.UI;

type MainWindow() = 
    [<DefaultValue>][<SerializeField>]val mutable _text : Text
    [<DefaultValue>][<SerializeField>]val mutable _button : Button
    inherit MonoBehaviour()
