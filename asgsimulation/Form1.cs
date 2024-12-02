using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace asgsimulations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox energyTB = this.Controls.Find("energy", true)[0] as TextBox;
            TextBox massTB = this.Controls.Find("mass", true)[0] as TextBox;
            TextBox diameterTB = this.Controls.Find("diameter", true)[0] as TextBox;
            TextBox gravityTB = this.Controls.Find("gravity", true)[0] as TextBox;
            TextBox densityTB = this.Controls.Find("density", true)[0] as TextBox;
            TextBox hopTB = this.Controls.Find("hop", true)[0] as TextBox;
            TextBox angleTB = this.Controls.Find("angle", true)[0] as TextBox;
            TextBox heightTB = this.Controls.Find("height", true)[0] as TextBox;
            TextBox nameTB = this.Controls.Find("name", true)[0] as TextBox;
            TextBox indexTB = this.Controls.Find("index", true)[0] as TextBox;
            TextBox rotateDeacyTB = this.Controls.Find("rotatedeacy", true)[0] as TextBox;
            TextBox autohuTB = this.Controls.Find("autohu", true)[0] as TextBox;
            Chart chart = this.Controls.Find("chart", true)[0] as Chart;
            Button plotButton = this.Controls.Find("plot", true)[0] as Button;
            Button seriesButton = this.Controls.Find("newseries", true)[0] as Button;
            Button deleteButton = this.Controls.Find("delete", true)[0] as Button;
            Button saveButton = this.Controls.Find("save", true)[0] as Button;
            Button setNameButton = this.Controls.Find("setname", true)[0] as Button;
            Button setautohu = this.Controls.Find("setautohu", true)[0] as Button;
            Button buttonwatchvideo = this.Controls.Find("watch", true)[0] as Button;
            ComboBox xAxis = this.Controls.Find("xaxis", true)[0] as ComboBox;
            ComboBox yAxis = this.Controls.Find("yaxis", true)[0] as ComboBox;
            plotButton.Click += new EventHandler(Plot);
            seriesButton.Click += new EventHandler(NewSeries);
            deleteButton.Click += new EventHandler(Delete);
            saveButton.Click += new EventHandler(Save);
            setNameButton.Click += new EventHandler(SetName);
            setautohu.Click += new EventHandler(Sethu);
            buttonwatchvideo.Click += new EventHandler(Watch);

            void Plot(object sender, EventArgs e) // rysuje wykres
            {
                double dt = 0.0009765625; // krok czasowy 2^-10
                // jeżeli uda się wszystkie parametry z textboxów przekonwetować na double to wszytko obliczamy
                if (int.TryParse(indexTB.Text, out int index) &&
                    index > 0 && index <= chart.Series.Count &&
                    double.TryParse(energyTB.Text, out double energy) &&
                    double.TryParse(massTB.Text, out double mass) &&
                    double.TryParse(diameterTB.Text, out double diameter) &&
                    double.TryParse(gravityTB.Text, out double gravity) &&
                    double.TryParse(densityTB.Text, out double density) &&
                    double.TryParse(hopTB.Text, out double rotate) &&
                    double.TryParse(angleTB.Text, out double angle) &&
                    double.TryParse(heightTB.Text, out double height) &&
                    double.TryParse(rotateDeacyTB.Text, out double rotateDeacy))
                {
                    // zresetowanie obecnej serii i przekonwetowanie  parametrów na jednostki SI i ustawienie początkowego stanu
                    chart.Series[index - 1].Points.Clear();
                    Vector2 position = new Vector2(0, height);
                    mass /= 1000;
                    Vector2 velocity = new Vector2(Math.Sqrt(2 * energy / mass), 0);
                    velocity = velocity.Rotate(angle);
                    Vector2 acceleration = new Vector2(0, 0);
                    diameter /= 1000;
                    double radius = diameter / 2;
                    double area = Math.PI * radius * radius;
                    rotate *= Math.PI * diameter;
                    rotateDeacy /= 10000000;

                    double x = 0;
                    double y = 0;
                    string chosex = xAxis.SelectedItem.ToString();
                    string chosey = yAxis.SelectedItem.ToString();
                    double t = 0;
                    while (position.y >= 0) // główna pętla symulacji
                    {
                        // wybranie danych jakie mają się wyświeltić na wykresie i zrobienie tego
                        switch (chosex)
                        {
                            case "position.x": x = position.x; break;
                            case "position.y": x = position.y; break;
                            case "energy": x = (velocity.x * velocity.x + velocity.y * velocity.y) * mass / 2; break;
                            case "speed": x = velocity.Magnitude(); break;
                            case "rotate speed": x = rotate; break;
                            case "time": x = t; break;
                        }
                        switch (chosey)
                        {
                            case "position.x": y = position.x; break;
                            case "position.y": y = position.y; break;
                            case "energy": y = (velocity.x * velocity.x + velocity.y * velocity.y) * mass / 2; break;
                            case "speed": y = velocity.Magnitude(); break;
                            case "rotate speed": y = rotate; break;
                            case "time": y = t; break;
                        }
                        chart.Series[index - 1].Points.AddXY(x, y);

                        // zresetowanie przyśpieszenia i dodanie grawitacji
                        acceleration.x = 0;
                        acceleration.y = -gravity;

                        // stosunek prędkości obrotowej do liniowej ważny dla działania hop-up
                        double vu = rotate / velocity.Magnitude();

                        // obliczenie i dodanie siły oporu powietrza
                        double cd0 = 0.4274795;
                        double cd = (cd0 + 2.2132291 * vu - 10.345178 * vu * vu + 16.157030 * vu * vu * vu - 5.27306480 * vu * vu * vu * vu) / (1 + 3.1077276 * vu - 13.6598678 * vu * vu + 24.00539887 * vu * vu * vu - 8.340493152 * vu * vu * vu * vu + 0.07910093 * vu * vu * vu * vu * vu);
                        double fd = 0.5 * cd * density * area * (velocity.x * velocity.x + velocity.y * velocity.y);
                        acceleration = acceleration.Add(velocity.Normalize().Times(-fd / mass));

                        // obliczenie i dodanie efektu magnusa
                        // to skomplikowane obliczanie cl uwzględnia tak zwany "reverse magnus effect" który powstaje przy niskim stosunku prędkości obrotowej do liniowej
                        double cl = (-0.0020907 - 0.208056226 * vu + 0.768791456 * vu * vu - 0.84865215 * vu * vu * vu + 0.75365982 * vu * vu * vu * vu) / (1 - 4.82629033 * vu + 9.95459464 * vu * vu - 7.85649742 * vu * vu * vu + 3.273765328 * vu * vu * vu * vu);
                        double fm = cl * density * area * (velocity.x * velocity.x + velocity.y * velocity.y);
                        Vector2 susvelocity = new Vector2(-velocity.y, velocity.x);
                        acceleration = acceleration.Add(susvelocity.Normalize().Times(fm / mass));

                        // spowolnienie rotacji
                        // nie wiem jak to poprawnie obliczyć więc na podstawie mojej wiedzy zgadłem do czego to spowolnienie powinno być proporcjonalne i pomnożyłem to przez współczynnik który gdy dowiem się ile powinien wynosić nie będzie możliwy do zmienienia w ui
                        rotate -= dt * rotateDeacy * rotate * rotate * density / mass;

                        // dodanie przyśpieszenia do prędkości i prędkości do pozycji i zwiększenie minionego czasu
                        position = position.Add(velocity.Times(dt * 0.5));
                        velocity = velocity.Add(acceleration.Times(dt));
                        position = position.Add(velocity.Times(dt * 0.5));
                        t += dt;
                    }

                    // mój chory algorytm na ustawienie interwału w osi x na jakąś z liczb 1, 2, 5 w odpowiednim rzędzie wielkości
                    // tylko dlatego że domyślna ilość interwałów była według mnie trochę za mała
                    // sprawdziłem czy ten algorytm jest w stanie zrobić chatgpt 4 w lepszy sposób ale zrobił w gorszy bo nie potrafił rozkminić że ma to się zrobić na wszystkich możliwych rzędach wielkości plus jest taki że (póki co) ai nie zapierdoli mi pracy :) (nie jestem zawodowym programistą (głównie dlatego bo nie mam 18 lat (mam nadzieje że tylko dlatego (i potem znajde pracę (żeby nie pracować w maku (jak jakiś ksawery))))))
                    // całe szczęscie że 1 wątek może zrobić w chuj operacji w ciagu sekundy bo inczej ten kod wykonywał by się wieki
                    double[] intervals = new double[3] { 1, 2, 5 };
                    double interval = 0;
                    foreach (var series in chart.Series)
                    {
                        foreach (var point in series.Points)
                        {
                            if (point.XValue > interval)
                                interval = point.XValue;
                        }
                    }
                    interval /= 5;
                    double tempinterval = -1;
                    while (true)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (intervals[i] > interval)
                                break;
                            tempinterval = intervals[i];
                        }
                        if (interval <= intervals[2])
                            break;
                        for (int i = 0; i < 3; i++)
                            intervals[i] *= 10;
                    }
                    if (tempinterval == -1)
                    {
                        while (true)
                        {
                            for (int i = 0; i < 3; i++)
                                intervals[i] /= 10;
                            for (int i = 2; i >= 0; i--)
                            {
                                if (intervals[i] < interval)
                                {
                                    tempinterval = intervals[i];
                                    break;
                                }
                            }
                            if (interval >= intervals[0])
                                break;
                        }
                    }
                    chart.ChartAreas[0].AxisX.Interval = tempinterval;
                }
            }

            void Sethu(object sender, EventArgs e) // automatycznie ustawia hopka
            {
                double dt = 0.0009765625;
                if (double.TryParse(energyTB.Text, out double energy) &&
                    double.TryParse(massTB.Text, out double mass) &&
                    double.TryParse(diameterTB.Text, out double diameter) &&
                    double.TryParse(gravityTB.Text, out double gravity) &&
                    double.TryParse(densityTB.Text, out double density) &&
                    double.TryParse(heightTB.Text, out double height) &&
                    double.TryParse(rotateDeacyTB.Text, out double rotateDeacy) &&
                    double.TryParse(autohuTB.Text, out double autohu))
                {
                    autohu /= 100;
                    double max = 0;
                    double correction = 1024;
                    int directioncorrection = 0;
                    double setrotate = 0;
                    double rotate = 0;
                    rotateDeacy /= 10000000;

                    mass /= 1000;
                    diameter /= 1000;

                    int i = 100; // żeby w razie problemu funkcja kiedyś zakończyła swoję działanie
                    while (i > 0)
                    {
                        // prawie to samo co w funkcji plot tylko bez rysowania wykresu ale za to z sprawdzaniem najwyższego punktu w trajektori
                        i--;
                        Vector2 position = new Vector2(0, height);
                        Vector2 velocity = new Vector2(Math.Sqrt(2 * energy / mass), 0);
                        Vector2 acceleration = new Vector2(0, 0);
                        double radius = diameter / 2;
                        double area = Math.PI * radius * radius;
                        rotate = setrotate * Math.PI * diameter;

                        max = height;
                        while (position.y >= 0)
                        {
                            acceleration.x = 0;
                            acceleration.y = -gravity;

                            double vu = rotate / velocity.Magnitude();

                            double cd0 = 0.4274795;
                            double cd = (cd0 + 2.2132291 * vu - 10.345178 * vu * vu + 16.157030 * vu * vu * vu - 5.27306480 * vu * vu * vu * vu) / (1 + 3.1077276 * vu - 13.6598678 * vu * vu + 24.00539887 * vu * vu * vu - 8.340493152 * vu * vu * vu * vu + 0.07910093 * vu * vu * vu * vu * vu);
                            double fd = 0.5 * cd * density * area * (velocity.x * velocity.x + velocity.y * velocity.y);
                            acceleration = acceleration.Add(velocity.Normalize().Times(-fd / mass));

                            double cl = (-0.0020907 - 0.208056226 * vu + 0.768791456 * vu * vu - 0.84865215 * vu * vu * vu + 0.75365982 * vu * vu * vu * vu) / (1 - 4.82629033 * vu + 9.95459464 * vu * vu - 7.85649742 * vu * vu * vu + 3.273765328 * vu * vu * vu * vu);
                            double fm = cl * density * area * (velocity.x * velocity.x + velocity.y * velocity.y);
                            acceleration = acceleration.Add(velocity.Normalize().Rotate(90).Times(fm / mass));

                            rotate -= dt * rotateDeacy * rotate * rotate * density / mass;

                            velocity = velocity.Add(acceleration.Times(dt));
                            position = position.Add(velocity.Times(dt));
                            if (position.y > max)
                                max = position.y;
                        }

                        // logika jest taka że chcemy skorygować hopka w odpowiednim kierunku
                        // jeżeli poprzednio kierunek zmian był przeciwny do obecnego to wartość o jaką korygujemy zmniejszamy 2 razy a zaczynamy od 1024 (żeby się dobrze przez 2 dzieliło)
                        // pętle przerywamy gdy uzyskamy podniesienie kulki przez hopka z dokładnością +-0,5cm od tego co podał użytkownik lub po 100 iteracjach jak napisałem wyżej
                        if (max - height + 0.005 < autohu)
                        {
                            if (directioncorrection == -1)
                                correction /= 2;
                            directioncorrection = 1;
                            setrotate += correction;
                        }
                        else if (max - height - 0.005 > autohu)
                        {
                            if (directioncorrection == 1)
                                correction /= 2;
                            directioncorrection = -1;
                            setrotate -= correction;
                        }
                        else
                            break;
                    }
                    hopTB.Text = setrotate.ToString();
                }
            }

            void NewSeries(object sender, EventArgs e) // tworzy nowy zbiór punktów (serie) na wykresie
            {
                // tworzy nazwę nowej seri jako series [ilość seri razem z tą nową]
                string name = "series " + (chart.Series.ToList().Count + 1).ToString();

                // dopóki nazwa się powtarza dodajemy do niej gwiazdki (muszę tak zrobić bo gdy się powtarza to crashuje program)
                while (true)
                {
                    if (chart.Series.IndexOf(name) != -1)
                        name += "*";
                    else break;
                }

                Series series = new Series(name);
                series.ChartType = SeriesChartType.FastLine;
                series.ChartArea = "ChartArea1";
                series.BorderWidth = 3;
                chart.Series.Add(series);
                indexTB.Text = chart.Series.ToList().Count.ToString();
            }

            void Delete(object sender, EventArgs e) // usuwa wszystkie serię poza pierwszą
            {
                if (int.TryParse(indexTB.Text, out int index) &&
                    index > 0 && index <= chart.Series.Count &&
                    chart.Series.ToList().Count > 1)
                {
                    chart.Series.RemoveAt(index - 1);
                    indexTB.Text = chart.Series.ToList().Count.ToString();
                }
            }

            void Save(object sender, EventArgs e) // zapisuje wykres jako .png
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save as png";
                saveFileDialog.FileName = "chart.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    chart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
            }

            void SetName(object sender, EventArgs e) // zmienia nazwę serii
            {
                if (chart.Series.IndexOf(nameTB.Text) == -1 &&
                    int.TryParse(indexTB.Text, out int index) &&
                    index > 0 && index <= chart.Series.Count)
                    chart.Series[index - 1].Name = nameTB.Text;
            }

            void Watch(object sender, EventArgs e) // otwiera potężny filmik
            {
                System.Diagnostics.Process.Start("https://youtu.be/_HH48TscK0o");
            }
        }

        private void Form1_Load(object sender, EventArgs e) { } // nie wiem kurwa czemu to się dodaje jak usuwam to jest error
    }

    class Vector2 // klasa do wektorów 2 wymiarowych (działa)
    {
        // zadeklarowanie zmiennych x i y oraz ustawienie ich w konstruktorze
        public double x;
        public double y;
        public Vector2(double sx, double sy)
        {
            x = sx;
            y = sy;
        }

        public Vector2 Add(Vector2 vector22) // dodanie wektorów
        {
            Vector2 vector = new Vector2(x, y);
            vector.x += vector22.x;
            vector.y += vector22.y;
            return vector;
        }

        public Vector2 Times(double a) // mnożenie wekotra przez liczbe
        {
            Vector2 vector = new Vector2(x, y);
            vector.x *= a;
            vector.y *= a;
            return vector;
        }

        public Vector2 Normalize() // oblicza wektor o tym samym kierunku ale długości 1
        {
            Vector2 vector = new Vector2(x, y);
            double magnitude = vector.Magnitude();
            vector.x /= magnitude;
            vector.y /= magnitude;
            return vector;
        }

        public double Magnitude() // oblicza długość wektora
        {
            return Math.Sqrt(x * x + y * y);
        }

        public Vector2 Rotate(double angle) // obraca wektor o kąt w stopniach
        {
            Vector2 vector = new Vector2(x, y);
            double radian = Math.PI * angle / 180.0;
            double cosTheta = Math.Cos(radian);
            double sinTheta = Math.Sin(radian);
            vector.x = x * cosTheta - y * sinTheta;
            vector.y = x * sinTheta + y * cosTheta;
            return vector;
        }
    }
}