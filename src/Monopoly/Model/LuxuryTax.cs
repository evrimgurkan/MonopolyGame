using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class LuxuryTax : Tax
    {
        private TaxType _type;
        private string _label;
        private int taxAmount;

        public LuxuryTax(string label, int _taxAmount)
        {
            _type = TaxType.TYPE_LUXURY;
            _label = label;
            taxAmount = _taxAmount;
        }

        public override TaxType getTaxType() // is really need? 
        {
            return _type;
        }

        public override int getTaxPrice()
        {
            return taxAmount;
        }

        public override string getLabel()
        {
            return _label;
        }

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;
            // TODO: Should be checked player cash in bank
            controller.getBank().takeMoneyFromPlayer(getTaxPrice(), controller.getCurrentPlayer());

            controller.AddLog("Player " + controller.getCurrentPlayer().name +
                                " paid $" + getTaxPrice());

            controller.updateBankInfo(controller.getBank().cash, "", false);
        }
    }
}
