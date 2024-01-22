using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB04.HandtaschenBeispiel
{
    public class HandTaschenListe
    {
        private List<Handtasche> _handTaschen = new List<Handtasche>();

        public List<Handtasche> HandTaschen
        {
            get { return _handTaschen; }
            set { _handTaschen = value; }
        }
        public HandTaschenListe AddHandtasche (HandTaschenListe handtaschenList, Handtasche newHandtasche)
        {
            if (handtaschenList.HandTaschen.Any())
            {
                foreach (Handtasche existingHandtasche in handtaschenList.HandTaschen)
                {
                    if(CompareHandtaschen(existingHandtasche, newHandtasche))
                    {
                        return this;
                    }
                }
            }
            handtaschenList.HandTaschen.Add(newHandtasche);
            return this;
        }

        private bool CompareHandtaschen(Handtasche handtasche1, Handtasche handtasche2)
        {
            if (handtasche1.Name == handtasche2.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public override string ToString()
        //{
        //    return string.Join(Environment.NewLine, this.HandTaschen);
        //}
    }
}
