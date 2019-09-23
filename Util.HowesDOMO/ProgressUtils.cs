using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Util
{
    public class ProgressUtils
    {
        /// <summary>
        /// 执行程序
        /// </summary>
        /// <param name="fileName">运行的程序</param>
        /// <param name="arguments">参数</param>
        /// <param name="windowStyle">程序运行窗口模式(默认静默模式)</param>
        public static void ExcuteProgressWithArguments(string fileName, string arguments, ProcessWindowStyle windowStyle = ProcessWindowStyle.Hidden)
        {
            using (var p = new Process())
            {
                p.StartInfo.FileName = fileName;
                p.StartInfo.Arguments = arguments;
                p.StartInfo.WindowStyle = windowStyle;

                p.Start();
                p.WaitForExit();
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="arguments"></param>
        /// <returns>
        /// Item1:ExitCode; 0 - 正常, 1 - 异常
        /// Item2:OutputMsg; 
        /// Item3:ErrorMsg
        /// </returns>
        public static ProcessResult ExcuteBatCMD(string arguments)
        {
            // /c 表示运行后关闭窗口
            System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + arguments);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            System.Diagnostics.Process process = System.Diagnostics.Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            string outputMsg = process.StandardOutput.ReadToEnd();
            outputMsg = outputMsg.TrimAdv();

            string errorMsg = process.StandardError.ReadToEnd();
            errorMsg = errorMsg.TrimAdv();

            int exitCode = process.ExitCode;

            Debug.WriteLine("output>>" + (String.IsNullOrEmpty(outputMsg) ? "(none)" : outputMsg));
            Debug.WriteLine("error>>" + (String.IsNullOrEmpty(errorMsg) ? "(none)" : errorMsg));
            Debug.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");

            process.Close();

            return new ProcessResult(exitCode, outputMsg, errorMsg);
        }
    }

    public class ProcessResult
    {
        public ProcessResult()
        {

        }

        public ProcessResult(int _ExitCode, string _OutputMsg, string _ErrorMsg)
        {
            this.ExitCode = _ExitCode;
            this.OutputMsg = _OutputMsg;
            this.ErrorMsg = _ErrorMsg;
        }

        public int ExitCode { get; private set; }

        public string OutputMsg { get; private set; }

        public string ErrorMsg { get; private set; }
    }
}
