using System.Diagnostics;
using System.ComponentModel;
namespace SaviorIA.Views.Menu.Tests;


	 public partial class SadPerson : ContentPage, INotifyPropertyChanged
    {
        private List<bool> checkboxStates = Enumerable.Repeat(false, 11).ToList();
        private int checkboxCounter = 0;

        public new event PropertyChangedEventHandler PropertyChanged;

        private Dictionary<int, string> imageIndexToName = new Dictionary<int, string>
            {
                { 1, "gender" },
                { 2, "age" },
                { 3, "depression" },
                { 4, "suicideAttempts" },
                { 5, "alcoholAbuse" },
                { 6, "cognitiveDisorders" },
                { 7, "lowSocialSupport" },
                { 8, "organizedSuicidePlan" },
                { 9, "withoutAStablePartner" },
                { 10, "somaticIllness" }
            };

        public int CheckboxCounter
        {
            get { return checkboxCounter; }
            set
            {
                if (checkboxCounter != value)
                {
                    checkboxCounter = value;
                    OnPropertyChanged(nameof(CheckboxCounter));
                    UpdateResultFrame();
                }
            }
        }

        private Color resultFrameBackgroundColor;

        public Color ResultFrameBackgroundColor
        {
            get { return resultFrameBackgroundColor; }
            set
            {
                if (resultFrameBackgroundColor != value)
                {
                    resultFrameBackgroundColor = value;
                    OnPropertyChanged(nameof(ResultFrameBackgroundColor)); // Notifica a la interfaz de usuario que la propiedad ha cambiado
                }
            }
        }

        private string resultLabelText;

        public string ResultLabelText
        {
            get { return resultLabelText; }
            set
            {
                if (resultLabelText != value)
                {
                    resultLabelText = value;
                    OnPropertyChanged(nameof(ResultLabelText));
                }
            }
        }

        public SadPerson()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Choose_Tapped(object sender, TappedEventArgs e)
        {
            Image tappedImage = (Image)sender;
            string classId = tappedImage.ClassId;

            if (!int.TryParse(classId, out int index))
            {
                return;
            }

            checkboxStates[index] = !checkboxStates[index];
            tappedImage.Source = checkboxStates[index] ? "icon_checkbox_checked.png" : "icon_checkbox.png";
            CheckboxCounter += checkboxStates[index] ? 1 : -1;

            string labelName = GetLabelNameByIndex(index);
            Label label = this.FindByName<Label>(labelName);
            label.Text = checkboxStates[index] ? "1" : "0";
            Debug.WriteLine($"Se hizo clic en la fila con índice {index}. Checkbox Counter: {CheckboxCounter}");
        }


        private void ResetCheckboxes(object sender, EventArgs e)
        {
            checkboxStates = Enumerable.Repeat(false, 11).ToList();
            CheckboxCounter = 0;

            foreach (var indexToName in imageIndexToName)
            {
                string imageName = indexToName.Value;

                Image checkboxImage = this.FindByName<Image>(imageName);
                checkboxImage.Source = "icon_checkbox.png";

                string labelName = "label" + imageName.First().ToString().ToUpper() + imageName.Substring(1);
                Label label = this.FindByName<Label>(labelName);
                label.Text = "0";
            }

            UpdateResultFrame();
        }


        private string GetLabelNameByIndex(int index)
        {
            switch (index)
            {
                case 1:
                    return "labelGender";
                case 2:
                    return "labelAge";
                case 3:
                    return "labelDepression";
                case 4:
                    return "labelSuicideAttempts";
                case 5:
                    return "labelAlcoholAbuse";
                case 6:
                    return "labelCognitiveDisorders";
                case 7:
                    return "labelLowSocialSupport";
                case 8:
                    return "labelOrganizedSuicidePlan";
                case 9:
                    return "labelWithoutAStablePartner";
                case 10:
                    return "labelSomaticIllness";
                default:
                    return string.Empty;
            }
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateResultFrame()
        {
            if (CheckboxCounter >= 1 && CheckboxCounter <= 2)
            {
                ResultFrameBackgroundColor = Color.FromArgb("#D4EFDF");
                ResultLabelText = "Sin riesgo";
            }
            else if (CheckboxCounter >= 3 && CheckboxCounter <= 4)
            {
                ResultFrameBackgroundColor = Color.FromArgb("#FCF3CF");
                ResultLabelText = "Riesgo bajo";
            }
            else if (CheckboxCounter >= 5 && CheckboxCounter <= 6)
            {
                ResultFrameBackgroundColor = Color.FromArgb("#EDBB99");
                ResultLabelText = "Riesgo medio";
            }
            else if (CheckboxCounter >= 7 && CheckboxCounter <= 10)
            {
                ResultFrameBackgroundColor = Color.FromArgb("#EC7063");
                ResultLabelText = "Riesgo Alto";
            }
            else
            {
                ResultFrameBackgroundColor = Colors.Transparent;
                ResultLabelText = "";
            }
        }
    }
