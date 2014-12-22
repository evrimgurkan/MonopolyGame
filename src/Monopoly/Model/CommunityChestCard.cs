using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations;
using Model.CommandOperations.Orders;

namespace Model
{
    class CommunityChestCard : Card
    {
        private CardType _type;
        private string _label;
        private OrderType _order_type;
        public CommunityChestCard(string label, OrderType orderType)
        {
            _type = CardType.TYPE_CCHEST;
            _label = label;
            _order_type = orderType;
        }

        public override CardType getType()
        {
            return _type;
        }

        public override string getLabel()
        {
            return _label;
        }

        public override OrderType getOrderType()
        {
            return _order_type;
        }

        protected override Order getOrder(OrderType type)
        {
            GameController controller = GameController.GameControllerInstance;
            Order order = null;
            switch (type)
            {
                case OrderType.AdvancetoGo:
                    order = new AdvancetoGoOrder(controller.getCurrentPlayer(),
                                                controller.getBank());
                    break;
                case OrderType.BankErrorInYourFavor:
                    break;
                case OrderType.DoctorFees:
                    break;
                case OrderType.GetOutofJail:
                    break;
                case OrderType.GotoJail:
                    break;
                case OrderType.Birthday_CollectFromEachPlayer:
                    break;
                case OrderType.GrandOperaNight:
                    break;
                case OrderType.IncomeTaxRefund:
                    break;
                case OrderType.LifeInsuranceMatures:
                    break;
                case OrderType.PayHospitalFees:
                    break;
                case OrderType.PaySchoolFees:
                    break;
                case OrderType.ReceiveConsultancyFee:
                    break;
                case OrderType.StreetRepairs:
                    break;
                case OrderType.WonSecondPrize:
                    break;
                case OrderType.Inherit:
                    break;
                case OrderType.FromSaleofStock:
                    break;
                default:
                    order = new AdvancetoGoOrder(controller.getCurrentPlayer(),
                                                controller.getBank());
                    break;
            }
            return order;
        }

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;
            Order _order = getOrder(_order_type);
            Command _command = new CardCommand(_order);
            controller.SetCommand(_command);
            controller.ExecuteCommand();
        }
    }
}
