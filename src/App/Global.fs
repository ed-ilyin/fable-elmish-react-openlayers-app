module Global
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

type Page = Home | Counter | About

let toHash = function
    | About -> "#about"
    | Counter -> "#counter"
    | Home -> "#home"
