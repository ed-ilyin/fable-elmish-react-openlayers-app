module Global
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

type Page = Home | Counter | About

let toHash = function
    | About -> "#about"
    | Counter -> "#counter"
    | Home -> "#home"

importAll "ol/ol.css"
let sourceXyzOptions = createEmpty<Ol.Source.XYZOptions>

do sourceXyzOptions.url <-
    Some "https://{a-c}.tile.openstreetmap.org/{z}/{x}/{y}.png"

let layerTileOptions = createEmpty<Ol.Layer.TileOptions>
do layerTileOptions.source <- Ol.Source.xyz.Create sourceXyzOptions
let layer = Ol.Layer.tile.Create layerTileOptions :> Ol.Layer.Base
let viewOptions = createEmpty<Ol.ViewOptions>
do viewOptions.center <- Some (0., 0.)
do viewOptions.zoom <- Some 2.
let mapOptions = createEmpty<Ol.MapOptions>
do mapOptions.layers <- ResizeArray<_> [ layer ] |> U2.Case1 |> Some
do mapOptions.view <- Ol.view.Create viewOptions |> Some
// let olmap = Ol.map.Create mapOptions

// // Exampe:
// import 'ol/ol.css';
// import Map from 'ol/map';
// import View from 'ol/view';
// import TileLayer from 'ol/layer/tile';
// import XYZ from 'ol/source/xyz';

// new Map({
//   target: 'map',
//   layers: [
//     new TileLayer({
//       source: new XYZ({
//         url: 'https://{a-c}.tile.openstreetmap.org/{z}/{x}/{y}.png'
//       })
//     })
//   ],
//   view: new View({
//     center: [0, 0],
//     zoom: 2
//   })
// });
