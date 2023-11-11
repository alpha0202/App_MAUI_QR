using App_MAUI_QR.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MAUI_QR.Models
{
    public class GenerarBardCodeModel : BaseBinding
    {

        private string _valorBarCode;

        public string valorBarCode
        {
            get
            {
                return _valorBarCode;
            }
            set
            {
                SetValue(ref _valorBarCode, value);

            }
        }

    }
}
