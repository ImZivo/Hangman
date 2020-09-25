namespace Hangman.Service.Client
open System
open System.Threading.Tasks
open System.Net.Http
open System.Net.Http.Headers
open Newtonsoft.Json

type IHttpClient =
    abstract member GetAsync : uri:Uri -> Task<'a>

type JsonHttpClient() =
    interface IHttpClient with
        member _this.GetAsync uri =
            let GetStringAsync uri =
                let url:Uri = uri
                let getHttp =
                    let http = new HttpClient()
                    let jsonHeader = MediaTypeWithQualityHeaderValue "application/json"
                    http.DefaultRequestHeaders.Accept.Add jsonHeader
                    http
                async {
                    use http = getHttp
                    return! http.GetStringAsync url |> Async.AwaitTask
                }
            async {
                let! json = GetStringAsync uri
                let obj = JsonConvert.DeserializeObject<'a> json
                return obj
            } |> Async.StartAsTask