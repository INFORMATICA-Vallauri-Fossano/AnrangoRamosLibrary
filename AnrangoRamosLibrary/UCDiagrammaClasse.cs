using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnrangoRamosLibrary
{
    public enum AccessModifier
    {
        Public,
        Private,
        Protected,
        Internal,
        ProtectedInternal,
        PrivateProtected
    }
    public partial class UCDiagrammaClasse : UserControl
    {
        public UCDiagrammaClasse()
        {
            InitializeComponent();
        }
    }
    class UMLfield
    {
        /// <summary> 
        /// Modificatori di TypeAttributes:
        /// <list type="bullet">
        /// <item><description><c>TypeAttributes.Public</c>: <c>modifier = '+';</c></description></item>
        /// <item><description><c>TypeAttributes.Sealed</c>: <c>modifier = '#';</c></description></item>
        /// <item><description><c>TypeAttributes.NestedPrivate</c>: <c>modifier = '-';</c></description></item>
        /// </list>
        /// </summary>

        public TypeAttributes Modifier { get; set; }
        public string FieldName {  get; set; }
        public TypeCode FieldType{  get; set; }
        public override string ToString()
        {
            char modifier=' ';
            switch (Modifier)
            {
                case TypeAttributes.Public:
                    modifier = '+';
                    break;
                case TypeAttributes.Sealed:
                    modifier = '#';
                    break;
                case TypeAttributes.NestedPrivate:
                    modifier = '-';
                    break;
            }
            return $"{modifier}{FieldName} : {FieldType}";
        }
    }

}
