using System;
using System.Collections.Generic;
using Magic_The_Base.Templates;

namespace Magic_The_Base.Controllers
{
    public class CardController
    {
        MTGWizards cards;

        public CardController()
        {
            this.cards = new MTGWizards();
        }

        public List<String> recoverCollections()
        {
            return this.cards.recoverCollections();
        }

        public List<String> RecoverCardsLinks(String collection)
        {
            return this.cards.RecoverCardsLinks(collection);
        }

        public void ExtrairCards(List<String> cards)
        {
            this.cards.ExtrairCards(cards);
        }
    }
}
