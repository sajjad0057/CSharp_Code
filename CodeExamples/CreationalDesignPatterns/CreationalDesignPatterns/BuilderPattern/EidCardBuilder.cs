using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.CreationalDesignPatterns.BuilderPattern
{
    /// <summary>
    /// Builder
    /// </summary>
    public class EidCardBuilder
    {
        private EidCard _eidCard;

        public EidCardBuilder()
        {
            _eidCard = new EidCard();
        }

        public void AddReceiverName(string receiverName)
        {
            _eidCard.ReceiverName = receiverName;
        }

        public void AddMessage(string message)
        {
            _eidCard.Message = message;
        }

        public void AddColor(string color)
        {
            _eidCard.Color = color;
        }

        public void AddDesign(string design)
        {
            _eidCard.DesignName = design;
        }


        public EidCard Build()
        {
            return _eidCard;
        }
    }
}
