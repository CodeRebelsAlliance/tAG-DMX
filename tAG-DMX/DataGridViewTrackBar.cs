using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tAG_DMX
{
    public class DataGridViewTrackBarColumn : DataGridViewColumn
    {
        public DataGridViewTrackBarColumn() : base(new DataGridViewTrackBarCell())
        {
        }
    }

    public class DataGridViewTrackBarCell : DataGridViewTextBoxCell
    {
        public DataGridViewTrackBarCell() : base()
        {
            this.Style.Format = "N0";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue,
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            if (DataGridView?.EditingControl is DataGridViewTrackBarEditingControl ctl)
            {
                ctl.Value = this.Value == null ? (int)this.DefaultNewRowValue : (int)this.Value;
                ctl.BackColor = dataGridViewCellStyle.BackColor;
                ctl.ForeColor = dataGridViewCellStyle.ForeColor;
            }
        }

        public override Type EditType
        {
            get { return typeof(DataGridViewTrackBarEditingControl); }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }

        public override object DefaultNewRowValue
        {
            get { return 0; }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates cellState, object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (this.DataGridView?.EditingControl == null)
            {
                using (Bitmap bitmap = new Bitmap(cellBounds.Width, cellBounds.Height))
                {
                    using (Graphics bitmapGraphics = Graphics.FromImage(bitmap))
                    {
                        TrackBar trackBar = new TrackBar
                        {
                            Minimum = 0,
                            Maximum = 255,
                            Orientation = Orientation.Vertical,
                            Value = value != null ? (int)value : 0,
                            Bounds = new Rectangle(0, 0, cellBounds.Width, cellBounds.Height),
                            BackColor = cellStyle.BackColor,
                            ForeColor = cellStyle.ForeColor
                        };
                        trackBar.DrawToBitmap(bitmap, new Rectangle(0, 0, cellBounds.Width, cellBounds.Height));
                        graphics.DrawImage(bitmap, cellBounds);
                    }
                }
            }
        }
    }

    public class DataGridViewTrackBarEditingControl : TrackBar, IDataGridViewEditingControl
    {
        private DataGridView? dataGridView;
        private bool valueChanged = false;
        private int rowIndex;

        public DataGridViewTrackBarEditingControl()
        {
            this.Minimum = 0;
            this.Maximum = 255;
            this.Orientation = Orientation.Vertical;
        }

        public object EditingControlFormattedValue
        {
            get { return this.Value.ToString(); }
            set
            {
                if (value is string stringValue)
                {
                    this.Value = int.Parse(stringValue);
                }
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Right:
                case Keys.Down:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        public DataGridView EditingControlDataGridView
        {
            get { return dataGridView!; }
            set { dataGridView = value; }
        }

        public bool EditingControlValueChanged
        {
            get { return valueChanged; }
            set { valueChanged = value; }
        }

        public Cursor EditingPanelCursor
        {
            get { return base.Cursor; }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            valueChanged = true;
            this.EditingControlDataGridView?.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}