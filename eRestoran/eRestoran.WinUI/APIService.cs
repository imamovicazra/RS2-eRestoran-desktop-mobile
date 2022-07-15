using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using eRestoran.Model;
using System.Windows.Forms;
using eRestoran.Model.Requests;

namespace eRestoran.WinUI
{
    public class APIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Lozinka{ get; set; }
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

       
        public async Task<T> Get<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
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
                var url = $"{Properties.Settings.Default.APIUrl}/Korisnici/Auth";
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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(Model.Korisnici);
            }
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = Properties.Settings.Default.APIUrl+"/"+_route;
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<bool> Delete<T>(int id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<bool>();
            return result;
        }
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> GetById<T>(object id)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> UpdateStatusDostave<T>(int id, int statusID)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}/Status/{statusID}";
            return await url.WithBasicAuth(KorisnickoIme, Lozinka).PatchJsonAsync(null).ReceiveJson<T>();
        }
    }
}
