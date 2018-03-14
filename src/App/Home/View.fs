module Home.View
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.ReactOpenLayers
open Fable.Import
open Types

let placeButton dispatch (name, lon, lat, zoom) =
    button [ OnClick <| fun _ ->
        ChangePlace (name, Ol.proj.fromLonLat ((lon, lat)), zoom)
            |> dispatch
    ] [ str name ]

let orientationButton dispatch (name, orientation) =
    button [
        OnClick (fun _ -> ChangeOrientation orientation |> dispatch)
    ] [ str name ]

let root model dispatch =
    div [] [
        span [] [ str (sprintf "Hello %s" model.name) ]
        [   "landscape", Landscape
            "portrait", Portrait
        ]   |> List.map (orientationButton dispatch)
            |> div []
        olMap [
            Center model.coordinate
            Zoom model.zoom
            Orientation model.orientation
        ] []
        [   "Rīga", 24.106389, 56.948889, 15.
            "London", -0.1275, 51.507222, 13.
        ]   |> List.map (placeButton dispatch)
            |> div []
    ]
