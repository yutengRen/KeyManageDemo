﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KeyManager
{
    class Helper
    {

        public bool CheckValidationResult(object sender, X509Certificate certificate,X509Chain chain, SslPolicyErrors errors)
        {  // 总是接受  
            return true;
        }

        /// <summary>
        /// 发送请求的方法
        /// </summary>
        /// <param name="Url">地址</param>
        /// <param name="postDataStr">数据</param>
        /// <returns></returns>
        public static string HttpPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        public static string Post(string url, Dictionary<string, string> dic)
        {
            string result = "";
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Timeout = 10000;
                #region 添加Post 参数
                StringBuilder builder = new StringBuilder();
                int i = 0;
                foreach (var item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
                byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
                req.ContentLength = data.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                #endregion
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                //获取响应内容  
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch
            {

            }
            return result;
        }

        public static String sign(Dictionary<string, string> paramValues, String secret)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //对数组进行排序
                List<string> strList = paramValues.Keys.ToList();
                strList.Sort();

                foreach (String paramName in strList)
                {
                    //sb.append(paramName).append(paramValues.get(paramName));
                    sb.Append(paramName).Append(paramValues[paramName]);
                }

                //foreach (var item in paramValues)
                //{
                //    sb.Append(item.Key).Append(item.Value);
                //}

                sb.Append(secret);

                //String sign = getMD5(sb.ToString());
                //return sign;

                byte[] md5Digest = getMD5Digest(sb.ToString());
                String sign = byte2hex(md5Digest);
                return sign;
            }
            catch (IOException e)
            {
                return e.ToString();
            }
        }

        private static byte[] getMD5Digest(String data)
        {
            Byte[] clearBytes = Encoding.Default.GetBytes(data);
            Byte[] hashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);
            return hashedBytes;
        }

        private static String byte2hex(byte[] bytes)
        {
            StringBuilder sign = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                //String hex = Integer.toHexString(bytes[i] & 0xFF);
                String hex = bytes[i].ToString("X");
                if (hex.Length == 1)
                {
                    sign.Append("0");
                }
                sign.Append(hex.ToUpper());
            }
            return sign.ToString();
        }

        public static string getMD5(string sText)
        {
            Byte[] clearBytes = Encoding.Default.GetBytes(sText);
            Byte[] hashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);
            return BitConverter.ToString(hashedBytes);
        }

        /// <summary>
        /// 把内容保存到今天的文本文件中
        /// </summary>
        /// <param name="strLog"></param>
        public static void makeLog(string strLog)
        {
            try
            {
                string path = "C:\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(DateTime.Now + " " + strLog);
                sw.Close();
            }
            catch
            {
            }
        }
    }
}
