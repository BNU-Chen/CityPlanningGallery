using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using DevExpress.XtraTab;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace CityPlanningGallery
{
    public partial class ucDocumentReader : UserControl
    {
        private bool imageFlag; //btn_Search按钮背景图片
        private List<DocumentRange> documentRangeCollection = new List<DocumentRange>();
        private List<Paragraph> paragraphCollection = new List<Paragraph>();
        private List<RichTextBox> readOnlyRichTextBoxCollection = new List<RichTextBox>();
        private List<RichTextBox> roRichTextBoxCollection = new List<RichTextBox>();
        private bool multiDocumentSearch = false;

        public string Searchkeyword
        {
            set
            {
                this.te_KeyWord.Text = value;
            }
            get
            {
                return this.te_KeyWord.Text;
            }
        }
        public RichEditControl REC_DocumentDisplay
        {
            get
            {
                return this.rec_DocumentDisplay;
            }
        }

        //构造函数
        public ucDocumentReader()
        {
            InitializeComponent();
            this.rec_DocumentDisplay.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;
            this.rec_DocumentDisplay.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden;
            this.flowLayoutPanel.MouseEnter += flowLayoutPanel_MouseEnter;
            this.panelControl1.MouseEnter += panelControl1_MouseEnter;
            this.rec_DocumentDisplay.MouseEnter += rec_DocumentDisplay_MouseEnter;
            this.imageFlag = true;
        }

        void flowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                this.flowLayoutPanel.Focus();
            }
            catch
            { }
        }

        void panelControl1_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                this.flowLayoutPanel.Focus();
            }
            catch
            { }
        }

        void rec_DocumentDisplay_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                this.rec_DocumentDisplay.Focus();
            }
            catch
            { }
        }

        #region //控件响应事件
        //搜索按钮单击事件
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //控件状态恢复
            this.setInitializationSearchResult();
            this.SearchResultInfoChange();
            if (!imageFlag) te_KeyWord.Text = "";
        }
        //搜索栏Enter键事件
        private void TextEdit_Filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //控件状态恢复
                this.setInitializationSearchResult();
                this.KeyWordSearch();
            }
        }
        //鼠标单击事件，文档位置响应
        private void flowLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RichTextBox roRTBControl = (RichTextBox)sender;
                if (roRTBControl != null)
                {
                    if (this.multiDocumentSearch)
                    {
                        this.multiDocumentSearch = false;
                        //this.cbe_SearchRange.SelectedIndex = -1;
                        this.SearchFromDocument(this.te_KeyWord.Text.Trim(), roRTBControl.Tag.ToString());
                    }
                    else
                        MoveToParagraph((Paragraph)(roRTBControl.Tag));
                }
            }
            catch { }
        }
        //鼠标滚轮事件
        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                this.flowLayoutPanel.Focus();
            }
            catch
            { }
        }
        //关键词控件文本值变更事件
        private void te_KeyWord_EditValueChanged(object sender, EventArgs e)
        {
            if (te_KeyWord.Text == "")
            {
                btn_Search.BackgroundImage = global::CityPlanningGallery.Properties.Resources.search_16;
                imageFlag = true;
            }
            else
            {
                btn_Search.BackgroundImage = global::CityPlanningGallery.Properties.Resources.delete_16;
                imageFlag = false;
            }
        }
        #endregion

        #region //搜索相关函数
        //关键词搜索
        private bool KeyWordSearch()
        {
            try
            {
                this.documentRangeCollection = this.getDocumentRangeCollectionByKeyWord(this.te_KeyWord.Text.Trim(), this.rec_DocumentDisplay.Document);
                this.paragraphCollection = this.getParagraphCollectionByDocumentRangeCollection(this.documentRangeCollection, this.rec_DocumentDisplay.Document);
                this.readOnlyRichTextBoxCollection = this.getReadOnlyRichTextBoxCollectionByParagrapheCollection(this.te_KeyWord.Text.Trim(), this.paragraphCollection, this.rec_DocumentDisplay.Document);
                this.AddRichTextBoxToFlowLayoutPanal(this.readOnlyRichTextBoxCollection);
                if (this.documentRangeCollection.Count != 0) 
                {
                    this.MoveToParagraph(this.paragraphCollection[0]);
                    this.DocumentKeyWordHighlightSet();
                }
                this.SearchResultInfoChange();
                this.flowLayoutPanel.Refresh();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //根据关键字返回关键字在文档中的位置集合
        private List<DocumentRange> getDocumentRangeCollectionByKeyWord(string keyWord, Document searchDocument)
        {
            List<DocumentRange> documentRangeCollection = new List<DocumentRange>();
            try
            {
                if (keyWord != "" && searchDocument != null)
                {
                    //搜索参数设置
                    SearchOptions sOptions = SearchOptions.None;
                    SearchDirection sDirection = SearchDirection.Forward;
                    DocumentRange sRange = searchDocument.Range;
                    //开始搜索
                    ISearchResult _SearchResult = searchDocument.StartSearch(keyWord, sOptions, sDirection, sRange);
                    this.documentRangeCollection.Clear();
                    while (_SearchResult.FindNext()) documentRangeCollection.Add(_SearchResult.CurrentResult);
                }
                return documentRangeCollection;
            }
            catch
            {
                return documentRangeCollection;
            }
        }
        //根据关键字位置集合返回所在段落集合
        private List<Paragraph> getParagraphCollectionByDocumentRangeCollection(List<DocumentRange> documentRangeCollection, Document searchDocument)
        {
            List<Paragraph> paragraphCollection = new List<Paragraph>();
            if (documentRangeCollection.Count != 0)
            {
                Paragraph par_Cur = searchDocument.GetParagraph(documentRangeCollection[0].Start);
                for (int i = 1; i < documentRangeCollection.Count; i++)
                {
                    Paragraph par_Next = searchDocument.GetParagraph(documentRangeCollection[i].Start);
                    if (!par_Cur.Equals(par_Next))
                    {
                        paragraphCollection.Add(par_Cur);
                        par_Cur = par_Next;
                    }
                }
            }
            return paragraphCollection;
        }
        //根据段落集合生成ReadOnlyRichTextBox控件集合
        private List<RichTextBox> getReadOnlyRichTextBoxCollectionByParagrapheCollection(string keyWord, List<Paragraph> paragraphCollection, Document searchDocument)
        {
            List<RichTextBox> readOnlyRichTextBoxCollection = new List<RichTextBox>();
            if (paragraphCollection.Count != 0 && searchDocument != null)
            {
                for (int i = 0; i < paragraphCollection.Count; i++)
                {
                    RichTextBox roRTB = new RichTextBox();
                    roRTB.ReadOnly = true;
                    roRTB.MouseClick += new MouseEventHandler(this.flowLayoutPanel_MouseClick);
                    roRTB.MouseWheel += new MouseEventHandler(flowLayoutPanel1_MouseWheel);
                    roRTB.ContentsResized += roRTB_ContentsResized;
                    roRTB.Width = this.flowLayoutPanel.Width - 25;
                    //roRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    Paragraph paragraph = paragraphCollection[i];
                    roRTB.Tag = paragraph;
                    string par_Text = searchDocument.GetText(paragraph.Range);
                    int startPosition = 0;
                    roRTB.Text = par_Text;
                    while (par_Text.IndexOf(keyWord, startPosition) >= 0)
                    {
                        int curPosition = par_Text.IndexOf(keyWord, startPosition);
                        roRTB.Select(curPosition, keyWord.Length);
                        roRTB.SelectionColor = Color.Red;
                        startPosition = curPosition + keyWord.Length;
                    }
                    //this.flowLayoutPanel.Controls.Add(roRTB);
                    readOnlyRichTextBoxCollection.Add(roRTB);
                }
            }
            return readOnlyRichTextBoxCollection;
        }
        //添加ReadOnlyRichTextBox控件至flowLayoutPanel
        private void AddRichTextBoxToFlowLayoutPanal(List<RichTextBox> readOnlyRichTextBoxCollection)
        {
            foreach (RichTextBox readOnlyRichTextBox in readOnlyRichTextBoxCollection)
                this.flowLayoutPanel.Controls.Add(readOnlyRichTextBox);
            this.flowLayoutPanel.Refresh();
        }
        //根据文档搜索结果生成ReadOnlyRichTextBox控件
        private RichTextBox getReadOnlyRichTextBoxOfMultiDocumentSearch(string filePath, int resultCount)
        {
            RichTextBox roRTB = new RichTextBox();
            roRTB.MouseClick += new MouseEventHandler(this.flowLayoutPanel_MouseClick);
            roRTB.MouseWheel += new MouseEventHandler(flowLayoutPanel1_MouseWheel);
            roRTB.Width = this.flowLayoutPanel.Width - 25;
            roRTB.Text = Path.GetFileNameWithoutExtension(filePath) + "\n共搜索到关键字：" + resultCount.ToString() + "处";
            roRTB.Tag = filePath;
            return roRTB;
        }
        #endregion

        #region //显示相关函数
        //文档中关键字高亮显示
        private void DocumentKeyWordHighlightSet()
        {
            Document searchDocument = this.getSearchDocument();
            foreach (DocumentRange documentRange in this.documentRangeCollection)
            {
                CharacterProperties cp = searchDocument.BeginUpdateCharacters(documentRange);
                cp.ForeColor = Color.Red;          //字体颜色
                cp.BackColor = Color.Yellow;       //背景色
                searchDocument.EndUpdateCharacters(cp);
            }
        }
        //文档颜色恢复
        private void DocumentCharacterPropertiesReset()
        {
            try
            {
                Document searchDocument = this.getSearchDocument();
                if (searchDocument != null)
                {
                    CharacterProperties cp = searchDocument.BeginUpdateCharacters(searchDocument.Range);
                    cp.ForeColor = Color.Black;  //字体颜色
                    cp.BackColor = Color.White;  //背景色
                    searchDocument.EndUpdateCharacters(cp);
                }
            }
            catch { }
        }
        //文档显示位置滚动至指定段落
        private void MoveToParagraph(Paragraph paragraph)
        {
            Document searchDocument = this.getSearchDocument();
            if (searchDocument != null)
            {
                searchDocument.Selection = searchDocument.CreateRange(paragraph.Range.Start, 0);
                this.rec_DocumentDisplay.ScrollToCaret();
                searchDocument.Selection = searchDocument.CreateRange(paragraph.Range.End, 0);
                this.rec_DocumentDisplay.ScrollToCaret();
                searchDocument.Selection = paragraph.Range;
            }
        }
        //搜索结果提示信息变更
        private void SearchResultInfoChange()
        {
            this.lblSearchResultInfo.Text = "搜索结果：" + this.documentRangeCollection.Count + "个";
        }
        //搜索结果文本框大小随内容变化而变化
        void roRTB_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            rtb.Height = e.NewRectangle.Height + 10;
        }
        #endregion

        #region //辅助函数
        //获取当前搜索文档
        private Document getSearchDocument()
        {
            try
            {
                if (this.rec_DocumentDisplay.Document == null) return null;
                Document searchDocument = this.rec_DocumentDisplay.Document;
                return searchDocument;
            }
            catch
            {
                return null;
            }
        }
        //根据文件后缀按相应方式打开文件
        private bool OpenDocumentFile(string documentPath)
        {
            if (!File.Exists(documentPath)) return false;
            string extName = Path.GetExtension(documentPath); //记录文件扩展名
            DocumentFormat documentFormat;  //打开方式

            switch (extName)
            {
                case ".doc":
                    documentFormat = DocumentFormat.Doc;
                    break;
                case ".docx":
                    documentFormat = DocumentFormat.OpenXml;
                    break;
                case ".epub":
                    documentFormat = DocumentFormat.ePub;
                    break;
                case ".html":
                    documentFormat = DocumentFormat.Html;
                    break;
                case ".mht":
                    documentFormat = DocumentFormat.Mht;
                    break;
                case ".odt":
                    documentFormat = DocumentFormat.OpenDocument;
                    break;
                case ".txt":
                    documentFormat = DocumentFormat.PlainText;
                    break;
                case ".rtf":
                    documentFormat = DocumentFormat.Rtf;
                    break;
                case ".xml":
                    documentFormat = DocumentFormat.WordML;
                    break;
                default:
                    documentFormat = DocumentFormat.Undefined;
                    break;
            }
            try
            {
                this.rec_DocumentDisplay.LoadDocument(documentPath, documentFormat);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //初始化搜索结果变量
        public void setInitializationSearchResult()
        {
            this.documentRangeCollection = new List<DocumentRange>();
            this.paragraphCollection = new List<Paragraph>();
            this.flowLayoutPanel.Controls.Clear();
            this.SearchResultInfoChange();
            DocumentCharacterPropertiesReset();
        }
        //查找界面初始化
        public void ResetSearchPanel()
        {
            this.flowLayoutPanel.Controls.Clear();
            //this.cbe_SearchRange.SelectedIndex = -1;
            this.lblSearchResultInfo.Text = "搜索结果：";
            this.te_KeyWord.Text = "";
        }
        #endregion

        #region //公共函数，外部调用
        //根据关键字及文档路径搜索，外部调用方法
        public bool SearchFromDocument(string keyWord, string documentPath)
        {
            try
            {
                if (!OpenDocumentFile(documentPath) || keyWord == "") return false;
                this.te_KeyWord.Text = keyWord;
                this.Refresh();
                this.setInitializationSearchResult();
                if (this.KeyWordSearch())
                {
                    this.SearchResultInfoChange();
                    this.rec_DocumentDisplay.Refresh();
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
