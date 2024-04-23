namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
    int valor = 0;
    public DiceView()
	{
		InitializeComponent();
        SidesPicker.SelectedIndex = 0;
    }

    private void RollBtn_Clicked(object sender, EventArgs e)
    {
        valor = Convert.ToInt32(SidesPicker.SelectedItem);
        var umvalor = 0;
        umvalor = new Random().Next(1, valor + 1);
        ResultLabel.Text = umvalor.ToString();
    }

}