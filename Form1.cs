using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_autoposter
{
    public partial class Form1 : Form
    {
        string testUrl = "https://vk.com/groups";
        List<string> pablicUrl;
        
        WebDriverAction driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            driver = new WebDriverAction();
            driver.Initialize();
            pablicUrl = new List<string>();
            pablicUrl.Add("https://vk.com/club230995386");
            driver.OpenUrl(testUrl);
            driver.ClickButton_ByClass("vkuiButton__in");
        }

        private void test_setup_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    driver.OpenUrl(pablicUrl[0]);
                    driver.Wait(5000);
                    driver.ClickButton_ByCssSelector("[data-testid=\"posting_create_post_button\"]");
                    driver.Wait(500);
                    driver.WriteText("[data-testid=\"posting_base_screen_input_message\"]", "Hello comrads. It's me  Ryan Gosling. I'm not died in drive. I'm alive, and i'm going to Chernobyl");
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
    }
}
