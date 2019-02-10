using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOopC_
{
    public class Order
    {

      public  class Builder
        {
            private String bred;
            private String met;
            private String chees;



            public Order build()
            {
                return new Order(this);
            }

            public Builder Bread(String bread)
            {
                this.bred = bread;
                return this;
            }
            public Builder Met(String met)
            {
                this.met = met;
                return this;
            }
            public Builder Chees(String chees)
            {
                this.chees = chees;
                return this;
            }

            public String GetMet()
            {
                return this.met;
            }
            public string GetChees()
            {
                return this.chees;
            }
            public String GetBread()
            {
                return this.bred;
            }
        }

        private Order(Builder builder)
        {
            this.bred = builder.GetBread();
            this.chees = builder.GetChees();
            this.met = builder.GetMet();
        }

        public String met { get; }
        public String bred { get; }
        public String chees { get; }


    }
    //------experiment--------------------------------------------------------------------------------------------------------------

    class MyClass
    {
        private string aa;
        private string bb;
        private string cc;

        public MyClass SetA(string a)
        {
            this.aa = a;
            return this;
        }
        public MyClass SetB(string b)
        {
            this.bb = b;
            return this;

        }
        public MyClass SetC(string c)
        {
            this.cc = c;
            return this;

        }

        public string GetAll()
        {
            return $"{aa} {bb} {cc}";
        }


    }

}
