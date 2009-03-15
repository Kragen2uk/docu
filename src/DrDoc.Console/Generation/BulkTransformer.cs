﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DrDoc.Documentation;

namespace DrDoc.Generation
{
    public class BulkTransformer
    {
        private readonly ITemplateTransformer transformer;

        public BulkTransformer(ITemplateTransformer transformer)
        {
            this.transformer = transformer;
        }

        public void TransformDirectory(string path, IList<Namespace> namespaces)
        {
            foreach (var file in Directory.GetFiles(path, "*.spark"))
            {
                transformer.Transform(file, namespaces);
            }

            foreach (var directory in Directory.GetDirectories(path))
            {
                TransformDirectory(directory, namespaces);
            }
        }
    }
}
