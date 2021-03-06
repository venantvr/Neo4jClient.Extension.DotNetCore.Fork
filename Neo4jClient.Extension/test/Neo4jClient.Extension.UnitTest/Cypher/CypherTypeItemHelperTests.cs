﻿using Neo4jClient.Extension.Cypher;
using Neo4jClient.Extension.Cypher.Attributes;
using NUnit.Framework;

namespace Neo4jClient.Extension.Test.Cypher
{
    [TestFixture]
    public class CypherTypeItemHelperTests
    {
        [Test]
        public void AddKeyAttributeTest()
        {
            //setup
            var helper = new CypherTypeItemHelper();

            //act
            var key = helper.AddKeyAttribute<CypherModel, CypherMatchAttribute>(CypherExtension.DefaultExtensionContext,
                new CypherModel());

            //assert
            Assert.AreEqual(
                new CypherTypeItem() {Type = typeof(CypherModel), AttributeType = typeof(CypherMatchAttribute)}, key);
        }

        [Test]
        public void PropertyForUsageTest()
        {
            //setup
            var helper = new CypherTypeItemHelper();

            //act
            var result = helper.PropertiesForPurpose<CypherModel, CypherMatchAttribute>(new CypherModel());

            //assert
            Assert.AreEqual("id", result[0].TypeName);
            Assert.AreEqual("id", result[0].JsonName);
        }
    }
}