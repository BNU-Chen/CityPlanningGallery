using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

namespace CityPlanningGallery
{
    public class clsConfig
    {
        private static string iniFilePath = Application.StartupPath + "\\setting.ini";

        //INIFile Config
        private static string DataSection = "DataCenter";
        private static string KeyRootDataPath = "RootDataPath";
        private static string KeyPlanningDocFolderName = "PlanningDocFolderName";
        private static string KeyPlanningImageFolderName = "PlanningImageFolderName";
        private static string KeyPlanningMapFolderName = "PlanningMapFolderName";

        private static string KeyMapGuihuaName = "MapGuihuaName";
        private static string KeyMapXianzhuangName = "MapXianzhuangName";
        private static string KeyMapFenxiName = "MapFenxiName";
        private static string KeyThumbName = "ThumbName";
        private static string KeyLegendName = "LegendName";

        //规划文档
        private static string KeyPlanningDoc = "PlanningDocName";
        private static string KeyPlanningDesc = "PlanningDescName";
        private static string KeyPlanningThematic = "PlanningThematicDocFolder";

        //SQL Server
        private static string SQLServerSection = "SQLServer";
        private static string KeyServerName = "ServerName";
        private static string KeyCatalogName = "CatalogName";
        private static string KeyUserName = "UserName";
        private static string KeyPassword = "Password";

        public static string IniFilePath
        {
            get { return clsConfig.iniFilePath; }
            set { clsConfig.iniFilePath = value; }
        }
        //根目录
        public static string RootDataPath
        {
            get { return clsINIFile.IniReadValue(DataSection, KeyRootDataPath); }
        }

        //规划文档目录
        public static string PlanningDocFolder
        {
            get { return RootDataPath + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningDocFolderName); }
        }
        //规划图集目录
        public static string PlanningImageFolder
        {
            get { return RootDataPath + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningImageFolderName); }
        }
        //规划地图目录
        public static string PlanningMapFolder
        {
            get { return RootDataPath + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningMapFolderName); }
        }

        //地图-------------------
        //规划
        public static string PlanningMapGuihuaFolder
        {
            get { return RootDataPath + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + clsINIFile.IniReadValue(DataSection, KeyMapGuihuaName); }
        }
        //现状
        public static string PlanningMapXianzhuangFolder
        {
            get { return RootDataPath + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + clsINIFile.IniReadValue(DataSection, KeyMapXianzhuangName); }
        }
        //分析
        public static string PlanningMapFenxiFolder
        {
            get { return RootDataPath + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + clsINIFile.IniReadValue(DataSection, KeyMapFenxiName); }
        }
        //缩略图-------------------
        //规划
        public static string GetThumbFolder(string path)
        {
            string thumbPath = "";
            if (Directory.Exists(path))
            {
                thumbPath = path + "\\" + clsINIFile.IniReadValue(DataSection, KeyThumbName);
            }
            return thumbPath;
        }
        //图例-------------------
        //规划
        public static string GetLegendFolder(string path)
        {
            string LegendPath = "";
            if (Directory.Exists(path))
            {
                LegendPath = path + "\\" + clsINIFile.IniReadValue(DataSection, KeyLegendName);
            }
            return LegendPath;
        }

        //规划文档----------------------------------------
        //规划文档
        public static string PlanningDoc
        {
            get { return PlanningDocFolder + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningDoc); }
        }
        //规划说明
        public static string PlanningDesc
        {
            get { return PlanningDocFolder + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningDesc); }
        }
        public static string ThematicDocsFolder
        {
            get { return PlanningDocFolder + "\\" + clsINIFile.IniReadValue(DataSection, KeyPlanningThematic); }
        }

        //SQLServer数据库
        public static string DBServerName
        {
            get { return clsINIFile.IniReadValue(SQLServerSection,KeyServerName); }
        }

        public static string DbCatalogName
        {
            get { return clsINIFile.IniReadValue(SQLServerSection, KeyCatalogName); }
        }
        public static string DBUserName
        {
            get { return clsINIFile.IniReadValue(SQLServerSection,KeyUserName); }
        }

        public static string DBPassword
        {
            get { return clsINIFile.IniReadValue(SQLServerSection,KeyPassword); }
        }
    }
}
