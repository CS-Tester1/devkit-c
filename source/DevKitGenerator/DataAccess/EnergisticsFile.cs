﻿// 
// License notice 
// Standards DevKit, version 1.0 
// Copyright 2011 ExxonMobil Upstream Research Company
//  
// The following Energistics (c) products were used in the creation of this work: 
// 
// •	WITSML Data Schema Specifications, Version 1.4.1 
// •	WITSML API Specifications, version 1.4.1 
// •	WITSML Data Schema Specifications, Version 1.3.1.1 
// •	WITSML API Specifications, version 1.3.1 
// •	PRODML Data Schema Specifications, Version 1.2 
// •	PRODML Web Service Specifications, Version 2.0
// 
// All rights in the WITSML™ Standard and the PRODML™ Standard, or any portion thereof, which remain in the 
// Standards DevKitshall remain with Energistics or its suppliers and shall remain subject to the terms of 
// the Product License Agreement available at http://www.energistics.org/product-license-agreement. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in 
// compliance with the License. 
// 
// You may obtain a copy of the License at 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the License. 
// 
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Class that handles reading and writing of Energistics XML files
    /// </summary>
    public static class EnergisticsFile
    {
        /// <summary>
        /// Reads an Energistics XML file
        /// </summary>
        /// <typeparam name="T">Type of the object that the file contains</typeparam>
        /// <param name="fileName">Name of the XML file</param>
        /// <returns>The object representation of the XML file</returns>
        public static T ReadFile<T>(string fileName)
        {
            if (File.Exists(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    object xmlobject = serializer.Deserialize(reader);
                    if (xmlobject is T)
                    {
                        return (T)xmlobject;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException(String.Format("Cannot find file '{0}'", fileName));
            }
        }

        /// <summary>
        /// Writes an Energistics object to an XML file
        /// </summary>
        /// <param name="fileName">The name of the XML file</param>
        /// <param name="energisticsObject">The object to write</param>
        public static void WriteFile(string fileName, object energisticsObject)
        {
            if (energisticsObject != null)
            {
                XmlSerializer serializer = new XmlSerializer(energisticsObject.GetType());

                using (XmlWriter writer = XmlWriter.Create(fileName))
                {
                    serializer.Serialize(writer, energisticsObject);
                }
            }
        }   
    }
}