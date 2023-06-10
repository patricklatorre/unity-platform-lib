using System.Collections.Generic;
using Platform.Enums;
using UnityEngine;

namespace Platform.Tags {
    
    public static class TagSystemExtensions {
    
        
        public static bool HasTag(this GameObject gameObject, EnumSO tag) {
            var tagList = gameObject.transform.GetComponent<TagList>();
            if (tagList == null) { return false; }

            return tagList.HasTag(tag);
        }
        

        public static bool HasTags(this GameObject gameObject, List<EnumSO> tags) {
            var tagList = gameObject.transform.GetComponent<TagList>();
            if (tagList == null) { return false; }

            return tagList.HasTags(tags);
        }

        
        public static bool HasTag(this Collider collider, EnumSO tag) {
            var tagList = collider.transform.GetComponent<TagList>();
            if (tagList == null) { return false; }

            return tagList.HasTag(tag);
        }
        
        
        public static bool HasTags(this Collider collider, List<EnumSO> tags) {
            var tagList = collider.transform.GetComponent<TagList>();
            if (tagList == null) { return false; }

            return tagList.HasTags(tags);
        }
        
        
        public static bool HasTag(this RaycastHit hit, EnumSO tag) {
            var tagList = hit.transform.GetComponent<TagList>();
            if (tagList == null) { return false; }

            return tagList.HasTag(tag);
        }
        
        
        public static bool HasTags(this RaycastHit hit, List<EnumSO> tags) {
            var tagList = hit.transform.GetComponent<TagList>();
            if (tagList == null) { return false; }

            return tagList.HasTags(tags);
        }


    }
    
}