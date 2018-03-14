module Fable.Helpers.ReactOpenLayers
open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React

type Orientation = Horizontal | Vertical

type Attribute =
    | Center of OpenLayers.Ol.Coordinate
    | Orientation of Orientation
    | Ref of (Browser.Element -> unit)
    interface Props.IHTMLProp

[<Pojo>]
type Props = {
    center: OpenLayers.Ol.Coordinate option
}

type OlMap(props) =
    inherit React.Component<Props, obj>(props)
    let sourceXyzOptions = createEmpty<Ol.Source.XYZOptions>
    do sourceXyzOptions.url <-
        Some "https://{a-c}.tile.openstreetmap.org/{z}/{x}/{y}.png"
    let layerTileOptions = createEmpty<Ol.Layer.TileOptions>
    do layerTileOptions.source <-
        Ol.Source.xyz.Create sourceXyzOptions
    let layer = Ol.Layer.tile.Create layerTileOptions :> Ol.Layer.Base
    let viewOptions = createEmpty<Ol.ViewOptions>
    do viewOptions.center <- Some (2000000., 7000000.)
    do viewOptions.zoom <- Some 15.
    let mapOptions = createEmpty<Ol.MapOptions>
    do mapOptions.layers <-
        ResizeArray<_> [ layer ] |> U2.Case1 |> Some
    do mapOptions.view <- Ol.view.Create viewOptions |> Some
    let mutable mapDiv : Browser.Element = unbox null
    let mutable olMap : OpenLayers.Ol.Map = unbox null
    let update props =
        do props.center |> Option.iter (olMap.getView().setCenter)
    override this.render () =
        div [ Ref (fun e -> mapDiv <- e) ] []
    override this.componentDidMount () =
        do mapOptions.target <- U2.Case1 mapDiv |> Some
        do olMap <- Ol.map.Create mapOptions
        do update this.props

    override this.componentDidUpdate (_, _) =
        do update this.props

let inline olMap b c =
    let props = JsInterop.keyValueList CaseRules.LowerFirst b |> unbox
    ofType<OlMap,_,_> props c
