using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

using iTextSharp.text.pdf;


namespace PDF_Extract_Bookmarks
{
	public partial class View : Form
	{
		public View()
		{
			InitializeComponent();
		}

		private void inputClick(object sender, EventArgs e)
		{
			openFileDialog.DefaultExt = "pdf";
			openFileDialog.Filter = "PDF-Datei|*.pdf";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				tbxInput.Text = openFileDialog.FileName;
				tbxOutput1.Text = tbxInput.Text.Replace("pdf", "html");
				tbxOutput2.Text = tbxInput.Text.Replace("pdf", "xml");
			}
		}

		private void extractClick(object sender, EventArgs e)
		{
			try
			{
				PdfReader pdfReader = new PdfReader(tbxInput.Text);

				IList<Dictionary<string, object>> bookmarks = SimpleBookmark.GetBookmark(pdfReader);
				if (bookmarks == null)
				{
					MessageBox.Show("The PDF document does not contain any bookmarks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					tbxInput.Text = "";
					tbxOutput1.Text = "";
					tbxOutput2.Text = "";
					return;
				}
				MemoryStream memStream = new MemoryStream();
				SimpleBookmark.ExportToXML(bookmarks, memStream, "utf-8", true);

				memStream.Position = 0;
				extractToHTML(memStream, tbxOutput1.Text);
				memStream.Position = 0;
				extractToXML(memStream, tbxOutput2.Text);

				pdfReader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		private void extractToHTML(MemoryStream memStream, string file)
		{

			string dtdLink = "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd";
			string dtdDef = "-//W3C//DTD XHTML 1.0 Transitional//EN";

			XmlTextReader reader = new XmlTextReader(memStream);
			XmlTextWriter writer = new XmlTextWriter(file, Encoding.UTF8);
			writer.Formatting = Formatting.Indented;

			// Create an xml document
			XmlDocument htmlDoc = new XmlDocument();
			/// Set the XmlResolver property to null to prevent the docType below from throwing exceptions
			htmlDoc.XmlResolver = null;
			XmlDocumentType docType = htmlDoc.CreateDocumentType("html", dtdDef, dtdLink, null);
			htmlDoc.AppendChild(docType);

			// Write the root node in the xhtml namespace.
			using (XmlWriter tw = htmlDoc.CreateNavigator().AppendChild())
			{
				tw.WriteStartElement("html", "http://www.w3.org/1999/xhtml");

				while (reader.Read())
				{
					switch (reader.NodeType)
					{
						case XmlNodeType.Element:
						if (reader.Name == "Title")
							tw.WriteStartElement("H"+reader.Depth);
						else
							tw.WriteStartElement(reader.Name);
						break;
						case XmlNodeType.Text:
						tw.WriteValue(reader.Value);
						break;
						case XmlNodeType.EndElement:
						tw.WriteEndElement();
						break;
					}
				}
				tw.WriteEndElement();

				tw.Flush();
				tw.Close();
				htmlDoc.Save(writer);

			}
		}

		private void extractToXML(MemoryStream memStream, string file)
		{

			XmlTextReader reader = new XmlTextReader(memStream);
			XmlTextWriter writer = new XmlTextWriter(file, Encoding.UTF8);
			writer.Formatting = Formatting.Indented;

			writer.WriteStartDocument();

			while (reader.Read())
			{
				switch (reader.NodeType)
				{
					case XmlNodeType.Element:
					if (reader.Name == "Title")
						writer.WriteStartElement("H"+reader.Depth);
					else
						writer.WriteStartElement(reader.Name);
					break;
					case XmlNodeType.Text:
					writer.WriteValue(reader.Value);
					break;
					case XmlNodeType.EndElement:
					writer.WriteEndElement();
					break;
				}
			}
			writer.WriteEndDocument();

			writer.Flush();
			writer.Close();

		}
	}
}

