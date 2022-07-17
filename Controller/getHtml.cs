using System;
using System.Net;
using System.IO;

namespace CW1_IP.Controller
{
    public class getHtml
    {
        private string HtmlCode;
        private HttpWebRequest request;
        private HttpWebResponse response;
        private static string URL { get; set; }
        private static int StatCode { get; set; }

        public  getHtml(string url)
        {
            URL = url;
        }
        public string CheckForHttp()
        {
            if (URL.Contains("http://") || URL.Contains("https://"))
            {
                return URL;
            }
            else
            {
                URL = "http://" + URL;
                return URL;
            }
        }

        public int GetStatusCode()
        {
            
            URL = CheckForHttp();
            try
            {
                // Creating http request for URL provided in search box
                request = (HttpWebRequest)WebRequest.Create(URL);
                //Obtain respose for request
                response = (HttpWebResponse)request.GetResponse();
                //To read the request and store in varialbe;

                StatCode = (int)response.StatusCode;
                return (StatCode);
            }
            catch (WebException e) // Block to print error message
            {
                try
                {
                    StatCode = (int)((HttpWebResponse)e.Response).StatusCode;
                }
                catch (Exception)
                {
                    return 0;
                }
                if (StatCode == 404)
                {
                    return 404;
                }
                else if (StatCode == 400)
                {
                    return 400;
                }
                else if (StatCode == 403)
                {
                    return 403;
                }
                else
                {
                    return StatCode;
                }
            }
            catch (Exception)
            {
                return (0);
            }
        }
        public string HtmlResponse()
        {
           
            URL = CheckForHttp();
            
            //Error Handling implented using try catch 
            if (StatCode == 200)
            {
                try
                {
                    // Creating http request for URL provided in search box
                    request = (HttpWebRequest)WebRequest.Create(URL);
                    //Obtain respose for request
                    response = (HttpWebResponse)request.GetResponse();
                    //To read the request and store in varialbe;

                    StreamReader rd = new StreamReader(response.GetResponseStream());
                    HtmlCode = rd.ReadToEnd();
                    HtmlCode = "200 (OK) \n" + HtmlCode;
                    rd.Close();
                    response.Close();
                }
                catch (Exception e)// Other Types of Exceptions
                {
                    HtmlCode = e.Message;
                }
            }else if (StatCode == 404)
                    {
                        HtmlCode = "404 Not Found";
                    }
                    else if (StatCode == 400)
                    {
                        HtmlCode = "400 Bad Request";
                    }
                    else if (StatCode == 403)
                    {
                        HtmlCode = "403 Forbidden";
                    }
                    else
                    {
                        return HtmlCode;
                    }
                //return the source code or error message
                return HtmlCode;

            }
        
        // Function to find Title 
        public string GetTitle()
        {
            string S1 = "<title>";
            int I1 = HtmlCode.IndexOf(S1);

            string S2 = "</title>";
            int I2 = HtmlCode.IndexOf(S2);
            
            I1 += 7;
            int lenght = I2 - I1;
            string Title;
            try
            {
                if (HtmlCode.Contains(S1) && HtmlCode.Contains(S2))
                    Title = HtmlCode.Substring(I1, lenght);
                else
                    Title = "Title not Found";
            }catch(Exception)
            {
                 Title = "Title not Found";
            }
            return Title;
        }
    }
}
