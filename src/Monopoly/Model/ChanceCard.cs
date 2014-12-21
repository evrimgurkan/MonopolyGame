using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations;
using Model.CommandOperations.Orders;

namespace Model
{
    class ChanceCard : Card
    {
        private CardType _type;
        private string _label;
        private OrderType _order_type;
        
        public ChanceCard(string label,OrderType orderType)
        {
            _type = CardType.TYPE_CHANCE;
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

        public override void applyAction()
        {
            GameController controller = GameController.GameControllerInstance;
            Order _order = getOrder(_order_type);
            Command _command = new CardCommand(_order);
            controller.SetCommand(_command);
            controller.ExecuteCommand();
        }

        protected override Order getOrder(OrderType type)
        {
            GameController controller = GameController.GameControllerInstance;
            switch (type)
            {
                case OrderType.AdvancetoGo:
                    return new AdvancetoGoOrder(controller.getCurrentPlayer(),
                                                controller.getBank());
                    break;
                case OrderType.AdvancetoIllinoisAve:
                    break;
                case OrderType.AdvancetoNearestUtility:
                    break;
                case OrderType.AdvancetoNearestRailroad:
                    break;
                case OrderType.AdvancetoCharlesPlace:
                    break;
                case OrderType.BankPaysYou:
                    break;
                case OrderType.GetOutofJail:
                    break;
                case OrderType.GoBack_3_Space:
                    break;
                case OrderType.GotoJail:
                    break;
                case OrderType.RepairsAllProperty:
                    break;
                case OrderType.PayPoorTax:
                    break;
                case OrderType.AdvancetoReadingRailroad:
                    break;
                case OrderType.AdvancetoBoardwalk:
                    break;
                case OrderType.PayEachPlayer:
                    break;
                case OrderType.Collect_150:
                    break;
                case OrderType.WonCompetition:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
