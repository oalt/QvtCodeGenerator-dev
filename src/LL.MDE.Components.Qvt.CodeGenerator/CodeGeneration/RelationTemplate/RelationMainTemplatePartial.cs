﻿using LL.MDE.Components.Qvt.Metamodel.QVTRelation;
using LL.MDE.Components.Qvt.CodeGenerator.Analysis;

namespace LL.MDE.Components.Qvt.CodeGenerator.CodeGeneration.RelationTemplate
{ 
	public partial class RelationMainTemplate
	{
		private readonly IRelation relation;
		private readonly RelationAnalysisResult analysisResult;
		private readonly bool useMetamodelInterface;

		public RelationMainTemplate(IRelation relation, bool useMetamodelInterface = true)
		{
			this.relation = relation;
			analysisResult = AnalysersBatchHelper.AnalyzeRelation(relation);
			this.useMetamodelInterface = useMetamodelInterface;

		}
	}
}