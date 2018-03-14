module Home.View
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.ReactOpenLayers
open Fable.Import
open Types

let placeButton dispatch (name, lonLat) =
    button [ OnClick <| fun _ -> ChangePlace (name, Ol.proj.fromLonLat lonLat) |> dispatch ]
        [ str name ]
let root model dispatch =
    div [] [
        span [] [ str (sprintf "Hello %s" model.name) ]
        olMap [ Center model.coordinate ] []
        [   "Riga", (24.106389, 56.948889)
            "London", (-0.1275, 51.507222)
        ]   |> List.map (placeButton dispatch)
            |> div []
    ]
