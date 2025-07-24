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
        List<string> pablicUrl;
        
        WebDriverAction driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGoogleCredential();
            /*driver = new WebDriverAction();
            driver.Initialize();
            pablicUrl = new List<string>();
            pablicUrl.Add("https://vk.com/club230995386");
            driver.OpenUrl(testUrl);
            driver.ClickButton_ByClass("vkuiButton__in");*/
        }

        private void test_setup_Click(object sender, EventArgs e)
        {
                try
                {
                    driver.OpenUrl(pablicUrl[0]);
                    driver.Wait(5000);
                    driver.ClickButton_ByCssSelector("[data-testid=\"posting_create_post_button\"]");
                    driver.Wait(500);
                    driver.WriteText("[data-testid=\"posting_base_screen_input_message\"]", "#фэндом (Мультифэндом. Ограничений по фэндомам нет. Разрешены хуманизации, АУ и ОС/ФС)#ориджинал (Сам Эден и выдуманные админами и игроками миры)#игровая_конференция (Полуролевая. РП и оффтоп в одной беседе)#полуролевое // #литературный_стиль (По желанию)#R#ролевая_группа (Для анкет, правил и т.п)#актуально_всегда#нелайкооткликаемо #реал (Фото с вашими лицами запрещены)Конкретного жанра нет. Всё зависит от актуального мира.Доброго времени суток всем!Спешу вас познакомить с нашим прекрасным курортом \"Эден\" - особенное место, в котором абсолютно все могут хорошо отдохнуть, - НО, если кому-то интересно поработать на компанию, то это тоже не под запретом.На курорте есть все необходимые условия для комфорта - начиная от уютного главного зала и тёплого чая и заканчивая баней, горами, а самое главное - путешествиями по новым мирам!Природа Эдена позволяет путешествовать по различным мирам, в которых абсолютно разные законы мироздания и не только! Вот, на прошлой неделе вы были в мире с летающими островами и явно необычными законами физики, а уже сегодня вы в измерении, где текут реки из лавы и крови, а по земле ходят клишированные демоны.Никогда невозможно узнать то, что будет далее, и как раз эта особенность Эдена и добавляет еще одну - невероятное разнообразие постояльцев. Боги, рыцари, киборги и многое другое вас могут здесь ждать!Помимо прочего, компания, управляющая курортом, всегда отстроит всё заново дабы все отдыхали и оставались довольными, ведь для нас это главное!Совсем краткая сводка правил Эдена:> Все правила и более детальные описания находятся в группе. Здесь самые основные.> Вы имеете полное право отыгрывать чисто повседневку.> Процента канона нет, хэдканоны разрешены. Однако, персонаж должен быть узнаваем.> Те, кто русский язык в глаза не видели — мимо. Ваш текст должен быть хотя бы немного понятен.> У постов нет ограничений по объему.> Актив — 10 постов в неделю. Также вы можете взять дополнительную роль при хорошем активе (подробнее в правилах)> При желании вы можете взять на себя роль работника на Эдене, отдыхающего или же аномалии, неожиданно попавшей на курорт.Если после прочтения вам по-прежнему хочется на наш курорт, то милости просим: https://vk.com/world_eden");
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
            string range = $"{sheet}!A2:D2";
            var request = services.Spreadsheets.Values.Get(SpreadSheetId,range);

            var response = request.Execute();
            var values = response.Values;
            List<string> data = new List<string>();
            if(values != null && values.Count > 0)
            {
                foreach(var row in values )
                {
                    data.Clear();
                    foreach (var item in row )
                    {
                        data.Add(item.ToString());
                    }

                    groupLines1.Initialize(data.ToArray());
                }
            }
        }
    }
}
