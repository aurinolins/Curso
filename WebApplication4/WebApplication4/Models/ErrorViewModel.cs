using System;
using WebApplication4.Models.Entidades;

namespace WebApplication4.Models

{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}