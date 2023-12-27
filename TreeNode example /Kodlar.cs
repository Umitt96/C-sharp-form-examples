namespace video_12;
using System.IO;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        StreamWriter sw = new StreamWriter("deneme.txt");

        foreach (TreeNode bolum in treeView1.Nodes)
            sw.Write(bolum.Text + ", ");

        sw.Close();
        MessageBox.Show("Dosya başarıyla yazıldı!");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        StreamWriter sw2 = new StreamWriter("deneme2.txt");

        for (int i = 0; i < treeView1.Nodes.Count; i++)
        {
            sw2.Write(treeView1.Nodes[i].Text + " > ");

            for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
            {
                sw2.Write(treeView1.Nodes[i].Nodes[j].Text);

                if (j < treeView1.Nodes[i].Nodes.Count - 1)
                {
                    sw2.Write(", ");
                }
            }

            sw2.WriteLine();

        }
        MessageBox.Show("Düzgün dosya başarıyla yazıldı!");
        sw2.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        string dosya_adi = "fakulte_bolum.txt";
        StreamReader sr = new StreamReader(dosya_adi);

        while (!sr.EndOfStream)
        {
            string satir = sr.ReadLine();
            string[] dizi = satir.Split(",");

            TreeNode ana_dugum = treeView1.Nodes.Add(dizi[0]);

            for (int i = 1; i < dizi.Length; i++)
            {
                ana_dugum.Nodes.Add(dizi[i]);
            }
        }

        sr.Close();
    }
}
