﻿using LL.MDE.Components.Qvt.Metamodel.QVTRelation;

namespace LL.MDE.Components.Qvt.CodeGenerator.CodeGeneration.FunctionsInterfaceTemplate
{ 
	public partial class FunctionsInterfaceTemplate
	{
	    private readonly IRelationalTransformation Transformation;

        public FunctionsInterfaceTemplate(IRelationalTransformation Transformation)
		{
			this.Transformation = Transformation;

		}
	}
}