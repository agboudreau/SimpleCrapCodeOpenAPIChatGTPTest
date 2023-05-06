using System;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using OpenAI.GPT3.ObjectModels.RequestModels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace OpenAPIChatGTPTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
           _= this.TestCall();

        }

        private async Task TestCall()
        {
            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = " Example : 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"  // your key here
            });

            var completionResult = await openAiService.Completions.CreateCompletion(new CompletionCreateRequest()
            {
                Prompt = Questiontxt.Text, //"write me a book report on lord of the flies.",
                Temperature = 1,
                MaxTokens = 255,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,

            }, OpenAI.GPT3.ObjectModels.Models.TextDavinciV3);

            if (completionResult.Successful)
            {
                Responsetxt.Text = completionResult.Choices[0].Text;

           
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Languages.Items.Add("English");
            Languages.Items.Add("Spanish");
            Languages.Items.Add("Mandarin Chinese");
            Languages.Items.Add("French");
            Languages.Items.Add("Arabic");
            Languages.Items.Add("Russian");
            Languages.Items.Add("German");
            Languages.Items.Add("Japanese");
            Languages.Items.Add("Portuguese");
            Languages.Items.Add("Italian");
            Languages.Items.Add("Korean");
            Languages.Items.Add("Dutch");
            Languages.Items.Add("Turkish");
            Languages.Items.Add("Swedish");
            Languages.Items.Add("Czech");
            Languages.Items.Add("Danish");
            Languages.Items.Add("Polish");
            Languages.Items.Add("Norwegian");
            Languages.Items.Add("Hungarian");
            Languages.Items.Add("Thai");

        }

        private void Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string language = (string)comboBox.SelectedItem;

            this.SubmitBtn.Text = "Ask";
            this.lblChatGPTResponse.Text = "Answer                                                                     ";
            this.lblWhatQuestion.Text = "What Question do you want to ask?";
            this.lblLanguage.Text = "Selected Language:";

            foreach (Control item in Controls)
            {
                System.String ctrlName = item.Name;
                if(item.Text.Length > 0)
                {
                    _ = SetLanguageAsync(ctrlName, language);
                }

            }
        }

 
        private async Task SetLanguageAsync(System.String ctrlName, System.String Language) {


            System.String texttoTranslate = Controls[ctrlName].Text;

            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = " Example : 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"  // your key here
            });

            var completionResult = await openAiService.Completions.CreateCompletion(new CompletionCreateRequest()
            {
                Prompt = "Translate the word '"+ texttoTranslate + "' to " + Language, //"write me a book report on lord of the flies.",
                Temperature = 1,
                MaxTokens = 255,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0,

            }, OpenAI.GPT3.ObjectModels.Models.TextDavinciV3);

            if (completionResult.Successful)
            {

                Controls[ctrlName].Text = completionResult.Choices[0].Text.Replace("\n", "").Replace("\r", "");

            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }
             
            }
        }

    }
}