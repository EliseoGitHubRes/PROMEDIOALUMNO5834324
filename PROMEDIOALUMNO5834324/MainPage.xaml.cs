namespace PROMEDIOALUMNO5834324;

public partial class MainPage : ContentPage
{
    /// <summary>
    /// <Createddate>22/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>22/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL LA IMAGEN
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>

    public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    ///EVENTO QUE SE EJECUTA AL PRESIONAR EL BOTON 
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
		double Cali1 = Convert.ToDouble(c1.Text);
        double Cali2 = Convert.ToDouble(c2.Text);
        double Cali3 = Convert.ToDouble(c3.Text);
        double Cali4 = Convert.ToDouble(c4.Text);
        double Cali5 = Convert.ToDouble(c5.Text);

        double resultado = (Cali1 + Cali2 + Cali3 + Cali4 + Cali5) / 5;

        prom.Text = "El promedio del alumno es: " + resultado;
    }
}

