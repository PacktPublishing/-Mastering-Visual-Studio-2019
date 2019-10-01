namespace FSharpWeb.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Newtonsoft.Json

[<Route("api/[controller]")>]
[<ApiController>]
type ValuesController () =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        let values = [|"value1"; "value2"|]
        let obj = {| Name="Test";Description="Description"|}
        ActionResult<string>(JsonConvert.SerializeObject(obj))

    [<HttpGet("{id}")>]
    member this.Get(id:int) =
        let value = "value"
        ActionResult<string>(value)

    [<HttpPost>]
    member this.Post([<FromBody>] value:string) =
        ()

    [<HttpPut("{id}")>]
    member this.Put(id:int, [<FromBody>] value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member this.Delete(id:int) =
        ()
