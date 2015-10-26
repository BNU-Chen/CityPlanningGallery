using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CityPlanningGallery
{
    public class Config
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

        public static string IniFilePath
        {
            get { return Config.iniFilePath; }
            set { Config.iniFilePath = value; }
        }
        //根目录
        public static string RootDataPath
        {
            get { return INIFile.IniReadValue(DataSection, RootDataPath); }
        }

        //规划文档目录
        public static string PlanningDocFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningDocFolderName); }
        }
        //规划图集目录
        public static string PlanningImageFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningImageFolderName); }
        }
        //规划地图目录
        public static string PlanningMapFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName); }
        }

        //地图-------------------
        //规划
        public static string PlanningMapGuihuaFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapGuihuaName; }
        }
        //现状
        public static string PlanningMapXianzhuangFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapXianzhuangName; }
        }
        //分析
        public static string PlanningMapFenxiFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapFenxiName; }
        }
        //缩略图-------------------
        //规划
        public static string PlanninThumbGuihuaFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapGuihuaName + "\\" + KeyThumbName; }
        }
        //现状
        public static string PlanninThumbXianzhuangFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapXianzhuangName + "\\" + KeyThumbName; }
        }
        //分析
        public static string PlanninThumbFenxiFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapFenxiName + "\\" + KeyThumbName; }
        }
        //图例-------------------
        //规划
        public static string PlanninThumbGuihuaFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapGuihuaName + "\\" + KeyLegendName; }
        }
        //现状
        public static string PlanninThumbXianzhuangFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapXianzhuangName + "\\" + KeyLegendName; }
        }
        //分析
        public static string PlanninThumbFenxiFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + KeyMapFenxiName + "\\" + KeyLegendName; }
        }

    }
}
