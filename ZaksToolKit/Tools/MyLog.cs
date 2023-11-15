using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace ZaksToolKit.Tools {
    public static class ZaksTool {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static string makeMd5(string input, bool isUpper = false) {
            MD5 d5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] res = d5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < res.Length; i++) {
                // x参数 将10进制转换为16进制
                if(isUpper) {
                    sb.Append(res[i].ToString("X"));
                } else {
                    sb.Append(res[i].ToString("x"));
                }

            }

            return sb.ToString();
        }
    }

}
