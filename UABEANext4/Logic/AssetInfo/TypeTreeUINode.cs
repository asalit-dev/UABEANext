using AssetsTools.NET;
using Avalonia.Controls.Documents;
using System.Collections.Generic;

namespace UABEANext4.Logic.AssetInfo;

public class TypeTreeUINode
{
    public TypeTreeNode Node { get; init; }
    public InlineCollection Display { get; init; }
    public List<TypeTreeUINode> Children { get; init; }
}
