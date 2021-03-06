﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextGameEngine
{
    abstract class Module
    {
        protected MapManager mapManager;

        protected delegate void ModuleUpdateHandler(object sender, object data);

        /// <summary>
        /// Event called when come action is executed on it by the user
        /// </summary>
        abstract public event ModuleUpdateHandler Update;

        /// <summary>
        /// Create the object to show and use the module
        /// </summary>
        /// <param name="mm">MapManager object to interact with</param>
        /// <returns>A Control object to use the module</returns>
        abstract public Control Load(MapManager mm);
    }
}
