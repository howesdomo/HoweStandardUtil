using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public interface IAndroidPermission
    {
        bool CheckPermission(string permission);

        bool IsPermissionInDict(string permissionName);

        void RequestPermission(string permission);

        void RequestPermissions(string[] permissions);

        void OnRequestPermissionsResult(int requestCode, bool[] grantResults);
    }
}
