// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void AssetAddedHandler(object o, AssetAddedArgs args);

	public class AssetAddedArgs : GLib.SignalArgs {
		public GES.Asset Asset{
			get {
				return (GES.Asset) Args [0];
			}
		}

	}
}
