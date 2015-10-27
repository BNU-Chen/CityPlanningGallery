﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;

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
            get { return INIFile.IniReadValue(DataSection, KeyRootDataPath); }
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
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + INIFile.IniReadValue(DataSection, KeyMapGuihuaName); }
        }
        //现状
        public static string PlanningMapXianzhuangFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + INIFile.IniReadValue(DataSection, KeyMapXianzhuangName); }
        }
        //分析
        public static string PlanningMapFenxiFolder
        {
            get { return RootDataPath + "\\" + INIFile.IniReadValue(DataSection, KeyPlanningMapFolderName) + "\\" + INIFile.IniReadValue(DataSection, KeyMapFenxiName); }
        }
        //缩略图-------------------
        //规划
        public static string GetThumbFolder(string path)
        {
            string thumbPath = "";
            if (Directory.Exists(path))
            {
                thumbPath = path + "\\" + INIFile.IniReadValue(DataSection, KeyThumbName);
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
                LegendPath = path + "\\" + INIFile.IniReadValue(DataSection, KeyLegendName);
            }
            return LegendPath;
        }

    }
}
