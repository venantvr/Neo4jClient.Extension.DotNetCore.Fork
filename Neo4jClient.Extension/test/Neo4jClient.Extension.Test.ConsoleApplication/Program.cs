using System;
using Neo4jClient.Extension.Test.Cypher;

namespace Neo4jClient.Extension.Test.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var cypherExtensionTests = new CypherExtensionTests();
            
            cypherExtensionTests.EntityLabelWithoutAttrTest();
            cypherExtensionTests.EntityLabelWithTest();
            cypherExtensionTests.ToCypherStringMergeTest();
            cypherExtensionTests.MatchAllTest();
            cypherExtensionTests.MergeEntityOverrideMergeTest();          
        }
    }
}