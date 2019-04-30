/*****************************************************************
**  Program Name:   Calculator C#               				**
**  Version Number: V1.0                                        **
**  Copyright (C):  September 6, 2009 Richard W. Allen          **
**  Date Started:   September 6, 2009                           **
**  Date Ended:     September 7, 2009                           **
**  Author:         Richardn W. Allen                           **
**  Webpage:        http://richard-allen.homelinux.com/         **
**  IDE:            Visual Studio 2008                          **
**  Compiler:       C# 2008                                     **
**  Langage:        C# 2008                   				    **
**  License:        GNU GENERAL PUBLIC LICENSE Version 2    	**
**		            see license.txt for for details	            **
******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorCSharp
{
    static class Start
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}
