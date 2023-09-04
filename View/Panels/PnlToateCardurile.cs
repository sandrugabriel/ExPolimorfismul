using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;
using View.Models;

namespace View.Panels
{
    internal class PnlToateCardurile : Panel
    {

        Form1 form;
        ControllerClient controllerClient;
        ControllerDetalii controllerDetalii;
        ControllerFigura controllerFigura;
        List<DetaliDesen> toate;
        Client client;

        public PnlToateCardurile(Form1 form1,List<DetaliDesen> toate1, Client client1)
        {

            this.form = form1;
            controllerFigura = new ControllerFigura();
            controllerClient = new ControllerClient();
            controllerDetalii = new ControllerDetalii();
            toate = toate1;
            client = client1;

            //PnlCards
            this.Size = new System.Drawing.Size(1209, 605);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PnlCards";


            createCard(3);
        }

        public void createCard(int nrCollums)
        {

            this.Controls.Clear();

            int x = 61, y = 28, ct = 0;

            foreach (DetaliDesen detaliDesen  in toate)
            {

                ct++;
                PnlCard pnlCard = new PnlCard(form, detaliDesen, client);
                this.Controls.Add(pnlCard);
                pnlCard.Location = new System.Drawing.Point(x, y);
                x += 350;

                if(ct%nrCollums == 0)
                {
                    x = 61;
                    y += 280;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }

            }

        }



    }
}
