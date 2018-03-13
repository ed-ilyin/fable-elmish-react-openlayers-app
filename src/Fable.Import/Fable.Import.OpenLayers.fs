// ts2fable 0.5.2
module rec Fable.Import.OpenLayers
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

let [<Import("*","openlayers")>] ol: Ol.IExports = jsNative

type [<AllowNullLiteral>] GlobalObject =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

module Ol =
    let [<Import("Collection","openlayers/ol")>] collection: Collection.IExports = jsNative
    let [<Import("color","openlayers/ol")>] color: Color.IExports = jsNative
    let [<Import("colorlike","openlayers/ol")>] colorlike: Colorlike.IExports = jsNative
    let [<Import("control","openlayers/ol")>] control: Control.IExports = jsNative
    let [<Import("coordinate","openlayers/ol")>] coordinate: Coordinate.IExports = jsNative
    let [<Import("easing","openlayers/ol")>] easing: Easing.IExports = jsNative
    let [<Import("events","openlayers/ol")>] events: Events.IExports = jsNative
    let [<Import("extent","openlayers/ol")>] extent: Extent.IExports = jsNative
    let [<Import("featureloader","openlayers/ol")>] featureloader: Featureloader.IExports = jsNative
    let [<Import("format","openlayers/ol")>] format: Format.IExports = jsNative
    let [<Import("geom","openlayers/ol")>] geom: Geom.IExports = jsNative
    let [<Import("has","openlayers/ol")>] has: Has.IExports = jsNative
    let [<Import("interaction","openlayers/ol")>] interaction: Interaction.IExports = jsNative
    let [<Import("layer","openlayers/ol")>] layer: Layer.IExports = jsNative
    let [<Import("loadingstrategy","openlayers/ol")>] loadingstrategy: Loadingstrategy.IExports = jsNative
    let [<Import("pointer","openlayers/ol")>] pointer: Pointer.IExports = jsNative
    let [<Import("proj","openlayers/ol")>] proj: Proj.IExports = jsNative
    let [<Import("render","openlayers/ol")>] render: Render.IExports = jsNative
    let [<Import("source","openlayers/ol")>] source: Source.IExports = jsNative
    let [<Import("style","openlayers/ol")>] style: Style.IExports = jsNative
    let [<Import("tilegrid","openlayers/ol")>] tilegrid: Tilegrid.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract AssertionError: AssertionErrorStatic
        abstract Attribution: AttributionStatic
        abstract Collection: CollectionStatic
        abstract DeviceOrientation: DeviceOrientationStatic
        abstract Disposable: DisposableStatic
        abstract Feature: FeatureStatic
        abstract Geolocation: GeolocationStatic
        abstract Graticule: GraticuleStatic
        abstract Image: ImageStatic
        abstract ImageBase: ImageBaseStatic
        abstract ImageTile: ImageTileStatic
        /// <summary>Inherit the prototype methods from one constructor into another.
        ///
        /// Usage:
        ///
        ///      function ParentClass(a, b) { }
        ///      ParentClass.prototype.foo = function(a) { }
        ///
        ///      function ChildClass(a, b, c) {
        ///        // Call parent constructor
        ///        ParentClass.call(this, a, b);
        ///      }
        ///      ol.inherits(ChildClass, ParentClass);
        ///
        ///      var child = new ChildClass('a', 'b', 'see');
        ///      child.foo(); // This works.</summary>
        /// <param name="childCtor">Child constructor.</param>
        /// <param name="parentCtor">Parent constructor.</param>
        abstract inherits: childCtor: (unit -> obj option) * parentCtor: (unit -> obj option) -> unit
        abstract Kinetic: KineticStatic
        abstract Map: MapStatic
        abstract MapBrowserEvent: MapBrowserEventStatic
        abstract MapBrowserPointerEvent: MapBrowserPointerEventStatic
        abstract MapEvent: MapEventStatic
        abstract ObjectEvent: ObjectEventStatic
        abstract Object: ObjectStatic
        abstract Observable: ObservableStatic
        abstract Overlay: OverlayStatic
        abstract Sphere: SphereStatic
        abstract Tile: TileStatic
        abstract VectorTile: VectorTileStatic
        abstract View: ViewStatic

    /// Error object thrown when an assertion failed. This is an ECMA-262 Error,
    /// extended with a `code` property.
    type [<AllowNullLiteral>] AssertionError =
        inherit Error
        /// Error code. The meaning of the code can be found on
        /// {@link http://openlayers.org/en/latest/errors.html} (replace `latest` with
        /// the version found in the OpenLayers script's header comment if a version
        /// other than the latest is used).
        abstract code: float with get, set

    /// Error object thrown when an assertion failed. This is an ECMA-262 Error,
    /// extended with a `code` property.
    type [<AllowNullLiteral>] AssertionErrorStatic =
        /// <summary>Error object thrown when an assertion failed. This is an ECMA-262 Error,
        /// extended with a `code` property.</summary>
        /// <param name="code">Error code.</param>
        [<Emit "new $0($1...)">] abstract Create: code: float -> AssertionError

    type [<AllowNullLiteral>] Attribution =
        /// Get the attribution markup.
        abstract getHTML: unit -> string

    type [<AllowNullLiteral>] AttributionStatic =
        /// <param name="options">Attribution options.</param>
        [<Emit "new $0($1...)">] abstract Create: options: Olx.AttributionOptions -> Attribution

    type [<AllowNullLiteral>] Collection<'T> =
        inherit Ol.Object
        /// Remove all elements from the collection.
        abstract clear: unit -> unit
        /// <summary>Add elements to the collection.  This pushes each item in the provided array
        /// to the end of the collection.</summary>
        /// <param name="arr">Array.</param>
        abstract extend: arr: ResizeArray<'T> -> Ol.Collection<'T>
        /// <summary>Iterate over each element, calling the provided callback.</summary>
        /// <param name="f">The function to call
        /// for every element. This function takes 3 arguments (the element, the
        /// index and the array). The return value is ignored.</param>
        /// <param name="opt_this">The object to use as `this` in `f`.</param>
        abstract forEach: f: ('T -> float -> ResizeArray<'T> -> obj option) * ?opt_this: 'S -> unit
        /// Get a reference to the underlying Array object. Warning: if the array
        /// is mutated, no events will be dispatched by the collection, and the
        /// collection's "length" property won't be in sync with the actual length
        /// of the array.
        abstract getArray: unit -> ResizeArray<'T>
        /// <summary>Get the element at the provided index.</summary>
        /// <param name="index">Index.</param>
        abstract item: index: float -> 'T
        /// Get the length of this collection.
        abstract getLength: unit -> float
        /// <summary>Insert an element at the provided index.</summary>
        /// <param name="index">Index.</param>
        /// <param name="elem">Element.</param>
        abstract insertAt: index: float * elem: 'T -> unit
        /// Remove the last element of the collection and return it.
        /// Return `undefined` if the collection is empty.
        abstract pop: unit -> 'T
        /// <summary>Insert the provided element at the end of the collection.</summary>
        /// <param name="elem">Element.</param>
        abstract push: elem: 'T -> float
        /// <summary>Remove the first occurrence of an element from the collection.</summary>
        /// <param name="elem">Element.</param>
        abstract remove: elem: 'T -> 'T
        /// <summary>Remove the element at the provided index and return it.
        /// Return `undefined` if the collection does not contain this index.</summary>
        /// <param name="index">Index.</param>
        abstract removeAt: index: float -> 'T
        /// <summary>Set the element at the provided index.</summary>
        /// <param name="index">Index.</param>
        /// <param name="elem">Element.</param>
        abstract setAt: index: float * elem: 'T -> unit

    type [<AllowNullLiteral>] CollectionStatic =
        /// <param name="opt_array">Array.</param>
        [<Emit "new $0($1...)">] abstract Create: ?opt_array: ResizeArray<'T> -> Collection<'T>

    module Collection =

        type [<AllowNullLiteral>] IExports =
            abstract Event: EventStatic

        type EventType =
            string

        type [<AllowNullLiteral>] Event =
            inherit Ol.Events.Event
            /// The element that is added to or removed from the collection.
            abstract element: obj option with get, set

        type [<AllowNullLiteral>] EventStatic =
            /// <param name="type">Type.</param>
            /// <param name="opt_element">Element.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: Ol.Collection.EventType * ?opt_element: obj option -> Event

    module Color =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Return the color as an array. This function maintains a cache of calculated
            /// arrays which means the result should not be modified.</summary>
            /// <param name="color">Color.</param>
            abstract asArray: color: U2<Ol.Color, string> -> Ol.Color
            /// <summary>Return the color as an rgba string.</summary>
            /// <param name="color">Color.</param>
            abstract asString: color: U2<Ol.Color, string> -> string

    module Colorlike =

        type [<AllowNullLiteral>] IExports =
            /// <param name="color">Color.</param>
            abstract asColorLike: color: U2<Ol.Color, Ol.ColorLike> -> Ol.ColorLike

    module Control =

        type [<AllowNullLiteral>] IExports =
            abstract Attribution: AttributionStatic
            abstract Control: ControlStatic
            abstract FullScreen: FullScreenStatic
            /// <summary>Set of controls included in maps by default. Unless configured otherwise,
            /// this returns a collection containing an instance of each of the following
            /// controls:
            /// * {@link ol.control.Zoom}
            /// * {@link ol.control.Rotate}
            /// * {@link ol.control.Attribution}</summary>
            /// <param name="opt_options">Defaults options.</param>
            abstract defaults: ?opt_options: Olx.Control.DefaultsOptions -> Ol.Collection<Ol.Control.Control>
            abstract MousePosition: MousePositionStatic
            abstract OverviewMap: OverviewMapStatic
            abstract Rotate: RotateStatic
            abstract ScaleLine: ScaleLineStatic
            abstract Zoom: ZoomStatic
            abstract ZoomSlider: ZoomSliderStatic
            abstract ZoomToExtent: ZoomToExtentStatic

        type [<AllowNullLiteral>] Attribution =
            inherit Ol.Control.Control
            /// Return `true` if the attribution is collapsible, `false` otherwise.
            abstract getCollapsible: unit -> bool
            /// <summary>Set whether the attribution should be collapsible.</summary>
            /// <param name="collapsible">True if the widget is collapsible.</param>
            abstract setCollapsible: collapsible: bool -> unit
            /// <summary>Collapse or expand the attribution according to the passed parameter. Will
            /// not do anything if the attribution isn't collapsible or if the current
            /// collapsed state is already the one requested.</summary>
            /// <param name="collapsed">True if the widget is collapsed.</param>
            abstract setCollapsed: collapsed: bool -> unit
            /// Return `true` when the attribution is currently collapsed or `false`
            /// otherwise.
            abstract getCollapsed: unit -> bool

        type [<AllowNullLiteral>] AttributionStatic =
            /// <param name="opt_options">Attribution options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.AttributionOptions -> Attribution
            /// <summary>Update the attribution element.</summary>
            /// <param name="mapEvent">Map event.</param>
            abstract render: mapEvent: Ol.MapEvent -> unit

        type [<AllowNullLiteral>] Control =
            inherit Ol.Object
            /// Get the map associated with this control.
            abstract getMap: unit -> Ol.Map
            /// <summary>Remove the control from its current map and attach it to the new map.
            /// Subclasses may set up event handlers to get notified about changes to
            /// the map here.</summary>
            /// <param name="map">Map.</param>
            abstract setMap: map: Ol.Map -> unit
            /// <summary>This function is used to set a target element for the control. It has no
            /// effect if it is called after the control has been added to the map (i.e.
            /// after `setMap` is called on the control). If no `target` is set in the
            /// options passed to the control constructor and if `setTarget` is not called
            /// then the control is added to the map's overlay container.</summary>
            /// <param name="target">Target.</param>
            abstract setTarget: target: U2<Element, string> -> unit

        type [<AllowNullLiteral>] ControlStatic =
            /// <param name="options">Control options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Control.ControlOptions -> Control

        type [<AllowNullLiteral>] FullScreen =
            inherit Ol.Control.Control

        type [<AllowNullLiteral>] FullScreenStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.FullScreenOptions -> FullScreen

        type [<AllowNullLiteral>] MousePosition =
            inherit Ol.Control.Control
            /// Return the coordinate format type used to render the current position or
            /// undefined.
            abstract getCoordinateFormat: unit -> Ol.CoordinateFormatType
            /// Return the projection that is used to report the mouse position.
            abstract getProjection: unit -> Ol.Proj.Projection
            /// <summary>Set the coordinate format type used to render the current position.</summary>
            /// <param name="format">The format to render the current
            /// position in.</param>
            abstract setCoordinateFormat: format: Ol.CoordinateFormatType -> unit
            /// <summary>Set the projection that is used to report the mouse position.</summary>
            /// <param name="projection">The projection to report mouse
            /// position in.</param>
            abstract setProjection: projection: Ol.Proj.Projection -> unit

        type [<AllowNullLiteral>] MousePositionStatic =
            /// <param name="opt_options">Mouse position
            /// options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.MousePositionOptions -> MousePosition
            /// <summary>Update the mouseposition element.</summary>
            /// <param name="mapEvent">Map event.</param>
            abstract render: mapEvent: Ol.MapEvent -> unit

        /// Create a new control with a map acting as an overview map for an other
        /// defined map.
        type [<AllowNullLiteral>] OverviewMap =
            inherit Ol.Control.Control
            /// Return `true` if the overview map is collapsible, `false` otherwise.
            abstract getCollapsible: unit -> bool
            /// <summary>Set whether the overview map should be collapsible.</summary>
            /// <param name="collapsible">True if the widget is collapsible.</param>
            abstract setCollapsible: collapsible: bool -> unit
            /// <summary>Collapse or expand the overview map according to the passed parameter. Will
            /// not do anything if the overview map isn't collapsible or if the current
            /// collapsed state is already the one requested.</summary>
            /// <param name="collapsed">True if the widget is collapsed.</param>
            abstract setCollapsed: collapsed: bool -> unit
            /// Determine if the overview map is collapsed.
            abstract getCollapsed: unit -> bool
            /// Return the overview map.
            abstract getOverviewMap: unit -> Ol.Map

        /// Create a new control with a map acting as an overview map for an other
        /// defined map.
        type [<AllowNullLiteral>] OverviewMapStatic =
            /// <summary>Create a new control with a map acting as an overview map for an other
            /// defined map.</summary>
            /// <param name="opt_options">OverviewMap options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.OverviewMapOptions -> OverviewMap
            /// <summary>Update the overview map element.</summary>
            /// <param name="mapEvent">Map event.</param>
            abstract render: mapEvent: Ol.MapEvent -> unit

        type [<AllowNullLiteral>] Rotate =
            inherit Ol.Control.Control

        type [<AllowNullLiteral>] RotateStatic =
            /// <param name="opt_options">Rotate options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.RotateOptions -> Rotate
            /// <summary>Update the rotate control element.</summary>
            /// <param name="mapEvent">Map event.</param>
            abstract render: mapEvent: Ol.MapEvent -> unit

        type [<AllowNullLiteral>] ScaleLine =
            inherit Ol.Control.Control
            /// Return the units to use in the scale line.
            abstract getUnits: unit -> Ol.Control.ScaleLine.Units
            /// <summary>Set the units to use in the scale line.</summary>
            /// <param name="units">The units to use in the scale line.</param>
            abstract setUnits: units: Ol.Control.ScaleLine.Units -> unit

        type [<AllowNullLiteral>] ScaleLineStatic =
            /// <param name="opt_options">Scale line options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.ScaleLineOptions -> ScaleLine
            /// <summary>Update the scale line element.</summary>
            /// <param name="mapEvent">Map event.</param>
            abstract render: mapEvent: Ol.MapEvent -> unit

        module ScaleLine =

            type Property =
                string

            type [<StringEnum>] [<RequireQualifiedAccess>] Units =
                | Degrees
                | Imperial
                | Nautical
                | Metric
                | Us

        type [<AllowNullLiteral>] Zoom =
            inherit Ol.Control.Control

        type [<AllowNullLiteral>] ZoomStatic =
            /// <param name="opt_options">Zoom options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.ZoomOptions -> Zoom

        type [<AllowNullLiteral>] ZoomSlider =
            inherit Ol.Control.Control

        type [<AllowNullLiteral>] ZoomSliderStatic =
            /// <param name="opt_options">Zoom slider options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.ZoomSliderOptions -> ZoomSlider
            /// <summary>Update the zoomslider element.</summary>
            /// <param name="mapEvent">Map event.</param>
            abstract render: mapEvent: Ol.MapEvent -> unit

        type [<AllowNullLiteral>] ZoomToExtent =
            inherit Ol.Control.Control

        type [<AllowNullLiteral>] ZoomToExtentStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Control.ZoomToExtentOptions -> ZoomToExtent

    module Coordinate =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Add `delta` to `coordinate`. `coordinate` is modified in place and returned
            /// by the function.
            ///
            /// Example:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      ol.coordinate.add(coord, [-2, 4]);
            ///      // coord is now [5.85, 51.983333]</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="delta">Delta.</param>
            abstract add: coordinate: Ol.Coordinate * delta: Ol.Coordinate -> Ol.Coordinate
            /// <summary>Returns a {@link ol.CoordinateFormatType} function that can be used to format
            /// a {ol.Coordinate} to a string.
            ///
            /// Example without specifying the fractional digits:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var stringifyFunc = ol.coordinate.createStringXY();
            ///      var out = stringifyFunc(coord);
            ///      // out is now '8, 48'
            ///
            /// Example with explicitly specifying 2 fractional digits:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var stringifyFunc = ol.coordinate.createStringXY(2);
            ///      var out = stringifyFunc(coord);
            ///      // out is now '7.85, 47.98'</summary>
            /// <param name="opt_fractionDigits">The number of digits to include
            /// after the decimal point. Default is `0`.</param>
            abstract createStringXY: ?opt_fractionDigits: float -> Ol.CoordinateFormatType
            /// <summary>Transforms the given {@link ol.Coordinate} to a string using the given string
            /// template. The strings `{x}` and `{y}` in the template will be replaced with
            /// the first and second coordinate values respectively.
            ///
            /// Example without specifying the fractional digits:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var template = 'Coordinate is ({x}|{y}).';
            ///      var out = ol.coordinate.format(coord, template);
            ///      // out is now 'Coordinate is (8|48).'
            ///
            /// Example explicitly specifying the fractional digits:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var template = 'Coordinate is ({x}|{y}).';
            ///      var out = ol.coordinate.format(coord, template, 2);
            ///      // out is now 'Coordinate is (7.85|47.98).'</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="template">A template string with `{x}` and `{y}` placeholders
            /// that will be replaced by first and second coordinate values.</param>
            /// <param name="opt_fractionDigits">The number of digits to include
            /// after the decimal point. Default is `0`.</param>
            abstract format: coordinate: Ol.Coordinate * template: string * ?opt_fractionDigits: float -> string
            /// <summary>Rotate `coordinate` by `angle`. `coordinate` is modified in place and
            /// returned by the function.
            ///
            /// Example:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var rotateRadians = Math.PI / 2; // 90 degrees
            ///      ol.coordinate.rotate(coord, rotateRadians);
            ///      // coord is now [-47.983333, 7.85]</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="angle">Angle in radian.</param>
            abstract rotate: coordinate: Ol.Coordinate * angle: float -> Ol.Coordinate
            /// <summary>Format a geographic coordinate with the hemisphere, degrees, minutes, and
            /// seconds.
            ///
            /// Example without specifying fractional digits:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var out = ol.coordinate.toStringHDMS(coord);
            ///      // out is now '47° 58′ 60″ N 7° 50′ 60″ E'
            ///
            /// Example explicitly specifying 1 fractional digit:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var out = ol.coordinate.toStringHDMS(coord, 1);
            ///      // out is now '47° 58′ 60.0″ N 7° 50′ 60.0″ E'</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="opt_fractionDigits">The number of digits to include
            /// after the decimal point. Default is `0`.</param>
            abstract toStringHDMS: ?coordinate: Ol.Coordinate * ?opt_fractionDigits: float -> string
            /// <summary>Format a coordinate as a comma delimited string.
            ///
            /// Example without specifying fractional digits:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var out = ol.coordinate.toStringXY(coord);
            ///      // out is now '8, 48'
            ///
            /// Example explicitly specifying 1 fractional digit:
            ///
            ///      var coord = [7.85, 47.983333];
            ///      var out = ol.coordinate.toStringXY(coord, 1);
            ///      // out is now '7.8, 48.0'</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="opt_fractionDigits">The number of digits to include
            /// after the decimal point. Default is `0`.</param>
            abstract toStringXY: ?coordinate: Ol.Coordinate * ?opt_fractionDigits: float -> string

    type [<AllowNullLiteral>] DeviceOrientation =
        inherit Ol.Object
        /// Rotation around the device z-axis (in radians).
        abstract getAlpha: unit -> float
        /// Rotation around the device x-axis (in radians).
        abstract getBeta: unit -> float
        /// Rotation around the device y-axis (in radians).
        abstract getGamma: unit -> float
        /// The heading of the device relative to north (in radians).
        abstract getHeading: unit -> float
        /// Determine if orientation is being tracked.
        abstract getTracking: unit -> bool
        /// <summary>Enable or disable tracking of device orientation events.</summary>
        /// <param name="tracking">The status of tracking changes to alpha, beta and
        /// gamma. If true, changes are tracked and reported immediately.</param>
        abstract setTracking: tracking: bool -> unit

    type [<AllowNullLiteral>] DeviceOrientationStatic =
        /// <param name="opt_options">Options.</param>
        [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.DeviceOrientationOptions -> DeviceOrientation

    /// Objects that need to clean up after themselves.
    type [<AllowNullLiteral>] Disposable =
        interface end

    /// Objects that need to clean up after themselves.
    type [<AllowNullLiteral>] DisposableStatic =
        /// Objects that need to clean up after themselves.
        [<Emit "new $0($1...)">] abstract Create: unit -> Disposable

    module Easing =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Start slow and speed up.</summary>
            /// <param name="t">Input between 0 and 1.</param>
            abstract easeIn: t: float -> float
            /// <summary>Start fast and slow down.</summary>
            /// <param name="t">Input between 0 and 1.</param>
            abstract easeOut: t: float -> float
            /// <summary>Start slow, speed up, and then slow down again.</summary>
            /// <param name="t">Input between 0 and 1.</param>
            abstract inAndOut: t: float -> float
            /// <summary>Maintain a constant speed over time.</summary>
            /// <param name="t">Input between 0 and 1.</param>
            abstract linear: t: float -> float
            /// <summary>Start slow, speed up, and at the very end slow down again.  This has the
            /// same general behavior as {@link ol.easing.inAndOut}, but the final slowdown
            /// is delayed.</summary>
            /// <param name="t">Input between 0 and 1.</param>
            abstract upAndDown: t: float -> float

    module Events =
        let [<Import("condition","openlayers/ol/events")>] condition: Condition.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract Event: EventStatic
            abstract EventTarget: EventTargetStatic

        module Condition =

            type [<AllowNullLiteral>] IExports =
                /// <summary>Return `true` if only the alt-key is pressed, `false` otherwise (e.g. when
                /// additionally the shift-key is pressed).</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract altKeyOnly: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if only the alt-key and shift-key is pressed, `false` otherwise
                /// (e.g. when additionally the platform-modifier-key is pressed).</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract altShiftKeysOnly: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return always true.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract always: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if the event is a `click` event, `false` otherwise.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract click: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return always false.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract never: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if the browser event is a `pointermove` event, `false`
                /// otherwise.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract pointerMove: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if the event is a map `singleclick` event, `false` otherwise.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract singleClick: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if the event is a map `dblclick` event, `false` otherwise.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract doubleClick: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if no modifier key (alt-, shift- or platform-modifier-key) is
                /// pressed.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract noModifierKeys: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if only the platform-modifier-key (the meta-key on Mac,
                /// ctrl-key otherwise) is pressed, `false` otherwise (e.g. when additionally
                /// the shift-key is pressed).</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract platformModifierKeyOnly: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if only the shift-key is pressed, `false` otherwise (e.g. when
                /// additionally the alt-key is pressed).</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract shiftKeyOnly: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if the target element is not editable, i.e. not a `<input>`-,
                /// `<select>`- or `<textarea>`-element, `false` otherwise.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract targetNotEditable: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if the event originates from a mouse device.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract mouseOnly: mapBrowserEvent: Ol.MapBrowserEvent -> bool
                /// <summary>Return `true` if the event originates from a primary pointer in
                /// contact with the surface or if the left mouse button is pressed.</summary>
                /// <param name="mapBrowserEvent">Map browser event.</param>
                abstract primaryAction: mapBrowserEvent: Ol.MapBrowserEvent -> bool

        type [<AllowNullLiteral>] Event =
            /// The event type.
            abstract ``type``: string with get, set
            /// The event target.
            abstract target: GlobalObject with get, set
            /// Stop event propagation.
            abstract preventDefault: unit -> unit
            /// Stop event propagation.
            abstract stopPropagation: unit -> unit

        type [<AllowNullLiteral>] EventStatic =
            /// <param name="type">Type.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: string -> Event

        type [<AllowNullLiteral>] EventTarget =
            inherit Ol.Disposable

        type [<AllowNullLiteral>] EventTargetStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> EventTarget

    type EventsListenerFunctionType =
        U2<(Ol.Events.Event -> unit), (Ol.Events.Event -> bool)>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module EventsListenerFunctionType =
        let ofCase1 v: EventsListenerFunctionType = v |> U2.Case1
        let isCase1 (v: EventsListenerFunctionType) = match v with U2.Case1 _ -> true | _ -> false
        let asCase1 (v: EventsListenerFunctionType) = match v with U2.Case1 o -> Some o | _ -> None
        let ofCase2 v: EventsListenerFunctionType = v |> U2.Case2
        let isCase2 (v: EventsListenerFunctionType) = match v with U2.Case2 _ -> true | _ -> false
        let asCase2 (v: EventsListenerFunctionType) = match v with U2.Case2 o -> Some o | _ -> None

    module Extent =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Build an extent that includes all given coordinates.</summary>
            /// <param name="coordinates">Coordinates.</param>
            abstract boundingExtent: coordinates: ResizeArray<Ol.Coordinate> -> Ol.Extent
            /// <summary>Return extent increased by the provided value.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="value">The amount by which the extent should be buffered.</param>
            /// <param name="opt_extent">Extent.</param>
            abstract buffer: extent: Ol.Extent * value: float * ?opt_extent: Ol.Extent -> Ol.Extent
            /// <summary>Check if the passed coordinate is contained or on the edge of the extent.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="coordinate">Coordinate.</param>
            abstract containsCoordinate: extent: Ol.Extent * coordinate: Ol.Coordinate -> bool
            /// <summary>Check if one extent contains another.
            ///
            /// An extent is deemed contained if it lies completely within the other extent,
            /// including if they share one or more edges.</summary>
            /// <param name="extent1">Extent 1.</param>
            /// <param name="extent2">Extent 2.</param>
            abstract containsExtent: extent1: Ol.Extent * extent2: Ol.Extent -> bool
            /// <summary>Check if the passed coordinate is contained or on the edge of the extent.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="x">X coordinate.</param>
            /// <param name="y">Y coordinate.</param>
            abstract containsXY: extent: Ol.Extent * x: float * y: float -> bool
            /// Create an empty extent.
            abstract createEmpty: unit -> Ol.Extent
            /// <summary>Determine if two extents are equivalent.</summary>
            /// <param name="extent1">Extent 1.</param>
            /// <param name="extent2">Extent 2.</param>
            abstract equals: extent1: Ol.Extent * extent2: Ol.Extent -> bool
            /// <summary>Modify an extent to include another extent.</summary>
            /// <param name="extent1">The extent to be modified.</param>
            /// <param name="extent2">The extent that will be included in the first.</param>
            abstract extend: extent1: Ol.Extent * extent2: Ol.Extent -> Ol.Extent
            /// <summary>Get the bottom left coordinate of an extent.</summary>
            /// <param name="extent">Extent.</param>
            abstract getBottomLeft: extent: Ol.Extent -> Ol.Coordinate
            /// <summary>Get the bottom right coordinate of an extent.</summary>
            /// <param name="extent">Extent.</param>
            abstract getBottomRight: extent: Ol.Extent -> Ol.Coordinate
            /// <summary>Get the center coordinate of an extent.</summary>
            /// <param name="extent">Extent.</param>
            abstract getCenter: extent: Ol.Extent -> Ol.Coordinate
            /// <summary>Get the height of an extent.</summary>
            /// <param name="extent">Extent.</param>
            abstract getHeight: extent: Ol.Extent -> float
            /// <summary>Get the intersection of two extents.</summary>
            /// <param name="extent1">Extent 1.</param>
            /// <param name="extent2">Extent 2.</param>
            /// <param name="opt_extent">Optional extent to populate with intersection.</param>
            abstract getIntersection: extent1: Ol.Extent * extent2: Ol.Extent * ?opt_extent: Ol.Extent -> Ol.Extent
            /// <summary>Get the size (width, height) of an extent.</summary>
            /// <param name="extent">The extent.</param>
            abstract getSize: extent: Ol.Extent -> Ol.Size
            /// <summary>Get the top left coordinate of an extent.</summary>
            /// <param name="extent">Extent.</param>
            abstract getTopLeft: extent: Ol.Extent -> Ol.Coordinate
            /// <summary>Get the top right coordinate of an extent.</summary>
            /// <param name="extent">Extent.</param>
            abstract getTopRight: extent: Ol.Extent -> Ol.Coordinate
            /// <summary>Get the width of an extent.</summary>
            /// <param name="extent">Extent.</param>
            abstract getWidth: extent: Ol.Extent -> float
            /// <summary>Determine if one extent intersects another.</summary>
            /// <param name="extent1">Extent 1.</param>
            /// <param name="extent2">Extent.</param>
            abstract intersects: extent1: Ol.Extent * extent2: Ol.Extent -> bool
            /// <summary>Determine if an extent is empty.</summary>
            /// <param name="extent">Extent.</param>
            abstract isEmpty: extent: Ol.Extent -> bool
            /// <summary>Apply a transform function to the extent.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="transformFn">Transform function.  Called with
            /// [minX, minY, maxX, maxY] extent coordinates.</param>
            /// <param name="opt_extent">Destination extent.</param>
            abstract applyTransform: extent: Ol.Extent * transformFn: Ol.TransformFunction * ?opt_extent: Ol.Extent -> Ol.Extent

    type [<AllowNullLiteral>] Feature =
        inherit Ol.Object
        /// Clone this feature. If the original feature has a geometry it
        /// is also cloned. The feature id is not set in the clone.
        abstract clone: unit -> Ol.Feature
        /// Get the feature's default geometry.  A feature may have any number of named
        /// geometries.  The "default" geometry (the one that is rendered by default) is
        /// set when calling {@link ol.Feature#setGeometry}.
        abstract getGeometry: unit -> Ol.Geom.Geometry
        /// Get the feature identifier.  This is a stable identifier for the feature and
        /// is either set when reading data from a remote source or set explicitly by
        /// calling {@link ol.Feature#setId}.
        abstract getId: unit -> U2<float, string>
        /// Get the name of the feature's default geometry.  By default, the default
        /// geometry is named `geometry`.
        abstract getGeometryName: unit -> string
        /// Get the feature's style.  This return for this method depends on what was
        /// provided to the {@link ol.Feature#setStyle} method.
        abstract getStyle: unit -> U4<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.FeatureStyleFunction, Ol.StyleFunction>
        /// Get the feature's style function.
        abstract getStyleFunction: unit -> Ol.FeatureStyleFunction
        /// <summary>Set the default geometry for the feature.  This will update the property
        /// with the name returned by {@link ol.Feature#getGeometryName}.</summary>
        /// <param name="geometry">The new geometry.</param>
        abstract setGeometry: geometry: Ol.Geom.Geometry -> unit
        /// <summary>Set the style for the feature.  This can be a single style object, an array
        /// of styles, or a function that takes a resolution and returns an array of
        /// styles. If it is `null` the feature has no style (a `null` style).</summary>
        /// <param name="style">Style for this feature.</param>
        abstract setStyle: style: U4<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.FeatureStyleFunction, Ol.StyleFunction> -> unit
        /// <summary>Set the feature id.  The feature id is considered stable and may be used when
        /// requesting features or comparing identifiers returned from a remote source.
        /// The feature id can be used with the {@link ol.source.Vector#getFeatureById}
        /// method.</summary>
        /// <param name="id">The feature id.</param>
        abstract setId: id: U2<float, string> -> unit
        /// <summary>Set the property name to be used when getting the feature's default geometry.
        /// When calling {@link ol.Feature#getGeometry}, the value of the property with
        /// this name will be returned.</summary>
        /// <param name="name">The property name of the default geometry.</param>
        abstract setGeometryName: name: string -> unit

    type [<AllowNullLiteral>] FeatureStatic =
        /// <param name="opt_geometryOrProperties">You may pass a Geometry object directly, or an object literal
        /// containing properties.  If you pass an object literal, you may
        /// include a Geometry associated with a `geometry` key.</param>
        [<Emit "new $0($1...)">] abstract Create: ?opt_geometryOrProperties: U2<Ol.Geom.Geometry, obj> -> Feature

    module Featureloader =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Create an XHR feature loader for a `url` and `format`. The feature loader
            /// loads features (with XHR), parses the features, and adds them to the
            /// vector tile.</summary>
            /// <param name="url">Feature URL service.</param>
            /// <param name="format">Feature format.</param>
            abstract tile: url: U2<string, Ol.FeatureUrlFunction> * format: Ol.Format.Feature -> Ol.FeatureLoader
            /// <summary>Create an XHR feature loader for a `url` and `format`. The feature loader
            /// loads features (with XHR), parses the features, and adds them to the
            /// vector source.</summary>
            /// <param name="url">Feature URL service.</param>
            /// <param name="format">Feature format.</param>
            abstract xhr: url: U2<string, Ol.FeatureUrlFunction> * format: Ol.Format.Feature -> Ol.FeatureLoader

    module Format =
        let [<Import("filter","openlayers/ol/format")>] filter: Filter.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract EsriJSON: EsriJSONStatic
            abstract Feature: FeatureStatic
            abstract GeoJSON: GeoJSONStatic
            abstract GML: GMLStatic
            abstract GML2: GML2Static
            abstract GML3: GML3Static
            abstract GMLBase: GMLBaseStatic
            abstract GPX: GPXStatic
            abstract IGC: IGCStatic
            abstract JSONFeature: JSONFeatureStatic
            abstract KML: KMLStatic
            abstract MVT: MVTStatic
            abstract OSMXML: OSMXMLStatic
            abstract Polyline: PolylineStatic
            abstract TextFeature: TextFeatureStatic
            abstract TopoJSON: TopoJSONStatic
            abstract WFS: WFSStatic
            abstract WKT: WKTStatic
            abstract WMSCapabilities: WMSCapabilitiesStatic
            abstract WMSGetFeatureInfo: WMSGetFeatureInfoStatic
            abstract WMTSCapabilities: WMTSCapabilitiesStatic
            abstract XML: XMLStatic
            abstract XMLFeature: XMLFeatureStatic

        type [<AllowNullLiteral>] EsriJSON =
            inherit Ol.Format.JSONFeature
            /// <summary>Read a feature from a EsriJSON Feature source.  Only works for Feature,
            /// use `readFeatures` to read FeatureCollection source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeature: source: U5<ArrayBuffer, Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Feature
            /// <summary>Read all features from a EsriJSON source.  Works with both Feature and
            /// FeatureCollection sources.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U5<ArrayBuffer, Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read a geometry from a EsriJSON source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readGeometry: source: U5<ArrayBuffer, Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Geom.Geometry
            /// <summary>Read the projection from a EsriJSON source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U5<ArrayBuffer, Document, Node, GlobalObject, string> -> Ol.Proj.Projection
            /// <summary>Encode a geometry as a EsriJSON string.</summary>
            /// <param name="geometry">Geometry.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeGeometry: geometry: Ol.Geom.Geometry * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode a geometry as a EsriJSON object.</summary>
            /// <param name="geometry">Geometry.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeGeometryObject: geometry: Ol.Geom.Geometry * ?opt_options: Olx.Format.WriteOptions -> EsriJSONGeometry
            /// <summary>Encode a feature as a EsriJSON Feature string.</summary>
            /// <param name="feature">Feature.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeature: feature: Ol.Feature * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode a feature as a esriJSON Feature object.</summary>
            /// <param name="feature">Feature.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeatureObject: feature: Ol.Feature * ?opt_options: Olx.Format.WriteOptions -> GlobalObject
            /// <summary>Encode an array of features as EsriJSON.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeatures: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode an array of features as a EsriJSON object.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeaturesObject: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> GlobalObject

        type [<AllowNullLiteral>] EsriJSONStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.EsriJSONOptions -> EsriJSON

        type EsriJSONGeometry =
            JSON

        type [<AllowNullLiteral>] Feature =
            interface end

        type [<AllowNullLiteral>] FeatureStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Feature

        type GeoJSONFeature =
            JSON

        type GeoJSONFeatureCollection =
            JSON

        type GeoJSONGeometry =
            JSON

        type GeoJSONGeometryCollection =
            JSON

        type [<AllowNullLiteral>] GeoJSON =
            inherit Ol.Format.JSONFeature
            /// <summary>Read a feature from a GeoJSON Feature source.  Only works for Feature,
            /// use `readFeatures` to read FeatureCollection source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeature: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Feature
            /// <summary>Read all features from a GeoJSON source.  Works with both Feature and
            /// FeatureCollection sources.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read a geometry from a GeoJSON source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readGeometry: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Geom.Geometry
            /// <summary>Read the projection from a GeoJSON source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection
            /// <summary>Encode a feature as a GeoJSON Feature string.</summary>
            /// <param name="feature">Feature.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeature: feature: Ol.Feature * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode a feature as a GeoJSON Feature object.</summary>
            /// <param name="feature">Feature.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeatureObject: feature: Ol.Feature * ?opt_options: Olx.Format.WriteOptions -> GeoJSONFeature
            /// <summary>Encode an array of features as GeoJSON.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeatures: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode an array of features as a GeoJSON object.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeaturesObject: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> GeoJSONFeatureCollection
            /// <summary>Encode a geometry as a GeoJSON string.</summary>
            /// <param name="geometry">Geometry.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeGeometry: geometry: Ol.Geom.Geometry * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode a geometry as a GeoJSON object.</summary>
            /// <param name="geometry">Geometry.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeGeometryObject: geometry: Ol.Geom.Geometry * ?opt_options: Olx.Format.WriteOptions -> U2<GeoJSONGeometry, GeoJSONGeometryCollection>

        type [<AllowNullLiteral>] GeoJSONStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.GeoJSONOptions -> GeoJSON

        type [<AllowNullLiteral>] GML =
            inherit Ol.Format.GMLBase
            /// <summary>Encode an array of features in GML 3.1.1 Simple Features.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeFeatures: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode an array of features in the GML 3.1.1 format as an XML node.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeFeaturesNode: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> Node

        type [<AllowNullLiteral>] GMLStatic =
            /// <param name="opt_options">Optional configuration object.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.GMLOptions -> GML

        type [<AllowNullLiteral>] GML2 =
            inherit Ol.Format.GMLBase

        type [<AllowNullLiteral>] GML2Static =
            /// <param name="opt_options">Optional configuration object.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.GMLOptions -> GML2

        type [<AllowNullLiteral>] GML3 =
            inherit Ol.Format.GMLBase
            /// <summary>Encode a geometry in GML 3.1.1 Simple Features.</summary>
            /// <param name="geometry">Geometry.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeGeometryNode: geometry: Ol.Geom.Geometry * ?opt_options: Olx.Format.WriteOptions -> Node
            /// <summary>Encode an array of features in GML 3.1.1 Simple Features.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeFeatures: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode an array of features in the GML 3.1.1 format as an XML node.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeFeaturesNode: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> Node

        type [<AllowNullLiteral>] GML3Static =
            /// <param name="opt_options">Optional configuration object.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.GMLOptions -> GML3

        type [<AllowNullLiteral>] GMLBase =
            inherit Ol.Format.XMLFeature
            /// <summary>Read all features from a GML FeatureCollection.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>

        type [<AllowNullLiteral>] GMLBaseStatic =
            /// <param name="opt_options">Optional configuration object.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.GMLOptions -> GMLBase

        type [<AllowNullLiteral>] GPX =
            inherit Ol.Format.XMLFeature
            /// <summary>Read the first feature from a GPX source.
            /// Routes (`<rte>`) are converted into LineString geometries, and tracks (`<trk>`)
            /// into MultiLineString. Any properties on route and track waypoints are ignored.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeature: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Feature
            /// <summary>Read all features from a GPX source.
            /// Routes (`<rte>`) are converted into LineString geometries, and tracks (`<trk>`)
            /// into MultiLineString. Any properties on route and track waypoints are ignored.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read the projection from a GPX source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection
            /// <summary>Encode an array of features in the GPX format.
            /// LineString geometries are output as routes (`<rte>`), and MultiLineString
            /// as tracks (`<trk>`).</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeatures: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode an array of features in the GPX format as an XML node.
            /// LineString geometries are output as routes (`<rte>`), and MultiLineString
            /// as tracks (`<trk>`).</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeFeaturesNode: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> Node

        type [<AllowNullLiteral>] GPXStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.GPXOptions -> GPX

        type [<StringEnum>] [<RequireQualifiedAccess>] IGCZ =
            | Barometric
            | Gps
            | None

        type [<AllowNullLiteral>] IGC =
            inherit Ol.Format.TextFeature
            /// <summary>Read the feature from the IGC source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeature: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Feature
            /// <summary>Read the feature from the source. As IGC sources contain a single
            /// feature, this will return the feature in an array.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read the projection from the IGC source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection

        type [<AllowNullLiteral>] IGCStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.IGCOptions -> IGC

        type [<AllowNullLiteral>] JSONFeature =
            inherit Ol.Format.Feature

        type [<AllowNullLiteral>] JSONFeatureStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> JSONFeature

        type [<AllowNullLiteral>] KML =
            inherit Ol.Format.XMLFeature
            /// <summary>Read the first feature from a KML source. MultiGeometries are converted into
            /// GeometryCollections if they are a mix of geometry types, and into MultiPoint/
            /// MultiLineString/MultiPolygon if they are all of the same type.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeature: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Feature
            /// <summary>Read all features from a KML source. MultiGeometries are converted into
            /// GeometryCollections if they are a mix of geometry types, and into MultiPoint/
            /// MultiLineString/MultiPolygon if they are all of the same type.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read the name of the KML.</summary>
            /// <param name="source">Souce.</param>
            abstract readName: source: U3<Document, Node, string> -> string
            /// <summary>Read the network links of the KML.</summary>
            /// <param name="source">Source.</param>
            abstract readNetworkLinks: source: U3<Document, Node, string> -> ResizeArray<GlobalObject>
            /// <summary>Read the projection from a KML source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection
            /// <summary>Encode an array of features in the KML format. GeometryCollections, MultiPoints,
            /// MultiLineStrings, and MultiPolygons are output as MultiGeometries.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeFeatures: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode an array of features in the KML format as an XML node. GeometryCollections,
            /// MultiPoints, MultiLineStrings, and MultiPolygons are output as MultiGeometries.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Options.</param>
            abstract writeFeaturesNode: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> Node

        type [<AllowNullLiteral>] KMLStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.KMLOptions -> KML

        type [<AllowNullLiteral>] MVT =
            inherit Ol.Format.Feature
            abstract readFeatures: source: U5<Document, Node, ArrayBuffer, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection
            /// <summary>Sets the layers that features will be read from.</summary>
            /// <param name="layers">Layers.</param>
            abstract setLayers: layers: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] MVTStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.MVTOptions -> MVT

        module Filter =

            type [<AllowNullLiteral>] IExports =
                /// <summary>Create a `<Intersects>` operator to test whether a geometry-valued property
                /// intersects a given geometry.</summary>
                /// <param name="geometryName">Geometry name to use.</param>
                /// <param name="geometry">Geometry.</param>
                /// <param name="opt_srsName">SRS name. No srsName attribute will be
                /// set on geometries when this is not provided.</param>
                abstract intersects: geometryName: string * geometry: Ol.Geom.Geometry * ?opt_srsName: string -> Ol.Format.Filter.Intersects
                /// <summary>Create a logical `<Or>` operator between two or more filter conditions.</summary>
                /// <param name="conditions">Filter conditions.</param>
                abstract ``or``: [<ParamArray>] conditions: ResizeArray<Ol.Format.Filter.Filter> -> Ol.Format.Filter.Or
                /// <summary>Create a logical `<And>` operator between two or more filter conditions.</summary>
                /// <param name="conditions">Filter conditions.</param>
                abstract ``and``: [<ParamArray>] conditions: ResizeArray<Ol.Format.Filter.Filter> -> Ol.Format.Filter.And
                /// <summary>Represents a logical `<Not>` operator for a filter condition.</summary>
                /// <param name="condition">Filter condition.</param>
                abstract not: condition: Ol.Format.Filter.Filter -> Ol.Format.Filter.Not
                /// <summary>Create a `<BBOX>` operator to test whether a geometry-valued property
                /// intersects a fixed bounding box</summary>
                /// <param name="geometryName">Geometry name to use.</param>
                /// <param name="extent">Extent.</param>
                /// <param name="opt_srsName">SRS name. No srsName attribute will be
                /// set on geometries when this is not provided.</param>
                abstract bbox: geometryName: string * extent: Ol.Extent * ?opt_srsName: string -> Ol.Format.Filter.Bbox
                /// <summary>Create a `<Within>` operator to test whether a geometry-valued property
                /// is within a given geometry.</summary>
                /// <param name="geometryName">Geometry name to use.</param>
                /// <param name="geometry">Geometry.</param>
                /// <param name="opt_srsName">SRS name. No srsName attribute will be
                /// set on geometries when this is not provided.</param>
                abstract within: geometryName: string * geometry: Ol.Geom.Geometry * ?opt_srsName: string -> Ol.Format.Filter.Within
                /// <summary>Creates a `<PropertyIsEqualTo>` comparison operator.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                /// <param name="opt_matchCase">Case-sensitive?</param>
                abstract equalTo: propertyName: string * expression: U2<string, float> * ?opt_matchCase: bool -> Ol.Format.Filter.EqualTo
                /// <summary>Creates a `<PropertyIsNotEqualTo>` comparison operator.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                /// <param name="opt_matchCase">Case-sensitive?</param>
                abstract notEqualTo: propertyName: string * expression: U2<string, float> * ?opt_matchCase: bool -> Ol.Format.Filter.NotEqualTo
                /// <summary>Creates a `<PropertyIsLessThan>` comparison operator.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                abstract lessThan: propertyName: string * expression: float -> Ol.Format.Filter.LessThan
                /// <summary>Creates a `<PropertyIsLessThanOrEqualTo>` comparison operator.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                abstract lessThanOrEqualTo: propertyName: string * expression: float -> Ol.Format.Filter.LessThanOrEqualTo
                /// <summary>Creates a `<PropertyIsGreaterThan>` comparison operator.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                abstract greaterThan: propertyName: string * expression: float -> Ol.Format.Filter.GreaterThan
                /// <summary>Creates a `<PropertyIsGreaterThanOrEqualTo>` comparison operator.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                abstract greaterThanOrEqualTo: propertyName: string * expression: float -> Ol.Format.Filter.GreaterThanOrEqualTo
                /// <summary>Creates a `<PropertyIsNull>` comparison operator to test whether a property value
                /// is null.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                abstract isNull: propertyName: string -> Ol.Format.Filter.IsNull
                /// <summary>Creates a `<PropertyIsBetween>` comparison operator to test whether an expression
                /// value lies within a range given by a lower and upper bound (inclusive).</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="lowerBoundary">The lower bound of the range.</param>
                /// <param name="upperBoundary">The upper bound of the range.</param>
                abstract between: propertyName: string * lowerBoundary: float * upperBoundary: float -> Ol.Format.Filter.IsBetween
                /// <summary>Represents a `<PropertyIsLike>` comparison operator that matches a string property
                /// value against a text pattern.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="pattern">Text pattern.</param>
                /// <param name="opt_wildCard">Pattern character which matches any sequence of
                /// zero or more string characters. Default is '*'.</param>
                /// <param name="opt_singleChar">pattern character which matches any single
                /// string character. Default is '.'.</param>
                /// <param name="opt_escapeChar">Escape character which can be used to escape
                /// the pattern characters. Default is '!'.</param>
                /// <param name="opt_matchCase">Case-sensitive?</param>
                abstract like: propertyName: string * pattern: string * ?opt_wildCard: string * ?opt_singleChar: string * ?opt_escapeChar: string * ?opt_matchCase: bool -> Ol.Format.Filter.IsLike
                /// <summary>Create a `<During>` temporal operator.</summary>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="begin">The begin date in ISO-8601 format.</param>
                /// <param name="end">The end date in ISO-8601 format.</param>
                abstract during: propertyName: string * ``begin``: string * ``end``: string -> Ol.Format.Filter.During
                abstract Filter: FilterStatic
                abstract Spatial: SpatialStatic
                abstract Intersects: IntersectsStatic
                abstract Within: WithinStatic
                abstract LogicalNary: LogicalNaryStatic
                abstract And: AndStatic
                abstract Or: OrStatic
                abstract Comparison: ComparisonStatic
                abstract ComparisonBinary: ComparisonBinaryStatic
                abstract EqualTo: EqualToStatic
                abstract GreaterThan: GreaterThanStatic
                abstract GreaterThanOrEqualTo: GreaterThanOrEqualToStatic
                abstract LessThan: LessThanStatic
                abstract LessThanOrEqualTo: LessThanOrEqualToStatic
                abstract NotEqualTo: NotEqualToStatic
                abstract During: DuringStatic
                abstract IsBetween: IsBetweenStatic
                abstract IsLike: IsLikeStatic
                abstract IsNull: IsNullStatic
                abstract Not: NotStatic
                abstract Bbox: BboxStatic

            type [<AllowNullLiteral>] Filter =
                /// The XML tag name for a filter.
                abstract getTagName: unit -> string

            type [<AllowNullLiteral>] FilterStatic =
                /// <param name="tagName">The XML tag name for this filter.</param>
                [<Emit "new $0($1...)">] abstract Create: tagName: string -> Filter

            type [<AllowNullLiteral>] Spatial =
                inherit Ol.Format.Filter.Filter

            type [<AllowNullLiteral>] SpatialStatic =
                /// <param name="tagName">The XML tag name for this filter.</param>
                /// <param name="geometryName">Geometry name to use.</param>
                /// <param name="geometry">Geometry.</param>
                /// <param name="opt_srsName">SRS name. No srsName attribute will be
                /// set on geometries when this is not provided.</param>
                [<Emit "new $0($1...)">] abstract Create: tagName: string * geometryName: string * geometry: Ol.Geom.Geometry * ?opt_srsName: string -> Spatial

            type [<AllowNullLiteral>] Intersects =
                inherit Ol.Format.Filter.Spatial

            type [<AllowNullLiteral>] IntersectsStatic =
                /// <param name="geometryName">Geometry name to use.</param>
                /// <param name="geometry">Geometry.</param>
                /// <param name="opt_srsName">SRS name. No srsName attribute will be
                /// set on geometries when this is not provided.</param>
                [<Emit "new $0($1...)">] abstract Create: geometryName: string * geometry: Ol.Geom.Geometry * ?opt_srsName: string -> Intersects

            type [<AllowNullLiteral>] Within =
                inherit Ol.Format.Filter.Spatial

            type [<AllowNullLiteral>] WithinStatic =
                /// <param name="geometryName">Geometry name to use.</param>
                /// <param name="geometry">Geometry.</param>
                /// <param name="opt_srsName">SRS name. No srsName attribute will be
                /// set on geometries when this is not provided.</param>
                [<Emit "new $0($1...)">] abstract Create: geometryName: string * geometry: Ol.Geom.Geometry * ?opt_srsName: string -> Within

            type [<AllowNullLiteral>] LogicalNary =
                inherit Ol.Format.Filter.Filter

            type [<AllowNullLiteral>] LogicalNaryStatic =
                [<Emit "new $0($1...)">] abstract Create: unit -> LogicalNary

            type [<AllowNullLiteral>] And =
                inherit Ol.Format.Filter.LogicalNary

            type [<AllowNullLiteral>] AndStatic =
                /// <param name="conditions">Conditions</param>
                [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] conditions: ResizeArray<Ol.Format.Filter.Filter> -> And

            type [<AllowNullLiteral>] Or =
                inherit Ol.Format.Filter.LogicalNary

            type [<AllowNullLiteral>] OrStatic =
                /// <param name="conditions">Conditions</param>
                [<Emit "new $0($1...)">] abstract Create: [<ParamArray>] conditions: ResizeArray<Ol.Format.Filter.Filter> -> Or

            type [<AllowNullLiteral>] Comparison =
                inherit Ol.Format.Filter.Filter

            type [<AllowNullLiteral>] ComparisonStatic =
                /// <param name="tagName">The XML tag name for this filter.</param>
                /// <param name="propertyName">Name of the context property to compare.</param>
                [<Emit "new $0($1...)">] abstract Create: tagName: string * propertyName: string -> Comparison

            type [<AllowNullLiteral>] ComparisonBinary =
                inherit Ol.Format.Filter.Comparison

            type [<AllowNullLiteral>] ComparisonBinaryStatic =
                /// <param name="tagName">The XML tag name for this filter.</param>
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                /// <param name="opt_matchCase">Case-sensitive?</param>
                [<Emit "new $0($1...)">] abstract Create: tagName: string * propertyName: string * expression: U2<string, float> * ?opt_matchCase: bool -> ComparisonBinary

            type [<AllowNullLiteral>] EqualTo =
                inherit Ol.Format.Filter.ComparisonBinary

            type [<AllowNullLiteral>] EqualToStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                /// <param name="opt_matchCase">Case-sensitive?</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * expression: U2<string, float> * ?opt_matchCase: bool -> EqualTo

            type [<AllowNullLiteral>] GreaterThan =
                inherit Ol.Format.Filter.ComparisonBinary

            type [<AllowNullLiteral>] GreaterThanStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * expression: float -> GreaterThan

            type [<AllowNullLiteral>] GreaterThanOrEqualTo =
                inherit Ol.Format.Filter.ComparisonBinary

            type [<AllowNullLiteral>] GreaterThanOrEqualToStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * expression: float -> GreaterThanOrEqualTo

            type [<AllowNullLiteral>] LessThan =
                inherit Ol.Format.Filter.ComparisonBinary

            type [<AllowNullLiteral>] LessThanStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * expression: float -> LessThan

            type [<AllowNullLiteral>] LessThanOrEqualTo =
                inherit Ol.Format.Filter.ComparisonBinary

            type [<AllowNullLiteral>] LessThanOrEqualToStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * expression: float -> LessThanOrEqualTo

            type [<AllowNullLiteral>] NotEqualTo =
                inherit Ol.Format.Filter.ComparisonBinary

            type [<AllowNullLiteral>] NotEqualToStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="expression">The value to compare.</param>
                /// <param name="opt_matchCase">Case-sensitive?</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * expression: U2<string, float> * ?opt_matchCase: bool -> NotEqualTo

            type [<AllowNullLiteral>] During =
                inherit Ol.Format.Filter.Comparison

            type [<AllowNullLiteral>] DuringStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="begin">The begin date in ISO-8601 format.</param>
                /// <param name="end">The end date in ISO-8601 format.</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * ``begin``: string * ``end``: string -> During

            type [<AllowNullLiteral>] IsBetween =
                inherit Ol.Format.Filter.Comparison

            type [<AllowNullLiteral>] IsBetweenStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="lowerBoundary">The lower bound of the range.</param>
                /// <param name="upperBoundary">The upper bound of the range.</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * lowerBoundary: float * upperBoundary: float -> IsBetween

            type [<AllowNullLiteral>] IsLike =
                inherit Ol.Format.Filter.Comparison

            type [<AllowNullLiteral>] IsLikeStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                /// <param name="pattern">Text pattern.</param>
                /// <param name="opt_wildCard">Pattern character which matches any sequence of
                /// zero or more string characters. Default is '*'.</param>
                /// <param name="opt_singleChar">pattern character which matches any single
                /// string character. Default is '.'.</param>
                /// <param name="opt_escapeChar">Escape character which can be used to escape
                /// the pattern characters. Default is '!'.</param>
                /// <param name="opt_matchCase">Case-sensitive?</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string * pattern: string * ?opt_wildCard: string * ?opt_singleChar: string * ?opt_escapeChar: string * ?opt_matchCase: bool -> IsLike

            type [<AllowNullLiteral>] IsNull =
                inherit Ol.Format.Filter.Comparison

            type [<AllowNullLiteral>] IsNullStatic =
                /// <param name="propertyName">Name of the context property to compare.</param>
                [<Emit "new $0($1...)">] abstract Create: propertyName: string -> IsNull

            type [<AllowNullLiteral>] Not =
                inherit Ol.Format.Filter.Filter

            type [<AllowNullLiteral>] NotStatic =
                /// <param name="condition">Filter condition.</param>
                [<Emit "new $0($1...)">] abstract Create: condition: Ol.Format.Filter.Filter -> Not

            type [<AllowNullLiteral>] Bbox =
                inherit Ol.Format.Filter.Filter

            type [<AllowNullLiteral>] BboxStatic =
                /// <param name="geometryName">Geometry name to use.</param>
                /// <param name="extent">Extent.</param>
                /// <param name="opt_srsName">SRS name. No srsName attribute will be
                /// set on geometries when this is not provided.</param>
                [<Emit "new $0($1...)">] abstract Create: geometryName: string * extent: Ol.Extent * ?opt_srsName: string -> Bbox

        type [<AllowNullLiteral>] OSMXML =
            inherit Ol.Format.XMLFeature
            /// <summary>Read all features from an OSM source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read the projection from an OSM source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection

        type [<AllowNullLiteral>] OSMXMLStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> OSMXML

        type [<AllowNullLiteral>] Polyline =
            inherit Ol.Format.TextFeature
            /// <summary>Read the feature from the Polyline source. The coordinates are assumed to be
            /// in two dimensions and in latitude, longitude order.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeature: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Feature
            /// <summary>Read the feature from the source. As Polyline sources contain a single
            /// feature, this will return the feature in an array.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read the geometry from the source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readGeometry: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Geom.Geometry
            /// <summary>Read the projection from a Polyline source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection
            /// <summary>Write a single geometry in Polyline format.</summary>
            /// <param name="geometry">Geometry.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeGeometry: geometry: Ol.Geom.Geometry * ?opt_options: Olx.Format.WriteOptions -> string

        type [<AllowNullLiteral>] PolylineStatic =
            /// <param name="opt_options">Optional configuration object.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.PolylineOptions -> Polyline
            /// <summary>Encode a list of n-dimensional points and return an encoded string
            ///
            /// Attention: This function will modify the passed array!</summary>
            /// <param name="numbers">A list of n-dimensional points.</param>
            /// <param name="stride">The number of dimension of the points in the list.</param>
            /// <param name="opt_factor">The factor by which the numbers will be
            /// multiplied. The remaining decimal places will get rounded away.
            /// Default is `1e5`.</param>
            abstract encodeDeltas: numbers: ResizeArray<float> * stride: float * ?opt_factor: float -> string
            /// <summary>Decode a list of n-dimensional points from an encoded string</summary>
            /// <param name="encoded">An encoded string.</param>
            /// <param name="stride">The number of dimension of the points in the
            /// encoded string.</param>
            /// <param name="opt_factor">The factor by which the resulting numbers will
            /// be divided. Default is `1e5`.</param>
            abstract decodeDeltas: encoded: string * stride: float * ?opt_factor: float -> ResizeArray<float>
            /// <summary>Encode a list of floating point numbers and return an encoded string
            ///
            /// Attention: This function will modify the passed array!</summary>
            /// <param name="numbers">A list of floating point numbers.</param>
            /// <param name="opt_factor">The factor by which the numbers will be
            /// multiplied. The remaining decimal places will get rounded away.
            /// Default is `1e5`.</param>
            abstract encodeFloats: numbers: ResizeArray<float> * ?opt_factor: float -> string
            /// <summary>Decode a list of floating point numbers from an encoded string</summary>
            /// <param name="encoded">An encoded string.</param>
            /// <param name="opt_factor">The factor by which the result will be divided.
            /// Default is `1e5`.</param>
            abstract decodeFloats: encoded: string * ?opt_factor: float -> ResizeArray<float>

        type [<AllowNullLiteral>] TextFeature =
            inherit Ol.Format.Feature

        type [<AllowNullLiteral>] TextFeatureStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> TextFeature

        type [<AllowNullLiteral>] TopoJSON =
            inherit Ol.Format.JSONFeature
            /// <summary>Read all features from a TopoJSON source.</summary>
            /// <param name="source">Source.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> -> ResizeArray<Ol.Feature>
            /// <summary>Read the projection from a TopoJSON source.</summary>
            /// <param name="object">Source.</param>
            abstract readProjection: ``object``: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection

        type [<AllowNullLiteral>] TopoJSONStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.TopoJSONOptions -> TopoJSON

        type [<AllowNullLiteral>] WFS =
            inherit Ol.Format.XMLFeature
            /// <summary>Read all features from a WFS FeatureCollection.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read transaction response of the source.</summary>
            /// <param name="source">Source.</param>
            abstract readTransactionResponse: source: U4<Document, Node, GlobalObject, string> -> Ol.WFSTransactionResponse
            /// <summary>Read feature collection metadata of the source.</summary>
            /// <param name="source">Source.</param>
            abstract readFeatureCollectionMetadata: source: U4<Document, Node, GlobalObject, string> -> Ol.WFSFeatureCollectionMetadata
            /// <summary>Encode format as WFS `GetFeature` and return the Node.</summary>
            /// <param name="options">Options.</param>
            abstract writeGetFeature: options: Olx.Format.WFSWriteGetFeatureOptions -> Node
            /// <summary>Encode format as WFS `Transaction` and return the Node.</summary>
            /// <param name="inserts">The features to insert.</param>
            /// <param name="updates">The features to update.</param>
            /// <param name="deletes">The features to delete.</param>
            /// <param name="options">Write options.</param>
            abstract writeTransaction: inserts: ResizeArray<Ol.Feature> * updates: ResizeArray<Ol.Feature> * deletes: ResizeArray<Ol.Feature> * options: Olx.Format.WFSWriteTransactionOptions -> Node
            /// <summary>Read the projection from a WFS source.</summary>
            /// <param name="source">Source.</param>
            abstract readProjection: source: U4<Document, Node, GlobalObject, string> -> Ol.Proj.Projection

        type [<AllowNullLiteral>] WFSStatic =
            /// <param name="opt_options">Optional configuration object.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.WFSOptions -> WFS

        type [<AllowNullLiteral>] WKT =
            inherit Ol.Format.TextFeature
            /// <summary>Read a feature from a WKT source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeature: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Feature
            /// <summary>Read all features from a WKT source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>
            /// <summary>Read a single geometry from a WKT source.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Read options.</param>
            abstract readGeometry: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> Ol.Geom.Geometry
            /// <summary>Encode a feature as a WKT string.</summary>
            /// <param name="feature">Feature.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeature: feature: Ol.Feature * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Encode an array of features as a WKT string.</summary>
            /// <param name="features">Features.</param>
            /// <param name="opt_options">Write options.</param>
            abstract writeFeatures: features: ResizeArray<Ol.Feature> * ?opt_options: Olx.Format.WriteOptions -> string
            /// <summary>Write a single geometry as a WKT string.</summary>
            /// <param name="geometry">Geometry.</param>
            abstract writeGeometry: geometry: Ol.Geom.Geometry -> string

        type [<AllowNullLiteral>] WKTStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.WKTOptions -> WKT

        type [<AllowNullLiteral>] WMSCapabilities =
            inherit Ol.Format.XML
            /// <summary>Read a WMS capabilities document.</summary>
            /// <param name="source">The XML source.</param>
            abstract read: source: U3<Document, Node, string> -> GlobalObject

        type [<AllowNullLiteral>] WMSCapabilitiesStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WMSCapabilities

        type [<AllowNullLiteral>] WMSGetFeatureInfo =
            inherit Ol.Format.XMLFeature
            /// <summary>Read all features from a WMSGetFeatureInfo response.</summary>
            /// <param name="source">Source.</param>
            /// <param name="opt_options">Options.</param>
            abstract readFeatures: source: U4<Document, Node, GlobalObject, string> * ?opt_options: Olx.Format.ReadOptions -> ResizeArray<Ol.Feature>

        type [<AllowNullLiteral>] WMSGetFeatureInfoStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Format.WMSGetFeatureInfoOptions -> WMSGetFeatureInfo

        type [<AllowNullLiteral>] WMTSCapabilities =
            inherit Ol.Format.XML
            /// <summary>Read a WMTS capabilities document.</summary>
            /// <param name="source">The XML source.</param>
            abstract read: source: U3<Document, Node, string> -> GlobalObject

        type [<AllowNullLiteral>] WMTSCapabilitiesStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> WMTSCapabilities

        type [<AllowNullLiteral>] XML =
            interface end

        type [<AllowNullLiteral>] XMLStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> XML

        type [<AllowNullLiteral>] XMLFeature =
            inherit Ol.Format.Feature

        type [<AllowNullLiteral>] XMLFeatureStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> XMLFeature

    type [<AllowNullLiteral>] Geolocation =
        inherit Ol.Object
        /// Get the accuracy of the position in meters.
        abstract getAccuracy: unit -> float
        /// Get a geometry of the position accuracy.
        abstract getAccuracyGeometry: unit -> Ol.Geom.Geometry
        /// Get the altitude associated with the position.
        abstract getAltitude: unit -> float
        /// Get the altitude accuracy of the position.
        abstract getAltitudeAccuracy: unit -> float
        /// Get the heading as radians clockwise from North.
        abstract getHeading: unit -> float
        /// Get the position of the device.
        abstract getPosition: unit -> Ol.Coordinate
        /// Get the projection associated with the position.
        abstract getProjection: unit -> Ol.Proj.Projection
        /// Get the speed in meters per second.
        abstract getSpeed: unit -> float
        /// Determine if the device location is being tracked.
        abstract getTracking: unit -> bool
        /// Get the tracking options.
        abstract getTrackingOptions: unit -> PositionOptions
        /// <summary>Set the projection to use for transforming the coordinates.</summary>
        /// <param name="projection">The projection the position is
        /// reported in.</param>
        abstract setProjection: projection: Ol.Proj.Projection -> unit
        /// <summary>Enable or disable tracking.</summary>
        /// <param name="tracking">Enable tracking.</param>
        abstract setTracking: tracking: bool -> unit
        /// <summary>Set the tracking options.</summary>
        /// <param name="options">PositionOptions as defined by the
        /// [HTML5 Geolocation spec
        /// ](http://www.w3.org/TR/geolocation-API/#position_options_interface).</param>
        abstract setTrackingOptions: options: PositionOptions -> unit

    type [<AllowNullLiteral>] GeolocationStatic =
        /// <param name="opt_options">Options.</param>
        [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.GeolocationOptions -> Geolocation

    module Geom =

        type [<AllowNullLiteral>] IExports =
            abstract Circle: CircleStatic
            abstract Geometry: GeometryStatic
            abstract GeometryCollection: GeometryCollectionStatic
            abstract LinearRing: LinearRingStatic
            abstract LineString: LineStringStatic
            abstract MultiLineString: MultiLineStringStatic
            abstract MultiPoint: MultiPointStatic
            abstract MultiPolygon: MultiPolygonStatic
            abstract Point: PointStatic
            abstract Polygon: PolygonStatic
            abstract SimpleGeometry: SimpleGeometryStatic

        type [<AllowNullLiteral>] Circle =
            inherit Ol.Geom.SimpleGeometry
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.Circle
            /// Return the center of the circle as {@link ol.Coordinate coordinate}.
            abstract getCenter: unit -> Ol.Coordinate
            /// Return the radius of the circle.
            abstract getRadius: unit -> float
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the center of the circle as {@link ol.Coordinate coordinate}.</summary>
            /// <param name="center">Center.</param>
            abstract setCenter: center: Ol.Coordinate -> unit
            /// <summary>Set the center (as {@link ol.Coordinate coordinate}) and the radius (as
            /// number) of the circle.</summary>
            /// <param name="center">Center.</param>
            /// <param name="radius">Radius.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCenterAndRadius: center: Ol.Coordinate * radius: float * ?opt_layout: Ol.Geom.GeometryLayout -> unit
            /// <summary>Set the radius of the circle. The radius is in the units of the projection.</summary>
            /// <param name="radius">Radius.</param>
            abstract setRadius: radius: float -> unit

        type [<AllowNullLiteral>] CircleStatic =
            /// <param name="center">Center.</param>
            /// <param name="opt_radius">Radius.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: center: Ol.Coordinate * ?opt_radius: float * ?opt_layout: Ol.Geom.GeometryLayout -> Circle

        type [<StringEnum>] [<RequireQualifiedAccess>] GeometryType =
            | [<CompiledName "Point">] Point
            | [<CompiledName "LineString">] LineString
            | [<CompiledName "LinearRing">] LinearRing
            | [<CompiledName "Polygon">] Polygon
            | [<CompiledName "MultiPoint">] MultiPoint
            | [<CompiledName "MultiLineString">] MultiLineString
            | [<CompiledName "MultiPolygon">] MultiPolygon
            | [<CompiledName "GeometryCollection">] GeometryCollection
            | [<CompiledName "Circle">] Circle

        type [<StringEnum>] [<RequireQualifiedAccess>] GeometryLayout =
            | [<CompiledName "XY">] XY
            | [<CompiledName "XYZ">] XYZ
            | [<CompiledName "XYM">] XYM
            | [<CompiledName "XYZM">] XYZM

        type [<AllowNullLiteral>] Geometry =
            inherit Ol.Object
            /// <summary>Return the closest point of the geometry to the passed point as
            /// {@link ol.Coordinate coordinate}.</summary>
            /// <param name="point">Point.</param>
            /// <param name="opt_closestPoint">Closest point.</param>
            abstract getClosestPoint: point: Ol.Coordinate * ?opt_closestPoint: Ol.Coordinate -> Ol.Coordinate
            /// <summary>Returns true if this geometry includes the specified coordinate. If the
            /// coordinate is on the boundary of the geometry, returns false.</summary>
            /// <param name="coordinate">Coordinate.</param>
            abstract intersectsCoordinate: coordinate: Ol.Coordinate -> bool
            /// <summary>Get the extent of the geometry.</summary>
            /// <param name="opt_extent">Extent.</param>
            abstract getExtent: ?opt_extent: Ol.Extent -> Ol.Extent
            /// <summary>Rotate the geometry around a given coordinate. This modifies the geometry
            /// coordinates in place.</summary>
            /// <param name="angle">Rotation angle in radians.</param>
            /// <param name="anchor">The rotation center.</param>
            abstract rotate: angle: float * anchor: Ol.Coordinate -> unit
            /// <summary>Scale the geometry (with an optional origin).  This modifies the geometry
            /// coordinates in place.</summary>
            /// <param name="sx">The scaling factor in the x-direction.</param>
            /// <param name="opt_sy">The scaling factor in the y-direction (defaults to
            /// sx).</param>
            /// <param name="opt_anchor">The scale origin (defaults to the center
            /// of the geometry extent).</param>
            abstract scale: sx: float * ?opt_sy: float * ?opt_anchor: Ol.Coordinate -> unit
            /// <summary>Create a simplified version of this geometry.  For linestrings, this uses
            /// the the {@link
            /// https://en.wikipedia.org/wiki/Ramer-Douglas-Peucker_algorithm
            /// Douglas Peucker} algorithm.  For polygons, a quantization-based
            /// simplification is used to preserve topology.</summary>
            /// <param name="tolerance">The tolerance distance for simplification.</param>
            abstract simplify: tolerance: float -> Ol.Geom.Geometry
            /// <summary>Transform each coordinate of the geometry from one coordinate reference
            /// system to another. The geometry is modified in place.
            /// For example, a line will be transformed to a line and a circle to a circle.
            /// If you do not want the geometry modified in place, first `clone()` it and
            /// then use this function on the clone.</summary>
            /// <param name="source">The current projection.  Can be a
            /// string identifier or a {</param>
            /// <param name="destination">The desired projection.  Can be a
            /// string identifier or a {</param>
            abstract transform: source: Ol.ProjectionLike * destination: Ol.ProjectionLike -> Ol.Geom.Geometry
            /// Get the type of this geometry.
            abstract getType: unit -> Ol.Geom.GeometryType

        type [<AllowNullLiteral>] GeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> Geometry

        type [<AllowNullLiteral>] GeometryCollection =
            inherit Ol.Geom.Geometry
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.GeometryCollection
            /// Return the geometries that make up this geometry collection.
            abstract getGeometries: unit -> ResizeArray<Ol.Geom.Geometry>
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the geometries that make up this geometry collection.</summary>
            /// <param name="geometries">Geometries.</param>
            abstract setGeometries: geometries: ResizeArray<Ol.Geom.Geometry> -> unit
            abstract applyTransform: transformFn: Ol.TransformFunction -> unit
            /// <summary>Translate the geometry.</summary>
            /// <param name="deltaX">Delta X.</param>
            /// <param name="deltaY">Delta Y.</param>
            abstract translate: deltaX: float * deltaY: float -> unit

        type [<AllowNullLiteral>] GeometryCollectionStatic =
            /// <param name="opt_geometries">Geometries.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_geometries: ResizeArray<Ol.Geom.Geometry> -> GeometryCollection

        type [<AllowNullLiteral>] LinearRing =
            inherit Ol.Geom.SimpleGeometry
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.LinearRing
            /// Return the area of the linear ring on projected plane.
            abstract getArea: unit -> float
            /// Return the coordinates of the linear ring.
            abstract getCoordinates: unit -> ResizeArray<Ol.Coordinate>
            abstract getType: unit -> Ol.Geom.GeometryType
            /// <summary>Set the coordinates of the linear ring.</summary>
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCoordinates: coordinates: ResizeArray<Ol.Coordinate> * ?opt_layout: Ol.Geom.GeometryLayout -> unit

        type [<AllowNullLiteral>] LinearRingStatic =
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: coordinates: ResizeArray<Ol.Coordinate> * ?opt_layout: Ol.Geom.GeometryLayout -> LinearRing

        type [<AllowNullLiteral>] LineString =
            inherit Ol.Geom.SimpleGeometry
            /// <summary>Append the passed coordinate to the coordinates of the linestring.</summary>
            /// <param name="coordinate">Coordinate.</param>
            abstract appendCoordinate: coordinate: Ol.Coordinate -> unit
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.LineString
            /// <summary>Iterate over each segment, calling the provided callback.
            /// If the callback returns a truthy value the function returns that
            /// value immediately. Otherwise the function returns `false`.</summary>
            /// <param name="callback">Function
            /// called for each segment.</param>
            /// <param name="opt_this">The object to be used as the value of 'this'
            /// within callback.</param>
            abstract forEachSegment: callback: ('S -> Ol.Coordinate -> Ol.Coordinate -> 'T) * ?opt_this: 'S -> U2<'T, bool>
            /// <summary>Returns the coordinate at `m` using linear interpolation, or `null` if no
            /// such coordinate exists.
            ///
            /// `opt_extrapolate` controls extrapolation beyond the range of Ms in the
            /// MultiLineString. If `opt_extrapolate` is `true` then Ms less than the first
            /// M will return the first coordinate and Ms greater than the last M will
            /// return the last coordinate.</summary>
            /// <param name="m">M.</param>
            /// <param name="opt_extrapolate">Extrapolate. Default is `false`.</param>
            abstract getCoordinateAtM: m: float * ?opt_extrapolate: bool -> Ol.Coordinate
            /// Return the coordinates of the linestring.
            abstract getCoordinates: unit -> ResizeArray<Ol.Coordinate>
            /// <summary>Return the coordinate at the provided fraction along the linestring.
            /// The `fraction` is a number between 0 and 1, where 0 is the start of the
            /// linestring and 1 is the end.</summary>
            /// <param name="fraction">Fraction.</param>
            /// <param name="opt_dest">Optional coordinate whose values will
            /// be modified. If not provided, a new coordinate will be returned.</param>
            abstract getCoordinateAt: fraction: float * ?opt_dest: Ol.Coordinate -> Ol.Coordinate
            /// Return the length of the linestring on projected plane.
            abstract getLength: unit -> float
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the coordinates of the linestring.</summary>
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCoordinates: coordinates: ResizeArray<Ol.Coordinate> * ?opt_layout: Ol.Geom.GeometryLayout -> unit

        type [<AllowNullLiteral>] LineStringStatic =
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: coordinates: ResizeArray<Ol.Coordinate> * ?opt_layout: Ol.Geom.GeometryLayout -> LineString

        type [<AllowNullLiteral>] MultiLineString =
            inherit Ol.Geom.SimpleGeometry
            /// <summary>Append the passed linestring to the multilinestring.</summary>
            /// <param name="lineString">LineString.</param>
            abstract appendLineString: lineString: Ol.Geom.LineString -> unit
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.MultiLineString
            /// <summary>Returns the coordinate at `m` using linear interpolation, or `null` if no
            /// such coordinate exists.
            ///
            /// `opt_extrapolate` controls extrapolation beyond the range of Ms in the
            /// MultiLineString. If `opt_extrapolate` is `true` then Ms less than the first
            /// M will return the first coordinate and Ms greater than the last M will
            /// return the last coordinate.
            ///
            /// `opt_interpolate` controls interpolation between consecutive LineStrings
            /// within the MultiLineString. If `opt_interpolate` is `true` the coordinates
            /// will be linearly interpolated between the last coordinate of one LineString
            /// and the first coordinate of the next LineString.  If `opt_interpolate` is
            /// `false` then the function will return `null` for Ms falling between
            /// LineStrings.</summary>
            /// <param name="m">M.</param>
            /// <param name="opt_extrapolate">Extrapolate. Default is `false`.</param>
            /// <param name="opt_interpolate">Interpolate. Default is `false`.</param>
            abstract getCoordinateAtM: m: float * ?opt_extrapolate: bool * ?opt_interpolate: bool -> Ol.Coordinate
            /// Return the coordinates of the multilinestring.
            abstract getCoordinates: unit -> ResizeArray<ResizeArray<Ol.Coordinate>>
            /// <summary>Return the linestring at the specified index.</summary>
            /// <param name="index">Index.</param>
            abstract getLineString: index: float -> Ol.Geom.LineString
            /// Return the linestrings of this multilinestring.
            abstract getLineStrings: unit -> ResizeArray<Ol.Geom.LineString>
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the coordinates of the multilinestring.</summary>
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCoordinates: coordinates: ResizeArray<ResizeArray<Ol.Coordinate>> * ?opt_layout: Ol.Geom.GeometryLayout -> unit

        type [<AllowNullLiteral>] MultiLineStringStatic =
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: coordinates: ResizeArray<ResizeArray<Ol.Coordinate>> * ?opt_layout: Ol.Geom.GeometryLayout -> MultiLineString

        type [<AllowNullLiteral>] MultiPoint =
            inherit Ol.Geom.SimpleGeometry
            /// <summary>Append the passed point to this multipoint.</summary>
            /// <param name="point">Point.</param>
            abstract appendPoint: point: Ol.Geom.Point -> unit
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.MultiPoint
            /// Return the coordinates of the multipoint.
            abstract getCoordinates: unit -> ResizeArray<Ol.Coordinate>
            /// <summary>Return the point at the specified index.</summary>
            /// <param name="index">Index.</param>
            abstract getPoint: index: float -> Ol.Geom.Point
            /// Return the points of this multipoint.
            abstract getPoints: unit -> ResizeArray<Ol.Geom.Point>
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the coordinates of the multipoint.</summary>
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCoordinates: coordinates: ResizeArray<Ol.Coordinate> * ?opt_layout: Ol.Geom.GeometryLayout -> unit

        type [<AllowNullLiteral>] MultiPointStatic =
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: coordinates: ResizeArray<Ol.Coordinate> * ?opt_layout: Ol.Geom.GeometryLayout -> MultiPoint

        type [<AllowNullLiteral>] MultiPolygon =
            inherit Ol.Geom.SimpleGeometry
            /// <summary>Append the passed polygon to this multipolygon.</summary>
            /// <param name="polygon">Polygon.</param>
            abstract appendPolygon: polygon: Ol.Geom.Polygon -> unit
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.MultiPolygon
            /// Return the area of the multipolygon on projected plane.
            abstract getArea: unit -> float
            /// <summary>Get the coordinate array for this geometry.  This array has the structure
            /// of a GeoJSON coordinate array for multi-polygons.</summary>
            /// <param name="opt_right">Orient coordinates according to the right-hand
            /// rule (counter-clockwise for exterior and clockwise for interior rings).
            /// If `false`, coordinates will be oriented according to the left-hand rule
            /// (clockwise for exterior and counter-clockwise for interior rings).
            /// By default, coordinate orientation will depend on how the geometry was
            /// constructed.</param>
            abstract getCoordinates: ?opt_right: bool -> ResizeArray<ResizeArray<ResizeArray<Ol.Coordinate>>>
            /// Return the interior points as {@link ol.geom.MultiPoint multipoint}.
            abstract getInteriorPoints: unit -> Ol.Geom.MultiPoint
            /// <summary>Return the polygon at the specified index.</summary>
            /// <param name="index">Index.</param>
            abstract getPolygon: index: float -> Ol.Geom.Polygon
            /// Return the polygons of this multipolygon.
            abstract getPolygons: unit -> ResizeArray<Ol.Geom.Polygon>
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the coordinates of the multipolygon.</summary>
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCoordinates: coordinates: ResizeArray<ResizeArray<ResizeArray<Ol.Coordinate>>> * ?opt_layout: Ol.Geom.GeometryLayout -> unit

        type [<AllowNullLiteral>] MultiPolygonStatic =
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: coordinates: ResizeArray<ResizeArray<ResizeArray<Ol.Coordinate>>> * ?opt_layout: Ol.Geom.GeometryLayout -> MultiPolygon

        type [<AllowNullLiteral>] Point =
            inherit Ol.Geom.SimpleGeometry
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.Point
            /// Return the coordinate of the point.
            abstract getCoordinates: unit -> Ol.Coordinate
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the coordinate of the point.</summary>
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCoordinates: coordinates: Ol.Coordinate * ?opt_layout: Ol.Geom.GeometryLayout -> unit

        type [<AllowNullLiteral>] PointStatic =
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: coordinates: Ol.Coordinate * ?opt_layout: Ol.Geom.GeometryLayout -> Point

        type [<AllowNullLiteral>] Polygon =
            inherit Ol.Geom.SimpleGeometry
            /// <summary>Append the passed linear ring to this polygon.</summary>
            /// <param name="linearRing">Linear ring.</param>
            abstract appendLinearRing: linearRing: Ol.Geom.LinearRing -> unit
            /// Make a complete copy of the geometry.
            abstract clone: unit -> Ol.Geom.Polygon
            /// Return the area of the polygon on projected plane.
            abstract getArea: unit -> float
            /// <summary>Get the coordinate array for this geometry.  This array has the structure
            /// of a GeoJSON coordinate array for polygons.</summary>
            /// <param name="opt_right">Orient coordinates according to the right-hand
            /// rule (counter-clockwise for exterior and clockwise for interior rings).
            /// If `false`, coordinates will be oriented according to the left-hand rule
            /// (clockwise for exterior and counter-clockwise for interior rings).
            /// By default, coordinate orientation will depend on how the geometry was
            /// constructed.</param>
            abstract getCoordinates: ?opt_right: bool -> ResizeArray<ResizeArray<Ol.Coordinate>>
            /// Return an interior point of the polygon.
            abstract getInteriorPoint: unit -> Ol.Geom.Point
            /// Return the number of rings of the polygon,  this includes the exterior
            /// ring and any interior rings.
            abstract getLinearRingCount: unit -> float
            /// <summary>Return the Nth linear ring of the polygon geometry. Return `null` if the
            /// given index is out of range.
            /// The exterior linear ring is available at index `0` and the interior rings
            /// at index `1` and beyond.</summary>
            /// <param name="index">Index.</param>
            abstract getLinearRing: index: float -> Ol.Geom.LinearRing
            /// Return the linear rings of the polygon.
            abstract getLinearRings: unit -> ResizeArray<Ol.Geom.LinearRing>
            abstract getType: unit -> Ol.Geom.GeometryType
            abstract intersectsExtent: extent: Ol.Extent -> bool
            /// <summary>Set the coordinates of the polygon.</summary>
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            abstract setCoordinates: coordinates: ResizeArray<ResizeArray<Ol.Coordinate>> * ?opt_layout: Ol.Geom.GeometryLayout -> unit

        type [<AllowNullLiteral>] PolygonStatic =
            /// <param name="coordinates">Coordinates.</param>
            /// <param name="opt_layout">Layout.</param>
            [<Emit "new $0($1...)">] abstract Create: coordinates: ResizeArray<ResizeArray<Ol.Coordinate>> * ?opt_layout: Ol.Geom.GeometryLayout -> Polygon
            /// <summary>Create an approximation of a circle on the surface of a sphere.</summary>
            /// <param name="sphere">The sphere.</param>
            /// <param name="center">Center (`[lon, lat]` in degrees).</param>
            /// <param name="radius">The great-circle distance from the center to
            /// the polygon vertices.</param>
            /// <param name="opt_n">Optional number of vertices for the resulting
            /// polygon. Default is `32`.</param>
            abstract circular: sphere: Ol.Sphere * center: Ol.Coordinate * radius: float * ?opt_n: float -> Ol.Geom.Polygon
            /// <summary>Create a polygon from an extent. The layout used is `XY`.</summary>
            /// <param name="extent">The extent.</param>
            abstract fromExtent: extent: Ol.Extent -> Ol.Geom.Polygon
            /// <summary>Create a regular polygon from a circle.</summary>
            /// <param name="circle">Circle geometry.</param>
            /// <param name="opt_sides">Number of sides of the polygon. Default is 32.</param>
            /// <param name="opt_angle">Start angle for the first vertex of the polygon in
            /// radians. Default is 0.</param>
            abstract fromCircle: circle: Ol.Geom.Circle * ?opt_sides: float * ?opt_angle: float -> Ol.Geom.Polygon

        type [<AllowNullLiteral>] SimpleGeometry =
            inherit Ol.Geom.Geometry
            /// Return the first coordinate of the geometry.
            abstract getFirstCoordinate: unit -> Ol.Coordinate
            /// Return the last coordinate of the geometry.
            abstract getLastCoordinate: unit -> Ol.Coordinate
            /// Return the {@link ol.geom.GeometryLayout layout} of the geometry.
            abstract getLayout: unit -> Ol.Geom.GeometryLayout
            abstract applyTransform: transformFn: Ol.TransformFunction -> unit
            abstract translate: deltaX: float * deltaY: float -> unit

        type [<AllowNullLiteral>] SimpleGeometryStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> SimpleGeometry

    /// Render a grid for a coordinate system on a map.
    type [<AllowNullLiteral>] Graticule =
        /// Get the map associated with this graticule.
        abstract getMap: unit -> Ol.Map
        /// Get the list of meridians.  Meridians are lines of equal longitude.
        abstract getMeridians: unit -> ResizeArray<Ol.Geom.LineString>
        /// Get the list of parallels.  Pallels are lines of equal latitude.
        abstract getParallels: unit -> ResizeArray<Ol.Geom.LineString>
        /// <summary>Set the map for this graticule.  The graticule will be rendered on the
        /// provided map.</summary>
        /// <param name="map">Map.</param>
        abstract setMap: map: Ol.Map -> unit

    /// Render a grid for a coordinate system on a map.
    type [<AllowNullLiteral>] GraticuleStatic =
        /// <summary>Render a grid for a coordinate system on a map.</summary>
        /// <param name="opt_options">Options.</param>
        [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.GraticuleOptions -> Graticule

    module Has =

        type [<AllowNullLiteral>] IExports =
            abstract DEVICE_PIXEL_RATIO: float
            abstract CANVAS: bool
            abstract DEVICE_ORIENTATION: bool
            abstract GEOLOCATION: bool
            abstract TOUCH: bool
            abstract WEBGL: bool

    type [<AllowNullLiteral>] Image =
        inherit Ol.ImageBase
        /// <summary>Get the HTML image element (may be a Canvas, Image, or Video).</summary>
        /// <param name="opt_context">Object.</param>
        abstract getImage: ?opt_context: GlobalObject -> U3<HTMLCanvasElement, Image, HTMLVideoElement>
        /// Load the image or retry if loading previously failed.
        /// Loading is taken care of by the tile queue, and calling this method is
        /// only needed for preloading or for reloading in case of an error.
        abstract load: unit -> unit

    type [<AllowNullLiteral>] ImageStatic =
        /// <param name="extent">Extent.</param>
        /// <param name="resolution">Resolution.</param>
        /// <param name="pixelRatio">Pixel ratio.</param>
        /// <param name="attributions">Attributions.</param>
        /// <param name="src">Image source URI.</param>
        /// <param name="crossOrigin">Cross origin.</param>
        /// <param name="imageLoadFunction">Image load function.</param>
        [<Emit "new $0($1...)">] abstract Create: extent: Ol.Extent * resolution: float * pixelRatio: float * attributions: ResizeArray<Ol.Attribution> * src: string * ?crossOrigin: string * ?imageLoadFunction: Ol.ImageLoadFunctionType -> Image

    type [<AllowNullLiteral>] ImageBase =
        inherit Ol.Events.EventTarget

    type [<AllowNullLiteral>] ImageBaseStatic =
        /// <param name="extent">Extent.</param>
        /// <param name="resolution">Resolution.</param>
        /// <param name="pixelRatio">Pixel ratio.</param>
        /// <param name="state">State.</param>
        /// <param name="attributions">Attributions.</param>
        [<Emit "new $0($1...)">] abstract Create: extent: Ol.Extent * resolution: float * pixelRatio: float * state: Ol.ImageState * attributions: ResizeArray<Ol.Attribution> -> ImageBase

    type ImageState =
        float

    type [<AllowNullLiteral>] ImageTile =
        inherit Ol.Tile
        /// Get the image element for this tile.
        abstract getImage: ?opt_context: GlobalObject -> U3<HTMLCanvasElement, HTMLImageElement, HTMLVideoElement>

    type [<AllowNullLiteral>] ImageTileStatic =
        /// <param name="tileCoord">Tile coordinate.</param>
        /// <param name="state">State.</param>
        /// <param name="src">Image source URI.</param>
        /// <param name="crossOrigin">Cross origin.</param>
        /// <param name="tileLoadFunction">Tile load function.</param>
        [<Emit "new $0($1...)">] abstract Create: tileCoord: Ol.TileCoord * state: Ol.Tile.State * src: string * ?crossOrigin: string * ?tileLoadFunction: Ol.TileLoadFunctionType -> ImageTile

    module Interaction =
        let [<Import("DragAndDrop","openlayers/ol/interaction")>] dragAndDrop: DragAndDrop.IExports = jsNative
        let [<Import("DragBox","openlayers/ol/interaction")>] dragBox: DragBox.IExports = jsNative
        let [<Import("Draw","openlayers/ol/interaction")>] draw: Draw.IExports = jsNative
        let [<Import("Modify","openlayers/ol/interaction")>] modify: Modify.IExports = jsNative
        let [<Import("Select","openlayers/ol/interaction")>] select: Select.IExports = jsNative
        let [<Import("Translate","openlayers/ol/interaction")>] translate: Translate.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract DoubleClickZoom: DoubleClickZoomStatic
            abstract DragAndDrop: DragAndDropStatic
            abstract DragBox: DragBoxStatic
            abstract DragPan: DragPanStatic
            abstract DragRotate: DragRotateStatic
            abstract DragRotateAndZoom: DragRotateAndZoomStatic
            abstract DragZoom: DragZoomStatic
            abstract Draw: DrawStatic
            /// <summary>Set of interactions included in maps by default. Specific interactions can be
            /// excluded by setting the appropriate option to false in the constructor
            /// options, but the order of the interactions is fixed.  If you want to specify
            /// a different order for interactions, you will need to create your own
            /// {@link ol.interaction.Interaction} instances and insert them into a
            /// {@link ol.Collection} in the order you want before creating your
            /// {@link ol.Map} instance. The default set of interactions, in sequence, is:
            /// * {@link ol.interaction.DragRotate}
            /// * {@link ol.interaction.DoubleClickZoom}
            /// * {@link ol.interaction.DragPan}
            /// * {@link ol.interaction.PinchRotate}
            /// * {@link ol.interaction.PinchZoom}
            /// * {@link ol.interaction.KeyboardPan}
            /// * {@link ol.interaction.KeyboardZoom}
            /// * {@link ol.interaction.MouseWheelZoom}
            /// * {@link ol.interaction.DragZoom}</summary>
            /// <param name="opt_options">Defaults options.</param>
            abstract defaults: ?opt_options: Olx.Interaction.DefaultsOptions -> Ol.Collection<Ol.Interaction.Interaction>
            abstract Interaction: InteractionStatic
            abstract KeyboardPan: KeyboardPanStatic
            abstract KeyboardZoom: KeyboardZoomStatic
            abstract Modify: ModifyStatic
            abstract MouseWheelZoom: MouseWheelZoomStatic
            abstract PinchRotate: PinchRotateStatic
            abstract PinchZoom: PinchZoomStatic
            abstract Pointer: PointerStatic
            abstract Select: SelectStatic
            abstract Snap: SnapStatic
            abstract Translate: TranslateStatic

        type [<AllowNullLiteral>] DoubleClickZoom =
            inherit Ol.Interaction.Interaction

        type [<AllowNullLiteral>] DoubleClickZoomStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.DoubleClickZoomOptions -> DoubleClickZoom
            /// <summary>Handles the {@link ol.MapBrowserEvent map browser event} (if it was a
            /// doubleclick) and eventually zooms the map.</summary>
            /// <param name="mapBrowserEvent">Map browser event.</param>
            abstract handleEvent: mapBrowserEvent: Ol.MapBrowserEvent -> bool

        type [<AllowNullLiteral>] DragAndDrop =
            inherit Ol.Interaction.Interaction
            /// Handles the {@link ol.MapBrowserEvent map browser event} unconditionally and
            /// neither prevents the browser default nor stops event propagation.
            abstract handleEvent: obj option with get, set

        type [<AllowNullLiteral>] DragAndDropStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.DragAndDropOptions -> DragAndDrop

        module DragAndDrop =

            type [<AllowNullLiteral>] IExports =
                abstract Event: EventStatic

            type [<AllowNullLiteral>] Event =
                inherit Ol.Events.Event
                /// The features parsed from dropped data.
                abstract features: ResizeArray<Ol.Feature> with get, set
                /// The dropped file.
                abstract file: File with get, set
                /// The feature projection.
                abstract projection: Ol.Proj.Projection with get, set

            type [<AllowNullLiteral>] EventStatic =
                /// <param name="type">Type.</param>
                /// <param name="file">File.</param>
                /// <param name="opt_features">Features.</param>
                /// <param name="opt_projection">Projection.</param>
                [<Emit "new $0($1...)">] abstract Create: ``type``: Ol.Interaction.DragAndDropEventType * file: File * ?opt_features: ResizeArray<Ol.Feature> * ?opt_projection: Ol.Proj.Projection -> Event

        type DragAndDropEventType =
            string

        type [<AllowNullLiteral>] DragBox =
            inherit Ol.Interaction.Pointer
            /// Returns geometry of last drawn box.
            abstract getGeometry: unit -> Ol.Geom.Polygon

        type [<AllowNullLiteral>] DragBoxStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.DragBoxOptions -> DragBox

        module DragBox =

            type [<AllowNullLiteral>] IExports =
                abstract Event: EventStatic

            type [<AllowNullLiteral>] Event =
                inherit Ol.Events.Event
                /// The coordinate of the drag event.
                abstract coordinate: Ol.Coordinate with get, set
                abstract mapBrowserEvent: Ol.MapBrowserEvent with get, set

            type [<AllowNullLiteral>] EventStatic =
                /// <param name="type">The event type.</param>
                /// <param name="coordinate">The event coordinate.</param>
                /// <param name="mapBrowserEvent">Originating event.</param>
                [<Emit "new $0($1...)">] abstract Create: ``type``: string * coordinate: Ol.Coordinate * mapBrowserEvent: Ol.MapBrowserEvent -> Event

        type DragBoxEventType =
            string

        type [<AllowNullLiteral>] DragPan =
            inherit Ol.Interaction.Pointer

        type [<AllowNullLiteral>] DragPanStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.DragPanOptions -> DragPan

        type [<AllowNullLiteral>] DragRotate =
            inherit Ol.Interaction.Pointer

        type [<AllowNullLiteral>] DragRotateStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.DragRotateOptions -> DragRotate

        type [<AllowNullLiteral>] DragRotateAndZoom =
            inherit Ol.Interaction.Pointer

        type [<AllowNullLiteral>] DragRotateAndZoomStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.DragRotateAndZoomOptions -> DragRotateAndZoom

        type [<AllowNullLiteral>] DragZoom =
            inherit Ol.Interaction.DragBox

        type [<AllowNullLiteral>] DragZoomStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.DragZoomOptions -> DragZoom

        module Draw =

            type [<AllowNullLiteral>] IExports =
                abstract Event: EventStatic

            type [<AllowNullLiteral>] Event =
                inherit Ol.Events.Event
                /// The feature being drawn.
                abstract feature: Ol.Feature with get, set

            type [<AllowNullLiteral>] EventStatic =
                /// <param name="type">Type.</param>
                /// <param name="feature">The feature drawn.</param>
                [<Emit "new $0($1...)">] abstract Create: ``type``: Ol.Interaction.DrawEventType * feature: Ol.Feature -> Event

        type DrawEventType =
            string

        type [<AllowNullLiteral>] Draw =
            inherit Ol.Interaction.Pointer
            /// Remove last point of the feature currently being drawn.
            abstract removeLastPoint: unit -> unit
            /// Stop drawing and add the sketch feature to the target layer.
            /// The {@link ol.interaction.DrawEventType.DRAWEND} event is dispatched before
            /// inserting the feature.
            abstract finishDrawing: unit -> unit
            /// <summary>Extend an existing geometry by adding additional points. This only works
            /// on features with `LineString` geometries, where the interaction will
            /// extend lines by adding points to the end of the coordinates array.</summary>
            /// <param name="feature">Feature to be extended.</param>
            abstract extend: feature: Ol.Feature -> unit

        type [<AllowNullLiteral>] DrawStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Interaction.DrawOptions -> Draw
            /// Create a `geometryFunction` that will create a box-shaped polygon (aligned
            /// with the coordinate system axes).  Use this with the draw interaction and
            /// `type: 'Circle'` to return a box instead of a circle geometry.
            abstract createBox: unit -> Ol.DrawGeometryFunctionType
            /// <summary>Create a `geometryFunction` for `mode: 'Circle'` that will create a regular
            /// polygon with a user specified number of sides and start angle instead of an
            /// `ol.geom.Circle` geometry.</summary>
            /// <param name="opt_sides">Number of sides of the regular polygon. Default is
            /// 32.</param>
            /// <param name="opt_angle">Angle of the first point in radians. 0 means East.
            /// Default is the angle defined by the heading from the center of the
            /// regular polygon to the current pointer position.</param>
            abstract createRegularPolygon: ?opt_sides: float * ?opt_angle: float -> Ol.DrawGeometryFunctionType

        type [<AllowNullLiteral>] Interaction =
            inherit Ol.Object
            /// Return whether the interaction is currently active.
            abstract getActive: unit -> bool
            /// Get the map associated with this interaction.
            abstract getMap: unit -> Ol.Map
            /// <summary>Activate or deactivate the interaction.</summary>
            /// <param name="active">Active.</param>
            abstract setActive: active: bool -> unit

        type [<AllowNullLiteral>] InteractionStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Interaction.InteractionOptions -> Interaction

        type [<AllowNullLiteral>] KeyboardPan =
            inherit Ol.Interaction.Interaction

        type [<AllowNullLiteral>] KeyboardPanStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.KeyboardPanOptions -> KeyboardPan
            /// <summary>Handles the {@link ol.MapBrowserEvent map browser event} if it was a
            /// `KeyEvent`, and decides the direction to pan to (if an arrow key was
            /// pressed).</summary>
            /// <param name="mapBrowserEvent">Map browser event.</param>
            abstract handleEvent: mapBrowserEvent: Ol.MapBrowserEvent -> bool

        type [<AllowNullLiteral>] KeyboardZoom =
            inherit Ol.Interaction.Interaction

        type [<AllowNullLiteral>] KeyboardZoomStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.KeyboardZoomOptions -> KeyboardZoom
            /// <summary>Handles the {@link ol.MapBrowserEvent map browser event} if it was a
            /// `KeyEvent`, and decides whether to zoom in or out (depending on whether the
            /// key pressed was '+' or '-').</summary>
            /// <param name="mapBrowserEvent">Map browser event.</param>
            abstract handleEvent: mapBrowserEvent: Ol.MapBrowserEvent -> bool

        module Modify =

            type [<AllowNullLiteral>] IExports =
                abstract Event: EventStatic

            type [<AllowNullLiteral>] Event =
                inherit Ol.Events.Event
                /// The features being modified.
                abstract features: Ol.Collection<Ol.Feature> with get, set
                /// Associated {@link ol.MapBrowserEvent}.
                abstract mapBrowserEvent: Ol.MapBrowserEvent with get, set

            type [<AllowNullLiteral>] EventStatic =
                /// <param name="type">Type.</param>
                /// <param name="features">The features modified.</param>
                /// <param name="mapBrowserPointerEvent">Associated
                /// {</param>
                [<Emit "new $0($1...)">] abstract Create: ``type``: Ol.ModifyEventType * features: Ol.Collection<Ol.Feature> * mapBrowserPointerEvent: Ol.MapBrowserPointerEvent -> Event

        type [<AllowNullLiteral>] Modify =
            inherit Ol.Interaction.Pointer
            /// Removes the vertex currently being pointed.
            abstract removePoint: unit -> bool

        type [<AllowNullLiteral>] ModifyStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Interaction.ModifyOptions -> Modify

        type [<AllowNullLiteral>] MouseWheelZoom =
            inherit Ol.Interaction.Interaction
            /// <summary>Enable or disable using the mouse's location as an anchor when zooming</summary>
            /// <param name="useAnchor">true to zoom to the mouse's location, false
            /// to zoom to the center of the map</param>
            abstract setMouseAnchor: useAnchor: bool -> unit

        type [<AllowNullLiteral>] MouseWheelZoomStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.MouseWheelZoomOptions -> MouseWheelZoom
            /// <summary>Handles the {@link ol.MapBrowserEvent map browser event} (if it was a
            /// mousewheel-event) and eventually zooms the map.</summary>
            /// <param name="mapBrowserEvent">Map browser event.</param>
            abstract handleEvent: mapBrowserEvent: Ol.MapBrowserEvent -> bool

        type [<AllowNullLiteral>] PinchRotate =
            inherit Ol.Interaction.Pointer

        type [<AllowNullLiteral>] PinchRotateStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.PinchRotateOptions -> PinchRotate

        type [<AllowNullLiteral>] PinchZoom =
            inherit Ol.Interaction.Pointer

        type [<AllowNullLiteral>] PinchZoomStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.PinchZoomOptions -> PinchZoom

        type [<AllowNullLiteral>] Pointer =
            inherit Ol.Interaction.Interaction

        type [<AllowNullLiteral>] PointerStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.PointerOptions -> Pointer
            /// <summary>Handles the {@link ol.MapBrowserEvent map browser event} and may call into
            /// other functions, if event sequences like e.g. 'drag' or 'down-up' etc. are
            /// detected.</summary>
            /// <param name="mapBrowserEvent">Map browser event.</param>
            abstract handleEvent: mapBrowserEvent: Ol.MapBrowserEvent -> bool

        module Select =

            type [<AllowNullLiteral>] IExports =
                abstract Event: EventStatic

            type [<AllowNullLiteral>] Event =
                inherit Ol.Events.Event
                /// Selected features array.
                abstract selected: ResizeArray<Ol.Feature> with get, set
                /// Deselected features array.
                abstract deselected: ResizeArray<Ol.Feature> with get, set
                /// Associated {@link ol.MapBrowserEvent}.
                abstract mapBrowserEvent: Ol.MapBrowserEvent with get, set

            type [<AllowNullLiteral>] EventStatic =
                /// <param name="type">The event type.</param>
                /// <param name="selected">Selected features.</param>
                /// <param name="deselected">Deselected features.</param>
                /// <param name="mapBrowserEvent">Associated
                /// {</param>
                [<Emit "new $0($1...)">] abstract Create: ``type``: string * selected: ResizeArray<Ol.Feature> * deselected: ResizeArray<Ol.Feature> * mapBrowserEvent: Ol.MapBrowserEvent -> Event

        type [<AllowNullLiteral>] Select =
            inherit Ol.Interaction.Interaction
            /// Get the selected features.
            abstract getFeatures: unit -> Ol.Collection<Ol.Feature>
            /// <summary>Returns the associated {@link ol.layer.Vector vectorlayer} of
            /// the (last) selected feature. Note that this will not work with any
            /// programmatic method like pushing features to
            /// {@link ol.interaction.Select#getFeatures collection}.</summary>
            /// <param name="feature">Feature</param>
            abstract getLayer: feature: U2<Ol.Feature, Ol.Render.Feature> -> Ol.Layer.Vector
            /// <summary>Remove the interaction from its current map, if any,  and attach it to a new
            /// map, if any. Pass `null` to just remove the interaction from the current map.</summary>
            /// <param name="map">Map.</param>
            abstract setMap: map: Ol.Map -> unit

        type [<AllowNullLiteral>] SelectStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.SelectOptions -> Select
            /// <summary>Handles the {@link ol.MapBrowserEvent map browser event} and may change the
            /// selected state of features.</summary>
            /// <param name="mapBrowserEvent">Map browser event.</param>
            abstract handleEvent: mapBrowserEvent: Ol.MapBrowserEvent -> bool

        type [<AllowNullLiteral>] Snap =
            inherit Ol.Interaction.Pointer
            /// <summary>Add a feature to the collection of features that we may snap to.</summary>
            /// <param name="feature">Feature.</param>
            /// <param name="opt_listen">Whether to listen to the geometry change or not
            /// Defaults to `true`.</param>
            abstract addFeature: feature: Ol.Feature * ?opt_listen: bool -> unit
            /// <summary>Remove a feature from the collection of features that we may snap to.</summary>
            /// <param name="feature">Feature</param>
            /// <param name="opt_unlisten">Whether to unlisten to the geometry change
            /// or not. Defaults to `true`.</param>
            abstract removeFeature: feature: Ol.Feature * ?opt_unlisten: bool -> unit

        type [<AllowNullLiteral>] SnapStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Interaction.SnapOptions -> Snap

        module Translate =

            type [<AllowNullLiteral>] IExports =
                abstract Event: EventStatic

            type [<AllowNullLiteral>] Event =
                inherit Ol.Events.Event
                /// The features being translated.
                abstract features: Ol.Collection<Ol.Feature> with get, set
                /// The coordinate of the drag event.
                abstract coordinate: Ol.Coordinate with get, set

            type [<AllowNullLiteral>] EventStatic =
                /// <param name="type">Type.</param>
                /// <param name="features">The features translated.</param>
                /// <param name="coordinate">The event coordinate.</param>
                [<Emit "new $0($1...)">] abstract Create: ``type``: Ol.Interaction.TranslateEventType * features: Ol.Collection<Ol.Feature> * coordinate: Ol.Coordinate -> Event

        type TranslateEventType =
            string

        type [<AllowNullLiteral>] Translate =
            inherit Ol.Interaction.Pointer

        type [<AllowNullLiteral>] TranslateStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Interaction.TranslateOptions -> Translate

    type [<AllowNullLiteral>] Kinetic =
        interface end

    type [<AllowNullLiteral>] KineticStatic =
        /// <param name="decay">Rate of decay (must be negative).</param>
        /// <param name="minVelocity">Minimum velocity (pixels/millisecond).</param>
        /// <param name="delay">Delay to consider to calculate the kinetic
        /// initial values (milliseconds).</param>
        [<Emit "new $0($1...)">] abstract Create: decay: float * minVelocity: float * delay: float -> Kinetic

    module Layer =

        type [<AllowNullLiteral>] IExports =
            abstract Base: BaseStatic
            abstract Group: GroupStatic
            abstract Heatmap: HeatmapStatic
            abstract Image: ImageStatic
            abstract Layer: LayerStatic
            abstract Tile: TileStatic
            abstract Vector: VectorStatic
            abstract VectorTile: VectorTileStatic

        type [<AllowNullLiteral>] Base =
            inherit Ol.Object
            /// Return the {@link ol.Extent extent} of the layer or `undefined` if it
            /// will be visible regardless of extent.
            abstract getExtent: unit -> Ol.Extent
            /// Return the maximum resolution of the layer.
            abstract getMaxResolution: unit -> float
            /// Return the minimum resolution of the layer.
            abstract getMinResolution: unit -> float
            /// Return the opacity of the layer (between 0 and 1).
            abstract getOpacity: unit -> float
            /// Return the visibility of the layer (`true` or `false`).
            abstract getVisible: unit -> bool
            /// Return the Z-index of the layer, which is used to order layers before
            /// rendering. The default Z-index is 0.
            abstract getZIndex: unit -> float
            /// <summary>Set the extent at which the layer is visible.  If `undefined`, the layer
            /// will be visible at all extents.</summary>
            /// <param name="extent">The extent of the layer.</param>
            abstract setExtent: extent: Ol.Extent -> unit
            /// <summary>Set the maximum resolution at which the layer is visible.</summary>
            /// <param name="maxResolution">The maximum resolution of the layer.</param>
            abstract setMaxResolution: maxResolution: float -> unit
            /// <summary>Set the minimum resolution at which the layer is visible.</summary>
            /// <param name="minResolution">The minimum resolution of the layer.</param>
            abstract setMinResolution: minResolution: float -> unit
            /// <summary>Set the opacity of the layer, allowed values range from 0 to 1.</summary>
            /// <param name="opacity">The opacity of the layer.</param>
            abstract setOpacity: opacity: float -> unit
            /// <summary>Set the visibility of the layer (`true` or `false`).</summary>
            /// <param name="visible">The visibility of the layer.</param>
            abstract setVisible: visible: bool -> unit
            /// <summary>Set Z-index of the layer, which is used to order layers before rendering.
            /// The default Z-index is 0.</summary>
            /// <param name="zindex">The z-index of the layer.</param>
            abstract setZIndex: zindex: float -> unit

        type [<AllowNullLiteral>] BaseStatic =
            /// <param name="options">Layer options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Layer.BaseOptions -> Base

        type [<AllowNullLiteral>] Group =
            inherit Ol.Layer.Base
            /// Returns the {@link ol.Collection collection} of {@link ol.layer.Layer layers}
            /// in this group.
            abstract getLayers: unit -> Ol.Collection<Ol.Layer.Base>
            /// <summary>Set the {@link ol.Collection collection} of {@link ol.layer.Layer layers}
            /// in this group.</summary>
            /// <param name="layers">Collection of
            /// {</param>
            abstract setLayers: layers: Ol.Collection<Ol.Layer.Base> -> unit

        type [<AllowNullLiteral>] GroupStatic =
            /// <param name="opt_options">Layer options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Layer.GroupOptions -> Group

        type [<AllowNullLiteral>] Heatmap =
            inherit Ol.Layer.Vector
            /// Return the blur size in pixels.
            abstract getBlur: unit -> float
            /// Return the gradient colors as array of strings.
            abstract getGradient: unit -> ResizeArray<string>
            /// Return the size of the radius in pixels.
            abstract getRadius: unit -> float
            /// <summary>Set the blur size in pixels.</summary>
            /// <param name="blur">Blur size in pixels.</param>
            abstract setBlur: blur: float -> unit
            /// <summary>Set the gradient colors as array of strings.</summary>
            /// <param name="colors">Gradient.</param>
            abstract setGradient: colors: ResizeArray<string> -> unit
            /// <summary>Set the size of the radius in pixels.</summary>
            /// <param name="radius">Radius size in pixel.</param>
            abstract setRadius: radius: float -> unit

        type [<AllowNullLiteral>] HeatmapStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Layer.HeatmapOptions -> Heatmap

        type [<AllowNullLiteral>] Image =
            inherit Ol.Layer.Layer

        type [<AllowNullLiteral>] ImageStatic =
            /// <param name="opt_options">Layer options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Layer.ImageOptions -> Image

        type [<AllowNullLiteral>] Layer =
            inherit Ol.Layer.Base
            /// Get the layer source.
            abstract getSource: unit -> Ol.Source.Source
            /// <summary>Sets the layer to be rendered on top of other layers on a map. The map will
            /// not manage this layer in its layers collection, and the callback in
            /// {@link ol.Map#forEachLayerAtPixel} will receive `null` as layer. This
            /// is useful for temporary layers. To remove an unmanaged layer from the map,
            /// use `#setMap(null)`.
            ///
            /// To add the layer to a map and have it managed by the map, use
            /// {@link ol.Map#addLayer} instead.</summary>
            /// <param name="map">Map.</param>
            abstract setMap: map: Ol.Map -> unit
            /// <summary>Set the layer source.</summary>
            /// <param name="source">The layer source.</param>
            abstract setSource: source: Ol.Source.Source -> unit

        type [<AllowNullLiteral>] LayerStatic =
            /// <param name="options">Layer options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Layer.LayerOptions -> Layer

        type [<AllowNullLiteral>] Tile =
            inherit Ol.Layer.Layer
            /// Return the level as number to which we will preload tiles up to.
            abstract getPreload: unit -> float
            /// <summary>Set the level as number to which we will preload tiles up to.</summary>
            /// <param name="preload">The level to preload tiles up to.</param>
            abstract setPreload: preload: float -> unit
            /// Whether we use interim tiles on error.
            abstract getUseInterimTilesOnError: unit -> bool
            /// <summary>Set whether we use interim tiles on error.</summary>
            /// <param name="useInterimTilesOnError">Use interim tiles on error.</param>
            abstract setUseInterimTilesOnError: useInterimTilesOnError: bool -> unit

        type [<AllowNullLiteral>] TileStatic =
            /// <param name="opt_options">Tile layer options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Layer.TileOptions -> Tile

        type [<AllowNullLiteral>] Vector =
            inherit Ol.Layer.Layer
            /// Return the associated {@link ol.source.Vector vectorsource} of the layer.
            abstract getSource: unit -> Ol.Source.Vector
            /// Get the style for features.  This returns whatever was passed to the `style`
            /// option at construction or to the `setStyle` method.
            abstract getStyle: unit -> U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction>
            /// Get the style function.
            abstract getStyleFunction: unit -> Ol.StyleFunction
            /// <summary>Set the style for features.  This can be a single style object, an array
            /// of styles, or a function that takes a feature and resolution and returns
            /// an array of styles. If it is `undefined` the default style is used. If
            /// it is `null` the layer has no style (a `null` style), so only features
            /// that have their own styles will be rendered in the layer. See
            /// {@link ol.style} for information on the default style.</summary>
            /// <param name="style">Layer style.</param>
            abstract setStyle: style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> -> unit

        type [<AllowNullLiteral>] VectorStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Layer.VectorOptions -> Vector

        type [<StringEnum>] [<RequireQualifiedAccess>] VectorTileRenderType =
            | Image
            | Hybrid
            | Vector

        type [<AllowNullLiteral>] VectorTile =
            inherit Ol.Layer.Vector
            /// Return the level as number to which we will preload tiles up to.
            abstract getPreload: unit -> float
            /// Whether we use interim tiles on error.
            abstract getUseInterimTilesOnError: unit -> bool
            /// <summary>Set the level as number to which we will preload tiles up to.</summary>
            /// <param name="preload">The level to preload tiles up to.</param>
            abstract setPreload: preload: float -> unit
            /// <summary>Set whether we use interim tiles on error.</summary>
            /// <param name="useInterimTilesOnError">Use interim tiles on error.</param>
            abstract setUseInterimTilesOnError: useInterimTilesOnError: bool -> unit

        type [<AllowNullLiteral>] VectorTileStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Layer.VectorTileOptions -> VectorTile

    module Loadingstrategy =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Strategy function for loading all features with a single request.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="resolution">Resolution.</param>
            abstract all: extent: Ol.Extent * resolution: float -> ResizeArray<Ol.Extent>
            /// <summary>Strategy function for loading features based on the view's extent and
            /// resolution.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="resolution">Resolution.</param>
            abstract bbox: extent: Ol.Extent * resolution: float -> ResizeArray<Ol.Extent>
            /// <summary>Creates a strategy function for loading features based on a tile grid.</summary>
            /// <param name="tileGrid">Tile grid.</param>
            abstract tile: tileGrid: Ol.Tilegrid.TileGrid -> (Ol.Extent -> float -> ResizeArray<Ol.Extent>)

    type [<AllowNullLiteral>] Map =
        inherit Ol.Object
        /// <summary>Add the given control to the map.</summary>
        /// <param name="control">Control.</param>
        abstract addControl: control: Ol.Control.Control -> unit
        /// <summary>Add the given interaction to the map.</summary>
        /// <param name="interaction">Interaction to add.</param>
        abstract addInteraction: interaction: Ol.Interaction.Interaction -> unit
        /// <summary>Adds the given layer to the top of this map. If you want to add a layer
        /// elsewhere in the stack, use `getLayers()` and the methods available on
        /// {@link ol.Collection}.</summary>
        /// <param name="layer">Layer.</param>
        abstract addLayer: layer: Ol.Layer.Base -> unit
        /// <summary>Add the given overlay to the map.</summary>
        /// <param name="overlay">Overlay.</param>
        abstract addOverlay: overlay: Ol.Overlay -> unit
        /// <summary>Detect features that intersect a pixel on the viewport, and execute a
        /// callback with each intersecting feature. Layers included in the detection can
        /// be configured through `opt_layerFilter`.</summary>
        /// <param name="pixel">Pixel.</param>
        /// <param name="callback">Feature callback. The callback will be
        /// called with two arguments. The first argument is one
        /// {</param>
        /// <param name="opt_options">Optional options.</param>
        abstract forEachFeatureAtPixel: pixel: Ol.Pixel * callback: (U2<Ol.Feature, Ol.Render.Feature> -> Ol.Layer.Layer -> 'T) * ?opt_options: Olx.AtPixelOptions -> 'T
        /// <summary>Get all features that intersect a pixel on the viewport.</summary>
        /// <param name="pixel">Pixel.</param>
        /// <param name="opt_options">Optional options.</param>
        abstract getFeaturesAtPixel: pixel: Ol.Pixel * ?opt_options: Olx.AtPixelOptions -> Array<U2<Ol.Feature, Ol.Render.Feature>> option
        /// <summary>Detect layers that have a color value at a pixel on the viewport, and
        /// execute a callback with each matching layer. Layers included in the
        /// detection can be configured through `opt_layerFilter`.</summary>
        /// <param name="pixel">Pixel.</param>
        /// <param name="callback">Layer
        /// callback. This callback will recieve two arguments: first is the
        /// {</param>
        /// <param name="opt_this">Value to use as `this` when executing `callback`.</param>
        /// <param name="opt_layerFilter">Layer
        /// filter function. The filter function will receive one argument, the
        /// {</param>
        /// <param name="opt_this2">Value to use as `this` when executing `layerFilter`.</param>
        abstract forEachLayerAtPixel: pixel: Ol.Pixel * callback: (Ol.Layer.Layer -> Ol.Color -> 'T) * ?opt_this: 'S * ?opt_layerFilter: (Ol.Layer.Layer -> bool) * ?opt_this2: 'U -> 'T
        /// <summary>Detect if features intersect a pixel on the viewport. Layers included in the
        /// detection can be configured through `opt_layerFilter`.</summary>
        /// <param name="pixel">Pixel.</param>
        /// <param name="opt_options">Optional options.</param>
        abstract hasFeatureAtPixel: pixel: Ol.Pixel * ?opt_options: Olx.AtPixelOptions -> bool
        /// <summary>Returns the geographical coordinate for a browser event.</summary>
        /// <param name="event">Event.</param>
        abstract getEventCoordinate: ``event``: Event -> Ol.Coordinate
        /// <summary>Returns the map pixel position for a browser event relative to the viewport.</summary>
        /// <param name="event">Event.</param>
        abstract getEventPixel: ``event``: Event -> Ol.Pixel
        /// Get the target in which this map is rendered.
        /// Note that this returns what is entered as an option or in setTarget:
        /// if that was an element, it returns an element; if a string, it returns that.
        abstract getTarget: unit -> U2<Element, string>
        /// Get the DOM element into which this map is rendered. In contrast to
        /// `getTarget` this method always return an `Element`, or `null` if the
        /// map has no target.
        abstract getTargetElement: unit -> Element
        /// <summary>Get the coordinate for a given pixel.  This returns a coordinate in the
        /// map view projection.</summary>
        /// <param name="pixel">Pixel position in the map viewport.</param>
        abstract getCoordinateFromPixel: pixel: Ol.Pixel -> Ol.Coordinate
        /// Get the map controls. Modifying this collection changes the controls
        /// associated with the map.
        abstract getControls: unit -> Ol.Collection<Ol.Control.Control>
        /// Get the map overlays. Modifying this collection changes the overlays
        /// associated with the map.
        abstract getOverlays: unit -> Ol.Collection<Ol.Overlay>
        /// <summary>Get an overlay by its identifier (the value returned by overlay.getId()).
        /// Note that the index treats string and numeric identifiers as the same. So
        /// `map.getOverlayById(2)` will return an overlay with id `'2'` or `2`.</summary>
        /// <param name="id">Overlay identifier.</param>
        abstract getOverlayById: id: U2<string, float> -> Ol.Overlay
        /// Get the map interactions. Modifying this collection changes the interactions
        /// associated with the map.
        ///
        /// Interactions are used for e.g. pan, zoom and rotate.
        abstract getInteractions: unit -> Ol.Collection<Ol.Interaction.Interaction>
        /// Get the layergroup associated with this map.
        abstract getLayerGroup: unit -> Ol.Layer.Group
        /// Get the collection of layers associated with this map.
        abstract getLayers: unit -> Ol.Collection<Ol.Layer.Base>
        /// <summary>Get the pixel for a coordinate.  This takes a coordinate in the map view
        /// projection and returns the corresponding pixel.</summary>
        /// <param name="coordinate">A map coordinate.</param>
        abstract getPixelFromCoordinate: coordinate: Ol.Coordinate -> Ol.Pixel
        /// Get the size of this map.
        abstract getSize: unit -> Ol.Size
        /// Get the view associated with this map. A view manages properties such as
        /// center and resolution.
        abstract getView: unit -> Ol.View
        /// Get the element that serves as the map viewport.
        abstract getViewport: unit -> Element
        /// Requests an immediate render in a synchronous manner.
        abstract renderSync: unit -> unit
        /// Request a map rendering (at the next animation frame).
        abstract render: unit -> unit
        /// <summary>Remove the given control from the map.</summary>
        /// <param name="control">Control.</param>
        abstract removeControl: control: Ol.Control.Control -> Ol.Control.Control
        /// <summary>Remove the given interaction from the map.</summary>
        /// <param name="interaction">Interaction to remove.</param>
        abstract removeInteraction: interaction: Ol.Interaction.Interaction -> Ol.Interaction.Interaction
        /// <summary>Removes the given layer from the map.</summary>
        /// <param name="layer">Layer.</param>
        abstract removeLayer: layer: Ol.Layer.Base -> Ol.Layer.Base
        /// <summary>Remove the given overlay from the map.</summary>
        /// <param name="overlay">Overlay.</param>
        abstract removeOverlay: overlay: Ol.Overlay -> Ol.Overlay
        /// <summary>Sets the layergroup of this map.</summary>
        /// <param name="layerGroup">A layer group containing the layers in
        /// this map.</param>
        abstract setLayerGroup: layerGroup: Ol.Layer.Group -> unit
        /// <summary>Set the size of this map.</summary>
        /// <param name="size">The size in pixels of the map in the DOM.</param>
        abstract setSize: size: Ol.Size -> unit
        /// <summary>Set the target element to render this map into.</summary>
        /// <param name="target">The Element or id of the Element
        /// that the map is rendered in.</param>
        abstract setTarget: target: U2<Element, string> -> unit
        /// <summary>Set the view for this map.</summary>
        /// <param name="view">The view that controls this map.</param>
        abstract setView: view: Ol.View -> unit
        /// Force a recalculation of the map viewport size.  This should be called when
        /// third-party code changes the size of the map viewport.
        abstract updateSize: unit -> unit

    type [<AllowNullLiteral>] MapStatic =
        /// <param name="options">Map options.</param>
        [<Emit "new $0($1...)">] abstract Create: options: Olx.MapOptions -> Map

    type [<AllowNullLiteral>] MapBrowserEvent =
        inherit Ol.MapEvent
        /// The original browser event.
        abstract originalEvent: Event with get, set
        /// The pixel of the original browser event.
        abstract pixel: Ol.Pixel with get, set
        /// The coordinate of the original browser event.
        abstract coordinate: Ol.Coordinate with get, set
        /// Indicates if the map is currently being dragged. Only set for
        /// `POINTERDRAG` and `POINTERMOVE` events. Default is `false`.
        abstract dragging: bool with get, set

    type [<AllowNullLiteral>] MapBrowserEventStatic =
        /// <param name="type">Event type.</param>
        /// <param name="map">Map.</param>
        /// <param name="browserEvent">Browser event.</param>
        /// <param name="opt_dragging">Is the map currently being dragged?</param>
        /// <param name="opt_frameState">Frame state.</param>
        [<Emit "new $0($1...)">] abstract Create: ``type``: string * map: Ol.Map * browserEvent: Event * ?opt_dragging: bool * ?opt_frameState: Olx.FrameState -> MapBrowserEvent

    type [<AllowNullLiteral>] MapBrowserPointerEvent =
        inherit Ol.MapBrowserEvent
        abstract pointerEvent: Ol.Pointer.PointerEvent with get, set

    type [<AllowNullLiteral>] MapBrowserPointerEventStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MapBrowserPointerEvent

    type [<AllowNullLiteral>] MapEvent =
        inherit Ol.Events.Event
        /// The map where the event occurred.
        abstract map: Ol.Map with get, set
        /// The frame state at the time of the event.
        abstract frameState: Olx.FrameState with get, set

    type [<AllowNullLiteral>] MapEventStatic =
        /// <param name="type">Event type.</param>
        /// <param name="map">Map.</param>
        /// <param name="opt_frameState">Frame state.</param>
        [<Emit "new $0($1...)">] abstract Create: ``type``: string * map: Ol.Map * ?opt_frameState: Olx.FrameState -> MapEvent

    type [<AllowNullLiteral>] ObjectEvent =
        inherit Ol.Events.Event
        /// The name of the property whose value is changing.
        abstract key: string with get, set
        /// The old value. To get the new value use `e.target.get(e.key)` where
        /// `e` is the event object.
        abstract oldValue: obj option with get, set

    type [<AllowNullLiteral>] ObjectEventStatic =
        /// <param name="type">The event type.</param>
        /// <param name="key">The property name.</param>
        /// <param name="oldValue">The old value for `key`.</param>
        [<Emit "new $0($1...)">] abstract Create: ``type``: string * key: string * oldValue: obj option -> ObjectEvent

    type [<AllowNullLiteral>] Object =
        inherit Ol.Observable
        /// <summary>Gets a value.</summary>
        /// <param name="key">Key name.</param>
        abstract get: key: string -> obj option
        /// Get a list of object property names.
        abstract getKeys: unit -> ResizeArray<string>
        /// Get an object of all property names and values.
        abstract getProperties: unit -> obj
        /// <summary>Sets a value.</summary>
        /// <param name="key">Key name.</param>
        /// <param name="value">Value.</param>
        /// <param name="opt_silent">Update without triggering an event.</param>
        abstract set: key: string * value: obj option * ?opt_silent: bool -> unit
        /// <summary>Sets a collection of key-value pairs.  Note that this changes any existing
        /// properties and adds new ones (it does not remove any existing properties).</summary>
        /// <param name="values">Values.</param>
        /// <param name="opt_silent">Update without triggering an event.</param>
        abstract setProperties: values: ObjectSetPropertiesValues * ?opt_silent: bool -> unit
        /// <summary>Unsets a property.</summary>
        /// <param name="key">Key name.</param>
        /// <param name="opt_silent">Unset without triggering an event.</param>
        abstract unset: key: string * ?opt_silent: bool -> unit

    type [<AllowNullLiteral>] ObjectSetPropertiesValues =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: k: string -> obj option with get, set

    type [<AllowNullLiteral>] ObjectStatic =
        /// <param name="opt_values">An object with key-value pairs.</param>
        [<Emit "new $0($1...)">] abstract Create: ?opt_values: ObjectStaticOpt_values -> Object

    type [<AllowNullLiteral>] ObjectStaticOpt_values =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: k: string -> obj option with get, set

    type [<AllowNullLiteral>] Observable =
        inherit Ol.Events.EventTarget
        /// Increases the revision counter and dispatches a 'change' event.
        abstract changed: unit -> unit
        /// <summary>Dispatches an event and calls all listeners listening for events
        /// of this type. The event parameter can either be a string or an
        /// Object with a `type` property.</summary>
        /// <param name="event">Event object.</param>
        abstract dispatchEvent: ``event``: U3<GlobalObject, Ol.Events.Event, string> -> unit
        /// Get the version number for this object.  Each time the object is modified,
        /// its version number will be incremented.
        abstract getRevision: unit -> float
        /// <summary>Listen for a certain type of event.</summary>
        /// <param name="type">The event type or array of event types.</param>
        /// <param name="listener">The listener function.</param>
        /// <param name="opt_this">The object to use as `this` in `listener`.</param>
        abstract on: ``type``: U2<string, ResizeArray<string>> * listener: Ol.EventsListenerFunctionType * ?opt_this: GlobalObject -> U2<Ol.EventsKey, ResizeArray<Ol.EventsKey>>
        /// <summary>Listen once for a certain type of event.</summary>
        /// <param name="type">The event type or array of event types.</param>
        /// <param name="listener">The listener function.</param>
        /// <param name="opt_this">The object to use as `this` in `listener`.</param>
        abstract once: ``type``: U2<string, ResizeArray<string>> * listener: Ol.EventsListenerFunctionType * ?opt_this: GlobalObject -> U2<Ol.EventsKey, ResizeArray<Ol.EventsKey>>
        /// <summary>Unlisten for a certain type of event.</summary>
        /// <param name="type">The event type or array of event types.</param>
        /// <param name="listener">The listener function.</param>
        /// <param name="opt_this">The object which was used as `this` by the
        /// `listener`.</param>
        abstract un: ``type``: U2<string, ResizeArray<string>> * listener: Ol.EventsListenerFunctionType * ?opt_this: GlobalObject -> unit

    type [<AllowNullLiteral>] ObservableStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Observable
        /// <summary>Removes an event listener using the key returned by `on()` or `once()`.</summary>
        /// <param name="key">The key returned by `on()`
        /// or `once()` (or an array of keys).</param>
        abstract unByKey: key: U2<Ol.EventsKey, ResizeArray<Ol.EventsKey>> -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] OverlayPositioning =
        | [<CompiledName "bottom-left">] BottomLeft
        | [<CompiledName "bottom-center">] BottomCenter
        | [<CompiledName "bottom-right">] BottomRight
        | [<CompiledName "center-left">] CenterLeft
        | [<CompiledName "center-center">] CenterCenter
        | [<CompiledName "center-right">] CenterRight
        | [<CompiledName "top-left">] TopLeft
        | [<CompiledName "top-center">] TopCenter
        | [<CompiledName "top-right">] TopRight

    type [<AllowNullLiteral>] Overlay =
        inherit Ol.Object
        /// Get the DOM element of this overlay.
        abstract getElement: unit -> Element
        /// Get the overlay identifier which is set on constructor.
        abstract getId: unit -> U2<float, string>
        /// Get the map associated with this overlay.
        abstract getMap: unit -> Ol.Map
        /// Get the offset of this overlay.
        abstract getOffset: unit -> ResizeArray<float>
        /// Get the current position of this overlay.
        abstract getPosition: unit -> Ol.Coordinate
        /// Get the current positioning of this overlay.
        abstract getPositioning: unit -> Ol.OverlayPositioning
        /// <summary>Set the DOM element to be associated with this overlay.</summary>
        /// <param name="element">The Element containing the overlay.</param>
        abstract setElement: element: Element -> unit
        /// <summary>Set the map to be associated with this overlay.</summary>
        /// <param name="map">The map that the overlay is part of.</param>
        abstract setMap: map: Ol.Map -> unit
        /// <summary>Set the offset for this overlay.</summary>
        /// <param name="offset">Offset.</param>
        abstract setOffset: offset: ResizeArray<float> -> unit
        /// <summary>Set the position for this overlay. If the position is `undefined` the
        /// overlay is hidden.</summary>
        /// <param name="position">The spatial point that the overlay
        /// is anchored at.</param>
        abstract setPosition: position: Ol.Coordinate option -> unit
        /// <summary>Set the positioning for this overlay.</summary>
        /// <param name="positioning">how the overlay is
        /// positioned relative to its point on the map.</param>
        abstract setPositioning: positioning: Ol.OverlayPositioning -> unit

    type [<AllowNullLiteral>] OverlayStatic =
        /// <param name="options">Overlay options.</param>
        [<Emit "new $0($1...)">] abstract Create: options: Olx.OverlayOptions -> Overlay

    module Pointer =

        type [<AllowNullLiteral>] IExports =
            abstract PointerEvent: PointerEventStatic

        type [<AllowNullLiteral>] PointerEvent =
            interface end

        type [<AllowNullLiteral>] PointerEventStatic =
            [<Emit "new $0($1...)">] abstract Create: unit -> PointerEvent

    module Proj =

        type [<AllowNullLiteral>] IExports =
            abstract METERS_PER_UNIT: obj
            abstract Projection: ProjectionStatic
            /// <summary>Register proj4. If not explicitly registered, it will be assumed that
            /// proj4js will be loaded in the global namespace. For example in a
            /// browserify ES6 environment you could use:
            ///
            ///      import ol from 'openlayers';
            ///      import proj4 from 'proj4';
            ///      ol.proj.setProj4(proj4);</summary>
            /// <param name="proj4">Proj4.</param>
            abstract setProj4: proj4: obj option -> unit
            /// <summary>Registers transformation functions that don't alter coordinates. Those allow
            /// to transform between projections with equal meaning.</summary>
            /// <param name="projections">Projections.</param>
            abstract addEquivalentProjections: projections: ResizeArray<Ol.Proj.Projection> -> unit
            /// <summary>Add a Projection object to the list of supported projections that can be
            /// looked up by their code.</summary>
            /// <param name="projection">Projection instance.</param>
            abstract addProjection: projection: Ol.Proj.Projection -> unit
            /// <summary>Registers coordinate transform functions to convert coordinates between the
            /// source projection and the destination projection.
            /// The forward and inverse functions convert coordinate pairs; this function
            /// converts these into the functions used internally which also handle
            /// extents and coordinate arrays.</summary>
            /// <param name="source">Source projection.</param>
            /// <param name="destination">Destination projection.</param>
            /// <param name="forward">The forward transform
            /// function (that is, from the source projection to the destination
            /// projection) that takes a {</param>
            /// <param name="inverse">The inverse transform
            /// function (that is, from the destination projection to the source
            /// projection) that takes a {</param>
            abstract addCoordinateTransforms: source: Ol.ProjectionLike * destination: Ol.ProjectionLike * forward: (Ol.Coordinate -> Ol.Coordinate) * inverse: (Ol.Coordinate -> Ol.Coordinate) -> unit
            /// <summary>Transforms a coordinate from longitude/latitude to a different projection.</summary>
            /// <param name="coordinate">Coordinate as longitude and latitude, i.e.
            /// an array with longitude as 1st and latitude as 2nd element.</param>
            /// <param name="opt_projection">Target projection. The
            /// default is Web Mercator, i.e. 'EPSG:3857'.</param>
            abstract fromLonLat: coordinate: Ol.Coordinate * ?opt_projection: Ol.ProjectionLike -> Ol.Coordinate
            /// <summary>Transforms a coordinate to longitude/latitude.</summary>
            /// <param name="coordinate">Projected coordinate.</param>
            /// <param name="opt_projection">Projection of the coordinate.
            /// The default is Web Mercator, i.e. 'EPSG:3857'.</param>
            abstract toLonLat: coordinate: Ol.Coordinate * ?opt_projection: Ol.ProjectionLike -> Ol.Coordinate
            /// <summary>Fetches a Projection object for the code specified.</summary>
            /// <param name="projectionLike">Either a code string which is
            /// a combination of authority and identifier such as "EPSG:4326", or an
            /// existing projection object, or undefined.</param>
            abstract get: projectionLike: Ol.ProjectionLike -> Ol.Proj.Projection
            /// <summary>Checks if two projections are the same, that is every coordinate in one
            /// projection does represent the same geographic point as the same coordinate in
            /// the other projection.</summary>
            /// <param name="projection1">Projection 1.</param>
            /// <param name="projection2">Projection 2.</param>
            abstract equivalent: projection1: Ol.Proj.Projection * projection2: Ol.Proj.Projection -> bool
            /// <summary>Given the projection-like objects, searches for a transformation
            /// function to convert a coordinates array from the source projection to the
            /// destination projection.</summary>
            /// <param name="source">Source.</param>
            /// <param name="destination">Destination.</param>
            abstract getTransform: source: Ol.ProjectionLike * destination: Ol.ProjectionLike -> Ol.TransformFunction
            /// <summary>Transforms a coordinate from source projection to destination projection.
            /// This returns a new coordinate (and does not modify the original).
            ///
            /// See {@link ol.proj.transformExtent} for extent transformation.
            /// See the transform method of {@link ol.geom.Geometry} and its subclasses for
            /// geometry transforms.</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="source">Source projection-like.</param>
            /// <param name="destination">Destination projection-like.</param>
            abstract transform: coordinate: Ol.Coordinate * source: Ol.ProjectionLike * destination: Ol.ProjectionLike -> Ol.Coordinate
            /// <summary>Transforms an extent from source projection to destination projection.  This
            /// returns a new extent (and does not modify the original).</summary>
            /// <param name="extent">The extent to transform.</param>
            /// <param name="source">Source projection-like.</param>
            /// <param name="destination">Destination projection-like.</param>
            abstract transformExtent: extent: Ol.Extent * source: Ol.ProjectionLike * destination: Ol.ProjectionLike -> Ol.Extent
            /// <summary>Get the resolution of the point in degrees or distance units. For
            /// projections with degrees as the unit this will simply return the
            /// provided resolution. For other projections the point resolution is
            /// estimated by transforming the 'point' pixel to EPSG:4326, measuring
            /// its width and height on the normal sphere, and taking the average of
            /// the width and height.</summary>
            /// <param name="projection">The projection.</param>
            /// <param name="resolution">Nominal resolution in projection units.</param>
            /// <param name="point">Point to find adjusted resolution at.</param>
            abstract getPointResolution: projection: Ol.Proj.Projection * resolution: float * point: Ol.Coordinate -> float

        type [<StringEnum>] [<RequireQualifiedAccess>] Units =
            | Degress
            | Ft
            | M
            | Pixels
            | [<CompiledName "tile-pixels">] TilePixels
            | [<CompiledName "us-ft">] UsFt

        type [<AllowNullLiteral>] Projection =
            /// Get the code for this projection, e.g. 'EPSG:4326'.
            abstract getCode: unit -> string
            /// Get the validity extent for this projection.
            abstract getExtent: unit -> Ol.Extent
            /// Get the units of this projection.
            abstract getUnits: unit -> Ol.Proj.Units
            /// Get the amount of meters per unit of this projection.  If the projection is
            /// not configured with `metersPerUnit` or a units identifier, the return is
            /// `undefined`.
            abstract getMetersPerUnit: unit -> float
            /// Get the world extent for this projection.
            abstract getWorldExtent: unit -> Ol.Extent
            /// Is this projection a global projection which spans the whole world?
            abstract isGlobal: unit -> bool
            /// <summary>Set if the projection is a global projection which spans the whole world</summary>
            /// <param name="global">Whether the projection is global.</param>
            abstract setGlobal: ``global``: bool -> unit
            /// <summary>Set the validity extent for this projection.</summary>
            /// <param name="extent">Extent.</param>
            abstract setExtent: extent: Ol.Extent -> unit
            /// <summary>Set the world extent for this projection.</summary>
            /// <param name="worldExtent">World extent
            /// [minlon, minlat, maxlon, maxlat].</param>
            abstract setWorldExtent: worldExtent: Ol.Extent -> unit
            /// <summary>Set the getPointResolution function for this projection.</summary>
            /// <param name="func">Function</param>
            abstract setGetPointResolution: func: (float -> Ol.Coordinate -> float) -> unit
            /// <summary>Get the resolution of the point in degrees or distance units.
            /// For projections with degrees as the unit this will simply return the
            /// provided resolution. The default for other projections is to estimate
            /// the point resolution by transforming the 'point' pixel to EPSG:4326,
            /// measuring its width and height on the normal sphere,
            /// and taking the average of the width and height.
            /// An alternative implementation may be given when constructing a
            /// projection. For many local projections,
            /// such a custom function will return the resolution unchanged.</summary>
            /// <param name="resolution">Resolution in projection units.</param>
            /// <param name="point">Point.</param>
            abstract getPointResolution: resolution: float * point: Ol.Coordinate -> float

        type [<AllowNullLiteral>] ProjectionStatic =
            /// <param name="options">Projection options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.ProjectionOptions -> Projection

    module Render =
        let [<Import("canvas","openlayers/ol/render")>] canvas: Canvas.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract Event: EventStatic
            abstract Feature: FeatureStatic
            abstract VectorContext: VectorContextStatic
            /// <summary>Binds a Canvas Immediate API to a canvas context, to allow drawing geometries
            /// to the context's canvas.
            ///
            /// The units for geometry coordinates are css pixels relative to the top left
            /// corner of the canvas element.
            /// ```js
            /// var canvas = document.createElement('canvas');
            /// var render = ol.render.toContext(canvas.getContext('2d'),
            ///      { size: [100, 100] });
            /// render.setFillStrokeStyle(new ol.style.Fill({ color: blue }));
            /// render.drawPolygon(
            ///      new ol.geom.Polygon([[[0, 0], [100, 100], [100, 0], [0, 0]]]));
            /// ```</summary>
            /// <param name="context">Canvas context.</param>
            /// <param name="opt_options">Options.</param>
            abstract toContext: context: CanvasRenderingContext2D * ?opt_options: Olx.Render.ToContextOptions -> Ol.Render.Canvas.Immediate

        module Canvas =

            type [<AllowNullLiteral>] IExports =
                abstract Immediate: ImmediateStatic

            type [<AllowNullLiteral>] Immediate =
                inherit Ol.Render.VectorContext
                /// <summary>Render a circle geometry into the canvas.  Rendering is immediate and uses
                /// the current fill and stroke styles.</summary>
                /// <param name="geometry">Circle geometry.</param>
                abstract drawCircle: geometry: Ol.Geom.Circle -> unit
                /// <summary>Set the rendering style.  Note that since this is an immediate rendering API,
                /// any `zIndex` on the provided style will be ignored.</summary>
                /// <param name="style">The rendering style.</param>
                abstract setStyle: style: Ol.Style.Style -> unit
                /// <summary>Render a geometry into the canvas.  Call
                /// {@link ol.render.canvas.Immediate#setStyle} first to set the rendering style.</summary>
                /// <param name="geometry">The geometry to render.</param>
                abstract drawGeometry: geometry: U2<Ol.Geom.Geometry, Ol.Render.Feature> -> unit
                /// <summary>Render a feature into the canvas.  Note that any `zIndex` on the provided
                /// style will be ignored - features are rendered immediately in the order that
                /// this method is called.  If you need `zIndex` support, you should be using an
                /// {@link ol.layer.Vector} instead.</summary>
                /// <param name="feature">Feature.</param>
                /// <param name="style">Style.</param>
                abstract drawFeature: feature: Ol.Feature * style: Ol.Style.Style -> unit

            type [<AllowNullLiteral>] ImmediateStatic =
                /// <param name="context">Context.</param>
                /// <param name="pixelRatio">Pixel ratio.</param>
                /// <param name="extent">Extent.</param>
                /// <param name="transform">Transform.</param>
                /// <param name="viewRotation">View rotation.</param>
                [<Emit "new $0($1...)">] abstract Create: context: CanvasRenderingContext2D * pixelRatio: float * extent: Ol.Extent * transform: obj option * viewRotation: float -> Immediate

        type [<AllowNullLiteral>] Event =
            inherit Ol.Events.Event
            /// For canvas, this is an instance of {@link ol.render.canvas.Immediate}.
            abstract vectorContext: Ol.Render.VectorContext with get, set
            /// An object representing the current render frame state.
            abstract frameState: Olx.FrameState with get, set
            /// Canvas context. Only available when a Canvas renderer is used, null
            /// otherwise.
            abstract context: CanvasRenderingContext2D with get, set
            /// WebGL context. Only available when a WebGL renderer is used, null
            /// otherwise.
            abstract glContext: obj option with get, set

        type [<AllowNullLiteral>] EventStatic =
            /// <param name="type">Type.</param>
            /// <param name="opt_vectorContext">Vector context.</param>
            /// <param name="opt_frameState">Frame state.</param>
            /// <param name="opt_context">Context.</param>
            /// <param name="opt_glContext">WebGL Context.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: Ol.Render.EventType * ?opt_vectorContext: Ol.Render.VectorContext * ?opt_frameState: Olx.FrameState * ?opt_context: CanvasRenderingContext2D * ?opt_glContext: obj option -> Event

        type EventType =
            string

        /// Lightweight, read-only, {@link ol.Feature} and {@link ol.geom.Geometry} like
        /// structure, optimized for rendering and styling. Geometry access through the
        /// API is limited to getting the type and extent of the geometry.
        type [<AllowNullLiteral>] Feature =
            /// <summary>Get a feature property by its key.</summary>
            /// <param name="key">Key</param>
            abstract get: key: string -> obj option
            /// Get the extent of this feature's geometry.
            abstract getExtent: unit -> Ol.Extent
            /// Get the feature for working with its geometry.
            abstract getGeometry: unit -> Ol.Render.Feature
            /// Get the feature properties.
            abstract getProperties: unit -> obj
            /// Get the type of this feature's geometry.
            abstract getType: unit -> Ol.Geom.GeometryType

        /// Lightweight, read-only, {@link ol.Feature} and {@link ol.geom.Geometry} like
        /// structure, optimized for rendering and styling. Geometry access through the
        /// API is limited to getting the type and extent of the geometry.
        type [<AllowNullLiteral>] FeatureStatic =
            /// <summary>Lightweight, read-only, {@link ol.Feature} and {@link ol.geom.Geometry} like
            /// structure, optimized for rendering and styling. Geometry access through the
            /// API is limited to getting the type and extent of the geometry.</summary>
            /// <param name="type">Geometry type.</param>
            /// <param name="flatCoordinates">Flat coordinates. These always need
            /// to be right-handed for polygons.</param>
            /// <param name="ends">Ends or Endss.</param>
            /// <param name="properties">Properties.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: Ol.Geom.GeometryType * flatCoordinates: ResizeArray<float> * ends: U2<ResizeArray<float>, ResizeArray<ResizeArray<float>>> * properties: FeatureStaticProperties -> Feature

        type [<AllowNullLiteral>] FeatureStaticProperties =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: k: string -> obj option with get, set

        /// Context for drawing geometries.  A vector context is available on render
        /// events and does not need to be constructed directly.
        type [<AllowNullLiteral>] VectorContext =
            interface end

        /// Context for drawing geometries.  A vector context is available on render
        /// events and does not need to be constructed directly.
        type [<AllowNullLiteral>] VectorContextStatic =
            /// Context for drawing geometries.  A vector context is available on render
            /// events and does not need to be constructed directly.
            [<Emit "new $0($1...)">] abstract Create: unit -> VectorContext

    type [<StringEnum>] [<RequireQualifiedAccess>] RendererType =
        | Canvas
        | Dom
        | Webgl

    type [<StringEnum>] [<RequireQualifiedAccess>] RasterOperationType =
        | Pixel
        | Image

    module Source =

        type [<AllowNullLiteral>] IExports =
            abstract BingMaps: BingMapsStatic
            abstract CartoDB: CartoDBStatic
            abstract Cluster: ClusterStatic
            abstract Image: ImageStatic
            abstract ImageEvent: ImageEventStatic
            abstract ImageArcGISRest: ImageArcGISRestStatic
            abstract ImageCanvas: ImageCanvasStatic
            abstract ImageMapGuide: ImageMapGuideStatic
            // abstract Image: ImageStaticStatic
            abstract ImageVector: ImageVectorStatic
            abstract ImageWMS: ImageWMSStatic
            abstract OSM: OSMStatic
            abstract Raster: RasterStatic
            abstract RasterEvent: RasterEventStatic
            abstract Source: SourceStatic
            abstract Stamen: StamenStatic
            abstract Tile: TileStatic
            abstract TileEvent: TileEventStatic
            abstract TileArcGISRest: TileArcGISRestStatic
            abstract TileDebug: TileDebugStatic
            abstract TileImage: TileImageStatic
            abstract TileJSON: TileJSONStatic
            abstract TileUTFGrid: TileUTFGridStatic
            abstract TileWMS: TileWMSStatic
            abstract UrlTile: UrlTileStatic
            abstract Vector: VectorStatic
            abstract VectorEvent: VectorEventStatic
            abstract VectorTile: VectorTileStatic
            abstract WMTS: WMTSStatic
            abstract XYZ: XYZStatic
            abstract Zoomify: ZoomifyStatic

        type [<AllowNullLiteral>] BingMaps =
            inherit Ol.Source.TileImage
            /// The attribution containing a link to the Microsoft® Bing™ Maps Platform APIs’
            /// Terms Of Use.
            abstract TOS_ATTRIBUTION: Ol.Attribution with get, set

        type [<AllowNullLiteral>] BingMapsStatic =
            /// <param name="options">Bing Maps options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.BingMapsOptions -> BingMaps

        type [<AllowNullLiteral>] CartoDB =
            inherit Ol.Source.XYZ
            /// Returns the current config.
            abstract getConfig: unit -> GlobalObject
            /// <summary>Updates the carto db config.</summary>
            /// <param name="config">a key-value lookup. Values will replace current values
            /// in the config.</param>
            abstract updateConfig: config: GlobalObject -> unit
            /// <summary>Sets the CartoDB config</summary>
            /// <param name="config">In the case of anonymous maps, a CartoDB configuration
            /// object.
            /// If using named maps, a key-value lookup with the template parameters.</param>
            abstract setConfig: config: GlobalObject -> unit

        type [<AllowNullLiteral>] CartoDBStatic =
            /// <param name="options">CartoDB options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.CartoDBOptions -> CartoDB

        type [<AllowNullLiteral>] Cluster =
            inherit Ol.Source.Vector
            /// Get a reference to the wrapped source.
            abstract getSource: unit -> Ol.Source.Vector
            /// Get the distance in pixels between clusters.
            abstract getDistance: unit -> float
            /// <summary>Set the distance in pixels between clusters.</summary>
            /// <param name="distance">The distance in pixels.</param>
            abstract setDistance: distance: float -> unit

        type [<AllowNullLiteral>] ClusterStatic =
            /// <param name="options">Constructor options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.ClusterOptions -> Cluster

        type [<AllowNullLiteral>] Image =
            inherit Ol.Source.Source

        type [<AllowNullLiteral>] ImageStatic =
            /// <param name="options">Single image source options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Ol.SourceImageOptions -> Image

        type [<AllowNullLiteral>] ImageEvent =
            inherit Ol.Events.Event
            /// The image related to the event.
            abstract image: Ol.Image with get, set

        type [<AllowNullLiteral>] ImageEventStatic =
            /// <param name="type">Type.</param>
            /// <param name="image">The image.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: string * image: Ol.Image -> ImageEvent

        type [<AllowNullLiteral>] ImageArcGISRest =
            inherit Ol.Source.Image
            /// Get the user-provided params, i.e. those passed to the constructor through
            /// the "params" option, and possibly updated using the updateParams method.
            abstract getParams: unit -> GlobalObject
            /// Return the image load function of the source.
            abstract getImageLoadFunction: unit -> Ol.ImageLoadFunctionType
            /// Return the URL used for this ArcGIS source.
            abstract getUrl: unit -> string
            /// <summary>Set the image load function of the source.</summary>
            /// <param name="imageLoadFunction">Image load function.</param>
            abstract setImageLoadFunction: imageLoadFunction: Ol.ImageLoadFunctionType -> unit
            /// <summary>Set the URL to use for requests.</summary>
            /// <param name="url">URL.</param>
            abstract setUrl: url: string -> unit
            /// <summary>Update the user-provided params.</summary>
            /// <param name="params">Params.</param>
            abstract updateParams: ``params``: GlobalObject -> unit

        type [<AllowNullLiteral>] ImageArcGISRestStatic =
            /// <param name="opt_options">Image ArcGIS Rest Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.ImageArcGISRestOptions -> ImageArcGISRest

        type [<AllowNullLiteral>] ImageCanvas =
            inherit Ol.Source.Image

        type [<AllowNullLiteral>] ImageCanvasStatic =
            /// <param name="options">Constructor options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.ImageCanvasOptions -> ImageCanvas

        type [<AllowNullLiteral>] ImageMapGuide =
            inherit Ol.Source.Image
            /// Get the user-provided params, i.e. those passed to the constructor through
            /// the "params" option, and possibly updated using the updateParams method.
            abstract getParams: unit -> GlobalObject
            /// Return the image load function of the source.
            abstract getImageLoadFunction: unit -> Ol.ImageLoadFunctionType
            /// <summary>Update the user-provided params.</summary>
            /// <param name="params">Params.</param>
            abstract updateParams: ``params``: GlobalObject -> unit
            /// <summary>Set the image load function of the MapGuide source.</summary>
            /// <param name="imageLoadFunction">Image load function.</param>
            abstract setImageLoadFunction: imageLoadFunction: Ol.ImageLoadFunctionType -> unit

        type [<AllowNullLiteral>] ImageMapGuideStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.ImageMapGuideOptions -> ImageMapGuide

        // type [<AllowNullLiteral>] ImageStatic =
        //     inherit Ol.Source.Image

        type [<AllowNullLiteral>] ImageStaticStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.ImageStaticOptions -> ImageStatic

        type [<AllowNullLiteral>] ImageVector =
            inherit Ol.Source.ImageCanvas
            /// Get a reference to the wrapped source.
            abstract getSource: unit -> Ol.Source.Vector
            /// Get the style for features.  This returns whatever was passed to the `style`
            /// option at construction or to the `setStyle` method.
            abstract getStyle: unit -> U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction>
            /// Get the style function.
            abstract getStyleFunction: unit -> Ol.StyleFunction
            /// <summary>Set the style for features.  This can be a single style object, an array
            /// of styles, or a function that takes a feature and resolution and returns
            /// an array of styles. If it is `undefined` the default style is used. If
            /// it is `null` the layer has no style (a `null` style), so only features
            /// that have their own styles will be rendered in the layer. See
            /// {@link ol.style} for information on the default style.</summary>
            /// <param name="style">Layer style.</param>
            abstract setStyle: style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> -> unit

        type [<AllowNullLiteral>] ImageVectorStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.ImageVectorOptions -> ImageVector

        type [<AllowNullLiteral>] ImageWMS =
            inherit Ol.Source.Image
            /// <summary>Return the GetFeatureInfo URL for the passed coordinate, resolution, and
            /// projection. Return `undefined` if the GetFeatureInfo URL cannot be
            /// constructed.</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="resolution">Resolution.</param>
            /// <param name="projection">Projection.</param>
            /// <param name="params">GetFeatureInfo params. `INFO_FORMAT` at least should
            /// be provided. If `QUERY_LAYERS` is not provided then the layers specified
            /// in the `LAYERS` parameter will be used. `VERSION` should not be
            /// specified here.</param>
            abstract getGetFeatureInfoUrl: coordinate: Ol.Coordinate * resolution: float * projection: Ol.ProjectionLike * ``params``: GlobalObject -> string
            /// Get the user-provided params, i.e. those passed to the constructor through
            /// the "params" option, and possibly updated using the updateParams method.
            abstract getParams: unit -> GlobalObject
            /// Return the image load function of the source.
            abstract getImageLoadFunction: unit -> Ol.ImageLoadFunctionType
            /// Return the URL used for this WMS source.
            abstract getUrl: unit -> string
            /// <summary>Set the image load function of the source.</summary>
            /// <param name="imageLoadFunction">Image load function.</param>
            abstract setImageLoadFunction: imageLoadFunction: Ol.ImageLoadFunctionType -> unit
            /// <summary>Set the URL to use for requests.</summary>
            /// <param name="url">URL.</param>
            abstract setUrl: url: string -> unit
            /// <summary>Update the user-provided params.</summary>
            /// <param name="params">Params.</param>
            abstract updateParams: ``params``: GlobalObject -> unit

        type [<AllowNullLiteral>] ImageWMSStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.ImageWMSOptions -> ImageWMS

        type [<AllowNullLiteral>] OSM =
            inherit Ol.Source.XYZ
            /// The attribution containing a link to the OpenStreetMap Copyright and License
            /// page.
            abstract ATTRIBUTION: Ol.Attribution with get, set

        type [<AllowNullLiteral>] OSMStatic =
            /// <param name="opt_options">Open Street Map options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.OSMOptions -> OSM

        type [<AllowNullLiteral>] Raster =
            inherit Ol.Source.Image
            /// <summary>Set the operation.</summary>
            /// <param name="operation">New operation.</param>
            /// <param name="opt_lib">Functions that will be available to operations run
            /// in a worker.</param>
            abstract setOperation: operation: Ol.RasterOperation * ?opt_lib: GlobalObject -> unit

        type [<AllowNullLiteral>] RasterStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.RasterOptions -> Raster

        type [<AllowNullLiteral>] RasterEvent =
            inherit Ol.Events.Event
            /// The raster extent.
            abstract extent: Ol.Extent with get, set
            /// The pixel resolution (map units per pixel).
            abstract resolution: float with get, set
            /// An object made available to all operations.  This can be used by operations
            /// as a storage object (e.g. for calculating statistics).
            abstract data: GlobalObject with get, set

        type [<AllowNullLiteral>] RasterEventStatic =
            /// <param name="type">Type.</param>
            /// <param name="frameState">The frame state.</param>
            /// <param name="data">An object made available to operations.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: string * frameState: Olx.FrameState * data: GlobalObject -> RasterEvent

        type [<StringEnum>] [<RequireQualifiedAccess>] State =
            | Undefined
            | Loading
            | Ready
            | Error

        type [<AllowNullLiteral>] Source =
            inherit Ol.Object
            /// Get the attributions of the source.
            abstract getAttributions: unit -> ResizeArray<Ol.Attribution>
            /// Get the logo of the source.
            abstract getLogo: unit -> U2<string, Olx.LogoOptions>
            /// Get the projection of the source.
            abstract getProjection: unit -> Ol.Proj.Projection
            /// Get the state of the source, see {@link ol.source.State} for possible states.
            abstract getState: unit -> Ol.Source.State
            /// Refreshes the source and finally dispatches a 'change' event.
            abstract refresh: unit -> unit
            /// <summary>Set the attributions of the source.</summary>
            /// <param name="attributions">Attributions.
            /// Can be passed as `string`, `Array<string>`, `{</param>
            abstract setAttributions: attributions: Ol.AttributionLike -> unit

        type [<AllowNullLiteral>] SourceStatic =
            /// <param name="options">Source options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Ol.SourceSourceOptions -> Source

        type [<AllowNullLiteral>] Stamen =
            inherit Ol.Source.XYZ

        type [<AllowNullLiteral>] StamenStatic =
            /// <param name="options">Stamen options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.StamenOptions -> Stamen

        type [<AllowNullLiteral>] Tile =
            inherit Ol.Source.Source
            /// Return the tile grid of the tile source.
            abstract getTileGrid: unit -> Ol.Tilegrid.TileGrid

        type [<AllowNullLiteral>] TileStatic =
            /// <param name="options">Tile source options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Ol.SourceTileOptions -> Tile

        type [<AllowNullLiteral>] TileEvent =
            inherit Ol.Events.Event
            /// The tile related to the event.
            abstract tile: Ol.Tile with get, set

        type [<AllowNullLiteral>] TileEventStatic =
            /// <param name="type">Type.</param>
            /// <param name="tile">The tile.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: string * tile: Ol.Tile -> TileEvent

        type [<AllowNullLiteral>] TileArcGISRest =
            inherit Ol.Source.TileImage
            /// Get the user-provided params, i.e. those passed to the constructor through
            /// the "params" option, and possibly updated using the updateParams method.
            abstract getParams: unit -> GlobalObject
            /// <summary>Update the user-provided params.</summary>
            /// <param name="params">Params.</param>
            abstract updateParams: ``params``: GlobalObject -> unit

        type [<AllowNullLiteral>] TileArcGISRestStatic =
            /// <param name="opt_options">Tile ArcGIS Rest
            /// options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.TileArcGISRestOptions -> TileArcGISRest

        type [<AllowNullLiteral>] TileDebug =
            inherit Ol.Source.Tile

        type [<AllowNullLiteral>] TileDebugStatic =
            /// <param name="options">Debug tile options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.TileDebugOptions -> TileDebug

        type [<AllowNullLiteral>] TileImage =
            inherit Ol.Source.UrlTile
            /// <summary>Sets whether to render reprojection edges or not (usually for debugging).</summary>
            /// <param name="render">Render the edges.</param>
            abstract setRenderReprojectionEdges: render: bool -> unit
            /// <summary>Sets the tile grid to use when reprojecting the tiles to the given
            /// projection instead of the default tile grid for the projection.
            ///
            /// This can be useful when the default tile grid cannot be created
            /// (e.g. projection has no extent defined) or
            /// for optimization reasons (custom tile size, resolutions, ...).</summary>
            /// <param name="projection">Projection.</param>
            /// <param name="tilegrid">Tile grid to use for the projection.</param>
            abstract setTileGridForProjection: projection: Ol.ProjectionLike * tilegrid: Ol.Tilegrid.TileGrid -> unit

        type [<AllowNullLiteral>] TileImageStatic =
            /// <param name="options">Image tile options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.TileImageOptions -> TileImage

        type [<AllowNullLiteral>] TileJSON =
            inherit Ol.Source.TileImage
            abstract getTileJSON: unit -> TileJSON

        type [<AllowNullLiteral>] TileJSONStatic =
            /// <param name="options">TileJSON options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.TileJSONOptions -> TileJSON

        type [<AllowNullLiteral>] TileUTFGrid =
            inherit Ol.Source.Tile
            /// Return the template from TileJSON.
            abstract getTemplate: unit -> string
            /// <summary>Calls the callback (synchronously by default) with the available data
            /// for given coordinate and resolution (or `null` if not yet loaded or
            /// in case of an error).</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="resolution">Resolution.</param>
            /// <param name="callback">Callback.</param>
            /// <param name="opt_this">The object to use as `this` in the callback.</param>
            /// <param name="opt_request">If `true` the callback is always async.
            ///         The tile data is requested if not yet loaded.</param>
            abstract forDataAtCoordinateAndResolution: coordinate: Ol.Coordinate * resolution: float * callback: (obj option -> obj option) * ?opt_this: 'T * ?opt_request: bool -> unit

        type [<AllowNullLiteral>] TileUTFGridStatic =
            /// <param name="options">Source options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.TileUTFGridOptions -> TileUTFGrid

        type [<AllowNullLiteral>] TileWMS =
            inherit Ol.Source.TileImage
            /// <summary>Return the GetFeatureInfo URL for the passed coordinate, resolution, and
            /// projection. Return `undefined` if the GetFeatureInfo URL cannot be
            /// constructed.</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="resolution">Resolution.</param>
            /// <param name="projection">Projection.</param>
            /// <param name="params">GetFeatureInfo params. `INFO_FORMAT` at least should
            /// be provided. If `QUERY_LAYERS` is not provided then the layers specified
            /// in the `LAYERS` parameter will be used. `VERSION` should not be
            /// specified here.</param>
            abstract getGetFeatureInfoUrl: coordinate: Ol.Coordinate * resolution: float * projection: Ol.ProjectionLike * ``params``: GlobalObject -> string
            /// Get the user-provided params, i.e. those passed to the constructor through
            /// the "params" option, and possibly updated using the updateParams method.
            abstract getParams: unit -> GlobalObject
            /// <summary>Update the user-provided params.</summary>
            /// <param name="params">Params.</param>
            abstract updateParams: ``params``: GlobalObject -> unit

        type [<AllowNullLiteral>] TileWMSStatic =
            /// <param name="opt_options">Tile WMS options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.TileWMSOptions -> TileWMS

        type [<AllowNullLiteral>] UrlTile =
            inherit Ol.Source.Tile
            /// Return the tile load function of the source.
            abstract getTileLoadFunction: unit -> Ol.TileLoadFunctionType
            /// Return the tile URL function of the source.
            abstract getTileUrlFunction: unit -> Ol.TileUrlFunctionType
            /// Return the URLs used for this source.
            /// When a tileUrlFunction is used instead of url or urls,
            /// null will be returned.
            abstract getUrls: unit -> ResizeArray<string>
            /// <summary>Set the tile load function of the source.</summary>
            /// <param name="tileLoadFunction">Tile load function.</param>
            abstract setTileLoadFunction: tileLoadFunction: Ol.TileLoadFunctionType -> unit
            /// <summary>Set the tile URL function of the source.</summary>
            /// <param name="tileUrlFunction">Tile URL function.</param>
            /// <param name="opt_key">Optional new tile key for the source.</param>
            abstract setTileUrlFunction: tileUrlFunction: Ol.TileUrlFunctionType * ?opt_key: string -> unit
            /// <summary>Set the URL to use for requests.</summary>
            /// <param name="url">URL.</param>
            abstract setUrl: url: string -> unit
            /// <summary>Set the URLs to use for requests.</summary>
            /// <param name="urls">URLs.</param>
            abstract setUrls: urls: ResizeArray<string> -> unit

        type [<AllowNullLiteral>] UrlTileStatic =
            /// <param name="options">Image tile options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Ol.SourceUrlTileOptions -> UrlTile

        type [<AllowNullLiteral>] Vector =
            inherit Ol.Source.Source
            /// <summary>Add a single feature to the source.  If you want to add a batch of features
            /// at once, call {@link ol.source.Vector#addFeatures source.addFeatures()}
            /// instead.</summary>
            /// <param name="feature">Feature to add.</param>
            abstract addFeature: feature: Ol.Feature -> unit
            /// <summary>Add a batch of features to the source.</summary>
            /// <param name="features">Features to add.</param>
            abstract addFeatures: features: ResizeArray<Ol.Feature> -> unit
            /// Remove all features from the source.
            abstract clear: ?opt_fast: bool -> unit
            /// <summary>Iterate through all features on the source, calling the provided callback
            /// with each one.  If the callback returns any "truthy" value, iteration will
            /// stop and the function will return the same value.</summary>
            /// <param name="callback">Called with each feature
            /// on the source.  Return a truthy value to stop iteration.</param>
            /// <param name="opt_this">The object to use as `this` in the callback.</param>
            abstract forEachFeature: callback: (Ol.Feature -> 'S) * ?opt_this: 'T -> 'S
            /// <summary>Iterate through all features whose bounding box intersects the provided
            /// extent (note that the feature's geometry may not intersect the extent),
            /// calling the callback with each feature.  If the callback returns a "truthy"
            /// value, iteration will stop and the function will return the same value.
            ///
            /// If you are interested in features whose geometry intersects an extent, call
            /// the {@link ol.source.Vector#forEachFeatureIntersectingExtent
            /// source.forEachFeatureIntersectingExtent()} method instead.
            ///
            /// When `useSpatialIndex` is set to false, this method will loop through all
            /// features, equivalent to {@link ol.source.Vector#forEachFeature}.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="callback">Called with each feature
            /// whose bounding box intersects the provided extent.</param>
            /// <param name="opt_this">The object to use as `this` in the callback.</param>
            abstract forEachFeatureInExtent: extent: Ol.Extent * callback: (Ol.Feature -> 'S) * ?opt_this: 'T -> 'S
            /// <summary>Iterate through all features whose geometry intersects the provided extent,
            /// calling the callback with each feature.  If the callback returns a "truthy"
            /// value, iteration will stop and the function will return the same value.
            ///
            /// If you only want to test for bounding box intersection, call the
            /// {@link ol.source.Vector#forEachFeatureInExtent
            /// source.forEachFeatureInExtent()} method instead.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="callback">Called with each feature
            /// whose geometry intersects the provided extent.</param>
            /// <param name="opt_this">The object to use as `this` in the callback.</param>
            abstract forEachFeatureIntersectingExtent: extent: Ol.Extent * callback: (Ol.Feature -> 'S) * ?opt_this: 'T -> 'S
            /// Get the features collection associated with this source. Will be `null`
            /// unless the source was configured with `useSpatialIndex` set to `false`, or
            /// with an {@link ol.Collection} as `features`.
            abstract getFeaturesCollection: unit -> Ol.Collection<Ol.Feature>
            /// Get all features on the source.
            abstract getFeatures: unit -> ResizeArray<Ol.Feature>
            /// <summary>Get all features whose geometry intersects the provided coordinate.</summary>
            /// <param name="coordinate">Coordinate.</param>
            abstract getFeaturesAtCoordinate: coordinate: Ol.Coordinate -> ResizeArray<Ol.Feature>
            /// <summary>Get all features in the provided extent.  Note that this returns all features
            /// whose bounding boxes intersect the given extent (so it may include features
            /// whose geometries do not intersect the extent).
            ///
            /// This method is not available when the source is configured with
            /// `useSpatialIndex` set to `false`.</summary>
            /// <param name="extent">Extent.</param>
            abstract getFeaturesInExtent: extent: Ol.Extent -> ResizeArray<Ol.Feature>
            /// <summary>Get the closest feature to the provided coordinate.
            ///
            /// This method is not available when the source is configured with
            /// `useSpatialIndex` set to `false`.</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="opt_filter">Feature filter function.
            /// The filter function will receive one argument, the {</param>
            abstract getClosestFeatureToCoordinate: coordinate: Ol.Coordinate * ?opt_filter: (Ol.Feature -> bool) -> Ol.Feature
            /// Get the extent of the features currently in the source.
            ///
            /// This method is not available when the source is configured with
            /// `useSpatialIndex` set to `false`.
            abstract getExtent: unit -> Ol.Extent
            /// <summary>Get a feature by its identifier (the value returned by feature.getId()).
            /// Note that the index treats string and numeric identifiers as the same.  So
            /// `source.getFeatureById(2)` will return a feature with id `'2'` or `2`.</summary>
            /// <param name="id">Feature identifier.</param>
            abstract getFeatureById: id: U2<string, float> -> Ol.Feature
            /// Get the format associated with this source.
            abstract getFormat: unit -> Ol.Format.Feature
            /// Get the url associated with this source.
            abstract getUrl: unit -> U2<string, Ol.FeatureUrlFunction>
            /// <summary>Remove a single feature from the source.  If you want to remove all features
            /// at once, use the {@link ol.source.Vector#clear source.clear()} method
            /// instead.</summary>
            /// <param name="feature">Feature to remove.</param>
            abstract removeFeature: feature: Ol.Feature -> unit

        type [<AllowNullLiteral>] VectorStatic =
            /// <param name="opt_options">Vector source options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.VectorOptions -> Vector

        type [<AllowNullLiteral>] VectorEvent =
            inherit Ol.Events.Event
            /// The feature being added or removed.
            abstract feature: Ol.Feature with get, set

        type [<AllowNullLiteral>] VectorEventStatic =
            /// <param name="type">Type.</param>
            /// <param name="opt_feature">Feature.</param>
            [<Emit "new $0($1...)">] abstract Create: ``type``: string * ?opt_feature: Ol.Feature -> VectorEvent

        type [<AllowNullLiteral>] VectorTile =
            inherit Ol.Source.UrlTile

        type [<AllowNullLiteral>] VectorTileStatic =
            /// <param name="options">Vector tile options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.VectorTileOptions -> VectorTile

        module Wms =

            type [<StringEnum>] [<RequireQualifiedAccess>] ServerType =
                | Carmentaserver
                | Geoserver
                | Mapserver
                | Qgis

        type [<StringEnum>] [<RequireQualifiedAccess>] WMTSRequestEncoding =
            | [<CompiledName "KVP">] KVP
            | [<CompiledName "REST">] REST

        type [<AllowNullLiteral>] WMTS =
            inherit Ol.Source.TileImage
            /// Get the dimensions, i.e. those passed to the constructor through the
            /// "dimensions" option, and possibly updated using the updateDimensions
            /// method.
            abstract getDimensions: unit -> GlobalObject
            /// Return the image format of the WMTS source.
            abstract getFormat: unit -> string
            /// Return the layer of the WMTS source.
            abstract getLayer: unit -> string
            /// Return the matrix set of the WMTS source.
            abstract getMatrixSet: unit -> string
            /// Return the request encoding, either "KVP" or "REST".
            abstract getRequestEncoding: unit -> Ol.Source.WMTSRequestEncoding
            /// Return the style of the WMTS source.
            abstract getStyle: unit -> string
            /// Return the version of the WMTS source.
            abstract getVersion: unit -> string
            /// <summary>Update the dimensions.</summary>
            /// <param name="dimensions">Dimensions.</param>
            abstract updateDimensions: dimensions: GlobalObject -> unit

        type [<AllowNullLiteral>] WMTSStatic =
            /// <param name="options">WMTS options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Source.WMTSOptions -> WMTS
            /// <summary>Generate source options from a capabilities object.</summary>
            /// <param name="wmtsCap">An object representing the capabilities document.</param>
            /// <param name="config">Configuration properties for the layer.  Defaults for
            ///    the layer will apply if not provided.
            ///
            /// Required config properties:
            /// - layer - {string} The layer identifier.
            ///
            /// Optional config properties:
            /// - matrixSet - {string} The matrix set identifier, required if there is
            /// more than one matrix set in the layer capabilities.
            /// - projection - {string} The desired CRS when no matrixSet is specified.
            /// eg: "EPSG:3857". If the desired projection is not available,
            /// an error is thrown.
            /// - requestEncoding - {string} url encoding format for the layer. Default is
            /// the first tile url format found in the GetCapabilities response.
            /// - style - {string} The name of the style
            /// - format - {string} Image format for the layer. Default is the first
            /// format returned in the GetCapabilities response.</param>
            abstract optionsFromCapabilities: wmtsCap: GlobalObject * config: GlobalObject -> Olx.Source.WMTSOptions

        type [<AllowNullLiteral>] XYZ =
            inherit Ol.Source.TileImage

        type [<AllowNullLiteral>] XYZStatic =
            /// <param name="opt_options">XYZ options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.XYZOptions -> XYZ

        type [<AllowNullLiteral>] Zoomify =
            inherit Ol.Source.TileImage

        type [<AllowNullLiteral>] ZoomifyStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Source.ZoomifyOptions -> Zoomify

    /// Object literal with options for the {@link ol.Sphere.getLength} or
    /// {@link ol.Sphere.getArea} functions.
    type [<AllowNullLiteral>] SphereMetricOptions =
        /// Projection of the geometry.  By default, the geometry is assumed to be in
        /// EPSG:3857 (Web Mercator).
        abstract projection: Ol.Proj.Projection option with get, set
        /// Sphere radius.  By default, the radius of the earth is used (Clarke 1866
        /// Authalic Sphere).
        abstract radius: float option with get, set

    type [<AllowNullLiteral>] Sphere =
        /// <summary>Returns the geodesic area for a list of coordinates.
        ///
        /// [Reference](http://trs-new.jpl.nasa.gov/dspace/handle/2014/40409)
        /// Robert. G. Chamberlain and William H. Duquette, "Some Algorithms for
        /// Polygons on a Sphere", JPL Publication 07-03, Jet Propulsion
        /// Laboratory, Pasadena, CA, June 2007</summary>
        /// <param name="coordinates">List of coordinates of a linear
        /// ring. If the ring is oriented clockwise, the area will be positive,
        /// otherwise it will be negative.</param>
        abstract geodesicArea: coordinates: ResizeArray<Ol.Coordinate> -> float
        /// <summary>Returns the distance from c1 to c2 using the haversine formula.</summary>
        /// <param name="c1">Coordinate 1.</param>
        /// <param name="c2">Coordinate 2.</param>
        abstract haversineDistance: c1: Ol.Coordinate * c2: Ol.Coordinate -> float

    type [<AllowNullLiteral>] SphereStatic =
        /// <param name="radius">Radius.</param>
        [<Emit "new $0($1...)">] abstract Create: radius: float -> Sphere
        /// <summary>Get the spherical area of a geometry.  This is the area (in meters) assuming
        /// that polygon edges are segments of great circles on a sphere.</summary>
        /// <param name="geometry">A geometry.</param>
        /// <param name="opt_options">Options for the area
        /// calculation.  By default, geometries are assumed to be in 'EPSG:3857'.
        /// You can change this by providing a `projection` option.</param>
        abstract getArea: geometry: Geom.Geometry * ?opt_options: SphereMetricOptions -> float
        /// <summary>Get the spherical length of a geometry.  This length is the sum of the
        /// great circle distances between coordinates.  For polygons, the length is
        /// the sum of all rings.  For points, the length is zero.  For multi-part
        /// geometries, the length is the sum of the length of each part.</summary>
        /// <param name="geometry">A geometry.</param>
        /// <param name="opt_options">Options for the length
        /// calculation.  By default, geometries are assumed to be in 'EPSG:3857'.
        /// You can change this by providing a `projection` option.</param>
        abstract getLength: geometry: Geom.Geometry * ?opt_options: SphereMetricOptions -> float

    module Style =

        type [<AllowNullLiteral>] IExports =
            abstract AtlasManager: AtlasManagerStatic
            abstract Circle: CircleStatic
            abstract Fill: FillStatic
            abstract Icon: IconStatic
            abstract Image: ImageStatic
            abstract RegularShape: RegularShapeStatic
            abstract Stroke: StrokeStatic
            abstract Style: StyleStatic
            abstract Text: TextStatic

        /// Manages the creation of image atlases.
        ///
        /// Images added to this manager will be inserted into an atlas, which
        /// will be used for rendering.
        /// The `size` given in the constructor is the size for the first
        /// atlas. After that, when new atlases are created, they will have
        /// twice the size as the latest atlas (until `maxSize` is reached).
        ///
        /// If an application uses many images or very large images, it is recommended
        /// to set a higher `size` value to avoid the creation of too many atlases.
        type [<AllowNullLiteral>] AtlasManager =
            interface end

        /// Manages the creation of image atlases.
        ///
        /// Images added to this manager will be inserted into an atlas, which
        /// will be used for rendering.
        /// The `size` given in the constructor is the size for the first
        /// atlas. After that, when new atlases are created, they will have
        /// twice the size as the latest atlas (until `maxSize` is reached).
        ///
        /// If an application uses many images or very large images, it is recommended
        /// to set a higher `size` value to avoid the creation of too many atlases.
        type [<AllowNullLiteral>] AtlasManagerStatic =
            /// <summary>Manages the creation of image atlases.
            ///
            /// Images added to this manager will be inserted into an atlas, which
            /// will be used for rendering.
            /// The `size` given in the constructor is the size for the first
            /// atlas. After that, when new atlases are created, they will have
            /// twice the size as the latest atlas (until `maxSize` is reached).
            ///
            /// If an application uses many images or very large images, it is recommended
            /// to set a higher `size` value to avoid the creation of too many atlases.</summary>
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Style.AtlasManagerOptions -> AtlasManager

        type [<AllowNullLiteral>] Circle =
            inherit Ol.Style.Image
            /// Get the fill style for the circle.
            abstract getFill: unit -> Ol.Style.Fill
            /// <summary>Get the image used to render the circle.</summary>
            /// <param name="pixelRatio">Pixel ratio.</param>
            abstract getImage: pixelRatio: float -> HTMLCanvasElement
            /// Get the circle radius.
            abstract getRadius: unit -> float
            /// Get the stroke style for the circle.
            abstract getStroke: unit -> Ol.Style.Stroke
            /// <summary>Set the circle radius.</summary>
            /// <param name="radius">Circle radius.</param>
            abstract setRadius: radius: float -> unit

        type [<AllowNullLiteral>] CircleStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Style.CircleOptions -> Circle

        type [<AllowNullLiteral>] Fill =
            /// Get the fill color.
            abstract getColor: unit -> U2<Ol.Color, Ol.ColorLike>
            /// <summary>Set the color.</summary>
            /// <param name="color">Color.</param>
            abstract setColor: color: U2<Ol.Color, Ol.ColorLike> -> unit

        type [<AllowNullLiteral>] FillStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Style.FillOptions -> Fill

        type [<StringEnum>] [<RequireQualifiedAccess>] IconAnchorUnits =
            | Fraction
            | Pixels

        type [<StringEnum>] [<RequireQualifiedAccess>] IconOrigin =
            | [<CompiledName "bottom-left">] BottomLeft
            | [<CompiledName "bottom-right">] BottomRight
            | [<CompiledName "top-left">] TopLeft
            | [<CompiledName "top-right">] TopRight

        type [<AllowNullLiteral>] Icon =
            inherit Ol.Style.Image
            abstract getAnchor: unit -> ResizeArray<float>
            /// <summary>Get the image icon.</summary>
            /// <param name="pixelRatio">Pixel ratio.</param>
            abstract getImage: pixelRatio: float -> U2<Image, HTMLCanvasElement>
            abstract getOrigin: unit -> ResizeArray<float>
            /// Get the image URL.
            abstract getSrc: unit -> string
            abstract getSize: unit -> Ol.Size
            /// Load not yet loaded URI.
            /// When rendering a feature with an icon style, the vector renderer will
            /// automatically call this method. However, you might want to call this
            /// method yourself for preloading or other purposes.
            abstract load: unit -> unit

        type [<AllowNullLiteral>] IconStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Style.IconOptions -> Icon

        type [<AllowNullLiteral>] Image =
            /// Get the symbolizer opacity.
            abstract getOpacity: unit -> float
            /// Determine whether the symbolizer rotates with the map.
            abstract getRotateWithView: unit -> bool
            /// Get the symoblizer rotation.
            abstract getRotation: unit -> float
            /// Get the symbolizer scale.
            abstract getScale: unit -> float
            /// Determine whether the symbolizer should be snapped to a pixel.
            abstract getSnapToPixel: unit -> bool
            /// <summary>Set the opacity.</summary>
            /// <param name="opacity">Opacity.</param>
            abstract setOpacity: opacity: float -> unit
            /// <summary>Set the rotation.</summary>
            /// <param name="rotation">Rotation.</param>
            abstract setRotation: rotation: float -> unit
            /// <summary>Set the scale.</summary>
            /// <param name="scale">Scale.</param>
            abstract setScale: scale: float -> unit

        type [<AllowNullLiteral>] ImageStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Ol.StyleImageOptions -> Image

        type [<AllowNullLiteral>] RegularShape =
            inherit Ol.Style.Image
            abstract getAnchor: unit -> ResizeArray<float>
            /// Get the angle used in generating the shape.
            abstract getAngle: unit -> float
            /// Get the fill style for the shape.
            abstract getFill: unit -> Ol.Style.Fill
            abstract getImage: pixelRatio: float -> U3<HTMLCanvasElement, HTMLVideoElement, Image>
            abstract getOrigin: unit -> ResizeArray<float>
            /// Get the number of points for generating the shape.
            abstract getPoints: unit -> float
            /// Get the (primary) radius for the shape.
            abstract getRadius: unit -> float
            /// Get the secondary radius for the shape.
            abstract getRadius2: unit -> float
            abstract getSize: unit -> Ol.Size
            /// Get the stroke style for the shape.
            abstract getStroke: unit -> Ol.Style.Stroke

        type [<AllowNullLiteral>] RegularShapeStatic =
            /// <param name="options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Style.RegularShapeOptions -> RegularShape

        type [<AllowNullLiteral>] Stroke =
            /// Get the stroke color.
            abstract getColor: unit -> U2<Ol.Color, string>
            /// Get the line cap type for the stroke.
            abstract getLineCap: unit -> string
            /// Get the line dash style for the stroke.
            abstract getLineDash: unit -> ResizeArray<float>
            /// Get the line join type for the stroke.
            abstract getLineJoin: unit -> string
            /// Get the miter limit for the stroke.
            abstract getMiterLimit: unit -> float
            /// Get the stroke width.
            abstract getWidth: unit -> float
            /// <summary>Set the color.</summary>
            /// <param name="color">Color.</param>
            abstract setColor: color: U2<Ol.Color, string> -> unit
            /// <summary>Set the line cap.</summary>
            /// <param name="lineCap">Line cap.</param>
            abstract setLineCap: lineCap: string -> unit
            /// <summary>Set the line dash.
            ///
            /// Please note that Internet Explorer 10 and lower [do not support][mdn] the
            /// `setLineDash` method on the `CanvasRenderingContext2D` and therefore this
            /// property will have no visual effect in these browsers.
            ///
            /// [mdn]: https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash#Browser_compatibility</summary>
            /// <param name="lineDash">Line dash.</param>
            abstract setLineDash: lineDash: ResizeArray<float> -> unit
            /// <summary>Set the line join.</summary>
            /// <param name="lineJoin">Line join.</param>
            abstract setLineJoin: lineJoin: string -> unit
            /// <summary>Set the miter limit.</summary>
            /// <param name="miterLimit">Miter limit.</param>
            abstract setMiterLimit: miterLimit: float -> unit
            /// <summary>Set the width.</summary>
            /// <param name="width">Width.</param>
            abstract setWidth: width: float -> unit

        type [<AllowNullLiteral>] StrokeStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Style.StrokeOptions -> Stroke

        type [<AllowNullLiteral>] Style =
            /// Clones the style.
            abstract clone: unit -> Ol.Style.Style
            /// Get the geometry to be rendered.
            abstract getGeometry: unit -> U3<string, Ol.Geom.Geometry, Ol.StyleGeometryFunction>
            /// Get the function used to generate a geometry for rendering.
            abstract getGeometryFunction: unit -> Ol.StyleGeometryFunction
            /// Get the fill style.
            abstract getFill: unit -> Ol.Style.Fill
            /// Get the image style.
            abstract getImage: unit -> Ol.Style.Image
            /// Get the stroke style.
            abstract getStroke: unit -> Ol.Style.Stroke
            /// Get the text style.
            abstract getText: unit -> Ol.Style.Text
            /// Get the z-index for the style.
            abstract getZIndex: unit -> float
            /// <summary>Set the fill style.</summary>
            /// <param name="fill">Fill style.</param>
            abstract setFill: fill: Ol.Style.Fill -> unit
            /// <summary>Set a geometry that is rendered instead of the feature's geometry.</summary>
            /// <param name="geometry">Feature property or geometry or function returning a geometry to render
            /// for this style.</param>
            abstract setGeometry: geometry: U3<string, Ol.Geom.Geometry, Ol.StyleGeometryFunction> -> unit
            /// <summary>Set the image style.</summary>
            /// <param name="image">Image style.</param>
            abstract setImage: image: Ol.Style.Image -> unit
            /// <summary>Set the stroke style.</summary>
            /// <param name="stroke">Stroke style.</param>
            abstract setStroke: stroke: Ol.Style.Stroke -> unit
            /// <summary>Set the text style.</summary>
            /// <param name="text">Text style.</param>
            abstract setText: text: Ol.Style.Text -> unit
            /// <summary>Set the z-index.</summary>
            /// <param name="zIndex">ZIndex.</param>
            abstract setZIndex: zIndex: float -> unit

        type [<AllowNullLiteral>] StyleStatic =
            /// <param name="opt_options">Style options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Style.StyleOptions -> Style

        type [<AllowNullLiteral>] Text =
            /// Get the font name.
            abstract getFont: unit -> string
            /// Get the x-offset for the text.
            abstract getOffsetX: unit -> float
            /// Get the y-offset for the text.
            abstract getOffsetY: unit -> float
            /// Get the fill style for the text.
            abstract getFill: unit -> Ol.Style.Fill
            /// Determine whether the text rotates with the map.
            abstract getRotateWithView: unit -> bool
            /// Get the text rotation.
            abstract getRotation: unit -> float
            /// Get the text scale.
            abstract getScale: unit -> float
            /// Get the stroke style for the text.
            abstract getStroke: unit -> Ol.Style.Stroke
            /// Get the text to be rendered.
            abstract getText: unit -> string
            /// Get the text alignment.
            abstract getTextAlign: unit -> string
            /// Get the text baseline.
            abstract getTextBaseline: unit -> string
            /// <summary>Set the font.</summary>
            /// <param name="font">Font.</param>
            abstract setFont: font: string -> unit
            /// <summary>Set the x offset.</summary>
            /// <param name="offsetX">Horizontal text offset.</param>
            abstract setOffsetX: offsetX: float -> unit
            /// <summary>Set the y offset.</summary>
            /// <param name="offsetY">Vertical text offset.</param>
            abstract setOffsetY: offsetY: float -> unit
            /// <summary>Set the fill.</summary>
            /// <param name="fill">Fill style.</param>
            abstract setFill: fill: Ol.Style.Fill -> unit
            /// <summary>Set the rotation.</summary>
            /// <param name="rotation">Rotation.</param>
            abstract setRotation: rotation: float -> unit
            /// <summary>Set the scale.</summary>
            /// <param name="scale">Scale.</param>
            abstract setScale: scale: float -> unit
            /// <summary>Set the stroke.</summary>
            /// <param name="stroke">Stroke style.</param>
            abstract setStroke: stroke: Ol.Style.Stroke -> unit
            /// <summary>Set the text.</summary>
            /// <param name="text">Text.</param>
            abstract setText: text: string -> unit
            /// <summary>Set the text alignment.</summary>
            /// <param name="textAlign">Text align.</param>
            abstract setTextAlign: textAlign: string -> unit
            /// <summary>Set the text baseline.</summary>
            /// <param name="textBaseline">Text baseline.</param>
            abstract setTextBaseline: textBaseline: string -> unit

        type [<AllowNullLiteral>] TextStatic =
            /// <param name="opt_options">Options.</param>
            [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.Style.TextOptions -> Text

    type [<AllowNullLiteral>] Tile =
        inherit Ol.Events.EventTarget
        /// Get the tile coordinate for this tile.
        abstract getTileCoord: unit -> Ol.TileCoord
        /// Load the image or retry if loading previously failed.
        /// Loading is taken care of by the tile queue, and calling this method is
        /// only needed for preloading or for reloading in case of an error.
        abstract load: unit -> unit

    type [<AllowNullLiteral>] TileStatic =
        /// <param name="tileCoord">Tile coordinate.</param>
        /// <param name="state">State.</param>
        [<Emit "new $0($1...)">] abstract Create: tileCoord: Ol.TileCoord * state: Ol.Tile.State -> Tile

    module Tile =

        type State =
            float

    module Tilegrid =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Creates a tile grid with a standard XYZ tiling scheme.</summary>
            /// <param name="opt_options">Tile grid options.</param>
            abstract createXYZ: ?opt_options: Olx.Tilegrid.XYZOptions -> Ol.Tilegrid.TileGrid
            abstract TileGrid: TileGridStatic
            abstract WMTS: WMTSStatic

        type [<AllowNullLiteral>] TileGrid =
            /// <summary>Call a function with each tile coordinate for a given extent and zoom level.</summary>
            /// <param name="extent">Extent.</param>
            /// <param name="zoom">Zoom level.</param>
            /// <param name="callback">Function called with each tile coordinate.</param>
            abstract forEachTileCoord: extent: Ol.Extent * zoom: float * callback: (Ol.TileCoord -> obj option) -> unit
            /// Get the maximum zoom level for the grid.
            abstract getMaxZoom: unit -> float
            /// Get the minimum zoom level for the grid.
            abstract getMinZoom: unit -> float
            /// <summary>Get the origin for the grid at the given zoom level.</summary>
            /// <param name="z">Z.</param>
            abstract getOrigin: z: float -> Ol.Coordinate
            /// <summary>Get the resolution for the given zoom level.</summary>
            /// <param name="z">Z.</param>
            abstract getResolution: z: float -> float
            /// Get the list of resolutions for the tile grid.
            abstract getResolutions: unit -> ResizeArray<float>
            /// <summary>Get the extent of a tile coordinate.</summary>
            /// <param name="tileCoord">Tile coordinate.</param>
            /// <param name="opt_extent">Temporary extent object.</param>
            abstract getTileCoordExtent: tileCoord: Ol.TileCoord * ?opt_extent: Ol.Extent -> Ol.Extent
            /// <summary>Get the tile coordinate for the given map coordinate and resolution.  This
            /// method considers that coordinates that intersect tile boundaries should be
            /// assigned the higher tile coordinate.</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="resolution">Resolution.</param>
            /// <param name="opt_tileCoord">Destination ol.TileCoord object.</param>
            abstract getTileCoordForCoordAndResolution: coordinate: Ol.Coordinate * resolution: float * ?opt_tileCoord: Ol.TileCoord -> Ol.TileCoord
            /// <summary>Get a tile coordinate given a map coordinate and zoom level.</summary>
            /// <param name="coordinate">Coordinate.</param>
            /// <param name="z">Zoom level.</param>
            /// <param name="opt_tileCoord">Destination ol.TileCoord object.</param>
            abstract getTileCoordForCoordAndZ: coordinate: Ol.Coordinate * z: float * ?opt_tileCoord: Ol.TileCoord -> Ol.TileCoord
            /// <summary>Get the tile size for a zoom level. The type of the return value matches the
            /// `tileSize` or `tileSizes` that the tile grid was configured with. To always
            /// get an `ol.Size`, run the result through `ol.size.toSize()`.</summary>
            /// <param name="z">Z.</param>
            abstract getTileSize: z: float -> U2<float, Ol.Size>
            /// <param name="resolution">Resolution.</param>
            /// <param name="opt_direction">If 0, the nearest resolution will be used.
            /// If 1, the nearest lower resolution will be used. If -1, the nearest
            /// higher resolution will be used. Default is 0.</param>
            abstract getZForResolution: resolution: float * ?opt_direction: float -> float

        type [<AllowNullLiteral>] TileGridStatic =
            /// <param name="options">Tile grid options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Tilegrid.TileGridOptions -> TileGrid

        type [<AllowNullLiteral>] WMTS =
            inherit Ol.Tilegrid.TileGrid
            /// Get the list of matrix identifiers.
            abstract getMatrixIds: unit -> ResizeArray<string>

        type [<AllowNullLiteral>] WMTSStatic =
            /// <param name="options">WMTS options.</param>
            [<Emit "new $0($1...)">] abstract Create: options: Olx.Tilegrid.WMTSOptions -> WMTS
            /// <summary>Create a tile grid from a WMTS capabilities matrix set.</summary>
            /// <param name="matrixSet">An object representing a matrixSet in the
            /// capabilities document.</param>
            /// <param name="opt_extent">An optional extent to restrict the tile
            /// ranges the server provides.</param>
            abstract createFromCapabilitiesMatrixSet: matrixSet: GlobalObject * ?opt_extent: Ol.Extent -> Ol.Tilegrid.WMTS

    type AttributionLike =
        U4<string, ResizeArray<string>, Ol.Attribution, ResizeArray<Ol.Attribution>>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module AttributionLike =
        let ofString v: AttributionLike = v |> U4.Case1
        let isString (v: AttributionLike) = match v with U4.Case1 _ -> true | _ -> false
        let asString (v: AttributionLike) = match v with U4.Case1 o -> Some o | _ -> None
        let ofStringArray v: AttributionLike = v |> U4.Case2
        let isStringArray (v: AttributionLike) = match v with U4.Case2 _ -> true | _ -> false
        let asStringArray (v: AttributionLike) = match v with U4.Case2 o -> Some o | _ -> None
        // let ofOl.Attribution v: AttributionLike = v |> U4.Case3
        // let isOl.Attribution (v: AttributionLike) = match v with U4.Case3 _ -> true | _ -> false
        // let asOl.Attribution (v: AttributionLike) = match v with U4.Case3 o -> Some o | _ -> None
        // let ofOl.AttributionArray v: AttributionLike = v |> U4.Case4
        // let isOl.AttributionArray (v: AttributionLike) = match v with U4.Case4 _ -> true | _ -> false
        // let asOl.AttributionArray (v: AttributionLike) = match v with U4.Case4 o -> Some o | _ -> None

    type CanvasFunctionType =
        (Ol.Extent -> float -> float -> Ol.Size -> Ol.Proj.Projection -> HTMLCanvasElement)

    type Color =
        U3<float * float * float * float, Uint8Array, Uint8ClampedArray>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module Color =
        let ofCase1 v: Color = v |> U3.Case1
        let isCase1 (v: Color) = match v with U3.Case1 _ -> true | _ -> false
        let asCase1 (v: Color) = match v with U3.Case1 o -> Some o | _ -> None
        let ofUint8Array v: Color = v |> U3.Case2
        let isUint8Array (v: Color) = match v with U3.Case2 _ -> true | _ -> false
        let asUint8Array (v: Color) = match v with U3.Case2 o -> Some o | _ -> None
        let ofUint8ClampedArray v: Color = v |> U3.Case3
        let isUint8ClampedArray (v: Color) = match v with U3.Case3 _ -> true | _ -> false
        let asUint8ClampedArray (v: Color) = match v with U3.Case3 o -> Some o | _ -> None

    type ColorLike =
        U3<string, CanvasPattern, CanvasGradient>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module ColorLike =
        let ofString v: ColorLike = v |> U3.Case1
        let isString (v: ColorLike) = match v with U3.Case1 _ -> true | _ -> false
        let asString (v: ColorLike) = match v with U3.Case1 o -> Some o | _ -> None
        let ofCanvasPattern v: ColorLike = v |> U3.Case2
        let isCanvasPattern (v: ColorLike) = match v with U3.Case2 _ -> true | _ -> false
        let asCanvasPattern (v: ColorLike) = match v with U3.Case2 o -> Some o | _ -> None
        let ofCanvasGradient v: ColorLike = v |> U3.Case3
        let isCanvasGradient (v: ColorLike) = match v with U3.Case3 _ -> true | _ -> false
        let asCanvasGradient (v: ColorLike) = match v with U3.Case3 o -> Some o | _ -> None

    type Coordinate =
        float * float

    type CoordinateFormatType =
        (Ol.Coordinate -> string)

    type DragBoxEndConditionType =
        (Ol.MapBrowserEvent -> Ol.Pixel -> Ol.Pixel -> bool)

    type DrawGeometryFunctionType =
        (U3<Ol.Coordinate, ResizeArray<Ol.Coordinate>, ResizeArray<ResizeArray<Ol.Coordinate>>> -> Ol.Geom.SimpleGeometry -> Ol.Geom.SimpleGeometry)

    type EventsConditionType =
        (Ol.MapBrowserEvent -> bool)

    type EventsKey =
        GlobalObject

    type Extent =
        float * float * float * float

    type FeatureLoader =
        (Ol.Extent -> float -> Ol.Proj.Projection -> unit)

    type FeatureStyleFunction =
        (float -> U2<Ol.Style.Style, ResizeArray<Ol.Style.Style>>)

    type FeatureUrlFunction =
        (Ol.Extent -> float -> Ol.Proj.Projection -> string)

    type ImageLoadFunctionType =
        (Ol.Image -> string -> unit)

    type LoadingStrategy =
        (Ol.Extent -> float -> ResizeArray<Ol.Extent>)

    type ModifyEventType =
        string

    type Pixel =
        float * float

    type PreRenderFunction =
        (Ol.Map -> Olx.FrameState -> bool)

    type ProjectionLike =
        U2<Ol.Proj.Projection, string> option

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module ProjectionLike =
        // let ofOl.Proj.ProjectionOption v: ProjectionLike = v |> Option.map U2.Case1
        // let ofOl.Proj.Projection v: ProjectionLike = v |> U2.Case1 |> Some
        // let isOl.Proj.Projection (v: ProjectionLike) = match v with None -> false | Some o -> match o with U2.Case1 _ -> true | _ -> false
        // let asOl.Proj.Projection (v: ProjectionLike) = match v with None -> None | Some o -> match o with U2.Case1 o -> Some o | _ -> None
        let ofStringOption v: ProjectionLike = v |> FSharp.Core.Option.map U2.Case2
        let ofString v: ProjectionLike = v |> U2.Case2 |> Some
        let isString (v: ProjectionLike) = match v with None -> false | Some o -> match o with U2.Case2 _ -> true | _ -> false
        let asString (v: ProjectionLike) = match v with None -> None | Some o -> match o with U2.Case2 o -> Some o | _ -> None

    type RasterOperation =
        (U2<ResizeArray<ResizeArray<float>>, ResizeArray<ImageData>> -> GlobalObject -> U2<ResizeArray<float>, ImageData>)

    type SelectFilterFunction =
        (U2<Ol.Feature, Ol.Render.Feature> -> Ol.Layer.Layer -> bool)

    type Size =
        float * float

    type [<AllowNullLiteral>] SourceImageOptions =
        abstract attributions: Ol.AttributionLike option with get, set
        abstract extent: Ol.Extent option with get, set
        abstract logo: U2<string, Olx.LogoOptions> option with get, set
        abstract projection: Ol.ProjectionLike with get, set
        abstract resolutions: ResizeArray<float> option with get, set
        abstract state: Ol.Source.State option with get, set

    type [<AllowNullLiteral>] SourceSourceOptions =
        abstract attributions: Ol.AttributionLike option with get, set
        abstract logo: U2<string, Olx.LogoOptions> option with get, set
        abstract projection: Ol.ProjectionLike with get, set
        abstract state: Ol.Source.State option with get, set
        abstract wrapX: bool option with get, set

    type [<AllowNullLiteral>] SourceUrlTileOptions =
        abstract attributions: Ol.AttributionLike option with get, set
        abstract cacheSize: float option with get, set
        abstract extent: Ol.Extent option with get, set
        abstract logo: U2<string, Olx.LogoOptions> option with get, set
        abstract opaque: bool option with get, set
        abstract projection: Ol.ProjectionLike with get, set
        abstract state: Ol.Source.State option with get, set
        abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
        abstract tileLoadFunction: Ol.TileLoadFunctionType with get, set
        abstract tilePixelRatio: float option with get, set
        abstract tileUrlFunction: Ol.TileUrlFunctionType option with get, set
        abstract url: string option with get, set
        abstract urls: ResizeArray<string> option with get, set
        abstract wrapX: bool option with get, set

    type [<AllowNullLiteral>] SourceTileOptions =
        abstract attributions: Ol.AttributionLike option with get, set
        abstract cacheSize: float option with get, set
        abstract extent: Ol.Extent option with get, set
        abstract logo: U2<string, Olx.LogoOptions> option with get, set
        abstract opaque: bool option with get, set
        abstract tilePixelRatio: float option with get, set
        abstract projection: Ol.ProjectionLike with get, set
        abstract state: Ol.Source.State option with get, set
        abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
        abstract wrapX: bool option with get, set

    type [<AllowNullLiteral>] StyleImageOptions =
        abstract opacity: float with get, set
        abstract rotateWithView: bool with get, set
        abstract rotation: float with get, set
        abstract scale: float with get, set
        abstract snapToPixel: bool with get, set

    type StyleFunction =
        (U2<Ol.Feature, Ol.Render.Feature> -> float -> U2<Ol.Style.Style, ResizeArray<Ol.Style.Style>>)

    type StyleGeometryFunction =
        (U2<Ol.Feature, Ol.Render.Feature> -> U2<Ol.Geom.Geometry, Ol.Render.Feature>)

    type TileCoord =
        float * float * float

    type TileLoadFunctionType =
        (Ol.Tile -> string -> unit)

    type TileUrlFunctionType =
        (Ol.TileCoord -> float -> Ol.Proj.Projection -> string)

    type TransformFunction =
        (ResizeArray<float> -> ResizeArray<float> -> float -> ResizeArray<float>)

    type WFSFeatureCollectionMetadata =
        GlobalObject

    type WFSTransactionResponse =
        GlobalObject

    type [<AllowNullLiteral>] VectorTile =
        inherit Ol.Tile
        /// Get the feature format assigned for reading this tile's features.
        abstract getFormat: unit -> Ol.Format.Feature
        /// <param name="features">Features.</param>
        abstract setFeatures: features: ResizeArray<Ol.Feature> -> unit
        /// <summary>Set the projection of the features that were added with {@link #setFeatures}.</summary>
        /// <param name="projection">Feature projection.</param>
        abstract setProjection: projection: Ol.Proj.Projection -> unit
        /// <summary>Set the feature loader for reading this tile's features.</summary>
        /// <param name="loader">Feature loader.</param>
        abstract setLoader: loader: Ol.FeatureLoader -> unit

    type [<AllowNullLiteral>] VectorTileStatic =
        /// <param name="tileCoord">Tile coordinate.</param>
        /// <param name="state">State.</param>
        /// <param name="src">Data source url.</param>
        /// <param name="format">Feature format.</param>
        /// <param name="tileLoadFunction">Tile load function.</param>
        [<Emit "new $0($1...)">] abstract Create: tileCoord: Ol.TileCoord * state: Ol.Tile.State * src: string * format: Ol.Format.Feature * tileLoadFunction: Ol.TileLoadFunctionType -> VectorTile

    type [<AllowNullLiteral>] View =
        inherit Ol.Object
        /// <summary>Animate the view. The view's center, zoom (or resolution), and
        /// rotation can be animated for smooth transitions between view states.</summary>
        /// <param name="var_args">Animation options.</param>
        abstract animate: [<ParamArray>] var_args: Array<U2<Olx.Animation.AnimateOptions, Olx.Animation.AnimateCallback>> -> unit
        /// Determine if the view is being animated.
        abstract getAnimating: unit -> bool
        /// Determine if the user is interacting with the view, such as panning or zooming.
        abstract getInteracting: unit -> bool
        /// Cancel any ongoing animations.
        abstract cancelAnimations: unit -> unit
        /// <summary>Get the constrained center of this view.</summary>
        /// <param name="center">Center.</param>
        abstract constrainCenter: ?center: Ol.Coordinate -> Ol.Coordinate
        /// <summary>Get the constrained resolution of this view.</summary>
        /// <param name="resolution">Resolution.</param>
        /// <param name="opt_delta">Delta. Default is `0`.</param>
        /// <param name="opt_direction">Direction. Default is `0`.</param>
        abstract constrainResolution: ?resolution: float * ?opt_delta: float * ?opt_direction: float -> float
        /// <summary>Get the constrained rotation of this view.</summary>
        /// <param name="rotation">Rotation.</param>
        /// <param name="opt_delta">Delta. Default is `0`.</param>
        abstract constrainRotation: ?rotation: float * ?opt_delta: float -> float
        /// Get the view center.
        abstract getCenter: unit -> Ol.Coordinate
        /// <summary>Calculate the extent for the current view state and the passed size.
        /// The size is the pixel dimensions of the box into which the calculated extent
        /// should fit. In most cases you want to get the extent of the entire map,
        /// that is `map.getSize()`.</summary>
        /// <param name="size">Box pixel size.</param>
        abstract calculateExtent: ?size: Ol.Size -> Ol.Extent
        /// Get the maximum resolution of the view.
        abstract getMaxResolution: unit -> float
        /// Get the minimum resolution of the view.
        abstract getMinResolution: unit -> float
        /// Get the maximum zoom level for the view.
        abstract getMaxZoom: unit -> float
        /// <summary>Set a new maximum zoom level for the view.</summary>
        /// <param name="zoom">The maximum zoom level.</param>
        abstract setMaxZoom: zoom: float -> unit
        /// Get the minimum zoom level for the view.
        abstract getMinZoom: unit -> float
        /// <summary>Set a new minimum zoom level for the view.</summary>
        /// <param name="zoom">The minimum zoom level.</param>
        abstract setMinZoom: zoom: float -> unit
        /// Get the view projection.
        abstract getProjection: unit -> Ol.Proj.Projection
        /// Get the view resolution.
        abstract getResolution: unit -> float
        /// Get the resolutions for the view. This returns the array of resolutions
        /// passed to the constructor of the {ol.View}, or undefined if none were given.
        abstract getResolutions: unit -> ResizeArray<float>
        /// <summary>Get the resolution for a provided extent (in map units) and size (in pixels).</summary>
        /// <param name="extent">Extent.</param>
        /// <param name="opt_size">Box pixel size.</param>
        abstract getResolutionForExtent: extent: Ol.Extent * ?opt_size: Ol.Size -> float
        /// Get the view rotation.
        abstract getRotation: unit -> float
        /// Get the current zoom level.  If you configured your view with a resolutions
        /// array (this is rare), this method may return non-integer zoom levels (so
        /// the zoom level is not safe to use as an index into a resolutions array).
        abstract getZoom: unit -> float
        /// <summary>Get the zoom level for a resolution.</summary>
        /// <param name="resolution">The resolution.</param>
        abstract getZoomForResolution: resolution: float -> float
        /// <summary>Get the resolution for a zoom level.</summary>
        /// <param name="zoom">Zoom level.</param>
        abstract getResolutionForZoom: zoom: float -> float
        /// <summary>Fit the given geometry or extent based on the given map size and border.
        /// The size is pixel dimensions of the box to fit the extent into.
        /// In most cases you will want to use the map size, that is `map.getSize()`.
        /// Takes care of the map angle.</summary>
        /// <param name="opt_options">Options.</param>
        abstract fit: geometryOrExtent: U2<Ol.Geom.SimpleGeometry, Ol.Extent> * ?opt_options: Olx.View.FitOptions -> unit
        /// <summary>Center on coordinate and view position.</summary>
        /// <param name="coordinate">Coordinate.</param>
        /// <param name="size">Box pixel size.</param>
        /// <param name="position">Position on the view to center on.</param>
        abstract centerOn: coordinate: Ol.Coordinate * size: Ol.Size * position: Ol.Pixel -> unit
        /// <summary>Rotate the view around a given coordinate.</summary>
        /// <param name="rotation">New rotation value for the view.</param>
        /// <param name="opt_anchor">The rotation center.</param>
        abstract rotate: rotation: float * ?opt_anchor: Ol.Coordinate -> unit
        /// <summary>Set the center of the current view.</summary>
        /// <param name="center">The center of the view.</param>
        abstract setCenter: center: Ol.Coordinate -> unit
        /// <summary>Set the resolution for this view.</summary>
        /// <param name="resolution">The resolution of the view.</param>
        abstract setResolution: ?resolution: float -> unit
        /// <summary>Set the rotation for this view.</summary>
        /// <param name="rotation">The rotation of the view in radians.</param>
        abstract setRotation: rotation: float -> unit
        /// <summary>Zoom to a specific zoom level.</summary>
        /// <param name="zoom">Zoom level.</param>
        abstract setZoom: zoom: float -> unit

    type [<AllowNullLiteral>] ViewStatic =
        /// <param name="opt_options">View options.</param>
        [<Emit "new $0($1...)">] abstract Create: ?opt_options: Olx.ViewOptions -> View

module Olx =

    module Animation =

        type [<AllowNullLiteral>] BounceOptions =
            abstract resolution: float with get, set
            abstract start: float option with get, set
            abstract duration: float option with get, set
            abstract easing: (float -> float) option with get, set

        type [<AllowNullLiteral>] PanOptions =
            abstract source: Ol.Coordinate with get, set
            abstract start: float option with get, set
            abstract duration: float option with get, set
            abstract easing: (float -> float) option with get, set

        type [<AllowNullLiteral>] RotateOptions =
            abstract rotation: float option with get, set
            abstract anchor: Ol.Coordinate option with get, set
            abstract start: float option with get, set
            abstract duration: float option with get, set
            abstract easing: (float -> float) option with get, set

        type [<AllowNullLiteral>] ZoomOptions =
            abstract resolution: float with get, set
            abstract start: float option with get, set
            abstract duration: float option with get, set
            abstract easing: (float -> float) option with get, set

        /// Animation options. Multiple animations can be run in series by passing
        /// multiple options objects. To run multiple animations in parallel, call
        /// the method multiple times. An optional callback can be provided as a
        /// final argument. The callback will be called with a boolean indicating
        /// whether the animation completed without being cancelled.
        type [<AllowNullLiteral>] AnimateOptions =
            abstract center: Ol.Coordinate option with get, set
            abstract zoom: float option with get, set
            abstract resolution: float option with get, set
            abstract rotation: float option with get, set
            abstract anchor: Ol.Coordinate option with get, set
            abstract duration: float option with get, set
            abstract easing: (float -> float) option with get, set

        type AnimateCallback =
            (bool -> unit)

    module Control =

        type [<AllowNullLiteral>] AttributionOptions =
            abstract className: string option with get, set
            abstract target: Element option with get, set
            abstract collapsible: bool option with get, set
            abstract collapsed: bool option with get, set
            abstract tipLabel: string option with get, set
            abstract label: U2<string, Node> option with get, set
            abstract collapseLabel: U2<string, Node> option with get, set
            abstract render: (Ol.MapEvent -> obj option) option with get, set

        type [<AllowNullLiteral>] ControlOptions =
            abstract element: Element option with get, set
            abstract render: (Ol.MapEvent -> obj option) option with get, set
            abstract target: U2<Element, string> option with get, set

        type [<AllowNullLiteral>] DefaultsOptions =
            abstract attribution: bool option with get, set
            abstract attributionOptions: Olx.Control.AttributionOptions option with get, set
            abstract rotate: bool option with get, set
            abstract rotateOptions: Olx.Control.RotateOptions option with get, set
            abstract zoom: bool option with get, set
            abstract zoomOptions: Olx.Control.ZoomOptions option with get, set

        type [<AllowNullLiteral>] FullScreenOptions =
            abstract className: string option with get, set
            abstract label: U2<string, Node> option with get, set
            abstract labelActive: U2<string, Node> option with get, set
            abstract tipLabel: string option with get, set
            abstract keys: bool option with get, set
            abstract target: Element option with get, set
            abstract source: U2<Element, string> option with get, set

        type [<AllowNullLiteral>] MousePositionOptions =
            abstract className: string option with get, set
            abstract coordinateFormat: Ol.CoordinateFormatType option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract render: (Ol.MapEvent -> obj option) option with get, set
            abstract target: Element option with get, set
            abstract undefinedHTML: string option with get, set

        type [<AllowNullLiteral>] OverviewMapOptions =
            abstract collapsed: bool option with get, set
            abstract collapseLabel: U2<string, Node> option with get, set
            abstract collapsible: bool option with get, set
            abstract label: U2<string, Node> option with get, set
            abstract layers: U2<ResizeArray<Ol.Layer.Layer>, Ol.Collection<Ol.Layer.Layer>> option with get, set
            abstract render: (Ol.MapEvent -> obj option) option with get, set
            abstract target: Element option with get, set
            abstract tipLabel: string option with get, set
            abstract view: Ol.View option with get, set

        type [<AllowNullLiteral>] ScaleLineOptions =
            abstract className: string option with get, set
            abstract minWidth: float option with get, set
            abstract render: (Ol.MapEvent -> obj option) option with get, set
            abstract target: Element option with get, set
            abstract units: U2<Ol.Control.ScaleLine.Units, string> option with get, set

        type [<AllowNullLiteral>] RotateOptions =
            abstract className: string option with get, set
            abstract label: U2<string, Element> option with get, set
            abstract tipLabel: string option with get, set
            abstract duration: float option with get, set
            abstract autoHide: bool option with get, set
            abstract render: (Ol.MapEvent -> obj option) option with get, set
            abstract resetNorth: (unit -> obj option) option with get, set
            abstract target: Element option with get, set

        type [<AllowNullLiteral>] ZoomOptions =
            abstract duration: float option with get, set
            abstract className: string option with get, set
            abstract zoomInLabel: U2<string, Node> option with get, set
            abstract zoomOutLabel: U2<string, Node> option with get, set
            abstract zoomInTipLabel: string option with get, set
            abstract zoomOutTipLabel: string option with get, set
            abstract delta: float option with get, set
            abstract target: Element option with get, set

        type [<AllowNullLiteral>] ZoomSliderOptions =
            abstract className: string option with get, set
            abstract duration: float option with get, set
            abstract maxResolution: float option with get, set
            abstract minResolution: float option with get, set
            abstract render: (Ol.MapEvent -> obj option) option with get, set

        type [<AllowNullLiteral>] ZoomToExtentOptions =
            abstract className: string option with get, set
            abstract target: Element option with get, set
            abstract label: U2<string, Node> option with get, set
            abstract tipLabel: string option with get, set
            abstract extent: Ol.Extent option with get, set

    module Format =

        type [<AllowNullLiteral>] ReadOptions =
            abstract dataProjection: Ol.ProjectionLike with get, set
            abstract featureProjection: Ol.ProjectionLike with get, set

        type [<AllowNullLiteral>] WriteOptions =
            abstract dataProjection: Ol.ProjectionLike with get, set
            abstract featureProjection: Ol.ProjectionLike option with get, set
            abstract rightHanded: bool option with get, set
            abstract decimals: float option with get, set

        type [<AllowNullLiteral>] GeoJSONOptions =
            abstract defaultDataProjection: Ol.ProjectionLike with get, set
            abstract featureProjection: Ol.ProjectionLike with get, set
            abstract geometryName: string option with get, set

        type [<AllowNullLiteral>] EsriJSONOptions =
            abstract geometryName: string option with get, set

        type [<AllowNullLiteral>] MVTOptions =
            abstract featureClass: U2<(U2<Ol.Geom.Geometry, obj> -> obj option), (Ol.Geom.GeometryType -> ResizeArray<float> -> U2<ResizeArray<float>, ResizeArray<ResizeArray<float>>> -> obj -> obj option)> option with get, set
            abstract geometryName: string option with get, set
            abstract layerName: string option with get, set
            abstract layers: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] PolylineOptions =
            abstract factor: float option with get, set
            abstract geometryLayout: Ol.Geom.GeometryLayout option with get, set

        type [<AllowNullLiteral>] TopoJSONOptions =
            abstract defaultDataProjection: Ol.ProjectionLike with get, set

        type [<AllowNullLiteral>] IGCOptions =
            abstract altitudeMode: Ol.Format.IGCZ option with get, set

        type [<AllowNullLiteral>] KMLOptions =
            abstract extractStyles: bool option with get, set
            abstract showPointNames: bool option with get, set
            abstract defaultStyle: ResizeArray<Ol.Style.Style> option with get, set
            abstract writeStyles: bool option with get, set

        type [<AllowNullLiteral>] GMLOptions =
            abstract featureNS: U2<obj, string> option with get, set
            abstract featureType: U2<ResizeArray<string>, string> option with get, set
            abstract srsName: string with get, set
            abstract surface: bool option with get, set
            abstract curve: bool option with get, set
            abstract multiCurve: bool option with get, set
            abstract multiSurface: bool option with get, set
            abstract schemaLocation: string option with get, set

        type [<AllowNullLiteral>] GPXOptions =
            abstract readExtensions: (Ol.Feature -> Node -> obj option) option with get, set

        type [<AllowNullLiteral>] WFSOptions =
            abstract featureNS: U2<obj, string> option with get, set
            abstract featureType: U2<ResizeArray<string>, string> option with get, set
            abstract gmlFormat: Ol.Format.GMLBase option with get, set
            abstract schemaLocation: string option with get, set

        type [<AllowNullLiteral>] WFSWriteGetFeatureOptions =
            abstract featureNS: string with get, set
            abstract featurePrefix: string with get, set
            abstract featureTypes: ResizeArray<string> with get, set
            abstract srsName: string option with get, set
            abstract handle: string option with get, set
            abstract outputFormat: string option with get, set
            abstract maxFeatures: float option with get, set
            abstract geometryName: string option with get, set
            abstract propertyNames: ResizeArray<string> option with get, set
            abstract startIndex: float option with get, set
            abstract count: float option with get, set
            abstract bbox: Ol.Extent option with get, set
            abstract filter: Ol.Format.Filter.Filter option with get, set
            abstract resultType: string option with get, set

        type [<AllowNullLiteral>] WFSWriteTransactionOptions =
            abstract featureNS: string with get, set
            abstract featurePrefix: string with get, set
            abstract featureType: string with get, set
            abstract srsName: string option with get, set
            abstract handle: string option with get, set
            abstract nativeElements: ResizeArray<GlobalObject> with get, set
            abstract gmlOptions: Olx.Format.GMLOptions option with get, set

        type [<AllowNullLiteral>] WKTOptions =
            abstract splitCollection: bool option with get, set

        type [<AllowNullLiteral>] WMSGetFeatureInfoOptions =
            abstract layers: ResizeArray<string> option with get, set

    module Interaction =

        /// Object literal with config options for interactions.
        type [<AllowNullLiteral>] InteractionOptions =
            abstract handleEvent: (Ol.MapBrowserEvent -> bool) with get, set

        /// Interactions for the map. Default is `true` for all options.
        type [<AllowNullLiteral>] DefaultsOptions =
            abstract altShiftDragRotate: bool option with get, set
            abstract doubleClickZoom: bool option with get, set
            abstract constrainResolution: bool option with get, set
            abstract keyboard: bool option with get, set
            abstract mouseWheelZoom: bool option with get, set
            abstract shiftDragZoom: bool option with get, set
            abstract dragPan: bool option with get, set
            abstract pinchRotate: bool option with get, set
            abstract pinchZoom: bool option with get, set
            abstract zoomDelta: float option with get, set
            abstract zoomDuration: float option with get, set

        type [<AllowNullLiteral>] DoubleClickZoomOptions =
            abstract duration: float option with get, set
            abstract delta: float option with get, set

        type [<AllowNullLiteral>] DragAndDropOptions =
            abstract formatConstructors: Array<obj> option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract target: Element option with get, set
            abstract source: Ol.Source.Vector option with get, set

        type [<AllowNullLiteral>] DragBoxOptions =
            abstract className: string option with get, set
            abstract condition: Ol.EventsConditionType option with get, set
            abstract minArea: float option with get, set
            abstract boxEndCondition: Ol.DragBoxEndConditionType option with get, set

        type [<AllowNullLiteral>] DragPanOptions =
            abstract condition: Ol.EventsConditionType option with get, set
            abstract kinetic: Ol.Kinetic option with get, set

        type [<AllowNullLiteral>] DragRotateAndZoomOptions =
            abstract condition: Ol.EventsConditionType option with get, set
            abstract duration: float option with get, set

        type [<AllowNullLiteral>] DragRotateOptions =
            abstract condition: Ol.EventsConditionType option with get, set
            abstract duration: float option with get, set

        type [<AllowNullLiteral>] DragZoomOptions =
            abstract className: string option with get, set
            abstract condition: Ol.EventsConditionType option with get, set
            abstract duration: float option with get, set
            abstract out: bool option with get, set

        type [<AllowNullLiteral>] DrawOptions =
            abstract clickTolerance: float option with get, set
            abstract features: Ol.Collection<Ol.Feature> option with get, set
            abstract source: Ol.Source.Vector option with get, set
            abstract snapTolerance: float option with get, set
            abstract ``type``: Ol.Geom.GeometryType with get, set
            abstract maxPoints: float option with get, set
            abstract minPoints: float option with get, set
            abstract finishCondition: Ol.EventsConditionType option with get, set
            abstract style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> option with get, set
            abstract geometryFunction: Ol.DrawGeometryFunctionType option with get, set
            abstract geometryName: string option with get, set
            abstract condition: Ol.EventsConditionType option with get, set
            abstract freehandCondition: Ol.EventsConditionType option with get, set
            abstract freehand: bool option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] TranslateOptions =
            abstract features: Ol.Collection<Ol.Feature> option with get, set
            abstract layers: U2<ResizeArray<Ol.Layer.Layer>, (Ol.Layer.Layer -> bool)> option with get, set

        type [<AllowNullLiteral>] KeyboardPanOptions =
            abstract condition: Ol.EventsConditionType option with get, set
            abstract duration: float option with get, set
            abstract pixelDelta: float option with get, set

        type [<AllowNullLiteral>] KeyboardZoomOptions =
            abstract duration: float option with get, set
            abstract condition: Ol.EventsConditionType option with get, set
            abstract delta: float option with get, set

        type [<AllowNullLiteral>] ModifyOptions =
            abstract condition: Ol.EventsConditionType option with get, set
            abstract deleteCondition: Ol.EventsConditionType option with get, set
            abstract insertVertexCondition: Ol.EventsConditionType option with get, set
            abstract pixelTolerance: float option with get, set
            abstract style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> option with get, set
            abstract features: Ol.Collection<Ol.Feature> option with get, set
            abstract wrapX: bool option with get, set
            abstract source: Ol.Source.Vector option with get, set

        type [<AllowNullLiteral>] MouseWheelZoomOptions =
            abstract constrainResolution: bool option with get, set
            abstract duration: float option with get, set
            abstract timeout: float option with get, set
            abstract useAnchor: bool option with get, set

        type [<AllowNullLiteral>] PinchRotateOptions =
            abstract duration: float option with get, set
            abstract threshold: float option with get, set

        type [<AllowNullLiteral>] PinchZoomOptions =
            abstract constrainResolution: bool option with get, set
            abstract duration: float option with get, set

        type [<AllowNullLiteral>] PointerOptions =
            abstract handleDownEvent: (Ol.MapBrowserPointerEvent -> bool) option with get, set
            abstract handleDragEvent: (Ol.MapBrowserPointerEvent -> bool) option with get, set
            abstract handleEvent: (Ol.MapBrowserPointerEvent -> bool) option with get, set
            abstract handleMoveEvent: (Ol.MapBrowserPointerEvent -> bool) option with get, set
            abstract handleUpEvent: (Ol.MapBrowserPointerEvent -> bool) option with get, set

        type [<AllowNullLiteral>] SelectOptions =
            abstract addCondition: Ol.EventsConditionType option with get, set
            abstract condition: Ol.EventsConditionType option with get, set
            abstract layers: U2<ResizeArray<Ol.Layer.Layer>, (Ol.Layer.Layer -> bool)> option with get, set
            abstract style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> option with get, set
            abstract removeCondition: Ol.EventsConditionType option with get, set
            abstract toggleCondition: Ol.EventsConditionType option with get, set
            abstract multi: bool option with get, set
            abstract features: Ol.Collection<Ol.Feature> option with get, set
            abstract filter: Ol.SelectFilterFunction option with get, set
            abstract wrapX: bool option with get, set
            abstract hitTolerance: float option with get, set

        /// Options for snap
        type [<AllowNullLiteral>] SnapOptions =
            abstract features: Ol.Collection<Ol.Feature> option with get, set
            abstract edge: bool option with get, set
            abstract vertex: bool option with get, set
            abstract pixelTolerance: float option with get, set
            abstract source: Ol.Source.Vector option with get, set

    module Layer =

        type [<AllowNullLiteral>] BaseOptions =
            abstract opacity: float option with get, set
            abstract visible: bool option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract zIndex: float option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set

        type [<AllowNullLiteral>] LayerOptions =
            abstract opacity: float option with get, set
            abstract source: Ol.Source.Source option with get, set
            abstract visible: bool option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract zIndex: float option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set

        type [<AllowNullLiteral>] GroupOptions =
            abstract opacity: float option with get, set
            abstract visible: bool option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract zIndex: float option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set
            abstract layers: U2<ResizeArray<Ol.Layer.Base>, Ol.Collection<Ol.Layer.Base>> option with get, set

        type [<AllowNullLiteral>] HeatmapOptions =
            abstract gradient: ResizeArray<string> option with get, set
            abstract radius: float option with get, set
            abstract blur: float option with get, set
            abstract shadow: float option with get, set
            abstract weight: U2<string, (Ol.Feature -> float)> with get, set
            abstract extent: Ol.Extent option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set
            abstract opacity: float option with get, set
            abstract source: Ol.Source.Vector with get, set
            abstract visible: bool option with get, set
            abstract zIndex: float option with get, set

        type [<AllowNullLiteral>] ImageOptions =
            abstract opacity: float option with get, set
            abstract source: Ol.Source.Image with get, set
            abstract map: Ol.Map option with get, set
            abstract visible: bool option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set
            abstract zIndex: float option with get, set

        type [<AllowNullLiteral>] TileOptions =
            abstract opacity: float option with get, set
            abstract preload: float option with get, set
            abstract source: Ol.Source.Tile with get, set
            abstract map: Ol.Map option with get, set
            abstract visible: bool option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set
            abstract useInterimTilesOnError: bool option with get, set
            abstract zIndex: float option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] VectorRenderType =
            | Image
            | Vector

        type [<AllowNullLiteral>] VectorOptions =
            abstract renderMode: U2<Olx.Layer.VectorRenderType, string> option with get, set
            abstract renderOrder: (Ol.Feature -> Ol.Feature -> float) option with get, set
            abstract map: Ol.Map option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set
            abstract opacity: float option with get, set
            abstract renderBuffer: float option with get, set
            abstract source: Ol.Source.Vector with get, set
            abstract declutter: bool option with get, set
            abstract style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> option with get, set
            abstract updateWhileAnimating: bool option with get, set
            abstract updateWhileInteracting: bool option with get, set
            abstract visible: bool option with get, set
            abstract zIndex: float option with get, set

        type [<AllowNullLiteral>] VectorTileOptions =
            abstract renderBuffer: float option with get, set
            abstract renderMode: U2<Ol.Layer.VectorTileRenderType, string> option with get, set
            abstract renderOrder: (Ol.Feature -> Ol.Feature -> float) with get, set
            abstract map: Ol.Map option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract minResolution: float option with get, set
            abstract maxResolution: float option with get, set
            abstract opacity: float option with get, set
            abstract source: Ol.Source.VectorTile option with get, set
            abstract style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> option with get, set
            abstract updateWhileAnimating: bool option with get, set
            abstract updateWhileInteracting: bool option with get, set
            abstract visible: bool option with get, set
            abstract zIndex: float option with get, set

    module Render =

        type [<AllowNullLiteral>] ToContextOptions =
            abstract size: Ol.Size option with get, set
            abstract pixelRatio: float option with get, set

    module Source =

        type [<AllowNullLiteral>] BingMapsOptions =
            abstract cacheSize: float option with get, set
            abstract culture: string option with get, set
            abstract key: string with get, set
            abstract imagerySet: string with get, set
            abstract maxZoom: float option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] ClusterOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract distance: float option with get, set
            abstract extent: Ol.Extent option with get, set
            abstract geometryFunction: (Ol.Feature -> Ol.Geom.Point) option with get, set
            abstract format: Ol.Format.Feature option with get, set
            abstract logo: string option with get, set
            abstract projection: Ol.ProjectionLike option with get, set
            abstract source: Ol.Source.Vector with get, set
            abstract wrapX: bool option with get, set

        type TileJSON =
            JSON

        type [<AllowNullLiteral>] TileUTFGridOptions =
            abstract jsonp: bool option with get, set
            abstract preemptive: bool option with get, set
            abstract tileJSON: TileJSON option with get, set
            abstract url: string option with get, set

        type [<AllowNullLiteral>] TileImageOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract opaque: bool option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract state: Ol.Source.State option with get, set
            abstract tileClass: (Ol.ImageTile -> Ol.TileCoord -> Ol.Tile.State -> string -> string -> Ol.TileLoadFunctionType -> obj option) option with get, set
            abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract tilePixelRatio: float option with get, set
            abstract tileUrlFunction: Ol.TileUrlFunctionType option with get, set
            abstract url: string option with get, set
            abstract urls: ResizeArray<string> option with get, set
            abstract wrapX: bool option with get, set
            abstract transition: float option with get, set

        type [<AllowNullLiteral>] VectorTileOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract format: Ol.Format.Feature option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract overlaps: bool option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract state: Ol.Source.State option with get, set
            abstract tileClass: (Ol.VectorTile -> Ol.TileCoord -> Ol.Tile.State -> string -> Ol.Format.Feature -> Ol.TileLoadFunctionType -> obj option) option with get, set
            abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract tileUrlFunction: Ol.TileUrlFunctionType option with get, set
            abstract url: string option with get, set
            abstract urls: ResizeArray<string> option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] ImageMapGuideOptions =
            abstract url: string option with get, set
            abstract displayDpi: float option with get, set
            abstract metersPerUnit: float option with get, set
            abstract hidpi: bool option with get, set
            abstract useOverlay: bool option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract ratio: float option with get, set
            abstract resolutions: ResizeArray<float> option with get, set
            abstract imageLoadFunction: Ol.ImageLoadFunctionType option with get, set
            abstract ``params``: GlobalObject option with get, set

        type [<AllowNullLiteral>] MapQuestOptions =
            abstract cacheSize: float option with get, set
            abstract layer: string with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract url: string option with get, set

        type [<AllowNullLiteral>] TileDebugOptions =
            abstract projection: Ol.ProjectionLike with get, set
            abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] OSMOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract maxZoom: float option with get, set
            abstract opaque: bool option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract url: string option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] ImageArcGISRestOptions =
            abstract attributions: ResizeArray<Ol.Attribution> option with get, set
            abstract crossOrigin: string option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract imageLoadFunction: Ol.ImageLoadFunctionType option with get, set
            abstract ``params``: obj option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract ratio: float option with get, set
            abstract resolutions: ResizeArray<float> option with get, set
            abstract url: string option with get, set

        type [<AllowNullLiteral>] ImageCanvasOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract canvasFunction: Ol.CanvasFunctionType with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract ratio: float option with get, set
            abstract resolutions: ResizeArray<float> option with get, set
            abstract state: Ol.Source.State option with get, set

        type [<AllowNullLiteral>] ImageVectorOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract ratio: float option with get, set
            abstract renderBuffer: float option with get, set
            abstract resolutions: ResizeArray<float> option with get, set
            abstract source: Ol.Source.Vector with get, set
            abstract style: U3<Ol.Style.Style, ResizeArray<Ol.Style.Style>, Ol.StyleFunction> option with get, set

        type [<AllowNullLiteral>] RasterOptions =
            abstract sources: ResizeArray<Ol.Source.Source> with get, set
            abstract operation: Ol.RasterOperation option with get, set
            abstract lib: GlobalObject option with get, set
            abstract threads: float option with get, set
            abstract operationType: Ol.RasterOperationType option with get, set

        type [<AllowNullLiteral>] ImageWMSOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract crossOrigin: string option with get, set
            abstract hidpi: bool option with get, set
            abstract serverType: U2<Ol.Source.Wms.ServerType, string> option with get, set
            abstract imageLoadFunction: Ol.ImageLoadFunctionType option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract ``params``: obj with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract ratio: float option with get, set
            abstract resolutions: ResizeArray<float> option with get, set
            abstract url: string option with get, set

        type [<AllowNullLiteral>] StamenOptions =
            abstract cacheSize: float option with get, set
            abstract layer: string with get, set
            abstract minZoom: float option with get, set
            abstract maxZoom: float option with get, set
            abstract opaque: bool option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract url: string option with get, set

        type [<AllowNullLiteral>] ImageStaticOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract crossOrigin: string option with get, set
            abstract imageExtent: Ol.Extent with get, set
            abstract imageLoadFunction: Ol.ImageLoadFunctionType option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract imageSize: Ol.Size option with get, set
            abstract url: string with get, set

        type [<AllowNullLiteral>] TileArcGISRestOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract ``params``: obj option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
            abstract projection: Ol.ProjectionLike option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract url: string option with get, set
            abstract wrapX: bool option with get, set
            abstract transition: float option with get, set
            abstract urls: ResizeArray<string> option with get, set

        type [<AllowNullLiteral>] TileJSONOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract jsonp: bool option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract url: string with get, set
            abstract wrapX: bool option with get, set
            abstract transition: float option with get, set

        type [<AllowNullLiteral>] TileWMSOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract ``params``: obj with get, set
            abstract crossOrigin: string option with get, set
            abstract gutter: float option with get, set
            abstract hidpi: bool option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
            abstract projection: Ol.ProjectionLike option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract serverType: U2<Ol.Source.Wms.ServerType, string> option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract url: string option with get, set
            abstract urls: ResizeArray<string> option with get, set
            abstract wrapX: bool option with get, set
            abstract transition: float option with get, set

        type [<AllowNullLiteral>] VectorOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract features: U2<ResizeArray<Ol.Feature>, Ol.Collection<Ol.Feature>> option with get, set
            abstract format: Ol.Format.Feature option with get, set
            abstract loader: Ol.FeatureLoader option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract overlaps: bool option with get, set
            abstract strategy: Ol.LoadingStrategy option with get, set
            abstract url: U2<string, Ol.FeatureUrlFunction> option with get, set
            abstract useSpatialIndex: bool option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] WMTSOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract tileGrid: Ol.Tilegrid.WMTS with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract requestEncoding: U2<Ol.Source.WMTSRequestEncoding, string> option with get, set
            abstract layer: string with get, set
            abstract style: string with get, set
            abstract tileClass: (Ol.ImageTile -> Ol.TileCoord -> Ol.Tile.State -> string -> string -> Ol.TileLoadFunctionType -> obj option) option with get, set
            abstract tilePixelRatio: float option with get, set
            abstract version: string option with get, set
            abstract format: string option with get, set
            abstract matrixSet: string with get, set
            abstract dimensions: GlobalObject option with get, set
            abstract url: string option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract urls: ResizeArray<string> option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] XYZOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract opaque: bool option with get, set
            abstract projection: Ol.ProjectionLike option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract maxZoom: float option with get, set
            abstract minZoom: float option with get, set
            abstract tileGrid: Ol.Tilegrid.TileGrid option with get, set
            abstract tileLoadFunction: Ol.TileLoadFunctionType option with get, set
            abstract tilePixelRatio: float option with get, set
            abstract tileSize: U2<float, Ol.Size> option with get, set
            abstract tileUrlFunction: Ol.TileUrlFunctionType option with get, set
            abstract url: string option with get, set
            abstract urls: ResizeArray<string> option with get, set
            abstract wrapX: bool option with get, set

        type [<AllowNullLiteral>] CartoDBOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract projection: Ol.ProjectionLike with get, set
            abstract maxZoom: float option with get, set
            abstract minZoom: float option with get, set
            abstract wrapX: bool option with get, set
            abstract config: GlobalObject option with get, set
            abstract map: string option with get, set
            abstract account: string with get, set

        type [<AllowNullLiteral>] ZoomifyOptions =
            abstract attributions: Ol.AttributionLike option with get, set
            abstract cacheSize: float option with get, set
            abstract crossOrigin: string option with get, set
            abstract logo: U2<string, Olx.LogoOptions> option with get, set
            abstract reprojectionErrorThreshold: float option with get, set
            abstract url: string with get, set
            abstract tierSizeCalculation: string option with get, set
            abstract size: Ol.Size with get, set

    module Style =

        type [<AllowNullLiteral>] CircleOptions =
            abstract fill: Ol.Style.Fill option with get, set
            abstract radius: float with get, set
            abstract snapToPixel: bool option with get, set
            abstract stroke: Ol.Style.Stroke option with get, set
            abstract atlasManager: Ol.Style.AtlasManager option with get, set

        type [<AllowNullLiteral>] FillOptions =
            abstract color: U2<Ol.Color, Ol.ColorLike> option with get, set

        type [<AllowNullLiteral>] IconOptions =
            abstract anchor: ResizeArray<float> option with get, set
            abstract anchorOrigin: Ol.Style.IconOrigin option with get, set
            abstract anchorXUnits: Ol.Style.IconAnchorUnits option with get, set
            abstract anchorYUnits: Ol.Style.IconAnchorUnits option with get, set
            abstract color: U2<Ol.Color, string> option with get, set
            abstract crossOrigin: string option with get, set
            abstract img: U2<HTMLImageElement, HTMLCanvasElement> option with get, set
            abstract offset: ResizeArray<float> option with get, set
            abstract offsetOrigin: Ol.Style.IconOrigin option with get, set
            abstract opacity: float option with get, set
            abstract scale: float option with get, set
            abstract snapToPixel: bool option with get, set
            abstract rotateWithView: bool option with get, set
            abstract rotation: float option with get, set
            abstract size: Ol.Size option with get, set
            abstract imgSize: Ol.Size option with get, set
            abstract src: string option with get, set

        /// Specify radius for regular polygons, or radius1 and radius2 for stars.
        type [<AllowNullLiteral>] RegularShapeOptions =
            abstract fill: Ol.Style.Fill option with get, set
            abstract points: float with get, set
            abstract radius: float option with get, set
            abstract radius1: float option with get, set
            abstract radius2: float option with get, set
            abstract angle: float option with get, set
            abstract snapToPixel: bool option with get, set
            abstract stroke: Ol.Style.Stroke option with get, set
            abstract rotation: float option with get, set

        type [<AllowNullLiteral>] StrokeOptions =
            abstract color: U2<Ol.Color, string> option with get, set
            abstract lineCap: string option with get, set
            abstract lineJoin: string option with get, set
            abstract lineDash: ResizeArray<float> option with get, set
            abstract miterLimit: float option with get, set
            abstract width: float option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] TextPlacement =
            | Point
            | Line

        type [<AllowNullLiteral>] TextOptions =
            abstract font: string option with get, set
            abstract maxAngle: bool option with get, set
            abstract offsetX: float option with get, set
            abstract offsetY: float option with get, set
            abstract overflow: bool option with get, set
            abstract placement: Olx.Style.TextPlacement option with get, set
            abstract scale: float option with get, set
            abstract rotateWithView: bool option with get, set
            abstract rotation: float option with get, set
            abstract text: string option with get, set
            abstract textAlign: string option with get, set
            abstract textBaseline: string option with get, set
            abstract fill: Ol.Style.Fill option with get, set
            abstract stroke: Ol.Style.Stroke option with get, set
            abstract backgroundFill: Ol.Style.Fill option with get, set
            abstract backgroundStroke: Ol.Style.Stroke option with get, set
            abstract padding: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] StyleOptions =
            abstract geometry: U3<string, Ol.Geom.Geometry, Ol.StyleGeometryFunction> option with get, set
            abstract fill: Ol.Style.Fill option with get, set
            abstract image: Ol.Style.Image option with get, set
            abstract stroke: Ol.Style.Stroke option with get, set
            abstract text: Ol.Style.Text option with get, set
            abstract zIndex: float option with get, set

        type [<AllowNullLiteral>] AtlasManagerOptions =
            abstract initialSize: float option with get, set
            abstract maxSize: float option with get, set
            abstract space: float option with get, set

    module Tilegrid =

        type [<AllowNullLiteral>] TileGridOptions =
            abstract extent: Ol.Extent option with get, set
            abstract minZoom: float option with get, set
            abstract origin: Ol.Coordinate option with get, set
            abstract origins: ResizeArray<Ol.Coordinate> option with get, set
            abstract resolutions: ResizeArray<float> with get, set
            abstract tileSize: U2<float, Ol.Size> option with get, set
            abstract tileSizes: Array<U2<float, Ol.Size>> option with get, set

        type [<AllowNullLiteral>] WMTSOptions =
            abstract extent: Ol.Extent option with get, set
            abstract origin: Ol.Coordinate option with get, set
            abstract origins: ResizeArray<Ol.Coordinate> option with get, set
            abstract resolutions: ResizeArray<float> with get, set
            abstract matrixIds: ResizeArray<string> with get, set
            abstract sizes: ResizeArray<Ol.Size> option with get, set
            abstract tileSize: U2<float, Ol.Size> option with get, set
            abstract tileSizes: Array<U2<float, Ol.Size>> option with get, set
            abstract widths: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] XYZOptions =
            abstract extent: Ol.Extent option with get, set
            abstract maxZoom: float option with get, set
            abstract minZoom: float option with get, set
            abstract tileSize: U2<float, Ol.Size> option with get, set

    type [<AllowNullLiteral>] AttributionOptions =
        abstract html: string with get, set

    type [<AllowNullLiteral>] DeviceOrientationOptions =
        abstract tracking: bool option with get, set

    type [<AllowNullLiteral>] GeolocationOptions =
        abstract tracking: bool option with get, set
        abstract trackingOptions: PositionOptions option with get, set
        abstract projection: Ol.ProjectionLike with get, set

    /// Object literal with config options for the map logo.
    type [<AllowNullLiteral>] LogoOptions =
        abstract href: string with get, set
        abstract src: string with get, set

    type [<AllowNullLiteral>] GraticuleOptions =
        abstract map: Ol.Map option with get, set
        abstract maxLines: float option with get, set
        abstract strokeStyle: Ol.Style.Stroke option with get, set
        abstract targetSize: float option with get, set
        abstract showLabels: bool option with get, set
        abstract lonLabelFormatter: (float -> string) option with get, set
        abstract latLabelFormatter: (float -> string) option with get, set
        abstract lonLabelPosition: float option with get, set
        abstract latLabelPosition: float option with get, set
        abstract lonLabelStyle: Ol.Style.Text option with get, set
        abstract latLabelStyle: Ol.Style.Text option with get, set

    /// Object literal with config options for the map.
    type [<AllowNullLiteral>] MapOptions =
        abstract controls: U2<Ol.Collection<Ol.Control.Control>, ResizeArray<Ol.Control.Control>> option with get, set
        abstract pixelRatio: float option with get, set
        abstract interactions: U2<Ol.Collection<Ol.Interaction.Interaction>, ResizeArray<Ol.Interaction.Interaction>> option with get, set
        abstract keyboardEventTarget: U3<Element, Document, string> option with get, set
        abstract layers: U2<ResizeArray<Ol.Layer.Base>, Ol.Collection<Ol.Layer.Base>> option with get, set
        abstract loadTilesWhileAnimating: bool option with get, set
        abstract loadTilesWhileInteracting: bool option with get, set
        abstract logo: U4<bool, string, Olx.LogoOptions, Element> option with get, set
        abstract overlays: U2<Ol.Collection<Ol.Overlay>, ResizeArray<Ol.Overlay>> option with get, set
        abstract renderer: U3<Ol.RendererType, Array<U2<Ol.RendererType, string>>, string> option with get, set
        abstract target: U2<Element, string> option with get, set
        abstract view: Ol.View option with get, set

    /// Object literal with config options for the overlay.
    type [<AllowNullLiteral>] OverlayOptions =
        abstract id: U2<float, string> option with get, set
        abstract element: Element option with get, set
        abstract offset: ResizeArray<float> option with get, set
        abstract position: Ol.Coordinate option with get, set
        abstract positioning: U2<Ol.OverlayPositioning, string> option with get, set
        abstract stopEvent: bool option with get, set
        abstract insertFirst: bool option with get, set
        abstract autoPan: bool option with get, set
        abstract autoPanAnimation: Olx.Animation.PanOptions option with get, set
        abstract autoPanMargin: float option with get, set

    /// Object literal with config options for the projection.
    type [<AllowNullLiteral>] ProjectionOptions =
        abstract code: string with get, set
        abstract units: U2<Ol.Proj.Units, string> option with get, set
        abstract extent: Ol.Extent option with get, set
        abstract axisOrientation: string option with get, set
        abstract ``global``: bool option with get, set
        abstract metersPerUnit: float option with get, set
        abstract worldExtent: Ol.Extent option with get, set
        abstract getPointResolution: (float -> Ol.Coordinate -> float) option with get, set

    module View =

        type [<AllowNullLiteral>] FitOptions =
            abstract size: Ol.Size option with get, set
            abstract padding: ResizeArray<float> option with get, set
            abstract constrainResolution: bool option with get, set
            abstract nearest: bool option with get, set
            abstract minResolution: float option with get, set
            abstract maxZoom: float option with get, set
            abstract duration: float option with get, set
            abstract easing: (float -> float) option with get, set
            abstract callback: Olx.Animation.AnimateCallback option with get, set

    /// Object literal with config options for the view.
    type [<AllowNullLiteral>] ViewOptions =
        abstract center: Ol.Coordinate option with get, set
        abstract constrainRotation: U2<bool, float> option with get, set
        abstract enableRotation: bool option with get, set
        abstract extent: Ol.Extent option with get, set
        abstract maxResolution: float option with get, set
        abstract minResolution: float option with get, set
        abstract maxZoom: float option with get, set
        abstract minZoom: float option with get, set
        abstract projection: Ol.ProjectionLike option with get, set
        abstract resolution: float option with get, set
        abstract resolutions: ResizeArray<float> option with get, set
        abstract rotation: float option with get, set
        abstract zoom: float option with get, set
        abstract zoomFactor: float option with get, set

    /// Object literal with options for the {@link ol.Map#forEachFeatureAtPixel} and
    /// {@link ol.Map#hasFeatureAtPixel} methods.
    type [<AllowNullLiteral>] AtPixelOptions =
        abstract layerFilter: (Ol.Layer.Layer -> bool) option with get, set
        abstract hitTolerance: float option with get, set

    type [<AllowNullLiteral>] FrameState =
        abstract pixelRatio: float with get, set
        abstract time: float with get, set
        abstract viewState: Olx.ViewState with get, set

    type [<AllowNullLiteral>] ViewState =
        abstract center: Ol.Coordinate with get, set
        abstract projection: Ol.Proj.Projection with get, set
        abstract resolution: float with get, set
        abstract rotation: float with get, set
