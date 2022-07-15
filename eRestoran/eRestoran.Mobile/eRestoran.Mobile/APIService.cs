using eRestoran.Model;
using eRestoran.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eRestoran.Mobile
{
    public class APIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }
#if DEBUG
        private string APIUrl = "http://localhost:52322/api";
#endif
        public async Task<Model.Jela> Like(int Id)
        {
            var url= $"{APIUrl}/Jelo/{Id}/Like";
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(null).ReceiveJson<Model.Jela>();
            return result;
        }

        public async Task<bool> Dislike(int Id)
        {
            var url = $"{APIUrl}/Jelo/{Id}/Like";
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<bool>();
            return result;
        }
        public async Task<T> GetLajkanaJela<T>()
        {
            try
            {
                var url = $"{APIUrl}/Korisnici/Jela";

               return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default;
            }
        }
        public async Task<T> Get<T>(object search)
        {

            var url = $"{APIUrl}/{_route}";
            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }

        public async Task<Model.Korisnici> Authenticate(KorisnikAuthenticationRequest request)
        {
            try
            {
                var url = $"{APIUrl}/Korisnici/Auth";
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<Model.Korisnici>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(Model.Korisnici);
            }
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = APIUrl + "/" + _route;
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<bool> Delete<T>(int id)
        {
            var url = $"{APIUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<bool>();
            return result;
        }
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<T> GetById<T>(object id)
        {

            var url = $"{APIUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> UpdateStatusDostave<T>(int id, int statusID)
        {
            var url = $"{APIUrl}/{_route}/{id}/Status/{statusID}";
            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PatchJsonAsync(null).ReceiveJson<T>();
        }
        public async Task<Model.Korisnici> SignUp(KorisniciInsertRequest request)
        {
            try
            {
                var url = $"{APIUrl}/Korisnici/SignUp";
                return await url.PostJsonAsync(request).ReceiveJson<Korisnici>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(Model.Korisnici);
            }
        }
    }
}
