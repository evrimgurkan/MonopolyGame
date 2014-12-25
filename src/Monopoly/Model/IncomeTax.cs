using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class IncomeTax : Tax
    {

        private TaxType _type;
        private string _label;
        private int taxAmount;
        public IncomeTax(string label, int _taxAmount)
        {
            _type = TaxType.TYPE_INCOME;
            _label = label;
            taxAmount = _taxAmount;
        }

        public override TaxType getTaxType()
        {
            return _type;
        }

        public override int getTaxPrice()
        {
            return taxAmount;
        }

        public void setPaymentType(PaymentType _paymentType)
        {
            if (_paymentType == PaymentType.TYPE_TEN_PERCENT_AMOUNT)
            {
                taxAmount = Convert.ToInt32(GameController.GameControllerInstance.getCurrentPlayer().GetTotalAssetsAmount() * 0.1);
            }
        }

        public override string getLabel()
        {
            return _label;
        }

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;
            // TODO: Popup a window and select Payment type (%10 or 200$)
            // TODO: Should be checked player cash in bank
            controller.getBank().takeMoneyFromPlayer(getTaxPrice(), controller.getCurrentPlayer());

            controller.AddLog("Player " + controller.getCurrentPlayer().name +
                                " paid $" + getTaxPrice());

            controller.updateBankInfo(controller.getBank().cash, "", false);
        }
    }
}
