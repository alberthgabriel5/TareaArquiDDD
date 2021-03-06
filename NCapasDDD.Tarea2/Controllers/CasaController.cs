﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NCapasDDD.Aplicacion.Contratos;

namespace NCapasDDD.Tarea2.Controllers
{
    public class CasaController : Controller
    {
        #region Atributos
        private ICasaServicio _casaServicio;
        #endregion
        #region Constructor

        public CasaController(ICasaServicio casaServicio)
        {
            _casaServicio = casaServicio;
        }
        #endregion


        #region Metodos
        // GET: Casa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Casa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Casa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Casa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Casa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Casa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Casa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Casa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
