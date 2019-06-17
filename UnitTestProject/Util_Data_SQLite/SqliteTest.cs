using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SQLite;
using Util.Data_SQLite;

namespace UnitTestProject
{
    [TestClass]
    public class SqliteTest
    {
        public string connStr = @"D:\abc.db";

        SQLite.SQLiteAsyncConnection mDatabase;

        [TestInitialize]
        public void init()
        {
            mDatabase = new SQLiteAsyncConnection(connStr);
            initExternalDB();
        }

        private void initExternalDB()
        {
            DBVersion dbVersion = null;
            mDatabase.CreateTableAsync<DBVersion>().Wait();

            var taskR = mDatabase.Table<DBVersion>().FirstOrDefaultAsync();
            dbVersion = taskR.Result;

            if (dbVersion == null || dbVersion.Version < 1)
            {
                dbVersion = new DBVersion();
                initExternalDBStruct_v1(dbVersion);
            }

            if (dbVersion.Version < 2)
            {
                updateExternalDBStruct_v2(dbVersion);
            }
        }

        private void initExternalDBStruct_v1(DBVersion dbVersion)
        {
            dbVersion.Loaction = LocationEnum.External;
            dbVersion.Version = 1;
            mDatabase.InsertOrReplaceAsync(dbVersion);
        }

        private void updateExternalDBStruct_v2(DBVersion dbVersion)
        {
            dbVersion.Loaction = LocationEnum.External;
            dbVersion.Version = 2;
            mDatabase.InsertOrReplaceAsync(dbVersion);

            // 执行数据库升级脚本
            //mDatabase.CreateTableAsync<View.BuBuGao.Word>().Wait();

            //mDatabase.InsertAsync(new View.BuBuGao.Word() { Content = "天空" });
            mDatabase.CreateTableAsync<View.BuBuGao.Word>().Wait();
            mDatabase.CreateTableAsync<View.BuBuGao.Question>().Wait();

            View.BuBuGao.Question a1 = new View.BuBuGao.Question();
            a1.Name = "天空";
            a1.Words = new List<View.BuBuGao.Word>();
            a1.Words.Add(new View.BuBuGao.Word() { Content = "天空" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "空气" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "气体" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "体力" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "力度" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "度过" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "过去" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "去年" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "年轻" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "轻松" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "松树" });
            a1.Words.Add(new View.BuBuGao.Word() { Content = "树木" });

            View.BuBuGao.Question a2 = new View.BuBuGao.Question();
            a2.Name = "大人";
            a2.Words = new List<View.BuBuGao.Word>();
            a2.Words.Add(new View.BuBuGao.Word() { Content = "大人" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "人生" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "生命" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "命运" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "运货" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "货物" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "物品" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "品尝" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "尝试" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "试验" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "验证" });
            a2.Words.Add(new View.BuBuGao.Word() { Content = "证明" });

            View.BuBuGao.Question a3 = new View.BuBuGao.Question();
            a3.Name = "红豆";
            a3.Words = new List<View.BuBuGao.Word>();
            a3.Words.Add(new View.BuBuGao.Word() { Content = "红豆" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "豆沙" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "沙子" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "子女" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "女巫" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "巫师" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "师父" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "父亲节" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "节约" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "约见" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "见面" });
            a3.Words.Add(new View.BuBuGao.Word() { Content = "面粉" });

            View.BuBuGao.Question a4 = new View.BuBuGao.Question();
            a4.Name = "太黑";
            a4.Words = new List<View.BuBuGao.Word>();
            a4.Words.Add(new View.BuBuGao.Word() { Content = "太黑" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "黑白" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "白饭" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "饭菜" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "菜园" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "园丁" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "丁香花" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "花生" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "生气" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "气球" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "球体" });
            a4.Words.Add(new View.BuBuGao.Word() { Content = "体检" });

            View.BuBuGao.Question a5 = new View.BuBuGao.Question();
            a5.Name = "上面";
            a5.Words = new List<View.BuBuGao.Word>();

            a5.Words.Add(new View.BuBuGao.Word() { Content = "上面" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "面条" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "条件" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "件数" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "数学" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "学习" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "习惯" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "惯性" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "性格" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "格子" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "子孙" });
            a5.Words.Add(new View.BuBuGao.Word() { Content = "孙悟空" });

            mDatabase.InsertAsync(a1);
            mDatabase.InsertAsync(a2);
            mDatabase.InsertAsync(a3);
            mDatabase.InsertAsync(a4);
            mDatabase.InsertAsync(a5).Wait();

            InsertWordList(a1);
            InsertWordList(a2);
            InsertWordList(a3);
            InsertWordList(a4);
            InsertWordList(a5);
        }

        private void InsertWordList(View.BuBuGao.Question question)
        {
            foreach (View.BuBuGao.Word item in question.Words)
            {
                item.QuestionID = question.ID;
                mDatabase.InsertAsync(item).Wait(); // 重要
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            mDatabase.Table<View.BuBuGao.Question>().ToListAsync().ContinueWith((t) =>
            {
                foreach (var item in t.Result)
                {
                    item.Words = getWordsByQuestionID(item);
                }

                Assert.AreEqual<int>(5, t.Result.Count);
            });
        }

        private List<View.BuBuGao.Word> getWordsByQuestionID(View.BuBuGao.Question q)
        {
            return mDatabase.Table<View.BuBuGao.Word>().Where(i => i.QuestionID == q.ID).ToListAsync().Result;
        }


        [TestMethod]
        public void TestMethod2()
        {
            mDatabase.Table<View.BuBuGao.Word>().ToListAsync().ContinueWith((t) =>
            {
                foreach (var item in t.Result)
                {
                    System.Diagnostics.Debug.WriteLine(Util.JsonUtils.SerializeObject(item));
                }

                Assert.AreEqual<int>(50, t.Result.Count);
            });
        }


    }


}
