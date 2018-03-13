module Fable.Import.Ol
open Fable.Core

type ViewOptions = OpenLayers.Olx.ViewOptions
type MapOptions = OpenLayers.Olx.MapOptions

[<Import("default","ol/map")>]
let map: OpenLayers.Ol.MapStatic = jsNative

[<Import("default","ol/view")>]
let view: OpenLayers.Ol.ViewStatic = jsNative

module Layer =
    type Base = OpenLayers.Ol.Layer.Base
    type TileOptions = OpenLayers.Olx.Layer.TileOptions

    [<Import("default","ol/layer/tile")>]
    let tile: OpenLayers.Ol.Layer.TileStatic = jsNative

module Source =
    type XYZOptions = OpenLayers.Olx.Source.XYZOptions

    [<Import("default","ol/source/xyz")>]
    let xyz: OpenLayers.Ol.Source.XYZStatic = jsNative
