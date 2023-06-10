using System.Collections.Generic;
using Platform.Enums;
using UnityEngine;

namespace Platform.Tags {
    
    public class TagList : MonoBehaviour {

        public List<EnumSO> Tags = new List<EnumSO>();
        
        // Cached set of the Tag list, makes lookups much faster.
        // Tag list itself is not a set since HashSets are not serializable.
        HashSet<EnumSO> _tagSet;
        
        
        void Awake() {
            _tagSet = new HashSet<EnumSO>(Tags);
        }


        public void AddTag(EnumSO tag) {
            _tagSet.Add(tag);
        }
        

        public void AddTags(List<EnumSO> tags) {
            foreach (var tag in tags) {
                AddTag(tag);
            }
        }

        
        public void RemoveTag(EnumSO tag) {
            _tagSet.Remove(tag);
        }
        

        public void RemoveTags(List<EnumSO> tags) {
            foreach (var tag in tags) {
                RemoveTag(tag);
            }
        }

        
        public bool HasTag(EnumSO tag) {
            return _tagSet.Contains(tag);
        }


        public bool HasTags(List<EnumSO> tags) {
            foreach (var tag in tags) {
                if (!HasTag(tag)) { return false; }
            }

            return true;
        }
        
    }
    
}