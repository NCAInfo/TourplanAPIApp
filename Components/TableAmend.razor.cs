using global::Microsoft.AspNetCore.Components;

using AntDesign;

using Newtonsoft.Json;
using System.Web;
using System.Text.RegularExpressions;
using DiethelmAPI.ModelDb;

namespace TourplanAPIApp.Components
{
    public partial class TableAmend
    {
        private string Parse1(string value)
        {
        return Regex.Replace(value, @"\$\s?|(,*)", "");
        }
        void DoCalcRound(int val,RateSet rate){
            if (rate.GroupCost.Rates.AdultRate != null)
            {
                if (rate.GroupCost.Rates.AdultRateApply)
                {
                    rate.GroupSell.Rates.AdultRate = CalcRound(CalcRate(rate.GroupCost.Rates.AdultRate));
                     rate.FITSell.Rates.AdultRate =  CalcRound(CalcRate(rate.GroupCost.Rates.AdultRate));
                }
            }

            if (rate.GroupCost.Rates.ChildRateApply)
            {
                rate.GroupSell.Rates.ChildRate = CalcRound(CalcRate(rate.GroupCost.Rates.ChildRate)).Value;
                 rate.FITSell.Rates.ChildRate = CalcRound(CalcRate(rate.GroupCost.Rates.ChildRate)).Value;
            }

            if (rate.GroupCost.Rates.InfantRateApply)
            {
                 rate.GroupSell.Rates.InfantRate = CalcRound(CalcRate(rate.GroupCost.Rates.InfantRate)).Value;
                rate.FITSell.Rates.InfantRate = CalcRound(CalcRate(rate.GroupCost.Rates.InfantRate)).Value;
            }

            if (rate.GroupCost.Rates.PaxBreakRate != null)
            {
                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1Apply)
                {
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb1 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1)).Value;
                     rate.FITSell.Rates.PaxBreakRate.Price_Pxb1 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1)).Value;
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2Apply)
                {
                      rate.GroupSell.Rates.PaxBreakRate.Price_Pxb2 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2)).Value;
                      rate.FITSell.Rates.PaxBreakRate.Price_Pxb2 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2)).Value;
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3Apply)
                {
                      rate.GroupSell.Rates.PaxBreakRate.Price_Pxb3 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3)).Value;
                     rate.FITSell.Rates.PaxBreakRate.Price_Pxb3 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3)).Value;
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4Apply)
                {
                     rate.GroupSell.Rates.PaxBreakRate.Price_Pxb4 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4)).Value;
                     rate.FITSell.Rates.PaxBreakRate.Price_Pxb4 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4)).Value;
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5Apply)
                {
                     rate.GroupSell.Rates.PaxBreakRate.Price_Pxb5 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5)).Value;
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb5 = CalcRound(CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5)).Value;
                }
            }

            if (rate.GroupCost.Rates.RoomRate != null)
            {
                if (rate.GroupCost.Rates.RoomRate.SGApply)
                {
                    rate.GroupSell.Rates.RoomRate.SG = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.SG));
                    rate.FITSell.Rates.RoomRate.SG = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.SG));
                }

                if (rate.GroupCost.Rates.RoomRate.TWApply)
                {
                    rate.GroupSell.Rates.RoomRate.TW = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.TW));
                     rate.FITSell.Rates.RoomRate.TW = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.TW));
                }

                if (rate.GroupCost.Rates.RoomRate.TRApply)
                {
                    rate.GroupSell.Rates.RoomRate.TR = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.TR));
                    rate.FITSell.Rates.RoomRate.TR = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.TR));
                }

                if (rate.GroupCost.Rates.RoomRate.QDApply)
                {
                    rate.GroupSell.Rates.RoomRate.QD = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.QD));
                     rate.FITSell.Rates.RoomRate.QD = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.QD));
                }

                if (rate.GroupCost.Rates.RoomRate.AAApply)
                {
                    rate.GroupSell.Rates.RoomRate.AA = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.AA)).Value;
                    rate.FITSell.Rates.RoomRate.AA = CalcRound(CalcRate(rate.GroupCost.Rates.RoomRate.AA)).Value;
                }
            }

            if (rate.GroupCost.Rates.Extras != null)
            {
                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate)).Value;
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate)).Value;
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate)).Value;
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate)).Value;
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate)).Value;
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate)).Value;
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate)).Value;
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate)).Value;
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate)).Value;
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate)).Value;
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate)).Value;
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate)).Value;
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate)).Value;
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate)).Value;
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate)).Value;
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate)).Value;
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = CalcRound(CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate)).Value;
                }
            }
        }
        private double? CalcRound(double? fromOriginal){
            
            if(fromOriginal.HasValue){
                double roundedPrice = 0;
                double original = fromOriginal.Value;
                switch (RoundNumberSelected)
                {
                    case 1:
                        roundedPrice = original;
                        break;
                    case 2:
                        roundedPrice = Math.Ceiling(original * 10) / 10; // Round up to nearest $0.10
                        break;
                    case 3:
                        roundedPrice = Math.Ceiling(original * 2) / 2;   // Round up to nearest $0.50
                        break;
                    case 4:
                        roundedPrice = Math.Ceiling(original);           // Round up to nearest $1
                        break;
                    case 5:
                        roundedPrice = Math.Ceiling(original / 5) * 5;  // Round up to nearest $5
                        break;
                    case 6:
                        roundedPrice = Math.Ceiling(original / 10) * 10; // Round up to nearest $10
                        break;
                    case 7:
                        roundedPrice = Math.Ceiling(original / 100) * 100; // Round up to nearest $100
                        break;
                    default:
                        break;
                
                }
                return roundedPrice;
            }
            return null;
        }
        private double CalcRate(double? amount){
            double? divByExrate = 1f;
            double? retRate = amount.Value;
            if(_data.Buy_Currency != _data.Sell_Currency){
                if(ExRateOperator == "Div"){
                    divByExrate = _data.Exchange_Div_Rate.Value;
                    retRate = amount / divByExrate;
                }else{
                    divByExrate = _data.Exchange_Mut_Rate.Value;
                    retRate = amount * divByExrate;
                }
                
            }
            return retRate.Value;
        }
        void DoMarkup(RateSet rate)
        {
            var rateMaster = _dataMaster.RateSet.Where(w => w.Key == rate.Key).FirstOrDefault();
            var updateNew = rate.GroupCost;
            var updateMaster = rateMaster.GroupCost;
            if (rate.GroupCost.Rates.AdultRate != null)
            {
                if (rate.GroupCost.Rates.AdultRateApply)
                {
                    rate.GroupCost.Rates.AdultRate = rateMaster.GroupCost.Rates.AdultRate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.AdultRate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.AdultRate = CalcRate(rate.GroupCost.Rates.AdultRate);
                    rate.FITCost.Rates.AdultRate = rateMaster.FITCost.Rates.AdultRate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.AdultRate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.AdultRate =  CalcRate(rate.GroupCost.Rates.AdultRate);
                }
            }

            if (rate.GroupCost.Rates.ChildRateApply)
            {
                rate.GroupCost.Rates.ChildRate = rateMaster.GroupCost.Rates.ChildRate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.ChildRate * rate.MarkupPercent) / 100);
                rate.GroupSell.Rates.ChildRate = CalcRate(rate.GroupCost.Rates.ChildRate);
                rate.FITCost.Rates.ChildRate = rateMaster.FITCost.Rates.ChildRate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.ChildRate * rate.MarkupPercent) / 100);
                rate.FITSell.Rates.ChildRate = CalcRate(rate.GroupCost.Rates.ChildRate);
            }

            if (rate.GroupCost.Rates.InfantRateApply)
            {
                rate.GroupCost.Rates.InfantRate = rateMaster.GroupCost.Rates.InfantRate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.InfantRate * rate.MarkupPercent) / 100);
                rate.GroupSell.Rates.InfantRate = CalcRate(rate.GroupCost.Rates.InfantRate);
                rate.FITCost.Rates.InfantRate = rateMaster.FITCost.Rates.InfantRate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.InfantRate * rate.MarkupPercent) / 100);
                rate.FITSell.Rates.InfantRate = CalcRate(rate.GroupCost.Rates.InfantRate);
            }

            if (rate.GroupCost.Rates.PaxBreakRate != null)
            {
                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb1 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb1 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb1 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb1 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb1 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb1 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb1 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb2 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb2 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb2 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb2 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb2 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb2 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb2 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb3 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb3 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb3 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb3 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb3 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb3 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb3 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb4 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb4 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb4 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb4 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb4 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb4 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb4 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb5 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb5 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb5 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb5 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb5 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb5 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb5 = CalcRate(rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5);
                }
            }

            if (rate.GroupCost.Rates.RoomRate != null)
            {
                if (rate.GroupCost.Rates.RoomRate.SGApply)
                {
                    rate.GroupCost.Rates.RoomRate.SG = rateMaster.GroupCost.Rates.RoomRate.SG + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.SG * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.SG = CalcRate(rate.GroupCost.Rates.RoomRate.SG);
                    rate.FITCost.Rates.RoomRate.SG = rateMaster.FITCost.Rates.RoomRate.SG + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.SG * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.SG = CalcRate(rate.GroupCost.Rates.RoomRate.SG);
                }

                if (rate.GroupCost.Rates.RoomRate.TWApply)
                {
                    rate.GroupCost.Rates.RoomRate.TW = rateMaster.GroupCost.Rates.RoomRate.TW + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.TW * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.TW = CalcRate(rate.GroupCost.Rates.RoomRate.TW);
                    rate.FITCost.Rates.RoomRate.TW = rateMaster.FITCost.Rates.RoomRate.TW + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.TW * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.TW = CalcRate(rate.GroupCost.Rates.RoomRate.TW);
                }

                if (rate.GroupCost.Rates.RoomRate.TRApply)
                {
                    rate.GroupCost.Rates.RoomRate.TR = rateMaster.GroupCost.Rates.RoomRate.TR + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.TR * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.TR = CalcRate(rate.GroupCost.Rates.RoomRate.TR);
                    rate.FITCost.Rates.RoomRate.TR = rateMaster.FITCost.Rates.RoomRate.TR + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.TR * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.TR = CalcRate(rate.GroupCost.Rates.RoomRate.TR);
                }

                if (rate.GroupCost.Rates.RoomRate.QDApply)
                {
                    rate.GroupCost.Rates.RoomRate.QD = rateMaster.GroupCost.Rates.RoomRate.QD + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.QD * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.QD = CalcRate(rate.GroupCost.Rates.RoomRate.QD);
                    rate.FITCost.Rates.RoomRate.QD = rateMaster.FITCost.Rates.RoomRate.QD + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.QD * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.QD = CalcRate(rate.GroupCost.Rates.RoomRate.QD);
                }

                if (rate.GroupCost.Rates.RoomRate.AAApply)
                {
                    rate.GroupCost.Rates.RoomRate.AA = rateMaster.GroupCost.Rates.RoomRate.AA + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.AA * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.AA = CalcRate(rate.GroupCost.Rates.RoomRate.AA);
                    rate.FITCost.Rates.RoomRate.AA = rateMaster.FITCost.Rates.RoomRate.AA + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.AA * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.AA = CalcRate(rate.GroupCost.Rates.RoomRate.AA);
                }
            }

            if (rate.GroupCost.Rates.Extras != null)
            {
                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = CalcRate(rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = CalcRate(rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = CalcRate(rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate);
                }
            }
        }

        protected int RoundNumberSelected {get;set;} = 1;
        protected string ExRateOperator { get; set; } = "Div";
        protected double ExRate {get;set;} = 1;

        string styleRadio = "display: block;height:25px;line-height:25px";
        [Parameter]
        public List<RequestSetRate> AmendData { get; set; }

        bool IsLoading = true;
        IEnumerable<Product> _productList { get; set; } = new List<Product>();
        protected RequestSetRate _obj { get; set; }
        protected DateRange _data { get; set; } = new DateRange();
        protected DateRange _dataMaster { get; set; } = new DateRange();

        bool IsShowForm = false;
        private Form<DateRange> _form = new Form<DateRange>();
        protected GetOptionReplyRoot _optionDetail { get; set; } = new GetOptionReplyRoot();
        protected LoginModel User { get; set; } = new LoginModel();
        protected bool IsDone { get; set; } = false;

        protected List<PriceCode> _priceCodeList = new List<PriceCode>();
        bool IsShowOption = false;
        protected IEnumerable<Product> _selectedProduct { get; set; } = new List<Product>();
        public List<StayPayType> _stayPayTypeList { get; set; } = new List<StayPayType>();
        public IEnumerable<Currency> _currency {get;set;} = new List<Currency>();
        public IEnumerable<Tt> _TtList {get;set;} = new List<Tt>();

        void ShowCodeList()
        {
            IsShowOption = true;
        }

        void DoSelectOption()
        {
            if (_selectedProduct.Count() > 0)
            {
                _data.OptionCode = _selectedProduct.First().OptionCode;
            }

            IsShowOption = false;
        }

        protected override async Task OnInitializedAsync()
        {
            var userjson = await localStorage.GetAsync<string>("user");
            User = JsonConvert.DeserializeObject<LoginModel>(userjson.Value);
            _priceCodeList = await ap.GetPriceCodeDetail(User.Country);
            _stayPayTypeList.Add(new StayPayType { Id = 2, Name = "First" });
            _stayPayTypeList.Add(new StayPayType { Id = 1, Name = "Last" });
            _stayPayTypeList.Add(new StayPayType { Id = 3, Name = "Lowest" });
            _stayPayTypeList.Add(new StayPayType { Id = 5, Name = "Repeats on first" });
            _stayPayTypeList.Add(new StayPayType { Id = 4, Name = "Repeats on last" });
            _TtList = await ap.GetTaxAll(User.Country);
        }

        async Task Edit(int id)
        {
            IsShowForm = true;
            _obj = await ds.RequestSetRateById(id);
            if (_obj != null)
            {
                GetOptionRequest rq = new GetOptionRequest();
                rq.User = _obj.Supplier;
                rq.Password = _obj.Supplier;
                rq.OptionCode = _obj.OptionCode;
                rq.Date_From = _obj.Date_From;
                rq.Date_To = _obj.Date_To;
                var getLast6 = _obj.OptionCode.Substring(_obj.OptionCode.Length - 6);
                var optionCode = HttpUtility.HtmlEncode(getLast6.Substring(0, getLast6.Length - 2) + "%3F%3F");
                _productList = await ap.GetOptionList(_obj.Supplier, optionCode, User.Country);
                var getProductFromLast6 = _productList.Where(w => w.Code == getLast6).FirstOrDefault();
                if (getProductFromLast6 != null)
                {
                    _selectedProduct.Append(getProductFromLast6);
                }

                _optionDetail = await ap.GetOptionDetail(rq, User.Country);
                _data = JsonConvert.DeserializeObject<DateRange>(_obj.JsonData);
                
                if (_data.ChargeExtra1 == "Y")
                {
                    _data.ChargeEx1_Check = true;
                }

                if (_data.ChargeExtra2 == "Y")
                {
                    _data.ChargeEx2_Check = true;
                }

                if (_data.ChargeExtra3 == "Y")
                {
                    _data.ChargeEx3_Check = true;
                }

                if (_data.ChargeExtra4 == "Y")
                {
                    _data.ChargeEx4_Check = true;
                }

                if (_data.ChargeExtra5 == "Y")
                {
                    _data.ChargeEx5_Check = true;
                }

                if(_data.Exchange_Div_Rate != null)
                {
                    ExRateOperator = "Div";
                }
                if (_data.Exchange_Mut_Rate != null)
                {
                    ExRateOperator = "Mut";
                }
                foreach (var rate in _data.RateSet)
                {
                    rate.Stay_Type = HttpUtility.HtmlDecode(rate.Stay_Type);
                    rate.Stay_Type2 = HttpUtility.HtmlDecode(rate.Stay_Type2);
                    rate.Rate_Text = HttpUtility.HtmlDecode(rate.Rate_Text);
                    rate.Rate_Text2 = HttpUtility.HtmlDecode(rate.Rate_Text2);
                    if (rate.Apply_Mon == "Y")
                    {
                        rate.Apply_Mon_chk = true;
                    }

                    if (rate.Apply_Tue == "Y")
                    {
                        rate.Apply_Tue_chk = true;
                    }

                    if (rate.Apply_Wed == "Y")
                    {
                        rate.Apply_Wed_chk = true;
                    }

                    if (rate.Apply_Thu == "Y")
                    {
                        rate.Apply_Thu_chk = true;
                    }

                    if (rate.Apply_Fri == "Y")
                    {
                        rate.Apply_Fri_chk = true;
                    }

                    if (rate.Apply_Sat == "Y")
                    {
                        rate.Apply_Sat_chk = true;
                    }

                    if (rate.Apply_Sun == "Y")
                    {
                        rate.Apply_Sun_chk = true;
                    }

                    if (rate.Commissionable == "Y")
                    {
                        rate.Commissionable_chk = true;
                    }
                }

                foreach(var tax in _data.Taxes.TaxInfo){
                    if(tax.TaxMainOption == "Y"){
                        tax.TaxMainOption_apply = true;
                    }
                    if(tax.TaxSs == "Y"){
                        tax.TaxSs_apply = true;
                    }
                    if(tax.TaxTw == "Y"){
                        tax.TaxTw_apply = true;
                    }
                    if(tax.TaxTr == "Y"){
                        tax.TaxTr_apply = true;
                    }
                    if(tax.TaxQr == "Y"){
                        tax.TaxQr_apply = true;
                    }
                    if(tax.TaxEx1 == "Y"){
                        tax.TaxEx1_apply = true;
                    }
                    if(tax.TaxEx2 == "Y"){
                        tax.TaxEx2_apply = true;
                    }
                    if(tax.TaxEx3 == "Y"){
                        tax.TaxEx3_apply = true;
                    }
                    if(tax.TaxEx4 == "Y"){
                        tax.TaxEx4_apply = true;
                    }
                    if(tax.TaxEx5 == "Y"){
                        tax.TaxEx5_apply = true;
                    }
                }

                _dataMaster = JsonConvert.DeserializeObject<DateRange>(_obj.JsonMaster);
                if(_data.Taxes.TaxInfo.Count()>0){
                    if(_data.Taxes.TaxInfo.Any(t=>t.Tax == "")){
                        await _message.Warning("Tax Code unassigned",5);
                    }
                   
                }
            }
             _currency = await ap.GetCurrency(User.Country);
            IsLoading = false;
        }

        void Delete(int id)
        {
            var del = ds.RequestSetRateDelete(id);
            var objremove = AmendData.Where(w => w.Id == id).FirstOrDefault();
            AmendData.Remove(objremove);
        }

        void DoSubmit()
        {
            _form.Submit();
        }

        void DoSave()
        {
            foreach (var rate in _data.RateSet)
            {
                // rate.Stay_Type = HttpUtility.HtmlEncode(rate.Stay_Type);
                // rate.Stay_Type2 = HttpUtility.HtmlEncode(rate.Stay_Type2);
                // rate.Rate_Text = HttpUtility.HtmlEncode(rate.Rate_Text);
                // rate.Rate_Text2 = HttpUtility.HtmlEncode(rate.Rate_Text2);
                rate.Apply_Mon = (rate.Apply_Mon_chk ? "Y" : "N");
                rate.Apply_Tue = (rate.Apply_Tue_chk ? "Y" : "N");
                rate.Apply_Wed = (rate.Apply_Wed_chk ? "Y" : "N");
                rate.Apply_Thu = (rate.Apply_Thu_chk ? "Y" : "N");
                rate.Apply_Fri = (rate.Apply_Fri_chk ? "Y" : "N");
                rate.Apply_Sat = (rate.Apply_Sat_chk ? "Y" : "N");
                rate.Apply_Sun = (rate.Apply_Sun_chk ? "Y" : "N");
                rate.Commissionable = (rate.Commissionable_chk ? "Y" : "N");
                if (rate.StayPayType <= 3)
                {
                    rate.RepeatTimes = 0;
                }
            }

            if (_data.ChargeExtra1 != null)
            {
                _data.ChargeExtra1 = (_data.ChargeEx1_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra2 != null)
            {
                _data.ChargeExtra2 = (_data.ChargeEx2_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra3 != null)
            {
                _data.ChargeExtra3 = (_data.ChargeEx3_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra4 != null)
            {
                _data.ChargeExtra4 = (_data.ChargeEx4_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra5 != null)
            {
                _data.ChargeExtra5 = (_data.ChargeEx5_Check ? "Y" : "N");
            }


            foreach(var tax in _data.Taxes.TaxInfo){
                
               if(tax.TaxMainOption != null){
                    tax.TaxMainOption = (tax.TaxMainOption_apply?"Y":"N");
                }
                if(tax.TaxSs != null){
                    tax.TaxSs = (tax.TaxSs_apply?"Y":"N");
                }
                if(tax.TaxTw != null){
                    tax.TaxTw = (tax.TaxTw_apply?"Y":"N");
                }
                if(tax.TaxTr != null){
                    tax.TaxTr = (tax.TaxTr_apply?"Y":"N");
                }
                if(tax.TaxQr != null){
                    tax.TaxQr = (tax.TaxQr_apply?"Y":"N");
                }
                if(tax.TaxEx1 != null){
                    tax.TaxEx1 = (tax.TaxEx1_apply?"Y":"N");
                }
                if(tax.TaxEx2 != null){
                    tax.TaxEx2 = (tax.TaxEx2_apply?"Y":"N");
                }
                if(tax.TaxEx3 != null){
                    tax.TaxEx3 = (tax.TaxEx3_apply?"Y":"N");
                }
                if(tax.TaxEx4 != null){
                    tax.TaxEx4 = (tax.TaxEx4_apply?"Y":"N");
                }
                if(tax.TaxEx5 != null){
                    tax.TaxEx5 = (tax.TaxEx5_apply?"Y":"N");
                }
                
            }
            _obj.Price_Code = _data.Price_Code;
            _obj.OptionCode = _data.OptionCode;
            _obj.Date_From = _data.Date_From;
            _obj.Date_To = _data.Date_To;
            _obj.LastUpdated = DateTime.Now;
            _obj.JsonData = JsonConvert.SerializeObject(_data);
            ds.RequestSetRateSave(_obj);
            IsShowForm = false;
        }

        async Task DoApprove()
        {
            SetRateRequest rq = new SetRateRequest();
            rq.User = _obj.Supplier;
            rq.Password = _obj.Supplier;
            foreach (var rate in _data.RateSet)
            {
                // rate.Stay_Type = HttpUtility.HtmlEncode(rate.Stay_Type);
                // rate.Stay_Type2 = HttpUtility.HtmlEncode(rate.Stay_Type2);
                // rate.Rate_Text = HttpUtility.HtmlEncode(rate.Rate_Text);
                // rate.Rate_Text2 = HttpUtility.HtmlEncode(rate.Rate_Text2);
                rate.Apply_Mon = (rate.Apply_Mon_chk ? "Y" : "N");
                rate.Apply_Tue = (rate.Apply_Tue_chk ? "Y" : "N");
                rate.Apply_Wed = (rate.Apply_Wed_chk ? "Y" : "N");
                rate.Apply_Thu = (rate.Apply_Thu_chk ? "Y" : "N");
                rate.Apply_Fri = (rate.Apply_Fri_chk ? "Y" : "N");
                rate.Apply_Sat = (rate.Apply_Sat_chk ? "Y" : "N");
                rate.Apply_Sun = (rate.Apply_Sun_chk ? "Y" : "N");
                rate.Commissionable = (rate.Commissionable_chk ? "Y" : "N");
                if (rate.StayPayType <= 3)
                {
                    rate.RepeatTimes = 0;
                }
            }

            if (_data.ChargeExtra1 != null)
            {
                _data.ChargeExtra1 = (_data.ChargeEx1_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra2 != null)
            {
                _data.ChargeExtra2 = (_data.ChargeEx2_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra3 != null)
            {
                _data.ChargeExtra3 = (_data.ChargeEx3_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra4 != null)
            {
                _data.ChargeExtra4 = (_data.ChargeEx4_Check ? "Y" : "N");
            }

            if (_data.ChargeExtra5 != null)
            {
                _data.ChargeExtra5 = (_data.ChargeEx5_Check ? "Y" : "N");
            }
            foreach(var tax in _data.Taxes.TaxInfo){
                
               if(tax.TaxMainOption != null){
                    tax.TaxMainOption = (tax.TaxMainOption_apply?"Y":"N");
                }
                if(tax.TaxSs != null){
                    tax.TaxSs = (tax.TaxSs_apply?"Y":"N");
                }
                if(tax.TaxTw != null){
                    tax.TaxTw = (tax.TaxTw_apply?"Y":"N");
                }
                if(tax.TaxTr != null){
                    tax.TaxTr = (tax.TaxTr_apply?"Y":"N");
                }
                if(tax.TaxQr != null){
                    tax.TaxQr = (tax.TaxQr_apply?"Y":"N");
                }
                if(tax.TaxEx1 != null){
                    tax.TaxEx1 = (tax.TaxEx1_apply?"Y":"N");
                }
                if(tax.TaxEx2 != null){
                    tax.TaxEx2 = (tax.TaxEx2_apply?"Y":"N");
                }
                if(tax.TaxEx3 != null){
                    tax.TaxEx3 = (tax.TaxEx3_apply?"Y":"N");
                }
                if(tax.TaxEx4 != null){
                    tax.TaxEx4 = (tax.TaxEx4_apply?"Y":"N");
                }
                if(tax.TaxEx5 != null){
                    tax.TaxEx5 = (tax.TaxEx5_apply?"Y":"N");
                }
                
            }
            rq.DateRange.Add(_data);
            var ret = await ap.SetRate(rq, User.Country);
            if (ret.ErrorReply != null)
            {
                await _notice.Open(new NotificationConfig() { Message = "Error from Tourplan", Description = ret.ErrorReply.Error, NotificationType = NotificationType.Error });
            }
            else
            {
                _obj.Price_Code = _data.Price_Code;
                _obj.OptionCode = _data.OptionCode;
                _obj.Date_From = _data.Date_From;
                _obj.Date_To = _data.Date_To;
                _obj.DatePublish = DateTime.Now;
                _obj.PublishBy = User.Username;
                _obj.IsPublish = true;
                AmendData.Remove(_obj);
                IsShowForm = false;
            }

            _obj.JsonData = JsonConvert.SerializeObject(_data);
            ds.RequestSetRateSave(_obj);
        }
        void AddNewTax(Tt taxItem){
             var newTax = new TaxInfo();
                newTax.Tax = taxItem.Code;
                newTax.TaxEx1 = "Y";
                newTax.TaxEx1_apply = true;
                newTax.TaxEx2 = "Y";
                newTax.TaxEx2_apply = true;
                newTax.TaxEx3 = "Y";
                newTax.TaxEx3_apply = true;
                newTax.TaxEx4 = "Y";
                newTax.TaxEx4_apply = true;
                newTax.TaxEx5 = "Y";
                newTax.TaxEx5_apply = true;
                newTax.TaxSs = "Y";
                newTax.TaxSs_apply = true;
                 newTax.TaxTw = "Y";
                newTax.TaxTw_apply = true;
                 newTax.TaxTr = "Y";
                newTax.TaxTr_apply = true;
                newTax.TaxQr = "Y";
                newTax.TaxQr_apply = true;
             _data.Taxes.TaxInfo.Add(newTax);
        }
        void Copy(RequestSetRate model)
        {
            var copy = Functions.CloneObject<RequestSetRate>(model);
            copy.Id = 0;
            copy.Status = Status.New;
            ds.RequestSetRateSave(copy);
            AmendData.Add(copy);
        }

        async Task CheckOption()
        {
            GetOptionRequest rq = new GetOptionRequest();
            rq.User = _obj.Supplier;
            rq.Password = _obj.Supplier;
            rq.OptionCode = _data.OptionCode;
            rq.Date_From = _obj.Date_From;
            rq.Date_To = _obj.Date_To;
            var checkOption = await ap.GetOptionDetail(rq, User.Country);
            if (checkOption.GetOptionReply == null || checkOption.GetOptionReply.OptionData.Count == 0)
            {
                await _message.Error("No OptionCode in Tourplan", 5);
                _data.OptionCode = _dataMaster.OptionCode;
            }
            else
            {
                _optionDetail = checkOption;
            }
        }

        void AdultRateCopyTo(RateSet rate)
        {
            rate.GroupSell.Rates.AdultRate = rate.GroupCost.Rates.AdultRate;
        }

        async Task DoCopy(RateSet rate)
        {
            IsLoading = true;
            var newObj = Functions.CloneObject<RateSet>(rate);
            newObj.Stay_Type = newObj.Stay_Type + "(copy)";
            newObj.Rate_Text = newObj.Rate_Text + "(copy)";
            _data.RateSet.Add(newObj);
            IsLoading = false;
        }

        async Task DoDelete(RateSet rate)
        {
            IsLoading = true;
            _data.RateSet.Remove(rate);
            IsLoading = false;
        }

        public class StayPayType
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}