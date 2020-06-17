using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace UnitTestProject.Util_UnitTest
{
    public class HttpUtils_UnitTest
    {

        [TestMethod]
        public async void Post111()
        {
            dynamic data = new ExpandoObject();
            data.Order = "Abcdefg";
            data.DateTime = DateTime.Now;
            
            var httpM = await Util.Web.HttpUtils.HttpPostWithFormUrlEncodedContent
            (
                url: "https://localhost:44380//api/Test/Test",
                data: data
            );

            string returnJsonStr = await httpM.Content.ReadAsStringAsync();
            string expert = Util.JsonUtils.SerializeObject(data);

            Assert.AreEqual<string>(expert, returnJsonStr);
        }

    }
}
