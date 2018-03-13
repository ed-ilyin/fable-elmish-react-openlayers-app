module Home.View
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.ReactOpenLayers
open Fable.Helpers.React.Props
open Types

let root model dispatch =
    div [] [
        p [ ClassName "control" ] [
            input [
                ClassName "input"
                Type "text"
                Placeholder "Type your name"
                DefaultValue model
                AutoFocus true
                OnChange (fun ev ->
                    !!ev.target?value |> ChangeStr |> dispatch
                )
            ]
        ]
        br []
        span [] [ str (sprintf "Hello %s" model) ]
        olMap [ Options Global.mapOptions ] []
        olMap [ Options Global.mapOptions ] []
    ]
