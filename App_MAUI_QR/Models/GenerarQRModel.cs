using App_MAUI_QR.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MAUI_QR.Models
{
    public class GenerarQRModel :BaseBinding
    {
        private string _valorQR;

        public string valorQR 
        {
            get
            {
                return _valorQR;
            }
            set 
            { 
                SetValue(ref _valorQR, value);
            
            } 
        }
                
               
    }
}
