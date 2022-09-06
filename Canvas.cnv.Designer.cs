/*
 * Created by nxtSTUDIO.
 * User: valeriy
 * Date: 7/21/2018
 * Time: 9:19 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas2.
	/// </summary>
	partial class Canvas
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Modelo = new HMI.Main.Symbols.System_Model.sDefault();
			// 
			// Modelo
			// 
			this.Modelo.BeginInit();
			this.Modelo.AngleIgnore = false;
			this.Modelo.DesignTransformation = new NxtControl.Drawing.Matrix(1.014112752506785D, 0D, 0D, 1D, 64D, 41D);
			this.Modelo.Name = "Modelo";
			this.Modelo.SecurityToken = ((uint)(4294967295u));
			this.Modelo.TagName = "8E5C685065859F58";
			this.Modelo.EndInit();
			// 
			// Canvas
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1191D)), ((float)(890D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas2";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Modelo});
			this.Size = new System.Drawing.Size(1191, 890);
		}
		private HMI.Main.Symbols.System_Model.sDefault Modelo;
		#endregion
	}
}
