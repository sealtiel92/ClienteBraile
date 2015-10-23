using System;
using Gtk;
using System.IO;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void onClick (object sender, EventArgs e)
	{
		string texto = this.entry1.Text;
		float tam = float.Parse (this.entry2.Text);
		ClienteBraile.www.webservicex.net.Braille cliente = new ClienteBraile.www.webservicex.net.Braille ();
		byte []b = cliente.BrailleText (texto,tam);
		var pixbuf = new Gdk.Pixbuf (b);
		this.image2.Pixbuf = pixbuf;
	}
}
