using global::System;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Threading.Tasks;
using global::Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using TourplanAPIApp;
using TourplanAPIApp.Shared;
using TourplanAPIApp.Components;
using AntDesign;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Blazored.Typeahead;
using Newtonsoft.Json;
using System.Web;

namespace TourplanAPIApp.Components
{
    public partial class TableAmend
    {
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
                    rate.GroupSell.Rates.AdultRate = rateMaster.GroupSell.Rates.AdultRate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.AdultRate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.AdultRate = rateMaster.FITCost.Rates.AdultRate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.AdultRate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.AdultRate = rateMaster.FITSell.Rates.AdultRate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.AdultRate * rate.MarkupPercent) / 100);
                }
            }

            if (rate.GroupCost.Rates.ChildRateApply)
            {
                rate.GroupCost.Rates.ChildRate = rateMaster.GroupCost.Rates.ChildRate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.ChildRate * rate.MarkupPercent) / 100);
                rate.GroupSell.Rates.ChildRate = rateMaster.GroupSell.Rates.ChildRate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.ChildRate * rate.MarkupPercent) / 100);
                rate.FITCost.Rates.ChildRate = rateMaster.FITCost.Rates.ChildRate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.ChildRate * rate.MarkupPercent) / 100);
                rate.FITSell.Rates.ChildRate = rateMaster.FITSell.Rates.ChildRate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.ChildRate * rate.MarkupPercent) / 100);
            }

            if (rate.GroupCost.Rates.InfantRateApply)
            {
                rate.GroupCost.Rates.InfantRate = rateMaster.GroupCost.Rates.InfantRate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.InfantRate * rate.MarkupPercent) / 100);
                rate.GroupSell.Rates.InfantRate = rateMaster.GroupSell.Rates.InfantRate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.InfantRate * rate.MarkupPercent) / 100);
                rate.FITCost.Rates.InfantRate = rateMaster.FITCost.Rates.InfantRate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.InfantRate * rate.MarkupPercent) / 100);
                rate.FITSell.Rates.InfantRate = rateMaster.FITSell.Rates.InfantRate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.InfantRate * rate.MarkupPercent) / 100);
            }

            if (rate.GroupCost.Rates.PaxBreakRate != null)
            {
                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb1 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb1 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb1 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb1 = rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb1 + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb1 * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb1 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb1 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb1 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb1 = rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb1 + rate.MarkupAmount + ((rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb1 * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb2 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb2 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb2 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb2 = rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb2 + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb2 * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb2 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb2 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb2 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb2 = rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb2 + rate.MarkupAmount + ((rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb2 * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb3 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb3 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb3 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb3 = rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb3 + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb3 * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb3 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb3 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb3 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb3 = rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb3 + rate.MarkupAmount + ((rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb3 * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb4 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb4 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb4 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb4 = rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb4 + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb4 * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb4 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb4 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb4 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb4 = rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb4 + rate.MarkupAmount + ((rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb4 * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5Apply)
                {
                    rate.GroupCost.Rates.PaxBreakRate.Price_Pxb5 = rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb5 + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.PaxBreakRate.Price_Pxb5 * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.PaxBreakRate.Price_Pxb5 = rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb5 + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.PaxBreakRate.Price_Pxb5 * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.PaxBreakRate.Price_Pxb5 = rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb5 + rate.MarkupAmount + ((rateMaster.FITCost.Rates.PaxBreakRate.Price_Pxb5 * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.PaxBreakRate.Price_Pxb5 = rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb5 + rate.MarkupAmount + ((rateMaster.FITSell.Rates.PaxBreakRate.Price_Pxb5 * rate.MarkupPercent) / 100);
                }
            }

            if (rate.GroupCost.Rates.RoomRate != null)
            {
                if (rate.GroupCost.Rates.RoomRate.SGApply)
                {
                    rate.GroupCost.Rates.RoomRate.SG = rateMaster.GroupCost.Rates.RoomRate.SG + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.SG * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.SG = rateMaster.GroupSell.Rates.RoomRate.SG + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.RoomRate.SG * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.RoomRate.SG = rateMaster.FITCost.Rates.RoomRate.SG + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.SG * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.SG = rateMaster.FITSell.Rates.RoomRate.SG + rate.MarkupAmount + ((rateMaster.FITSell.Rates.RoomRate.SG * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.RoomRate.TWApply)
                {
                    rate.GroupCost.Rates.RoomRate.TW = rateMaster.GroupCost.Rates.RoomRate.TW + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.TW * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.TW = rateMaster.GroupSell.Rates.RoomRate.TW + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.RoomRate.TW * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.RoomRate.TW = rateMaster.FITCost.Rates.RoomRate.TW + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.TW * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.TW = rateMaster.FITSell.Rates.RoomRate.TW + rate.MarkupAmount + ((rateMaster.FITSell.Rates.RoomRate.TW * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.RoomRate.TRApply)
                {
                    rate.GroupCost.Rates.RoomRate.TR = rateMaster.GroupCost.Rates.RoomRate.TR + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.TR * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.TR = rateMaster.GroupSell.Rates.RoomRate.TR + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.RoomRate.TR * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.RoomRate.TR = rateMaster.FITCost.Rates.RoomRate.TR + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.TR * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.TR = rateMaster.FITSell.Rates.RoomRate.TR + rate.MarkupAmount + ((rateMaster.FITSell.Rates.RoomRate.TR * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.RoomRate.QDApply)
                {
                    rate.GroupCost.Rates.RoomRate.QD = rateMaster.GroupCost.Rates.RoomRate.QD + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.QD * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.QD = rateMaster.GroupSell.Rates.RoomRate.QD + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.RoomRate.QD * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.RoomRate.QD = rateMaster.FITCost.Rates.RoomRate.QD + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.QD * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.QD = rateMaster.FITSell.Rates.RoomRate.QD + rate.MarkupAmount + ((rateMaster.FITSell.Rates.RoomRate.QD * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.RoomRate.AAApply)
                {
                    rate.GroupCost.Rates.RoomRate.AA = rateMaster.GroupCost.Rates.RoomRate.AA + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.RoomRate.AA * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.RoomRate.AA = rateMaster.GroupSell.Rates.RoomRate.AA + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.RoomRate.AA * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.RoomRate.AA = rateMaster.FITCost.Rates.RoomRate.AA + rate.MarkupAmount + ((rateMaster.FITCost.Rates.RoomRate.AA * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.RoomRate.AA = rateMaster.FITSell.Rates.RoomRate.AA + rate.MarkupAmount + ((rateMaster.FITSell.Rates.RoomRate.AA * rate.MarkupPercent) / 100);
                }
            }

            if (rate.GroupCost.Rates.Extras != null)
            {
                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate = rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate = rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate = rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex1Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate = rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate = rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate = rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex2Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate = rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate = rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate = rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex3Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate = rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate = rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate = rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex4Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate = rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.AdultExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate = rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.ChildExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                }

                if (rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Apply)
                {
                    rate.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.GroupSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITCost.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                    rate.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate = rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate + rate.MarkupAmount + ((rateMaster.FITSell.Rates.Extras.InfantExtras.ExtraRates.Ex5Rate * rate.MarkupPercent) / 100);
                }
            }
        }

        protected string ExRateOperator { get; set; } = "Div";
        

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

                _dataMaster = JsonConvert.DeserializeObject<DateRange>(_obj.JsonMaster);
            }

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

        bool _loading = false;
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