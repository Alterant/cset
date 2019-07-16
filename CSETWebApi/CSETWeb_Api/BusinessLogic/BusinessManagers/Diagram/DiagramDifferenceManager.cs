﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSETWeb_Api.BusinessLogic.BusinessManagers.Diagram
{
    /// <summary>
    /// this is the main entry point for 
    /// diagram changes and differences
    /// </summary>
    public class DiagramDifferenceManager
    {
        public Dictionary<Guid, String> AddedComponents = new Dictionary<Guid, string>();
        public Dictionary<Guid, String> RemovedComponents = new Dictionary<Guid, string>();
        public Dictionary<Guid, String> OldDiagram = new Dictionary<Guid, string>();
        public Dictionary<Guid, String> NewDiagram = new Dictionary<Guid, string>();

        /// <summary>
        /// pass in the xml document
        /// get the existing from the database
        /// create the dictionaries 
        /// call the diff extractor
        /// get back the adds and deletes
        /// add records to the table for the new components
        /// deleted records for the removed components
        /// </summary>
        public void buildDiagramDictionaries(XmlDocument diagramDocument)
        {
            var cells = diagramDocument.SelectNodes("/mxGraphModel/root/object");
            foreach(var c in cells)
            {

            }

            var cells = diagramDocument.SelectNodes("/mxGraphModel/root/object");
            foreach (var c in cells)
            {

            }
        }
    }
}
