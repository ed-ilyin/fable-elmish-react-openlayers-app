module Fable.Helpers.ReactOpenLayers
open Fable.Import
open Fable.Import.Browser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React

type Attribute =
    | Options of Ol.MapOptions
    | Ref of (Browser.Element -> unit)
    interface Props.IHTMLProp

type OlMap(props) =
    inherit React.Component<obj, obj>(props)
    let mutable mapDiv : Browser.Element = unbox null
    let mutable olMap : OpenLayers.Ol.Map = unbox null
    override this.componentDidMount() =
        let mapOptions: Ol.MapOptions = unbox this.props?options
        do mapOptions.target <- U2.Case1 mapDiv |> Some
        do olMap <- Ol.map.Create mapOptions
    override this.render() =
        let p =
            JS.Object.assign (
                JsInterop.createEmpty,
                this.props?div,
                JsInterop.createObj [ "ref" ==> fun e -> mapDiv <- e ]
            )
        createElement ("div", p, this.children)

let inline olMap b c =
    let props = JsInterop.keyValueList CaseRules.LowerFirst b
    ofType<OlMap,_,_> props c
