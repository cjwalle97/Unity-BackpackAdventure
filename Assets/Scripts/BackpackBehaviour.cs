using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class BackpackBehaviour : MonoBehaviour
    {
        public BackpackConfig BagConfig;
        private BackpackConfig _currentconfig;
        private Dictionary<string, List<Item>> _backpack;      

        private bool AddToBackpack(Item item)
        {
            //CHECK ITEM TYPE
            //SORT ACCORDLING
            string itemtypekey = item.Type.ToString();

            //CHECK IF BACKPACK HAS ITEM ALREADY
            //IF NOT, ADD NEW LIST FOR THAT ITEM TYPE
            if (_backpack.ContainsKey(itemtypekey) == false)
            {
                List<Item> itemlist = new List<Item>();
                itemlist.Add(item);
                _backpack.Add(itemtypekey, itemlist);
                itemlist = null;
                return true;
            }

            //IF BACKPACK HAS ITEM ALREADY, ADD ITEM TO ALREADY EXISTING ITEMLIST
            //  - MAKE SURE ITEM IS NOT NULL
            if (item != null)
            {
                _backpack[itemtypekey].Add(item);
                return true;
            }
            return false;
        }

        private bool RemoveFromBackpack(string name)
        {
            //CHECK EACH ITEMTYPE IN BACKPACK
            foreach (var itemtype in _backpack)
            {
                //CHECK EACH ITEM IN CATAGORY
                foreach (var item in itemtype.Value)
                {
                    //IF MATCH, REMOVE
                    if (item.Name == name)
                    {
                        itemtype.Value.Remove(item);
                        return true;
                    }
                }
            }

            //NO MATCHES RETURN FALSE
            return false;
        }

        private bool ChangeBackpackConfig(BackpackConfig newconfig)
        {
            _currentconfig = newconfig;
            return true;
        }

        private bool AddConfigToBackpack(BackpackConfig newconfig)
        {
            foreach(var item in newconfig.Items)
            {
                AddToBackpack(item);
                return true;
            }
            return false;
        }
        
        // Use this for initialization
        void Start()
        {
            _backpack = new Dictionary<string, List<Item>>();

            foreach (var item in BagConfig.Items)
            {
                AddToBackpack(item);
            }
        }

        // Update is called once per frame
        void Update()
        {
            //-LOG ALL BACKPACK CONTENTS TO CONSOLE
            foreach (var itemtype in _backpack)
            {
                foreach (var item in itemtype.Value)
                {
                    Debug.Log(itemtype.Key + "(" + item.Name + ")");
                    //_currentconfig.Items.Add(item);
                }
            }
           
        }
    }
}