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

        public EidCardBuilder AddReceiverName(string receiverName)
        {
            _eidCard.ReceiverName = receiverName;
            return this;
        }

        public EidCardBuilder AddMessage(string message)
        {
            _eidCard.Message = message;
            return this;
        }

        public EidCardBuilder AddColor(string color)
        {
            _eidCard.Color = color;
            return this;
        }

        public EidCardBuilder AddDesign(string design)
        {
            _eidCard.DesignName = design;
            return this;
        }


        public EidCard Build()
        {
            return _eidCard;
        }
    }
}
