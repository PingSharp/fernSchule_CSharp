using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAClassLib
{
    public class WithoutChange
    {
        /// <summary>Ein beschreibender Text</summary>
        /// Variante in der Kommentierung bei:
        /// <see cref="secondCommentString">
        /// Weitere Variante in der Kommentierung bei:
        /// <seealso cref="thirdCommentString">
        public string commentString = "";
    }

    public class AddedFields
    {
        /// <summary>Ein beschreibender Text</summary>
        /// Variante in der Kommentierung bei:
        /// <see cref="secondCommentString">
        /// Weitere Variante in der Kommentierung bei:
        /// <seealso cref="thirdCommentString">
        public string commentString = "";
        /// <summary>
        /// BLABLA
        /// </summary>
        public string secondCommentString = "";
        /// <summary>
        /// blabla
        /// </summary>
        public string thirdCommentString = "";
    }

    public class AddedSeeAndSeealsoEnttags
    {
        /// <summary>Ein beschreibender Text</summary>
        /// Variante in der Kommentierung bei:
        /// <see cref="secondCommentString" />
        /// Weitere Variante in der Kommentierung bei:
        /// <seealso cref="thirdCommentString" />
        public string commentString = "";
        /// <summary>
        /// BLABLA
        /// </summary>
        public string secondCommentString = "";
        /// <summary>
        /// blabla
        /// </summary>
        public string thirdCommentString = "";
    }

    public class MovedSeeToPara
    {
        /// <summary>
        /// Ein beschreibender Text
        /// <para>Variante in der Kommentierung bei:
        /// <see cref="secondCommentString" />
        /// </para>
        /// </summary>
        /// Weitere Variante in der Kommentierung bei:
        /// <seealso cref="thirdCommentString" />
        public string commentString = "";
        /// <summary>
        /// BLABLA
        /// </summary>
        public string secondCommentString = "";
        /// <summary>
        /// blabla
        /// </summary>
        public string thirdCommentString = "";
    }

    /// <summary>
    /// This is class def for my homework
    /// </summary>
    public class FinishedClass
    {
        /// <summary>
        /// Ein beschreibender Text
        /// <para>Variante in der Kommentierung bei:
        /// <see cref="secondCommentString" />
        /// </para>
        /// </summary>
        /// <seealso cref="thirdCommentString" >Weitere Variante in der Kommentierung bei:</seealso> 
        public string commentString = "";
        /// <summary>
        /// BLABLA
        /// </summary>
        public string secondCommentString = "";
        /// <summary>
        /// blabla
        /// </summary>
        public string thirdCommentString = "";
    }
}
