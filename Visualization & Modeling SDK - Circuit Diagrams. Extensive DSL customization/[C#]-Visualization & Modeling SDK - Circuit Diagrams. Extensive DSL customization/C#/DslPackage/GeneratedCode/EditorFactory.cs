﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;

namespace Microsoft.Example.Circuits.DslPackage
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	[global::System.Runtime.InteropServices.Guid(Constants.CircuitsEditorFactoryId)]
	internal partial class CircuitsEditorFactory : CircuitsEditorFactoryBase
	{
		/// <summary>
		/// Constructs a new CircuitsEditorFactory.
		/// </summary>
		public CircuitsEditorFactory(global::System.IServiceProvider serviceProvider)
			: base(serviceProvider)
		{
		}
	}

	/// <summary>
	/// Factory for creating our editors
	/// </summary>
	internal abstract class CircuitsEditorFactoryBase : DslShell::ModelingEditorFactory
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="serviceProvider">Service provider used to access VS services.</param>
		protected CircuitsEditorFactoryBase(global::System.IServiceProvider serviceProvider) : base(serviceProvider)
		{
		}

		/// <summary>
		/// Called by the shell to ask the editor to create a new document object.
		/// </summary>
		public override DslShell::ModelingDocData CreateDocData(string fileName, VSShellInterop::IVsHierarchy hierarchy, uint itemId)
		{
			// Create the document type supported by this editor.
			return new CircuitsDocData(this.ServiceProvider, typeof(CircuitsEditorFactory).GUID);
		}

		/// <summary>
		/// Called by the shell to ask the editor to create a new view object.
		/// </summary>
		protected override DslShell::ModelingDocView CreateDocView(DslShell::ModelingDocData docData, string physicalView, out string editorCaption)
		{
			// Create the view type supported by this editor.
			editorCaption = "blah";

      CircuitsDocView dv = new CircuitsDocView(docData, this.ServiceProvider);
      /*foreach (ComponentModel cm in (docData as CircuitsDocData).ModelingDocStore.Store.ElementDirectory.FindElements<ComponentModel>())
      {
        editorCaption += cm.Name;
      }
      */
      return dv;
    }
    
	}
}

