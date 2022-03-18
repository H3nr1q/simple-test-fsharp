module Tests

open System
open Xunit
open Soma

[<Fact>]
let TesteXunit () =
    let actual = teste.add 1 4
    Assert.Equal(5, actual)