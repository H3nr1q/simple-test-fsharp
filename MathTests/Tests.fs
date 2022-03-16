module Tests

open System
open Xunit
open Soma

[<Fact>]
let teste1 () =
    let actual = teste.add 1 4
    Assert.Equal(5, actual)