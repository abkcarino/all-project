using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equation2degrepoo
{
    internal class Equation
    {
        double a;
        double b;
        double c;
      public  Equation() { }  

        public Equation(double b,double c) {
            this.b = b; this.c = c;
           

        }
        public Equation(double a,double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            

        }
        public  void  eq1d()
        {
            double x;
            x = -this.c / this.b;
            MessageBox.Show("la solution de cette equation =" + x);

        }
        public  void eq2d()
        {
            double x1;
            double x2;
            double d;
            d = this.b * this.b - 4 * this.a * this.c;
            if (d == 0)
            {
                x1 = this.b * this.b / 2 * this.a;
                MessageBox.Show("la solution de cette equation =" + x1);

            }
            else if (d > 0)
            {
                x1 = (this.b * this.b - Math.Sqrt(d)) / 2 * this.a;
                x2 = (this.b * this.b + Math.Sqrt(d)) / 2 * this.a;
                MessageBox.Show("la solution de cette equation =" + x1 + "," + x2);

            }
            else
                MessageBox.Show("error");
            
                
            

        }

    }
}
