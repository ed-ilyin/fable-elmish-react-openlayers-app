module Home.Types
open Fable.Import

type Model = {
    name: string
    coordinate: OpenLayers.Ol.Coordinate
    zoom: float
}

type Msg =
  | ChangePlace of (string * OpenLayers.Ol.Coordinate * float)
