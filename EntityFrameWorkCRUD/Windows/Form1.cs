using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntity;
using BussinesLayer;

using System.Windows.Forms;

namespace Windows
{
    public partial class Form1 : Form
    {
        BussinesLayer.AlumnoBL _objAlumnoBL = new BussinesLayer.AlumnoBL();
        BindingList<AlumnoDto> alumnoDataSource = new BindingList<AlumnoDto>();
        List<AlumnoDto> tempInsertar = new List<AlumnoDto>();
        List<AlumnoDto> tempEditar = new List<AlumnoDto>();
        List<AlumnoDto> tempEliminar = new List<AlumnoDto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void buttonnuvo_Click(object sender, EventArgs e)
        {
            alumnoDataSource.AddNew();
            //dataGridViewAlumnos.Rows.Add();
            dataGridViewAlumnos.Rows[dataGridViewAlumnos.Rows.Count - 1].Cells["_RegType"].Value = "Temp";
            
        }
        void cargarGrid()
        {
            alumnoDataSource = _objAlumnoBL.listarAlumnos();
            dataGridViewAlumnos.DataSource = alumnoDataSource;

            foreach (DataGridViewRow fila in dataGridViewAlumnos.Rows)
            {
                fila.Cells["_RegType"].Value = "No Temp";
            }
        }

        private void dataGridViewAlumnos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridViewAlumnos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewAlumnos.Rows[e.RowIndex].Cells["_RegType"].Value != null)
                {
                    dataGridViewAlumnos.Rows[e.RowIndex].Cells["_RegStatus"].Value = "Edited";
                }
            }
        }

        void llenarTemporales()
        {
            foreach (DataGridViewRow fila in dataGridViewAlumnos.Rows)
            {
                if (fila.Cells["_RegStatus"].Value != null && fila.Cells["_RegStatus"].Value.ToString() == "Edited")
                {
                    AlumnoDto _alumnnoDto = new AlumnoDto();
                    switch (fila.Cells["_RegType"].Value.ToString())
                    {
                        case "NoTemp":
                            _alumnnoDto.i_IdPersona = int.Parse(fila.Cells["i_IdPersona"].Value.ToString());
                            _alumnnoDto.t_FechaNacimiento = fila.Cells["t_FechaNacimiento"].Value != null ? DateTime.Parse(fila.Cells["t_FechaNacimiento"].Value.ToString()): DateTime.Today ;
                            _alumnnoDto.v_Direccion = fila.Cells["v_Direccion"].Value != null ? fila.Cells["v_Direccion"].Value.ToString() : null;
                            _alumnnoDto.v_NombresApellidos = fila.Cells["v_NombresApellidos"].Value != null ? fila.Cells["v_NombresApellidos"].Value.ToString() : null;
                            _alumnnoDto.v_DNI = fila.Cells["v_DNI"].Value != null ? fila.Cells["v_DNI"].Value.ToString() : null;
                            _alumnnoDto.v_Telefono = fila.Cells["v_Telefono"].Value != null ? fila.Cells["v_Telefono"].Value.ToString() : null;
                            tempEditar.Add(_alumnnoDto);
                            break;
                        case "Temp":
                            _alumnnoDto.t_FechaNacimiento = fila.Cells["t_FechaNacimiento"].Value != null ? DateTime.Parse(fila.Cells["t_FechaNacimiento"].Value.ToString()) : DateTime.Today;
                            _alumnnoDto.v_Direccion = fila.Cells["v_Direccion"].Value != null ? fila.Cells["v_Direccion"].Value.ToString() : null;
                            _alumnnoDto.v_NombresApellidos = fila.Cells["v_NombresApellidos"].Value != null ? fila.Cells["v_NombresApellidos"].Value.ToString() : null;
                            _alumnnoDto.v_DNI = fila.Cells["v_DNI"].Value != null ? fila.Cells["v_DNI"].Value.ToString() : null;
                            _alumnnoDto.v_Telefono = fila.Cells["v_Telefono"].Value != null ? fila.Cells["v_Telefono"].Value.ToString() : null;
                            tempInsertar.Add(_alumnnoDto);
                            break;

                    }
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count != 0)
            {
                if ( dataGridViewAlumnos.Rows[dataGridViewAlumnos.SelectedRows[0].Index].Cells["_RegType"].Value.ToString() == "NoTemp")
                {
                    AlumnoDto _alumnoDto = new AlumnoDto();
                    _alumnoDto.i_IdPersona = int.Parse(dataGridViewAlumnos.Rows[dataGridViewAlumnos.SelectedRows[0].Index].Cells["i_IdPersona"].Value.ToString());
                    tempEliminar.Add(_alumnoDto);
                    dataGridViewAlumnos.Rows.Remove(dataGridViewAlumnos.Rows[dataGridViewAlumnos.SelectedRows[0].Index]);
                }
                else
                {
                    dataGridViewAlumnos.Rows.Remove(dataGridViewAlumnos.Rows[dataGridViewAlumnos.SelectedRows[0].Index]);
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            llenarTemporales();
            operationResult objOperatioResult = new operationResult();
            _objAlumnoBL.actualizarAlumno(ref objOperatioResult, tempInsertar, tempEditar, tempEliminar);

            if(objOperatioResult.succes == 1 )
            { 
                cargarGrid();
                MessageBox.Show("Actualizado Correctamente");
            }
            else
            {
                MessageBox.Show(objOperatioResult.errorMessage + " \n" + objOperatioResult.innerException + " \n " + objOperatioResult.AdditionInformation.ToString());
            }
            tempInsertar = new List<AlumnoDto>();
            tempEliminar = new List<AlumnoDto>();
            tempEditar = new List<AlumnoDto>();
        }
    }
}

