module Home.State
open Elmish
open Fable.Import
open Types
open Fable.Helpers

let init () : Model * Cmd<Msg> =
    {   name = "Amsterdam"
        coordinate = (4.9, 52.366667) |> Ol.proj.fromLonLat
        zoom = 14.
        orientation = ReactOpenLayers.Landscape
    }, Cmd.none

let update msg model : Model * Cmd<Msg> =
    match msg with
    | ChangePlace (name, coordinate, zoom) ->
        { model with
            name = name
            coordinate = coordinate
            zoom = zoom
        }, Cmd.none
    | ChangeOrientation orientation ->
        { model with orientation = orientation }, Cmd.none
