namespace lig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gsgol = 0, tsgol = 0, fbgol = 0, bjkgol = 0;
        int gspuan = 0, tspuan = 0, fbpuan = 0, bjkpuan = 0;
        int gsaveraj = 0, tsaveraj = 0, fbaveraj = 0, bjkaveraj = 0;
        int gsagol = 0 , gsygol = 0 ;
        Random Rastgele = new Random();




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            label23.Text = fbpuan.ToString();
            label22.Text = gspuan.ToString();
            label24.Text = tspuan.ToString();
            label25.Text = bjkpuan.ToString();
            gsgol = Rastgele.Next(0, 10);
            fbgol = Rastgele.Next(0, 8);
            tsgol = Rastgele.Next(0, 8);
            bjkgol = Rastgele.Next(0, 8);
            label2.Text = gsgol.ToString();
            label4.Text = fbgol.ToString();
            label6.Text = tsgol.ToString();
            label8.Text = bjkgol.ToString();
            if (gsgol == gsaveraj)
            {
                label27.Text = gsaveraj.ToString();
            }
           
            if (gsgol > fbgol) 
            {
                
                gspuan = gspuan + 3;
                
                
                
                
            }
            
            if (fbgol > gsgol)
            {
                fbpuan = fbpuan + 3;
                
            }
            else if (gsgol == fbgol)
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
              

            }
            if (tsgol > bjkgol)
            {
                tspuan = tspuan + 3;
               
            }
            if (bjkgol > tsgol)
            {
                bjkpuan = bjkpuan + 3;
                
            }
            else if (tsgol == bjkgol)
            {
                tspuan = tspuan +1;
                bjkpuan = bjkpuan + 1;
               
                
            }
           

        }
    }
}
