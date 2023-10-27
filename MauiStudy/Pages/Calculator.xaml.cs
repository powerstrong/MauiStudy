namespace MauiStudy;

public partial class Calculator : ContentPage
{
	public Calculator()
	{
		InitializeComponent();
	}

    //private string _prev_value = "";
    private string _current_value = "";

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_6(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_7(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_num7(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "7" : "7";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_num8(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "8" : "8";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_num9(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "9" : "9";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_multiply(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_num4(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "4" : "4";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_num5(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "5" : "5";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_num6(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "6" : "6";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_minus(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_num1(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "1" : "1";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_num2(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "2" : "2";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_num3(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "3" : "3";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_plus(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_plusorminus(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_num0(object sender, EventArgs e)
    {
        _current_value = double.TryParse(_current_value, out _) ? _current_value + "0" : "0";
        ResultLabel.Text = _current_value;
    }

    private void Button_Clicked_dot(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_equal(object sender, EventArgs e)
    {

    }
}