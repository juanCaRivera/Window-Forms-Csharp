using System;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class MDI : Form
    {
        Form1 ut = new Form1();
        CInss ci = new CInss();
        Notas no = new Notas();
        ImpuestoSS ss = new ImpuestoSS();   
        form2 ut2 = new form2();   
        Form3 ut3 =new Form3();
        TreeView tree = new TreeView();
        DatosTipoLista dtl = new DatosTipoLista();
        CalculoDeArea cda = new CalculoDeArea();
        DataGridView dtgv = new DataGridView();
        PS2 prueba2 = new PS2();
        PracticaHome1 ph1 = new PracticaHome1();
        PracticaHome2 ph2 = new PracticaHome2();
        PraticaHome3 ph3 = new PraticaHome3();
        PracticaHome4 ph4 = new PracticaHome4();
        PracticaHome5 ph5 = new PracticaHome5();
        PracticaHome6 ph6 = new PracticaHome6();
        PS2switch psw2 = new PS2switch();
        ejemploDatagridview edgv = new ejemploDatagridview();
        Examen ex = new Examen();

        public MDI()
        {
            InitializeComponent();
        }

        private void utilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ut.MdiParent = this;
            ut.Show();
        }

        private void inssLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ci.MdiParent = this;
            ci.Show();
        }

        private void promedioDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            no.MdiParent = this;
            no.Show();
        }

        private void inssCalculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ss.MdiParent = this;
            ss.Show();
        }

        private void depreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ut2.MdiParent = this;
            ut2.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ut3.MdiParent = this;
            ut3.Show();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.MdiParent = this;
            tree.Show();
        }

        private void datosTipoListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtl.MdiParent = this;
            dtl.Show();
        }

        private void calculoDeAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cda.MdiParent = this;
            cda.Show();
        }

        private void dataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtgv.MdiParent = this;
            dtgv.Show();
        }

        private void pS2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prueba2.MdiParent = this;
            prueba2.Show();
        }

        private void ejemplosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pH1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ph1.MdiParent = this;
            ph1.Show();
        }

        private void pH2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ph2.MdiParent = this;
            ph2.Show();

        }

        private void pH3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ph3.MdiParent = this;
            ph3.Show();
        }

        private void pH4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ph4.MdiParent = this;
            ph4.Show();
        }

        private void pH5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ph5.MdiParent = this;
            ph5.Show();
        }

        private void pH6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ph6.MdiParent = this;
            ph6.Show();
        }

        private void pSswitch2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            psw2.MdiParent = this;
            psw2.Show();
        }

        private void eJMDGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edgv.MdiParent = this;
            edgv.Show();
        }

        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex.MdiParent = this;
            ex.Show();
        }
    }

}
