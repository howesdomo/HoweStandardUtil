using System.Net;

namespace System
{
    public class WebDateTime
    {
        private WebDateTime()
        {

        }

        public static DateTime Now
        {
            get
            {
                DateTime r = DateTime.Now;

                WebRequest request = null;
                WebResponse response = null;
                WebHeaderCollection headerCollection = null;
                string datetime = string.Empty;
                try
                {
                    request = WebRequest.Create("https://www.baidu.com");
                    request.Timeout = 3000;
                    request.Credentials = CredentialCache.DefaultCredentials;
                    response = (WebResponse)request.GetResponse();
                    headerCollection = response.Headers;
                    foreach (var h in headerCollection.AllKeys)
                    {
                        if (h == "Date")
                        {
                            datetime = headerCollection[h];
                        }
                    }
                }
                catch (Exception ex1)
                {
                    throw new Exception("GetInternetDateTime Step 1 Error", ex1);
                }
                finally
                {
                    if (request != null)
                    {
                        request.Abort();
                    }

                    if (response != null)
                    {
                        response.Close();
                    }

                    if (headerCollection != null)
                    {
                        headerCollection.Clear();
                    }
                }

                try
                {
                    r = Convert.ToDateTime(datetime);
                }
                catch (Exception ex2)
                {
                    throw new Exception("GetInternetDateTime Step 1 Error", ex2);
                }

                return r;
            }
        }

    }
}
