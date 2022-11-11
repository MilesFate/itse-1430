// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;
using System.Collections.Generic;

namespace LuisalbertoCastaneda.AdventureGame.World
{
    class Item
    {

        private List<Item> _items = new List<Item>();

        public Item Add ( Item item, out string error )
        {
            error = item.Validator();
            if (!String.IsNullOrEmpty(error))
                return null;

            var existing = FindItemName(item.ItemName);
            if (existing != null)
            {
                error = "Each room must have a unique name.";
                return null;
            }

            var newItem = item.Creation();
            item.ItemId = newItem.ItemId;
            _items.Add(newItem);

            return item;
        }

        private Item FindItemName ( string name )
        {
            foreach (var item in _items)
            {
                if (String.Compare(name, item.ItemName, true) == 0)
                    return item;
            };

            return null;
        }

        private Item FindItemId ( int id )
        {
            foreach (var item in _items)
            {
                if (item.ItemId == id)
                    return item;
            };

            return null;
        }

        public Item Get ( int id )
        {
            var item = FindItemId(id);

            return item?.Creation();
        }

        public IEnumerable<Item> GetAll ()
        {
            foreach (var item in _items)
                yield return item.Creation();
        }

        #region Getters and Setters

        public string ItemName
        {
            get => _itemName ?? "" ; 
            set => _itemName = (value != null) ? value.Trim() : ""; 
        }
        public int CoinValue { get; set; }
        public int Weight { get; set; }
        public int ItemId { get; set; }

        #endregion

        private string _itemName;

        public Item Creation ()
        {
            var item = new Item();

            item.ItemName = ItemName;
            item.CoinValue = CoinValue;
            item.Weight = Weight;

            return item;
        }

        public string Validator ()
        {
            if (String.IsNullOrEmpty(ItemName))
                return "Item must have a name";
            if (CoinValue < 0)
                return "Item must have value 0 or greater";
            if (Weight <= 0)
                return "Item must has weight";
            return null;
        }
    }
}
