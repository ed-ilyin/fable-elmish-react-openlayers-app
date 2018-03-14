module Home.View
open Fable.Helpers.React
open Fable.Helpers.ReactOpenLayers
open Fable.Helpers.React.Props
open Types

let placeButton dispatch (name, _ as place) =
    button [ OnClick <| fun _ -> ChangePlace place |> dispatch ]
        [ str name ]
let root model dispatch =
    div [] [
        span [] [ str (sprintf "Hello %s" model.name) ]
        olMap [ Center model.coordinate ] []
        [   "Riga", (100000., 10000.)
            "London", (100000., -10000.)
        ]   |> List.map (placeButton dispatch)
            |> div []
    ]
