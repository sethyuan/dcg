/*
 *  Dynamic Code Generator
 *  Copyright (C) 2006 Wei Yuan
 *
 *  This library is free software; you can redistribute it and/or modify it
 *  under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation; either version 2.1 of the License, or (at
 *  your option) any later version.
 *
 *  This library is distributed in the hope that it will be useful, but
 *  WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 *  or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public
 *  License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with this library; if not, write to the Free Software Foundation,
 *  Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
 *
 */

using System;

namespace Cavingdeep.Dcg.At.Parsing
{
    [Serializable]
    internal class SectionReference : Directive
    {
        public SectionReference(string name, string rest, string spaces, int line)
        {
            this.Name = name;
            this.Rest = rest;
            this.Spaces = spaces;
            this.Line = line;
        }

        public string Name
        {
            get;
            set;
        }

        public string Rest
        {
            get;
            set;
        }

        public string Spaces
        {
            get;
            private set;
        }

        public int Line
        {
            get;
            set;
        }
    }
}
