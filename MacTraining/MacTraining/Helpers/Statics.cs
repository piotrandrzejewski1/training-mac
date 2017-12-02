using System;
using System.Collections;
using System.Collections.Generic;
using MacTraining.Shared;
using UIKit;

namespace MacTraining.Helpers
{
    public static class Statics
    {
        private static Dictionary<string, UIViewController> _instances = new Dictionary<string, UIViewController>();

        public static T GetInstance<T>(PageNames name) where T : UIViewController
        {
            var restorationId = name + "Vc";
            if (_instances.ContainsKey(restorationId))
            {
                return (T)_instances[restorationId];
            }

            var storyboard = UIStoryboard.FromName(name.ToString() + "Storyboard", null);
            var instance = (storyboard.InstantiateViewController(restorationId) as T);
            _instances.Add(restorationId, instance);

            return instance;
        }

    }
}
