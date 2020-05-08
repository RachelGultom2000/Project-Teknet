﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travelancar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DaftarPesanan()
        {
            ViewBag.Message = "Daftar Pesanan";

            return View();
        }

        public ActionResult DetailPesanan()
        {
            ViewBag.Message = "Detail Pesanan";

            return View();
        }

        public ActionResult BankLogin()
        {
            ViewBag.Message = "Bank Login";

            return View();
        }

        public ActionResult BankDashboard()
        {
            ViewBag.Message = "Dashboard Bank";

            return View();
        }

        public ActionResult TransferSaldo()
        {
            ViewBag.Message = "Transfer Saldo";

            return View();
        }

        public ActionResult TransferSaldo_2()
        {
            ViewBag.Message = "Tranfer Saldo 2";

            return View();
        }

        public ActionResult RiwayatTransfer()
        {
            ViewBag.Message = "Riwayat Transfer";

            return View();
        }

        public ActionResult BerhasilTransaksi()
        {
            ViewBag.Message = "Berhasil";

            return View();
        }

        public ActionResult GagalTransaksi()
        {
            ViewBag.Message = "Gagal";

            return View();
        }

        public ActionResult AkunBerhasil()
        {
            ViewBag.Message = "Berhasil";

            return View();
        }


        public ActionResult AkunGagal()
        {
            ViewBag.Message = "Gagal";

            return View();
        }





    }
}