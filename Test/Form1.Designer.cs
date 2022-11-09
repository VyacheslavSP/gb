namespace Test;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Calck";
        Label LabelName = new Label()
        {
          Text = "&Введите сумму и валюту, которую хотите перевести и валюту, в которую переводите",
          Location = new Point(10, 10),
          TabIndex = 10
        };
        Label LabelRes = new Label()
        {
          Text = "&Результат операции",
          Location = new Point(10, 60),
          TabIndex = 10
        };
        Label Point = new Label()
        {
          Text = "&,",
          Location = new Point(55, 45),
          TabIndex = 0
        };

        TextBox UnitMoneyFrom = new TextBox()
        {
          Location = new Point(LabelName.Location.X, LabelName.Bounds.Bottom + Padding.Top),
          TabIndex = 10
        };
        TextBox FractionalMoneyFrom = new TextBox()
        {
          Location = new Point(Point.Location.X+10, LabelName.Bounds.Bottom + Padding.Top),
          TabIndex = 10
        };
        ComboBox  MoneyFromList = new ComboBox ()
        {
          Location = new Point(FractionalMoneyFrom.Location.X+25, LabelName.Bounds.Bottom + Padding.Top),
          TabIndex = 10
        };
        ComboBox  MoneyToList = new ComboBox ()
        {
          Location = new Point(FractionalMoneyFrom.Location.X+25, LabelName.Bounds.Bottom + Padding.Top+50),
          TabIndex = 10
        };
        TextBox Results = new TextBox()
        {
          Location = new Point(LabelName.Location.X, LabelName.Bounds.Bottom + Padding.Top+50),
          TabIndex = 10
        };
        Button ButtonStart = new Button()
        {
          Location = new Point(FractionalMoneyFrom.Location.X+75, LabelName.Bounds.Bottom + Padding.Top),
          TabIndex = 10
        };

        Controls.Add(LabelName);
        Controls.Add(ButtonStart);
        Controls.Add(LabelRes);
        Controls.Add(Results);
        Results.Size= new Size(70,10);
        ButtonStart.Size= new Size(100,70);
        ButtonStart.Text = "Перевести";
        LabelName.Size= new Size(1000,15);
        LabelRes.Size= new Size(1000,15);
        Controls.Add(UnitMoneyFrom);
        UnitMoneyFrom.Size= new Size(45,10);
        Controls.Add(Point);
        Controls.Add(FractionalMoneyFrom);
        FractionalMoneyFrom.Size= new Size(20,10);
        Controls.Add(MoneyFromList);
        MoneyFromList.Items.AddRange(new string[] { "USD", "RUB" , "EUR" });
        MoneyFromList.Size= new Size(50,10);
        FractionalMoneyFrom.BringToFront();
        MoneyFromList.BringToFront();
        UnitMoneyFrom.BringToFront();
        Controls.Add(MoneyToList);
        MoneyToList.Items.AddRange(new string[] { "USD", "RUB" , "EUR" });
        MoneyToList.Size= new Size(50,10);
        MoneyToList.SelectedItem = "USD";
        MoneyFromList.SelectedItem = "USD";
    }

    #endregion
}
