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
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(),200);
                    break;
                case OrderType.BankErrorInYourFavor:
                    order = new BankErrorInFavorOrder(controller.getCurrentPlayer(),
                                                controller.getBank());
                    break;
                case OrderType.DoctorFees:
                    order = new PayMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(),50);
                    break;
                case OrderType.GetOutofJail:
                    break;
                case OrderType.GotoJail:
                    order = new GoToJailCardOrder(controller.getCurrentPlayer());
                    break;
                case OrderType.Birthday_CollectFromEachPlayer:
                    order = new CollectFromEachPlayerOrder(controller.getCurrentPlayer(),
                                                controller.getBank(),10);
                    break;
                case OrderType.GrandOperaNight:
                    order = new CollectFromEachPlayerOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 50);
                    break;
                case OrderType.IncomeTaxRefund:
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 20);
                    break;
                case OrderType.LifeInsuranceMatures:
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 100);
                    break;
                case OrderType.PayHospitalFees:
                    order = new PayMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 100);
                    break;
                case OrderType.PaySchoolFees:
                    order = new PayMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 50);
                    break;
                case OrderType.ReceiveConsultancyFee:
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 25);
                    break;
                case OrderType.StreetRepairs:
                    break;
                case OrderType.WonSecondPrize:
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 10);
                    break;
                case OrderType.Inherit:
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 100);
                    break;
                case OrderType.FromSaleofStock:
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(), 50);
                    break;
                default:
                    order = new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(),50);
                    break;
            }
            return new CollectMoneyOrder(controller.getCurrentPlayer(),
                                                controller.getBank(),50); 
        }

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;
            Order _order = getOrder(_order_type);
            Command _command = new ActionCommand(_order);
            controller.SetCommand(_command);
            controller.ExecuteCommand();
        }
    }
}
