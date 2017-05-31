//Get with teammates and build out the following.
//  - pick up items and invoke events with the item
//  - listen for this event from the ui and populate the text field with the item name + "\n"

namespace Scripts
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;

    public class BackpackBehaviour : MonoBehaviour
    {
        
        
        [System.Serializable]
        public class OnItems : UnityEvent<List<Item>> {}
        public OnItems sendItems;

        public static UnityEvent OnPackChange = new UnityEvent();

        public Backpack BagConfig;
        public Backpack Pack;

        public bool AddToBackpack(Item item)
        {
            Pack.Items.Add(item);
            sendItems.Invoke(Pack.Items);
            OnPackChange.Invoke();
            return true;
        }

        public bool RemoveFromBackpack()
        {
            foreach (var item in Pack.Items)
            {
                string itemkey = item.GetType().BaseType.ToString();                
                var newItem = Instantiate(Resources.Load("RuntimePrefabs/" + itemkey), transform.position, transform.rotation) as GameObject;
                switch(itemkey)
                {
                    case "Potion":
                        newItem.GetComponent<PotionBehaviour>().OnDrop(item as Potion);
                        break;

                    case "Armor":
                        newItem.GetComponent<ArmorBehaviour>().OnDrop(item as Armor);
                        break;

                    case "Bomb":
                        newItem.GetComponent<BombBehaviour>().OnDrop(item as Bomb);
                        break;

                    case "Food":
                        newItem.GetComponent<FoodBehaviour>().OnDrop(item as Food);
                        break;

                    case "Weapon":
                        newItem.GetComponent<WeaponBehaviour>().OnDrop(item as Weapon);
                        break;

                    case "Book":
                        newItem.GetComponent<BookBehaviour>().OnDrop(item as Book);
                        break;
                }

                Pack.Items.Remove(item);
                sendItems.Invoke(Pack.Items);
                OnPackChange.Invoke();
                return true;
            }
            return false;
        }

        // Use this for initialization
        void Start()
        {
            Pack = ScriptableObject.CreateInstance<Backpack>();
            Pack.Items = new List<Item>();

            //OnItemAdd.AddListener()

            foreach (var item in BagConfig.Items)
            {
                AddToBackpack(Instantiate(item));
            }
            sendItems.Invoke(Pack.Items);
        }

        // Update is called once per frame
        void Update()
        {
            Pack.Items.ForEach(x => { if (x == null) { Pack.Items.Remove(x); } });

            if(Input.GetKey(KeyCode.I))
            {
                sendItems.Invoke(Pack.Items);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                RemoveFromBackpack();
            }
            
            if (Input.GetKeyDown(KeyCode.F1))
            {
                Save();
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                Load();
                Debug.Log("BREAKPOINT");

                //GetComponentInChildren<BackpackBehaviour>().Pack = BackpackLoader.Instance.LoadBackpack("BackpackSave");
                //_backpack = GetComponentInChildren<BackpackBehaviour>().Pack;              
            }
        }

        public void Save()
        {
            BackpackSaver.Instance.SaveBackpack(Pack, "BackpackSave");
            sendItems.Invoke(Pack.Items);
        }

        public void Load()
        {
            var p = BackpackLoader.Instance.LoadBackpack("BackpackSave");
            Pack.Items.ForEach(Destroy);
            Pack.Items.AddRange(p.Items);
            sendItems.Invoke(Pack.Items);
        }
    }
}