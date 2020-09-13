namespace Hangman.Service.Client
open System
open System.Net.Http
open System.Net.Http.Headers
open Newtonsoft.Json

module JsonHttpClient =
    let GetAsync<'a> uri =
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
        }