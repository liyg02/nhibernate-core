﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace NHibernate.Test.Events.Collections.Association.Unidirectional.ManyToMany
{
	using System.Threading.Tasks;
	[TestFixture]
	public class UnidirectionalManyToManyBagCollectionEventFixtureAsync : AbstractAssociationCollectionEventFixtureAsync
	{
		protected override IList Mappings
		{
			get { return new string[] { "Events.Collections.Association.Unidirectional.ManyToMany.UnidirectionalManyToManyBagMapping.hbm.xml" }; }
		}

		public override IParentWithCollection CreateParent(string name)
		{
			return new ParentWithCollectionOfEntities(name);
		}

		public override ICollection<IChild> CreateCollection()
		{
			return new List<IChild>();
		}
	}
}