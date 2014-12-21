using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations;

namespace Model
{
    abstract class Card
    {
        public enum CardType
        {
            TYPE_CHANCE,
            TYPE_CCHEST
        }

        public enum OrderType
        {
            AdvancetoGo,
            AdvancetoIllinoisAve,
            AdvancetoNearestUtility,
            AdvancetoNearestRailroad,
            AdvancetoCharlesPlace,
            BankPaysYou,
            GetOutofJail,
            GoBack_3_Space,
            GotoJail,
            RepairsAllProperty,
            PayPoorTax,
            AdvancetoReadingRailroad,
            AdvancetoBoardwalk,
            PayEachPlayer,
            Collect_150,
            WonCompetition,
            BankErrorInYourFavor,
            DoctorFees,
            Birthday_CollectFromEachPlayer,
            GrandOperaNight,
            IncomeTaxRefund,
            LifeInsuranceMatures,
            PayHospitalFees,
            PaySchoolFees,
            ReceiveConsultancyFee,
            StreetRepairs,
            WonSecondPrize,
            Inherit,
            FromSaleofStock
        }

        public abstract CardType getType();
        public abstract string getLabel();
        public abstract OrderType getOrderType();
        public abstract void applyAction();
        protected abstract Order getOrder(OrderType type);
    }
}
