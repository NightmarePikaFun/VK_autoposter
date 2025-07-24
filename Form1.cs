using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_autoposter
{
    public partial class Form1 : Form
    {
        private static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        private static readonly string AppName = "VK_Sender";
        private string SpreadSheetId = "1Fiq6OropoYnsC6a9fMN1NSreXwo713wLtEh3-4SuhQ8";
        private static readonly string sheet = "data_list";

        static SheetsService services;

        string testUrl = "https://vk.com/groups";
        
        List<GroupLines> groupLines = new List<GroupLines>();

        WebDriverAction driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGoogleCredential();
            driver = new WebDriverAction();
            driver.Initialize();
            driver.OpenUrl(testUrl);
            driver.ClickButton_ByClass("vkuiButton__in");
        }

        private void test_setup_Click(object sender, EventArgs e)
        {
            foreach (var item in groupLines)
            {
                try
                {
                    driver.OpenUrl(item.GroupLink);
                    driver.Wait(5000);
                    driver.ClickButton_ByCssSelector("[data-testid=\"posting_create_post_button\"]");
                    driver.Wait(500);
                    driver.WriteText("[data-testid=\"posting_base_screen_input_message\"]", item.GroupText);
                    //Upload image
                    Test_uploadImage();
                    driver.ClickButton_ByCssSelector("[data-testid=\"posting_base_screen_next\"]");
                    driver.Wait(500);
                    driver.ClickButton_ByCssSelector("[data-testid=\"posting_suggest_button\"]");
                    TestText.Text = "Succes";
                }
                catch (Exception ex)
                {
                    TestText.Text = ex.Message;
                }
                driver.Wait(20 * 1000);
            }
        }

        private void Test_uploadImage()
        {
            driver.ClickButton_ByCssSelector("[data-testid=\"posting_base_screen_select_from_vk\"]");
            driver.Wait(500);
            driver.ClickButton_ByCssSelector("[data-testid=\"posting_base_screen_select_photo_vk\"]");
            driver.Wait(1000);
            //Is tmp, select first album
            driver.ClickButton_ByCssSelector("[data-testid=\"posting_photo_picker_top_albums_item\"]");
            driver.Wait(1000);
            //Is tmp, select first picuter
            driver.ClickButton_ByCssSelector("[data-testid=\"posting_photo_picker_photos_item\"]");
            driver.Wait(2000);
            driver.ClickButton_ByCssSelector("[data-testid=\"posting_photo_picker_footer_submit_button\"]");

            
        }

        private void loadSheetDataButton_Click(object sender, EventArgs e)
        {
            ReadEntries();
        }

        private void LoadGoogleCredential()
        {
            GoogleCredential credential;
            using(var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            services = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = AppName,
            });
        }

        private void ReadEntries()
        {
            string range = $"{sheet}!A2:D60";
            var request = services.Spreadsheets.Values.Get(SpreadSheetId,range);

            var response = request.Execute();
            var values = response.Values;
            List<string> data = new List<string>();
            foreach(var item in groupLines)
            {
                item.Dispose();
                groupLinesPanel.Controls.Remove(item);
            }
            groupLines.Clear();
            if (values != null && values.Count > 0)
            {
                foreach(var row in values )
                {
                    data.Clear();
                    foreach (var item in row )
                    {
                        data.Add(item.ToString());
                    }
                    GroupLines newLine = new GroupLines();
                    groupLines.Add(newLine);
                    groupLinesPanel.Controls.Add(newLine);
                    newLine.Initialize(data.ToArray());
                    newLine.Dock = DockStyle.Top;
                }
            }
        }
    }
}
