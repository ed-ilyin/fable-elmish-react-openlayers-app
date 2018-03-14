module Home.State
open Elmish
open Fable.Import
open Types

let init () : Model * Cmd<Msg> =
    {   name = "Amsterdam"
        coordinate = (37.41, 8.82) |> Ol.proj.fromLonLat
    }, Cmd.none

let update msg model : Model * Cmd<Msg> =
    match msg with
    | ChangePlace (name, coordinate) ->
        { model with
            name = name
            coordinate = coordinate
        }, Cmd.none
