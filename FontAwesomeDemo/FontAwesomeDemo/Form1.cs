using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontAwesomeDemo {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load( object sender, EventArgs e ) {
			
			// Set the font to the FontAwesome font
			listView1.Font = Fonts.FontAwesome;

			// You can also adjust the font size and style by calling the Reload() overloaded method
			// =======================================================
			// Just reload the font using existing size and style
			//		Fonts.Reload( )
			//
			// Change the size only
			//		Fonts.Reload( float newSize ) 
			//
			// Change the style only (bold, regular, oblique, etc)
			//		Fonts.Reload( FontStyle newStyle ) 
			//
			// Change the size and style
			//		Fonts.Reload( float newSize, FontStyle newStyle ) 
			// =======================================================


			// To use the 'icons', all the Unicode conversion has been done
			// I have preserved the names as close as possible. Anywhere that
			// FontAwesome has a '-' (dash / hyphen), it has been replaced with
			// a '_' (underscore) character as c# does not allow for hyphens in
			// variable names.
			//
			// There were a couple other icons which were using the same name as
			// a reserved command or method such as 'try'. You can access these normally
			// as I used the @ symbol to override and allow for use of those names.
			//
			// Calling the icon is very simple :
			//     Fonts.fa. <icon name here>
			//
			// The following example shows a few icons being added to a listview.
			// Keep in mind these are actually text, not images, and thus can not be used
			// as image icons without converting the text to an image first using GDI / etc.
			// They can be used anywhere you can use text and change the font.

			listView1.Items.Add( Fonts.fa.amazon );
			listView1.Items.Add( Fonts.fa.google );
			listView1.Items.Add( Fonts.fa.github_square );
			listView1.Items.Add( Fonts.fa.hotel );
			listView1.Items.Add( Fonts.fa.microphone );
			listView1.Items.Add( Fonts.fa.motorcycle );
			listView1.Items.Add( Fonts.fa.object_group );


		}
	}
}
